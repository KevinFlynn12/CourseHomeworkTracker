using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlynnAssignment1.View.Datatier;
using FlynnAssignment1.View.Helper;
using FlynnAssignment1.View.Model;
using FlynnAssignment1.View.View.Output;

namespace FlynnAssignment1.View.Controller
{
    public class HomeworkTrackerController
    {
        private AllClasses AllClasses;



        /// <summary>Initalizes the HomeWorkTrackerController</summary>
        public HomeworkTrackerController()
        {
            this.AllClasses = new AllClasses();         
        }

        /// <summary>Creates a course for the AllClasses class </summary>
        /// <param name="courseName"> The name of the course you wish to initalize</param>
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
               this.AllClasses.Add(course);
        }

        /// <summary> Takes the file information from the selected file loads turns it
        /// into a AllClasses class object and updates each corresponding course information
        /// with the loaded csv file</summary>
        /// <param name="fileInfo">the file information</param>
        public void LoadCoursesFromCSVFile(string[] fileInfo)
        {
            var newClasses = HomeworkTrackerFileReader.ParseHomeWorkTrackerCSVFile(fileInfo);
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
            return HomeworkTrackerFileWriter.WriteCSVFile(this.AllClasses);
        }



        public String UpdateClassesOutput()
        {
            return HomeworkTrackerOutput.BuildCoursesHomeworkByPriority(this.AllClasses);
        }

        public void UpdateSelectedCoursesTasks(String name, ICollection<String> newTasks, int priority)
        {
            foreach (Course currentCourse in this.AllClasses)
            {
                if (currentCourse.CourseTitle.Equals(name))
                {
                    var newPriority = this.convertValueToPriority(priority);
                    if (newTasks != null)
                    {
                        currentCourse.Tasks = (IList<String>)newTasks;
                    }
                    currentCourse.Priority = newPriority;
                }
            }
        }

        private Priority convertValueToPriority(int priority)
        {
            Priority newPriority;
            if (priority == (int) Priority.High)
            {
                newPriority =  Priority.High;
            }
            else if (priority == (int)Priority.Medium)
            {
                newPriority =  Priority.Medium;
            }
            else
            {
                newPriority = Priority.Low;
            }

            return newPriority;
        }

    }
}
