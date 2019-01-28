using System;
using System.Collections.Generic;
using System.Drawing;
using FlynnAssignment1.DataTier;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;
using FlynnAssignment1.View.Output;

namespace FlynnAssignment1.Controller
{
    /// <summary>Class created to be controller between model method allClasses and view classes</summary>
    public class HomeworkTrackerController
    {
        private readonly AllClasses allClasses;



        /// <summary>Initializes the HomeWorkTrackerController</summary>
        public HomeworkTrackerController()
        {
            this.allClasses = new AllClasses();         
        }

        /// <summary>Creates a course for the allClasses class </summary>
        /// <param name="courseName"> The name of the course you wish to initialize</param>
        /// <param name="Task">Is the list of task you wish to add the selected Course</param>
        public void CreateACourse(String courseName, ICollection<String> Task)
        {
               var course = new Course(courseName);
               foreach (var currentTask in Task)
               {
                   if (currentTask != String.Empty)
                   {
                       course.Add(currentTask);
                   }                 
               }
               this.allClasses.Add(course);
        }

        /// <summary> Takes the file information from the selected file loads turns it
        /// into a allClasses class object and updates each corresponding course information
        /// with the loaded csv file</summary>
        /// <param name="fileInfo">the file information</param>
        public void LoadCoursesFromCSVFile(string[] fileInfo)
        {
            var newClasses = HomeworkTrackerFileReader.ParseHomeWorkTrackerCsvFile(fileInfo);
            foreach (var currentCourse in newClasses)
            {
                this.UpdateSelectedCoursesTasks(currentCourse.CourseTitle, currentCourse.Tasks, (int)currentCourse.Priority);
            }
        }


        /// <summary>Calls File writer to write a csv file on the information
        /// provided by the allClasses class</summary>
        /// <returns> a string of information about each of the courses</returns>
        public string WriteCSVFile()
        {
            return HomeworkTrackerFileWriter.WriteCsvFile(this.allClasses);
        }

        /// <summary>finds task related to course name</summary>
        /// <param name="courseName"> course name you desire to search</param>
        /// <returns>collection of task from course that matches the parameter</returns>
        public IList<String> FindMatchingCoursesTasks(string courseName)
        {
            IList<String> selectedTasks = null;
        
            foreach (Course currentCourse in this.allClasses)
            {
                if (currentCourse.CourseTitle.Equals(courseName))
                {
                    selectedTasks = currentCourse.Tasks;
                }
            }

            return selectedTasks;
        }



        /// <summary>determines color based on priority passed in</summary>
        /// <param name="selectedPriority">the priority selected</param>
        /// <returns>color that based on priority</returns>
        public Color DetermineColor(Priority selectedPriority)
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





        /// <summary>Calls output to update the its output  </summary>
        /// <returns>string of new output</returns>
        public String UpdateClassesOutput()
        {
            return HomeworkTrackerOutput.BuildCoursesHomeworkByPriority(this.allClasses);
        }

        /// <summary>updates course the matches the name by changing the priority and tasks
        /// to the parameters entered</summary>
        /// <param name="name">name used to find matching course</param>
        /// <param name="newTasks">newTask user wishes to add</param>
        /// <param name="priorityValue">Value that will be converted to a priority</param>
        public void UpdateSelectedCoursesTasks(String name, ICollection<String> newTasks, int priorityValue)
        {
            foreach (Course currentCourse in this.allClasses)
            {
                this.CheckForMatchedCourse(name, newTasks, priorityValue, currentCourse);
            }
        }

        private void CheckForMatchedCourse(string name, ICollection<string> newTasks, int priorityValue, Course currentCourse)
        {
            if (currentCourse.CourseTitle.Equals(name))
            {
                if (newTasks != null )
                {
                    currentCourse.Tasks = (IList<String>) newTasks;
                    currentCourse.Priority = PriorityConverter.ConvertValueToPriority(priorityValue);
                }
            }
        }

        /// <summary>Finds matched course based on name passed in and
        /// returns matched Courses priority</summary>
        /// <param name="selectedCourseName">name used to search all courses</param>
        /// <returns>priority of matched course</returns>
        public Priority FindMatchingCoursesPriority(string selectedCourseName)
        {
            var newPriority = new Priority();
            foreach (Course currentCourse in this.allClasses)
            {
                if (currentCourse.CourseTitle.Equals(selectedCourseName))
                {
                    newPriority = currentCourse.Priority;
                }
            }

            return newPriority;

        }



        

    }
}
