using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassTaskLibrary.Event;

namespace ClassTaskLibrary
{
    public partial class CourseInfo : UserControl
    {
        #region Data members

        private static readonly int priorityHigh = 3;
        private static readonly int priorityMedium = 2;
        private static readonly int priorityLow = 1;
        private static readonly int textBoxIndex = 1;
        private static readonly int checkBoxIndex = 0;
        public int SelectedPriority { get; private set; }

        public bool HighPriorityButtonSelected
        {
            get => this.HighPriorityButton.Checked;
            set=> this.HighPriorityButton.Checked = value;
        }

        public bool MediumPriorityButtonSelected
        {
            get => this.MediumPriorityButton.Checked;
            set => this.MediumPriorityButton.Checked = value;
        }

        public bool LowPriorityButtonSelected
        {
            get => this.LowPriorityButton.Checked;
            set => this.LowPriorityButton.Checked = value;
        }


        #endregion

        #region Constructors

        public CourseInfo()
        {
            this.InitializeComponent();
            this.SelectedPriority = priorityLow;
            this.HighPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;


            this.MediumPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.LowPriorityButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.CourseTasksGridView.MouseDown += this.TaskDataGridView_MouseDown;
            
        }

        #endregion

        #region Methods

        public event EventHandler<CourseInfoEventArgs> ChangeHasOccured;

        /// <summary>Adds the newTasks to the grid view</summary>
        /// <param name="newTasks">The newTasks.</param>
        public void LoadTasks(IList<string> newTasks)
        {
            this.clearAllCurrentTasks();
            if (newTasks.Count > this.CourseTasksGridView.RowCount)
            {
                var difference = newTasks.Count - this.CourseTasksGridView.RowCount;
                this.CourseTasksGridView.Rows.Add(difference + 1);
            }

            for (var i = 0; i < newTasks.Count; i++)
            {
                var row = this.CourseTasksGridView.Rows[i];
              
                var currentTask = newTasks[i];

                row.Cells[textBoxIndex].Value = currentTask;
            }
        }

        private void clearAllCurrentTasks()
        {
            foreach(DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[checkBoxIndex];
                var textBoxCell = (DataGridViewTextBoxCell)row.Cells[textBoxIndex];
                if (textBoxCell.Value != null)
                {
                    textBoxCell.Value = String.Empty;
                }
            }
        }







        private void PriorityHasChanged(int changedPriority)
        {
            var data = new CourseInfoEventArgs {
                Priority = changedPriority,
                Tasks = this.GenerateTasks()
            };

            this.ChangeHasOccured?.Invoke(this, data);
        }

        private void TaskHasChanged(List<string> changedTask)
        {
            var data = new CourseInfoEventArgs {
                Tasks = changedTask,
                Priority = this.SelectedPriority
            };

            this.ChangeHasOccured?.Invoke(this, data);
        }

        public List<string> GenerateTasks()
        {
            var tasks = new List<string>();
            foreach (DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[checkBoxIndex];
                checkToAddTextBox(checkBoxCell, row, tasks);
            }
            return tasks;
        }

        private static void checkToAddTextBox(DataGridViewCheckBoxCell checkBoxCell, DataGridViewRow row, List<string> tasks)
        {
            if (!Convert.ToBoolean(checkBoxCell.EditedFormattedValue))
            {
                var textBoxCell = (DataGridViewTextBoxCell) row.Cells[textBoxIndex];
                if (textBoxCell.Value != null)
                {
                    tasks.Add(textBoxCell.Value.ToString());
                }
            }
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
            else if (this.LowPriorityButton.Checked)
            {
                this.updatePriority(priorityLow);
            }
        }

        private void updatePriority(int newPriority)
        {
            this.PriorityHasChanged(newPriority);
            this.SelectedPriority = newPriority;
        }

        private void checkAllTasksMenuItem_Click(object sender, EventArgs e)
        {
            this.updateAllCheckBoxesInGridView( true);
        }

        private void updateAllCheckBoxesInGridView(bool newValue)
        {
            foreach (DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                var currentCheckBox = (DataGridViewCheckBoxCell) row.Cells[0];

                currentCheckBox.Value = newValue;
                currentCheckBox.Selected = newValue;
            }
        }

        private void unCheckAllTasksMenuItem_Click(object sender, EventArgs e)
        {
            this.updateAllCheckBoxesInGridView(false);
        }

        #endregion
    }
}