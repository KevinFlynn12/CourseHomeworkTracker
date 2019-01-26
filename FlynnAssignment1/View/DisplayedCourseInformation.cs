using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTaskLibrary;
using ClassTaskLibrary.Event;
using FlynnAssignment1.Controller;
using FlynnAssignment1.Helper;
using FlynnAssignment1.View.Output;

namespace FlynnAssignment1
{
    public partial class Form1 : Form
    {

        private ClassesInformationController controller;
        private int CS3202TabIndex = 0;
        private int ENGL1102TabIndex = 1;
        private int CHEM1212TabIndex = 2;
        private int CS3202Index;
        private string[] preloadedCS3202Tasks = {
            "Study", "Take Quiz"
        };
        private string[] preloadedENGL1102Tasks = {
            "Write Paper", "Do Homework"
        };
        private string[] preloadedCHEM1212Tasks = {
            "Finish Lab", "Buy Textbook"
        };



        public Form1()
        {
            this.InitializeComponent();
            this.Text = "Homework Tracker by Kevin Flynn";
            this.controller = new ClassesInformationController();

            this.InitializeEventHandlers();
            this.ClassesTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.CHEM1212.Tag = Priority.Low;
            this.ENGL1102.Tag = Priority.Low;
            this.CS3202Index = 0;
            this.ClassesTabControl.TabPages[this.CS3202Index].Tag = Priority.Low;

            this.CS3202Info.AddTasks(this.preloadedCS3202Tasks);
            this.ENGL1102Info.AddTasks(this.preloadedENGL1102Tasks);
            this.CHEM1212Info.AddTasks(this.preloadedCHEM1212Tasks);



            this.CreateAllCourses();
            this.ClassInformation.Text = this.controller.UpdateClassesOutput();
        }

        private void InitializeEventHandlers()
        {
            this.CS3202Info.ChangeHasOccured += this.CreateTabColor_OnChange;
            this.CS3202Info.ChangeHasOccured += this.processTaskChange;
            this.CHEM1212Info.ChangeHasOccured += this.processTaskChange;
            this.CHEM1212Info.ChangeHasOccured += this.CreateTabColor_OnChange;
            this.ENGL1102Info.ChangeHasOccured += this.processTaskChange;
            this.ENGL1102Info.ChangeHasOccured += this.CreateTabColor_OnChange;
            
           
            this.ClassesTabControl.DrawItem += this.tabControl1_DrawItem;
        }

        private void processTaskChange(object sender, CourseInfoEventArgs e)
        {  
            this.controller.UpdateSelectedCoursesTasks(this.ClassesTabControl.SelectedTab.Text, e.Tasks, e.Priority);
            this.ClassInformation.Text = this.controller.UpdateClassesOutput();
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
             var determinedColor = this.DetermineColor((Priority) page.Tag);
             e.Graphics.FillRectangle(new SolidBrush(determinedColor), e.Bounds);
             Rectangle tabBounds = e.Bounds;
             int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
             tabBounds.Offset(1, yOffset);
             TextRenderer.DrawText(e.Graphics, page.Text, Font, tabBounds, page.ForeColor);            
        }


        private Color DetermineColor(Priority selectedPriority)
        {
            var selectedColor = new Color();
            if (selectedPriority == Priority.High)
            {
                selectedColor = Color.Red;
            }
            else if (selectedPriority == Priority.Medium)
            {
                selectedColor = Color.Yellow;
            }
            else
            {
                selectedColor = default(Color);
            }
            return selectedColor;
        }


        private void CreateTabColor_OnChange(object sender, CourseInfoEventArgs e)
        {
            this.determineCurrentTabsPriority(e);
            this.ClassesTabControl.Invalidate(this.ClassesTabControl.GetTabRect(this.ClassesTabControl.SelectedIndex));
            this.controller.UpdateSelectedCoursesTasks(this.ClassesTabControl.SelectedTab.Text, e.Tasks, e.Priority);
            this.controller.UpdateClassesOutput();
        }


      


        private void determineCurrentTabsPriority(CourseInfoEventArgs e)
        {
            if (e.Priority == (int) Priority.High)
            {
                this.ClassesTabControl.SelectedTab.Tag = Priority.High;

            }
            else if (e.Priority == (int) Priority.Medium)
            {
                this.ClassesTabControl.SelectedTab.Tag = Priority.Medium;
            }
            else
            {
                this.ClassesTabControl.SelectedTab.Tag = Priority.Low;
            }

        }

       
    }
}
