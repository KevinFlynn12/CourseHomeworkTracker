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
     
        
        public CourseInfo()
        {
            this.InitializeComponent();
            this.LowPriorityButton.Checked = true;

            this.HighPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.MediumPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.LowPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.CourseTasksGridView.MouseDown += this.pictureBox1_MouseDown;


        }



        private void PriorityChanged(int changedPriority)
        {
            var data = new CourseInfoEventArgs {Priority = changedPriority};

            this.ChangeHasOccured?.Invoke(this, data);
        }


        private void TaskHasChanged(List<String> changedTask)
        {
            var data = new CourseInfoEventArgs {
                Tasks = changedTask, 
            };

            this.ChangeHasOccured?.Invoke(this, data);
        }


        public List<String> GenerateTasks()
        {
            var tasks = new List<string>();
            foreach (DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                if (!Convert.ToBoolean(cell.EditedFormattedValue))
                {
                    DataGridViewTextBoxCell textCell = (DataGridViewTextBoxCell)row.Cells[1];
                    if (textCell.Value != null)
                    {
                        tasks.Add(textCell.Value.ToString());
                    }
                }
            }

            return tasks;
        } 



        private void CourseTasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TaskHasChanged(this.GenerateTasks());  

        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                {
                    this.DataGridViewMenuStrip.Show(this, new Point(e.X, e.Y));
                }
                    break;
            }
        }


        private void PriorityGroupBox_Enter(object sender, EventArgs e)
        {
            if (this.HighPriorityButton.Checked)
            {
                this.PriorityChanged(priorityHigh);
            }
            else if (this.MediumPriorityButton.Checked)
            {
                this.PriorityChanged(priorityMedium);

            }
            else if(this.LowPriorityButton.Checked)
            {
                this.PriorityChanged(priorityLow);
            }

        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unCheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
