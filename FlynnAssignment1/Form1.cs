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
        public Form1()
        {
            this.InitializeComponent();
            this.Text = "Homework Tracker by Kevin Flynn";
            this.Course1Info.CoursePrioritySelected += this.processPriority;
            this.ClassInformation.Text = PriorityOutput.BuildPriorityOutput(null);
            


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
