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

        public String BuildClassesOutput()
        {
            return PriorityOutput.BuildPriorityOutput(this.AllClasses);
        }

        public void UpdateSelectedCoursesTasks(String name, ICollection<String> newTasks)
        {
            foreach (Course currentCourse in this.AllClasses)
            {
                if (currentCourse.CourseTitle.Equals(name))
                {
                    currentCourse.UpdateTasks(newTasks);
                }
            }
        }

        public void UpdateSelectedCoursesPriority(String courseName, Priority priority)
        {

        }

    }
}
