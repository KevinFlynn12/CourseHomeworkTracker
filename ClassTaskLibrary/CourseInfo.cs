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


        public RadioButton HightPriorityRadioButton
        {
            get => this.HighPriorityButton;
            set => this.HighPriorityButton = value;
        }
        public RadioButton MediumPriorityRadioButton
        {
            get => this.MediumPriorityButton;
            set => this.MediumPriorityButton = value;
        }

        public RadioButton LowtPriorityRadioButton
        {
            get => this.LowPriorityButton;
            set => this.LowPriorityButton = value;
        }


        #endregion

        #region Constructors

        public CourseInfo()
        {
            this.InitializeComponent();
            this.LowPriorityButton.Checked = true;
            this.SelectedPriority = priorityLow;
            this.HightPriorityRadioButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.MediumPriorityRadioButton.CheckedChanged += this.PriorityGroupBox_Enter;
            this.LowtPriorityRadioButton.CheckedChanged += this.PriorityGroupBox_Enter;
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
            var data = new CourseInfoEventArgs {Priority = changedPriority};

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
            
            if (this.HightPriorityRadioButton.Checked)
            {
                this.updatePriority(priorityHigh);
            }
            else if (this.MediumPriorityRadioButton.Checked)
            {
                this.updatePriority(priorityMedium);
            }
            else if (this.LowtPriorityRadioButton.Checked)
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