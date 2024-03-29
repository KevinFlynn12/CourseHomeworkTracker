﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassTaskLibrary.Event;

namespace ClassTaskLibrary
{
    /// <summary>Class created to store course information regarding task and priority of class</summary>
    public partial class CourseInfo : UserControl
    {
        #region Data members

        private const int PriorityHigh = 3;
        private const int PriorityMedium = 2;
        private const int PriorityLow = 1;
        private static readonly int textBoxIndex = 1;
        private static readonly int checkBoxIndex = 0;
        private int selectedPriority;

        #endregion

        #region Properties

        public bool HighPriorityButtonSelected
        {
            get => this.HighPriorityButton.Checked;
            set => this.HighPriorityButton.Checked = value;
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

        /// <summary>initializes the courseInfo class</summary>
        public CourseInfo()
        {
            this.InitializeComponent();
            this.selectedPriority = PriorityLow;
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

            this.courseInformationHasChanged();
        }

        private void clearAllCurrentTasks()
        {
            foreach (DataGridViewRow row in this.CourseTasksGridView.Rows)
            {
                var textBoxCell = (DataGridViewTextBoxCell) row.Cells[textBoxIndex];
                if (textBoxCell.Value != null)
                {
                    textBoxCell.Value = string.Empty;
                }
            }
        }

        private void courseInformationHasChanged()
        {
            var data = new CourseInfoEventArgs {
                Priority = this.selectedPriority,
                Tasks = this.GenerateTasks()
            };

            this.ChangeHasOccured?.Invoke(this, data);
        }

       

        /// <summary>Generates tasks CoursesTasksGridView</summary>
        /// <returns>list all strings in the grid view</returns>
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

        private static void checkToAddTextBox(DataGridViewCheckBoxCell checkBoxCell, DataGridViewRow row,
            List<string> tasks)
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
            this.courseInformationHasChanged();
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
                this.selectedPriority = PriorityHigh;
            }
            else if (this.MediumPriorityButton.Checked)
            {
                this.selectedPriority = PriorityMedium;
            }
            else if (this.LowPriorityButton.Checked)
            {
                this.selectedPriority = PriorityLow;
            }
            this.courseInformationHasChanged();
        }

        private void checkAllTasksMenuItem_Click(object sender, EventArgs e)
        {
            this.updateAllCheckBoxesInGridView(true);
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

        private void UnCheckAllTasksMenuItem_Click(object sender, EventArgs e)
        {
            this.updateAllCheckBoxesInGridView(false);
        }

        #endregion
    }
}