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
            this.components = new System.ComponentModel.Container();
            this.LowPriorityButton = new System.Windows.Forms.RadioButton();
            this.MediumPriorityButton = new System.Windows.Forms.RadioButton();
            this.HighPriorityButton = new System.Windows.Forms.RadioButton();
            this.CourseTasksGridView = new System.Windows.Forms.DataGridView();
            this.CompletedTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unCheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CourseTasksGridView)).BeginInit();
            this.PriorityGroupBox.SuspendLayout();
            this.DataGridViewMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowPriorityButton
            // 
            this.LowPriorityButton.AutoSize = true;
            this.LowPriorityButton.Checked = true;
            this.LowPriorityButton.Location = new System.Drawing.Point(4, 64);
            this.LowPriorityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LowPriorityButton.Name = "LowPriorityButton";
            this.LowPriorityButton.Size = new System.Drawing.Size(45, 17);
            this.LowPriorityButton.TabIndex = 2;
            this.LowPriorityButton.TabStop = true;
            this.LowPriorityButton.Text = "Low";
            this.LowPriorityButton.UseVisualStyleBackColor = true;
            // 
            // MediumPriorityButton
            // 
            this.MediumPriorityButton.AutoSize = true;
            this.MediumPriorityButton.Location = new System.Drawing.Point(4, 44);
            this.MediumPriorityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MediumPriorityButton.Name = "MediumPriorityButton";
            this.MediumPriorityButton.Size = new System.Drawing.Size(62, 17);
            this.MediumPriorityButton.TabIndex = 1;
            this.MediumPriorityButton.Text = "Medium";
            this.MediumPriorityButton.UseVisualStyleBackColor = true;
            // 
            // HighPriorityButton
            // 
            this.HighPriorityButton.AutoSize = true;
            this.HighPriorityButton.Location = new System.Drawing.Point(4, 22);
            this.HighPriorityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HighPriorityButton.Name = "HighPriorityButton";
            this.HighPriorityButton.Size = new System.Drawing.Size(47, 17);
            this.HighPriorityButton.TabIndex = 0;
            this.HighPriorityButton.Text = "High";
            this.HighPriorityButton.UseVisualStyleBackColor = true;
            // 
            // CourseTasksGridView
            // 
            this.CourseTasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseTasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompletedTask,
            this.Task});
            this.CourseTasksGridView.Location = new System.Drawing.Point(85, 11);
            this.CourseTasksGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CourseTasksGridView.Name = "CourseTasksGridView";
            this.CourseTasksGridView.RowHeadersVisible = false;
            this.CourseTasksGridView.RowTemplate.Height = 24;
            this.CourseTasksGridView.Size = new System.Drawing.Size(405, 212);
            this.CourseTasksGridView.TabIndex = 2;
            this.CourseTasksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseTasksGridView_CellContentClick);
            this.CourseTasksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseTasksGridView_CellContentClick);
            this.CourseTasksGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseTasksGridView_CellContentClick);
            // 
            // CompletedTask
            // 
            this.CompletedTask.HeaderText = "Done";
            this.CompletedTask.Name = "CompletedTask";
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.Controls.Add(this.HighPriorityButton);
            this.PriorityGroupBox.Controls.Add(this.LowPriorityButton);
            this.PriorityGroupBox.Controls.Add(this.MediumPriorityButton);
            this.PriorityGroupBox.Location = new System.Drawing.Point(8, 11);
            this.PriorityGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriorityGroupBox.Size = new System.Drawing.Size(72, 81);
            this.PriorityGroupBox.TabIndex = 3;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Text = "Priority";
            this.PriorityGroupBox.Enter += new System.EventHandler(this.PriorityGroupBox_Enter);
            // 
            // DataGridViewMenuStrip
            // 
            this.DataGridViewMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DataGridViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.unCheckAllToolStripMenuItem});
            this.DataGridViewMenuStrip.Name = "DataGridViewMenuStrip";
            this.DataGridViewMenuStrip.Size = new System.Drawing.Size(140, 48);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllTasksMenuItem_Click);
            // 
            // unCheckAllToolStripMenuItem
            // 
            this.unCheckAllToolStripMenuItem.Name = "unCheckAllToolStripMenuItem";
            this.unCheckAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.unCheckAllToolStripMenuItem.Text = "UnCheck All";
            this.unCheckAllToolStripMenuItem.Click += new System.EventHandler(this.UnCheckAllTasksMenuItem_Click);
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityGroupBox);
            this.Controls.Add(this.CourseTasksGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CourseInfo";
            this.Size = new System.Drawing.Size(500, 237);
            ((System.ComponentModel.ISupportInitialize)(this.CourseTasksGridView)).EndInit();
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            this.DataGridViewMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton LowPriorityButton;
        private System.Windows.Forms.RadioButton MediumPriorityButton;
        private System.Windows.Forms.RadioButton HighPriorityButton;
        private System.Windows.Forms.DataGridView CourseTasksGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CompletedTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.ContextMenuStrip DataGridViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unCheckAllToolStripMenuItem;
    }
}
