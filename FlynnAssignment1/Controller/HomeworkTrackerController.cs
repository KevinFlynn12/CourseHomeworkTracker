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

     

        public HomeworkTrackerController()
        {
            this.AllClasses = new AllClasses();
          
        }

        public void InitializeCourse(String courseName, ICollection<String> Task)
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

        public void LoadCoursesFromCSVFile(string[] fileInfo)
        {
            var newClasses = HomeworkTrackerFileReader.ParseHomeWorkTrackerCSVFile(fileInfo);
            foreach (var currentCourse in newClasses)
            {
                this.UpdateSelectedCoursesTasks(currentCourse.CourseTitle, currentCourse.Tasks, (int)currentCourse.Priority);
            }
        }      


        public string WriteHomeworkTracker()
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
                        currentCourse.UpdateTasks(newTasks);
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
