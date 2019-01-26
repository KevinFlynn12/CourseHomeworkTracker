using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTaskLibrary.Event;

namespace ClassTaskLibrary
{
    public partial class CourseInfo: UserControl
    {
        public event EventHandler<CourseInfoEventArgs> ChangeHasOccured;

        private static int priorityHigh = 3;
        private static int priorityMedium = 2;
        private static int priorityLow = 1;
        private static int textBoxIndex = 1;
        private static int checkBoxIndex = 0;
        private int selectedPriority;


       
        
        public CourseInfo()
        {
            this.InitializeComponent();
            this.LowPriorityButton.Checked = true;
            this.HighPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.MediumPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.LowPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.CourseTasksGridView.MouseDown += this.TaskDataGridView_MouseDown;

            
        }

        public void AddTasks(IList<String> tasks)
        {
            this.CourseTasksGridView.Rows.Add(tasks.Count);

            for (int i = 0; i < tasks.Count; i++)
            {
                var row = this.CourseTasksGridView.Rows[i];
                var currentTask = tasks[i];
          
                row.Cells[textBoxIndex].Value = currentTask;
            }
        }

        private void PriorityHasChanged(int changedPriority)
        {
            var data = new CourseInfoEventArgs {Priority = changedPriority};

            this.ChangeHasOccured?.Invoke(this, data);
        }


        private void TaskHasChanged(List<String> changedTask)
        {
            var data = new CourseInfoEventArgs {
                Tasks = changedTask, 
                Priority = this.selectedPriority

            };

            this.ChangeHasOccured?.Invoke(this, data);
        }


        public List<String> GenerateTasks()
        {
            var tasks = new List<string>();
            foreach (DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[checkBoxIndex];
                if (!Convert.ToBoolean(checkBoxCell.EditedFormattedValue))
                {
                    DataGridViewTextBoxCell textBoxCell = (DataGridViewTextBoxCell)row.Cells[textBoxIndex];
                    if (textBoxCell.Value != null)
                    {
                        tasks.Add(textBoxCell.Value.ToString());
                    }
                }
            }

            return tasks;
        } 



        private void CourseTasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TaskHasChanged(this.GenerateTasks());  
        }


        private void TaskDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            var mouseClick = e.Button;
            if (mouseClick == MouseButtons.Right)
            {
                this.DataGridViewMenuStrip.Show(this, new Point(e.X, e.Y));
            }
        }


        private void PriorityGroupBox_Enter(object sender, EventArgs e)
        {
            if (this.HighPriorityButton.Checked)
            {
                this.updatePriority(priorityHigh);
            }
            else if (this.MediumPriorityButton.Checked)
            {
                this.updatePriority(priorityMedium);

            }
            else if(this.LowPriorityButton.Checked)
            {
                this.updatePriority(priorityLow);
            }

        }

        private void updatePriority(int newPriority)
        {
            this.PriorityHasChanged(newPriority);
            this.selectedPriority = newPriority;
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.updateAllCheckBoxesInGridView(false, true);
        }

        private void updateAllCheckBoxesInGridView(bool originalValue, bool newValue)
        {
            foreach (DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                DataGridViewCheckBoxCell currentCheckBox = (DataGridViewCheckBoxCell)row.Cells[0];
                if (currentCheckBox.Selected == originalValue)
                {
                    currentCheckBox.Value = newValue;
                    currentCheckBox.Selected = newValue;
                }
            }
        }



        private void unCheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateAllCheckBoxesInGridView(true, false);

        }
    }
}
