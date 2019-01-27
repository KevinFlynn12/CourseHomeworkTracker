using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClassTaskLibrary;
using ClassTaskLibrary.Event;
using FlynnAssignment1.View.Controller;
using FlynnAssignment1.View.Helper;
using FlynnAssignment1.View.Model;

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

            this.CS3202Info.LoadTasks(this.preloadedCs3202Tasks);
            this.ENGL1102Info.LoadTasks(this.preloadedEngl1102Tasks);
            this.CHEM1212Info.LoadTasks(this.preloadedChem1212Tasks);
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
            var fileSelector = new OpenFileDialog();
            string filter = "CSV file (*.csv)|*.csv";
            fileSelector.Filter = filter;
            fileSelector.FilterIndex = 1;
            fileSelector.Multiselect = false;
            var selectedOpenFile = fileSelector.ShowDialog() == DialogResult.OK;
            if (selectedOpenFile)
            {                
               var fileInfo = File.ReadAllLines(fileSelector.FileName);
               this.controller.LoadCoursesFromCSVFile(fileInfo);
               
               this.LoadNewPrioritiesFromCSVFile(this.CS3202Info, this.CS3202.Text);
               this.LoadNewPrioritiesFromCSVFile(this.CHEM1212Info, this.CHEM1212.Text);
               this.LoadNewPrioritiesFromCSVFile(this.ENGL1102Info, this.ENGL1102.Text);
               this.ClassesTabControl.Invalidate(this.ClassesTabControl.GetTabRect(this.ClassesTabControl.SelectedIndex));

                this.LoadNewTasksFromCSVFile();
            }

        }

        private void LoadNewPrioritiesFromCSVFile(CourseInfo currentCourseInfo, string currentCoursesTitle)
        {

            var coursesPriority = this.controller.FindMatchingCoursesPriority(currentCoursesTitle);
            if (coursesPriority == Priority.High)
            {
                currentCourseInfo.HightPriorityRadioButton.Checked = true;
            }
            else if (coursesPriority == Priority.Medium)
            {
                currentCourseInfo.MediumPriorityRadioButton.Checked = true;
            }
            else if (coursesPriority == Priority.Low)
            {
                currentCourseInfo.LowtPriorityRadioButton.Checked = true;
            }
        }
       

        private void LoadNewTasksFromCSVFile()
        {
            var CS3202newTasks = this.controller.FindMatchingCoursesTasks(this.CS3202.Text);
            var CHEM1212newTasks = this.controller.FindMatchingCoursesTasks(this.CHEM1212.Text);
            var ENGL1102NewTasks = this.controller.FindMatchingCoursesTasks(this.ENGL1102.Text);
            this.CS3202Info.LoadTasks(CS3202newTasks);
            this.CHEM1212Info.LoadTasks(CHEM1212newTasks);
            this.ENGL1102Info.LoadTasks(ENGL1102NewTasks);
        }

       





        private void saveHomeworkTracker_Click(object sender, System.EventArgs e)
        {
            var newCsvFile = this.controller.WriteCSVFile();
            var saveFileDialog = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Filter = filter;

            var selectedSaveFile = saveFileDialog.ShowDialog() == DialogResult.OK;
            if (selectedSaveFile)
            {
                File.WriteAllText(saveFileDialog.FileName, newCsvFile);
            }

        }
    }
}