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
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.LowPriorityButton = new System.Windows.Forms.RadioButton();
            this.MediumPriorityButton = new System.Windows.Forms.RadioButton();
            this.HighPriorityButton = new System.Windows.Forms.RadioButton();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseTasksGridView = new System.Windows.Forms.DataGridView();
            this.PriorityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseTasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.AccessibleName = "PriorityButtons";
            this.PriorityGroupBox.Controls.Add(this.LowPriorityButton);
            this.PriorityGroupBox.Controls.Add(this.MediumPriorityButton);
            this.PriorityGroupBox.Controls.Add(this.HighPriorityButton);
            this.PriorityGroupBox.Location = new System.Drawing.Point(15, 13);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Size = new System.Drawing.Size(92, 115);
            this.PriorityGroupBox.TabIndex = 1;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Text = "Priority";
            this.PriorityGroupBox.Enter += new System.EventHandler(this.PriorityGroupBox_Enter);
            // 
            // LowPriorityButton
            // 
            this.LowPriorityButton.AutoSize = true;
            this.LowPriorityButton.Location = new System.Drawing.Point(7, 90);
            this.LowPriorityButton.Name = "LowPriorityButton";
            this.LowPriorityButton.Size = new System.Drawing.Size(54, 21);
            this.LowPriorityButton.TabIndex = 2;
            this.LowPriorityButton.TabStop = true;
            this.LowPriorityButton.Text = "Low";
            this.LowPriorityButton.UseVisualStyleBackColor = true;
            // 
            // MediumPriorityButton
            // 
            this.MediumPriorityButton.AutoSize = true;
            this.MediumPriorityButton.Location = new System.Drawing.Point(7, 62);
            this.MediumPriorityButton.Name = "MediumPriorityButton";
            this.MediumPriorityButton.Size = new System.Drawing.Size(78, 21);
            this.MediumPriorityButton.TabIndex = 1;
            this.MediumPriorityButton.TabStop = true;
            this.MediumPriorityButton.Text = "Medium";
            this.MediumPriorityButton.UseVisualStyleBackColor = true;
            // 
            // HighPriorityButton
            // 
            this.HighPriorityButton.AutoSize = true;
            this.HighPriorityButton.Location = new System.Drawing.Point(7, 35);
            this.HighPriorityButton.Name = "HighPriorityButton";
            this.HighPriorityButton.Size = new System.Drawing.Size(58, 21);
            this.HighPriorityButton.TabIndex = 0;
            this.HighPriorityButton.TabStop = true;
            this.HighPriorityButton.Text = "High";
            this.HighPriorityButton.UseVisualStyleBackColor = true;
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
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CourseTasksGridView);
            this.Controls.Add(this.PriorityGroupBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(666, 292);
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseTasksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.RadioButton LowPriorityButton;
        private System.Windows.Forms.RadioButton MediumPriorityButton;
        private System.Windows.Forms.RadioButton HighPriorityButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CompletedTask;
        private System.Windows.Forms.DataGridView CourseTasksGridView;
    }
}
