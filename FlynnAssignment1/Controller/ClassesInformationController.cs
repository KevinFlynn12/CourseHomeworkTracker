using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;
using FlynnAssignment1.View.Output;

namespace FlynnAssignment1.Controller
{
    public class ClassesInformationController
    {
        private AllClasses AllClasses; 

       

        public ClassesInformationController()
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

        public String UpdateClassesOutput()
        {
            return PriorityOutput.BuildPriorityOutput(this.AllClasses);
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
