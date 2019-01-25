using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
        }



        private void PriorityChanged(int changedPriority)
        {
            var data = new CourseInfoEventArgs {Priority = changedPriority};

            this.ChangeHasOccured?.Invoke(this, data);
        }


        private void TaskHasChanged(List<String> changedTask)
        {
            var data = new CourseInfoEventArgs { Tasks = changedTask };

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

        private void HighPriorityButton_CheckedChanged(object sender, EventArgs e)
        {
            this.PriorityChanged(priorityHigh);
        }

        private void MediumPriorityButton_CheckedChanged(object sender, EventArgs e)
        {
            this.PriorityChanged(priorityMedium);
        }

        private void LowPriorityButton_CheckedChanged(object sender, EventArgs e)
        {
            this.PriorityChanged(priorityLow);
        }
    }

    public class CourseInfoEventArgs : EventArgs
    {
        public int Priority { get; set; }
        public ICollection<String> Tasks { get; set; }

    }

}
