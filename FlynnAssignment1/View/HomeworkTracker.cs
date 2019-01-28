using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClassTaskLibrary;
using ClassTaskLibrary.Event;
using FlynnAssignment1.Controller;
using FlynnAssignment1.Helper;

namespace FlynnAssignment1
{
    public partial class Form1 : Form
    {
        #region Data members

        private readonly HomeworkTrackerController controller;
        private int Cs3202TabPage = 0;
        private int Engl1102TabPage = 1;
        private int Chem1212TabPage = 2;

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
            this.Text = "Homework Tracker by Kevin Flynn";
            this.controller = new HomeworkTrackerController();
            this.ClassesTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.InitializeEventHandlers();
            this.CHEM1212.Tag = Priority.Low;
            this.ENGL1102.Tag = Priority.Low;
            this.CS3202.Tag = Priority.Low;
            KeyPreview = true;
            KeyDown += this.HomeWorkTracker_KeyDown;
            this.CS3202Info.LoadTasks(this.preloadedCs3202Tasks);
            this.ENGL1102Info.LoadTasks(this.preloadedEngl1102Tasks);
            this.CHEM1212Info.LoadTasks(this.preloadedChem1212Tasks);
            this.createAllCourses();
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

        private void createAllCourses()
        {
            this.controller.CreateACourse(this.ClassesTabControl.TabPages[this.Cs3202TabPage].Text,
                this.CS3202Info.GenerateTasks());
            this.controller.CreateACourse(this.ClassesTabControl.TabPages[this.Engl1102TabPage].Text,
                this.ENGL1102Info.GenerateTasks());
            this.controller.CreateACourse(this.ClassesTabControl.TabPages[this.Chem1212TabPage].Text,
                this.CHEM1212Info.GenerateTasks());
        }

        private void coursesTabPage_DrawItem(object sender, DrawItemEventArgs e)
        {
            var page = this.ClassesTabControl.TabPages[e.Index];
            var determinedColor = this.controller.DetermineColor((Priority) page.Tag);
            e.Graphics.FillRectangle(new SolidBrush(determinedColor), e.Bounds);
            var tabBounds = e.Bounds;
            var yOffset = e.State == DrawItemState.Selected ? -2 : 1;
            tabBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, tabBounds, page.ForeColor);
        }

        private void CreateTabColor_OnChange(object sender, CourseInfoEventArgs e)
        {
            this.determineCurrentTabsPriority(e);
            this.ClassesTabControl.Invalidate(this.ClassesTabControl.GetTabRect(this.ClassesTabControl.SelectedIndex));
            this.controller.UpdateSelectedCoursesTasks(this.ClassesTabControl.SelectedTab.Text, e.Tasks, e.Priority);
            this.ClassInformation.Text = this.controller.UpdateClassesOutput();
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

        private void OpenHomeworkTrackerFile_Click(object sender, EventArgs e)
        {
            this.handleOpeningFile();
        }

        private void handleOpeningFile()
        {
            var fileSelector = new OpenFileDialog();
            var filter = "CSV file (*.csv)|*.csv";
            fileSelector.Filter = filter;
            fileSelector.FilterIndex = 1;
            fileSelector.Multiselect = false;
            var selectedOpenFile = fileSelector.ShowDialog() == DialogResult.OK;
            if (selectedOpenFile)
            {
                var fileInfo = File.ReadAllLines(fileSelector.FileName);
                this.controller.LoadCoursesFromCSVFile(fileInfo);

                this.loadNewPrioritiesFromCsvFile(this.CS3202Info, this.CS3202.Text);
                this.loadNewPrioritiesFromCsvFile(this.CHEM1212Info, this.CHEM1212.Text);
                this.loadNewPrioritiesFromCsvFile(this.ENGL1102Info, this.ENGL1102.Text);

                this.loadNewTasksFromCsvFile();

                this.ClassInformation.Text = this.controller.UpdateClassesOutput();
            }
        }

        private void loadNewPrioritiesFromCsvFile(CourseInfo currentCourseInfo, string currentCoursesTitle)
        {
            var coursesPriority = this.controller.FindMatchingCoursesPriority(currentCoursesTitle);
            if (coursesPriority == Priority.High)
            {
                currentCourseInfo.HighPriorityButtonSelected = true;
            }
            else if (coursesPriority == Priority.Medium)
            {
                currentCourseInfo.MediumPriorityButtonSelected = true;
            }
            else if (coursesPriority == Priority.Low)
            {
                currentCourseInfo.LowPriorityButtonSelected = true;
            }
        }

        private void loadNewTasksFromCsvFile()
        {
            var cs3202NewTasks = this.controller.FindMatchingCoursesTasks(this.CS3202.Text);
            var chem1212NewTasks = this.controller.FindMatchingCoursesTasks(this.CHEM1212.Text);
            var engl1102NewTasks = this.controller.FindMatchingCoursesTasks(this.ENGL1102.Text);
            this.CS3202Info.LoadTasks(cs3202NewTasks);
            this.CHEM1212Info.LoadTasks(chem1212NewTasks);
            this.ENGL1102Info.LoadTasks(engl1102NewTasks);
        }

        private void saveHomeworkTracker_Click(object sender, EventArgs e)
        {
            this.handleSavingFile();
        }

        private void handleSavingFile()
        {
            var newCsvFile = this.controller.WriteCSVFile();
            var saveFileDialog = new SaveFileDialog();
            var filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Filter = filter;

            var selectedSaveFile = saveFileDialog.ShowDialog() == DialogResult.OK;
            if (selectedSaveFile)
            {
                File.WriteAllText(saveFileDialog.FileName, newCsvFile);
            }
        }

        private void HomeWorkTracker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                this.handleOpeningFile();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.handleSavingFile();
            }
        }

        #endregion
    }
}