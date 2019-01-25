using System;
using System.Collections.Generic;

namespace ClassTaskLibrary
{

    public partial class CourseInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LowPriorityButton = new System.Windows.Forms.RadioButton();
            this.MediumPriorityButton = new System.Windows.Forms.RadioButton();
            this.HighPriorityButton = new System.Windows.Forms.RadioButton();
            this.CourseTasksGridView = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CourseTasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LowPriorityButton
            // 
            this.LowPriorityButton.AutoSize = true;
            this.LowPriorityButton.Location = new System.Drawing.Point(11, 116);
            this.LowPriorityButton.Name = "LowPriorityButton";
            this.LowPriorityButton.Size = new System.Drawing.Size(54, 21);
            this.LowPriorityButton.TabIndex = 2;
            this.LowPriorityButton.TabStop = true;
            this.LowPriorityButton.Text = "Low";
            this.LowPriorityButton.UseVisualStyleBackColor = true;
            this.LowPriorityButton.CheckedChanged += new System.EventHandler(this.LowPriorityButton_CheckedChanged);
            // 
            // MediumPriorityButton
            // 
            this.MediumPriorityButton.AutoSize = true;
            this.MediumPriorityButton.Location = new System.Drawing.Point(11, 75);
            this.MediumPriorityButton.Name = "MediumPriorityButton";
            this.MediumPriorityButton.Size = new System.Drawing.Size(78, 21);
            this.MediumPriorityButton.TabIndex = 1;
            this.MediumPriorityButton.TabStop = true;
            this.MediumPriorityButton.Text = "Medium";
            this.MediumPriorityButton.UseVisualStyleBackColor = true;
            this.MediumPriorityButton.CheckedChanged += new System.EventHandler(this.MediumPriorityButton_CheckedChanged);
            // 
            // HighPriorityButton
            // 
            this.HighPriorityButton.AutoSize = true;
            this.HighPriorityButton.Location = new System.Drawing.Point(11, 27);
            this.HighPriorityButton.Name = "HighPriorityButton";
            this.HighPriorityButton.Size = new System.Drawing.Size(58, 21);
            this.HighPriorityButton.TabIndex = 0;
            this.HighPriorityButton.TabStop = true;
            this.HighPriorityButton.Text = "High";
            this.HighPriorityButton.UseVisualStyleBackColor = true;
            this.HighPriorityButton.CheckedChanged += new System.EventHandler(this.HighPriorityButton_CheckedChanged);
            // 
            // CourseTasksGridView
            // 
            this.CourseTasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseTasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompletedTask,
            this.Task});
            this.CourseTasksGridView.Location = new System.Drawing.Point(113, 13);
            this.CourseTasksGridView.Name = "CourseTasksGridView";
            this.CourseTasksGridView.RowHeadersVisible = false;
            this.CourseTasksGridView.RowTemplate.Height = 24;
            this.CourseTasksGridView.Size = new System.Drawing.Size(540, 261);
            this.CourseTasksGridView.TabIndex = 2;
            this.CourseTasksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseTasksGridView_CellContentClick);
            this.CourseTasksGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseTasksGridView_CellContentClick);
            this.CourseTasksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseTasksGridView_CellContentClick);


            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // CompletedTask
            // 
            this.CompletedTask.HeaderText = "Done";
            this.CompletedTask.Name = "CompletedTask";
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LowPriorityButton);
            this.Controls.Add(this.CourseTasksGridView);
            this.Controls.Add(this.MediumPriorityButton);
            this.Controls.Add(this.HighPriorityButton);
            this.Name = "CourseInfo";
            this.Size = new System.Drawing.Size(666, 292);
            ((System.ComponentModel.ISupportInitialize)(this.CourseTasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton LowPriorityButton;
        private System.Windows.Forms.RadioButton MediumPriorityButton;
        private System.Windows.Forms.RadioButton HighPriorityButton;
        private System.Windows.Forms.DataGridView CourseTasksGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CompletedTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
    }
}
