using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTaskLibrary;
using FlynnAssignment1.View.Output;

namespace FlynnAssignment1
{
    public partial class Form1 : Form
    {
        private Color SelectedColor;

        public Form1()
        {

            this.InitializeComponent();
            this.Text = "Homework Tracker by Kevin Flynn";
            this.Course1Info.CoursePrioritySelected += this.processPriority;
            this.ClassInformation.Text = PriorityOutput.BuildPriorityOutput(null);

            this.ClassesTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.ClassesTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.SelectedColor = default(Color);


        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = this.ClassesTabControl.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(this.SelectedColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }



        private void processPriority(object sender, CourseInfoEventArgs e)
        {    
                this.ClassInformation.Text += "Success";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
