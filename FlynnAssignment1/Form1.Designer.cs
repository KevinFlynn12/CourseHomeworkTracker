namespace FlynnAssignment1
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
            this.Course1Info = new ClassTaskLibrary.CourseInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassInformation = new System.Windows.Forms.TextBox();
            this.CHEM1212 = new System.Windows.Forms.TabPage();
            this.Course3Info = new ClassTaskLibrary.CourseInfo();
            this.ENGL1102 = new System.Windows.Forms.TabPage();
            this.Course2Info = new ClassTaskLibrary.CourseInfo();
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
            CS3202 = new System.Windows.Forms.TabPage();
            CS3202.SuspendLayout();
            this.CHEM1212.SuspendLayout();
            this.ENGL1102.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CS3202
            // 
            CS3202.Controls.Add(this.Course1Info);
            CS3202.Location = new System.Drawing.Point(4, 25);
            CS3202.Name = "CS3202";
            CS3202.Padding = new System.Windows.Forms.Padding(3);
            CS3202.Size = new System.Drawing.Size(668, 287);
            CS3202.TabIndex = 0;
            CS3202.Text = "CS 3202";
            CS3202.UseVisualStyleBackColor = true;
            // 
            // Course1Info
            // 
            this.Course1Info.HighPrioritySelected = false;
            this.Course1Info.Location = new System.Drawing.Point(10, 6);
            this.Course1Info.LowPrioritySelected = false;
            this.Course1Info.MediumPrioritySelected = false;
            this.Course1Info.Name = "Course1Info";
            this.Course1Info.Size = new System.Drawing.Size(662, 275);
            this.Course1Info.TabIndex = 0;
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
            this.ClassInformation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CHEM1212
            // 
            this.CHEM1212.Controls.Add(this.Course3Info);
            this.CHEM1212.Location = new System.Drawing.Point(4, 25);
            this.CHEM1212.Name = "CHEM1212";
            this.CHEM1212.Padding = new System.Windows.Forms.Padding(3);
            this.CHEM1212.Size = new System.Drawing.Size(668, 287);
            this.CHEM1212.TabIndex = 2;
            this.CHEM1212.Text = "CHEM 1212";
            this.CHEM1212.UseVisualStyleBackColor = true;
            // 
            // Course3Info
            // 
            this.Course3Info.HighPrioritySelected = false;
            this.Course3Info.Location = new System.Drawing.Point(3, 3);
            this.Course3Info.LowPrioritySelected = false;
            this.Course3Info.MediumPrioritySelected = false;
            this.Course3Info.Name = "Course3Info";
            this.Course3Info.Size = new System.Drawing.Size(659, 278);
            this.Course3Info.TabIndex = 0;
            // 
            // ENGL1102
            // 
            this.ENGL1102.Controls.Add(this.Course2Info);
            this.ENGL1102.Location = new System.Drawing.Point(4, 25);
            this.ENGL1102.Name = "ENGL1102";
            this.ENGL1102.Padding = new System.Windows.Forms.Padding(3);
            this.ENGL1102.Size = new System.Drawing.Size(668, 287);
            this.ENGL1102.TabIndex = 1;
            this.ENGL1102.Text = "ENGL 1102";
            this.ENGL1102.UseVisualStyleBackColor = true;
            // 
            // Course2Info
            // 
            this.Course2Info.HighPrioritySelected = false;
            this.Course2Info.Location = new System.Drawing.Point(7, 7);
            this.Course2Info.LowPrioritySelected = false;
            this.Course2Info.MediumPrioritySelected = false;
            this.Course2Info.Name = "Course2Info";
            this.Course2Info.Size = new System.Drawing.Size(655, 277);
            this.Course2Info.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 653);
            this.Controls.Add(this.ClassInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassesTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            CS3202.ResumeLayout(false);
            this.CHEM1212.ResumeLayout(false);
            this.ENGL1102.ResumeLayout(false);
            this.ClassesTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassInformation;
        private System.Windows.Forms.TabPage CHEM1212;
        private ClassTaskLibrary.CourseInfo Course3Info;
        private System.Windows.Forms.TabPage ENGL1102;
        private ClassTaskLibrary.CourseInfo Course2Info;
        private ClassTaskLibrary.CourseInfo Course1Info;
        private System.Windows.Forms.TabControl ClassesTabControl;
    }
}

