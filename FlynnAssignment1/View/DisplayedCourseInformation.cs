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
using FlynnAssignment1.Controller;
using FlynnAssignment1.Helper;
using FlynnAssignment1.View.Output;

namespace FlynnAssignment1
{
    public partial class Form1 : Form
    {
        private Color SelectedColor;

        

        private ClassesInformationController controller;
        private int CS3202TabIndex = 0;
        private int ENGL1102TabIndex = 1;
        private int CHEM1212TabIndex = 2;

        public Form1()
        {

            this.InitializeComponent();
            this.Text = "Homework Tracker by Kevin Flynn";
            this.controller = new ClassesInformationController();
            this.SelectedColor = default(Color);

            this.InitalizeEventHandlers();

            this.CreateAllCourses();
            this.ClassInformation.Text = this.controller.BuildClassesOutput();


        }

        private void InitalizeEventHandlers()
        {
            this.CS3202Info.ChangeHasOccured += this.processPriority;
            this.CS3202Info.ChangeHasOccured += this.processTaskChange;
            this.CHEM1212Info.ChangeHasOccured += this.processTaskChange;
            this.CHEM1212Info.ChangeHasOccured += this.processPriority;
            this.ENGL1102Info.ChangeHasOccured += this.processTaskChange;
            this.ENGL1102Info.ChangeHasOccured += this.processPriority;
            this.ClassesTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.ClassesTabControl.DrawItem += this.tabControl1_DrawItem;    
             
        }

        private void processTaskChange(object sender, CourseInfoEventArgs e)
        {
            try
            {
                this.controller.UpdateSelectedCoursesTasks(this.ClassesTabControl.SelectedTab.Text, e.Tasks);
                this.ClassInformation.Text = this.controller.BuildClassesOutput();
            }
            catch (Exception)
            {

            }       
        }


        private void CreateAllCourses()
        { 
            this.controller.InitializeCourse(this.ClassesTabControl.TabPages[this.CS3202TabIndex].Text,this.CS3202Info.GenerateTasks());
            this.controller.InitializeCourse(this.ClassesTabControl.TabPages[this.ENGL1102TabIndex].Text, this.ENGL1102Info.GenerateTasks());
            this.controller.InitializeCourse(this.ClassesTabControl.TabPages[this.CHEM1212TabIndex].Text, this.CHEM1212Info.GenerateTasks());

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
            this.determineSelectedColor(e);
            this.ClassesTabControl.Invalidate(this.ClassesTabControl.GetTabRect(this.ClassesTabControl.SelectedIndex));

        }

        private void determineSelectedColor(CourseInfoEventArgs e)
        {
            if (e.Priority == (int) Priority.High)
            {
                this.SelectedColor = Color.Red;

            }
            else if (e.Priority == (int) Priority.Medium)
            {
                this.SelectedColor = Color.Yellow;
            }

            else
            {
                this.SelectedColor = default(Color);
            }

        }

       
    }
}
