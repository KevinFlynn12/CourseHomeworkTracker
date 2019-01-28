namespace FlynnAssignment1.View
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
            this.CS3202 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassInformation = new System.Windows.Forms.TextBox();
            this.CHEM1212 = new System.Windows.Forms.TabPage();
            this.ENGL1102 = new System.Windows.Forms.TabPage();
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHomeworkTrackerFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHomeworkTracker = new System.Windows.Forms.ToolStripMenuItem();
            this.CS3202Info = new ClassTaskLibrary.CourseInfo();
            this.ENGL1102Info = new ClassTaskLibrary.CourseInfo();
            this.CHEM1212Info = new ClassTaskLibrary.CourseInfo();
            this.CS3202.SuspendLayout();
            this.CHEM1212.SuspendLayout();
            this.ENGL1102.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CS3202
            // 
            this.CS3202.Controls.Add(this.CS3202Info);
            this.CS3202.Location = new System.Drawing.Point(4, 22);
            this.CS3202.Margin = new System.Windows.Forms.Padding(2);
            this.CS3202.Name = "CS3202";
            this.CS3202.Padding = new System.Windows.Forms.Padding(2);
            this.CS3202.Size = new System.Drawing.Size(499, 231);
            this.CS3202.TabIndex = 0;
            this.CS3202.Text = "CS 3202";
            this.CS3202.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task To Complete";
            // 
            // ClassInformation
            // 
            this.ClassInformation.Location = new System.Drawing.Point(9, 326);
            this.ClassInformation.Margin = new System.Windows.Forms.Padding(2);
            this.ClassInformation.Multiline = true;
            this.ClassInformation.Name = "ClassInformation";
            this.ClassInformation.ReadOnly = true;
            this.ClassInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClassInformation.Size = new System.Drawing.Size(502, 196);
            this.ClassInformation.TabIndex = 3;
            // 
            // CHEM1212
            // 
            this.CHEM1212.Controls.Add(this.CHEM1212Info);
            this.CHEM1212.Location = new System.Drawing.Point(4, 22);
            this.CHEM1212.Margin = new System.Windows.Forms.Padding(2);
            this.CHEM1212.Name = "CHEM1212";
            this.CHEM1212.Padding = new System.Windows.Forms.Padding(2);
            this.CHEM1212.Size = new System.Drawing.Size(499, 231);
            this.CHEM1212.TabIndex = 2;
            this.CHEM1212.Text = "CHEM 1212";
            this.CHEM1212.UseVisualStyleBackColor = true;
            // 
            // ENGL1102
            // 
            this.ENGL1102.Controls.Add(this.ENGL1102Info);
            this.ENGL1102.Location = new System.Drawing.Point(4, 22);
            this.ENGL1102.Margin = new System.Windows.Forms.Padding(2);
            this.ENGL1102.Name = "ENGL1102";
            this.ENGL1102.Padding = new System.Windows.Forms.Padding(2);
            this.ENGL1102.Size = new System.Drawing.Size(499, 231);
            this.ENGL1102.TabIndex = 1;
            this.ENGL1102.Text = "ENGL 1102";
            this.ENGL1102.UseVisualStyleBackColor = true;
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.CS3202);
            this.ClassesTabControl.Controls.Add(this.ENGL1102);
            this.ClassesTabControl.Controls.Add(this.CHEM1212);
            this.ClassesTabControl.Location = new System.Drawing.Point(9, 50);
            this.ClassesTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.SelectedIndex = 0;
            this.ClassesTabControl.Size = new System.Drawing.Size(507, 257);
            this.ClassesTabControl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenHomeworkTrackerFile,
            this.saveHomeworkTracker});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenHomeworkTrackerFile
            // 
            this.OpenHomeworkTrackerFile.Name = "OpenHomeworkTrackerFile";
            this.OpenHomeworkTrackerFile.Size = new System.Drawing.Size(180, 22);
            this.OpenHomeworkTrackerFile.Text = "&Open";
            this.OpenHomeworkTrackerFile.Click += new System.EventHandler(this.OpenHomeworkTrackerFile_Click);
            // 
            // saveHomeworkTracker
            // 
            this.saveHomeworkTracker.Name = "saveHomeworkTracker";
            this.saveHomeworkTracker.Size = new System.Drawing.Size(180, 22);
            this.saveHomeworkTracker.Text = "&Save";
            this.saveHomeworkTracker.Click += new System.EventHandler(this.saveHomeworkTracker_Click);
            // 
            // CS3202Info
            // 
            this.CS3202Info.Location = new System.Drawing.Point(8, 5);
            this.CS3202Info.Margin = new System.Windows.Forms.Padding(2);
            this.CS3202Info.Name = "CS3202Info";
            this.CS3202Info.Size = new System.Drawing.Size(496, 223);
            this.CS3202Info.TabIndex = 0;
            // 
            // ENGL1102Info
            // 
            this.ENGL1102Info.Location = new System.Drawing.Point(5, 6);
            this.ENGL1102Info.Margin = new System.Windows.Forms.Padding(2);
            this.ENGL1102Info.Name = "ENGL1102Info";
            this.ENGL1102Info.Size = new System.Drawing.Size(491, 225);
            this.ENGL1102Info.TabIndex = 0;
            // 
            // CHEM1212Info
            // 
            this.CHEM1212Info.Location = new System.Drawing.Point(7, 0);
            this.CHEM1212Info.Margin = new System.Windows.Forms.Padding(2);
            this.CHEM1212Info.Name = "CHEM1212Info";
            this.CHEM1212Info.Size = new System.Drawing.Size(494, 226);
            this.CHEM1212Info.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 531);
            this.Controls.Add(this.ClassInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassesTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CS3202.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem OpenHomeworkTrackerFile;
        private System.Windows.Forms.ToolStripMenuItem saveHomeworkTracker;
        private System.Windows.Forms.TabPage CS3202;
    }
}

