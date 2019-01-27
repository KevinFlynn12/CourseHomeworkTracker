using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClassTaskLibrary.Event;
using FlynnAssignment1.View.Controller;
using FlynnAssignment1.View.Helper;

namespace FlynnAssignment1.View
{
    public partial class Form1 : Form
    {
        #region Data members

        private readonly HomeworkTrackerController controller;
        private readonly int CS3202TabIndex = 0;
        private readonly int ENGL1102TabIndex = 1;
        private readonly int CHEM1212TabIndex = 2;

        private readonly string[] preloadedCs3202Tasks = {
            "Study", "Take Quiz"
        };

        private readonly string[] preloadedEngl1102Tasks = {
            "Write Paper", "Do Homework"
        };

        private readonly string[] preloadedChem1212Tasks = {
            "Finish Lab", "Buy Textbook"
        };

        #endregion

        #region Constructors

        public Form1()
        {
            this.InitializeComponent();
            Text = "Homework Tracker by Kevin Flynn";
            this.controller = new HomeworkTrackerController();

            this.InitializeEventHandlers();
            this.ClassesTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.CHEM1212.Tag = Priority.Low;
            this.ENGL1102.Tag = Priority.Low;
            this.CS3202.Tag = Priority.Low;

            this.CS3202Info.AddTasks(this.preloadedCs3202Tasks);
            this.ENGL1102Info.AddTasks(this.preloadedEngl1102Tasks);
            this.CHEM1212Info.AddTasks(this.preloadedChem1212Tasks);

            this.CreateAllCourses();
            this.ClassInformation.Text = this.controller.UpdateClassesOutput();
        }

        #endregion

        #region Methods

        private void InitializeEventHandlers()
        {
            this.CS3202Info.ChangeHasOccured += this.CreateTabColor_OnChange;
            this.CS3202Info.ChangeHasOccured += this.processTaskChange;
            this.CHEM1212Info.ChangeHasOccured += this.processTaskChange;
            this.CHEM1212Info.ChangeHasOccured += this.CreateTabColor_OnChange;
            this.ENGL1102Info.ChangeHasOccured += this.processTaskChange;
            this.ENGL1102Info.ChangeHasOccured += this.CreateTabColor_OnChange;
            this.ClassesTabControl.DrawItem += this.coursesTabPage_DrawItem;
            

        }

        private void processTaskChange(object sender, CourseInfoEventArgs e)
        {
            this.controller.UpdateSelectedCoursesTasks(this.ClassesTabControl.SelectedTab.Text, e.Tasks, e.Priority);
            this.ClassInformation.Text = this.controller.UpdateClassesOutput();
        }

        private void CreateAllCourses()
        {
            this.controller.CreateACourse(this.ClassesTabControl.TabPages[this.CS3202TabIndex].Text,
                this.CS3202Info.GenerateTasks());
            this.controller.CreateACourse(this.ClassesTabControl.TabPages[this.ENGL1102TabIndex].Text,
                this.ENGL1102Info.GenerateTasks());
            this.controller.CreateACourse(this.ClassesTabControl.TabPages[this.CHEM1212TabIndex].Text,
                this.CHEM1212Info.GenerateTasks());
        }

        private void coursesTabPage_DrawItem(object sender, DrawItemEventArgs e)
        {
            var page = this.ClassesTabControl.TabPages[e.Index];
            var determinedColor = this.DetermineColor((Priority) page.Tag);
            e.Graphics.FillRectangle(new SolidBrush(determinedColor), e.Bounds);
            var tabBounds = e.Bounds;
            var yOffset = e.State == DrawItemState.Selected ? -2 : 1;
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


        #endregion

        private void OpenHomeworkTrackerFile_Click(object sender, System.EventArgs e)
        {
            var FileDialog = new OpenFileDialog();
            string filter = "CSV file (*.csv)|*.csv";
            FileDialog.Filter = filter;
            FileDialog.FilterIndex = 1;
            FileDialog.Multiselect = false;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                

               var fileInfo = File.ReadAllLines(FileDialog.FileName);
               this.controller.LoadCoursesFromCSVFile(fileInfo);
               this.ClassInformation.Text = this.controller.UpdateClassesOutput();

            }

        }

        private void saveHomeworkTracker_Click(object sender, System.EventArgs e)
        {
            var newCsvFile = this.controller.WriteCSVFile();
            var FileDialog = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv";
            FileDialog.Filter = filter;
        
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(FileDialog.FileName, newCsvFile);
            }

        }
    }
}