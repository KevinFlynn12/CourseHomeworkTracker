﻿namespace FlynnAssignment1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage CS3202;
            this.CS3202Info = new ClassTaskLibrary.CourseInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassInformation = new System.Windows.Forms.TextBox();
            this.CHEM1212 = new System.Windows.Forms.TabPage();
            this.CHEM1212Info = new ClassTaskLibrary.CourseInfo();
            this.ENGL1102 = new System.Windows.Forms.TabPage();
            this.ENGL1102Info = new ClassTaskLibrary.CourseInfo();
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CS3202 = new System.Windows.Forms.TabPage();
            CS3202.SuspendLayout();
            this.CHEM1212.SuspendLayout();
            this.ENGL1102.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CS3202
            // 
            CS3202.Controls.Add(this.CS3202Info);
            CS3202.Location = new System.Drawing.Point(4, 25);
            CS3202.Name = "CS3202";
            CS3202.Padding = new System.Windows.Forms.Padding(3);
            CS3202.Size = new System.Drawing.Size(668, 287);
            CS3202.TabIndex = 0;
            CS3202.Text = "CS 3202";
            CS3202.UseVisualStyleBackColor = true;
            // 
            // CS3202Info
            // 
            this.CS3202Info.Location = new System.Drawing.Point(10, 6);
            this.CS3202Info.Name = "CS3202Info";
            this.CS3202Info.Size = new System.Drawing.Size(662, 275);
            this.CS3202Info.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task To Complete";
            // 
            // ClassInformation
            // 
            this.ClassInformation.Location = new System.Drawing.Point(12, 401);
            this.ClassInformation.Multiline = true;
            this.ClassInformation.Name = "ClassInformation";
            this.ClassInformation.Size = new System.Drawing.Size(668, 240);
            this.ClassInformation.TabIndex = 3;
            // 
            // CHEM1212
            // 
            this.CHEM1212.Controls.Add(this.CHEM1212Info);
            this.CHEM1212.Location = new System.Drawing.Point(4, 25);
            this.CHEM1212.Name = "CHEM1212";
            this.CHEM1212.Padding = new System.Windows.Forms.Padding(3);
            this.CHEM1212.Size = new System.Drawing.Size(668, 287);
            this.CHEM1212.TabIndex = 2;
            this.CHEM1212.Text = "CHEM 1212";
            this.CHEM1212.UseVisualStyleBackColor = true;
            // 
            // CHEM1212Info
            // 
            this.CHEM1212Info.Location = new System.Drawing.Point(9, 0);
            this.CHEM1212Info.Name = "CHEM1212Info";
            this.CHEM1212Info.Size = new System.Drawing.Size(659, 278);
            this.CHEM1212Info.TabIndex = 0;
            // 
            // ENGL1102
            // 
            this.ENGL1102.Controls.Add(this.ENGL1102Info);
            this.ENGL1102.Location = new System.Drawing.Point(4, 25);
            this.ENGL1102.Name = "ENGL1102";
            this.ENGL1102.Padding = new System.Windows.Forms.Padding(3);
            this.ENGL1102.Size = new System.Drawing.Size(668, 287);
            this.ENGL1102.TabIndex = 1;
            this.ENGL1102.Text = "ENGL 1102";
            this.ENGL1102.UseVisualStyleBackColor = true;
            // 
            // ENGL1102Info
            // 
            this.ENGL1102Info.Location = new System.Drawing.Point(7, 7);
            this.ENGL1102Info.Name = "ENGL1102Info";
            this.ENGL1102Info.Size = new System.Drawing.Size(655, 277);
            this.ENGL1102Info.TabIndex = 0;
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(CS3202);
            this.ClassesTabControl.Controls.Add(this.ENGL1102);
            this.ClassesTabControl.Controls.Add(this.CHEM1212);
            this.ClassesTabControl.Location = new System.Drawing.Point(12, 62);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.SelectedIndex = 0;
            this.ClassesTabControl.Size = new System.Drawing.Size(676, 316);
            this.ClassesTabControl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 653);
            this.Controls.Add(this.ClassInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassesTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            CS3202.ResumeLayout(false);
            this.CHEM1212.ResumeLayout(false);
            this.ENGL1102.ResumeLayout(false);
            this.ClassesTabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassInformation;
        private System.Windows.Forms.TabPage CHEM1212;
        private ClassTaskLibrary.CourseInfo CHEM1212Info;
        private System.Windows.Forms.TabPage ENGL1102;
        private ClassTaskLibrary.CourseInfo ENGL1102Info;
        private ClassTaskLibrary.CourseInfo CS3202Info;
        private System.Windows.Forms.TabControl ClassesTabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

