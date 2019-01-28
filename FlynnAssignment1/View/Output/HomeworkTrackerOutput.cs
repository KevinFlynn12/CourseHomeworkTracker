using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using FlynnAssignment1.View.Helper;
using FlynnAssignment1.View.Model;
using Microsoft.SqlServer.Server;
using Task = System.Threading.Tasks.Task;

namespace FlynnAssignment1.View.View.Output
{
    public static class HomeworkTrackerOutput
    {
        private static string BorderLine = "------------------------------------------------" + Environment.NewLine;
        private static readonly string Indent = "     ";

        /// <summary>Builds the output for the allClasses method ranked by priority</summary>
        /// <param name="Courses"> Collection of classes</param>
        /// <returns>A string of all Courses tasks ranked by priority</returns>
        public static string BuildCoursesHomeworkByPriority(AllClasses Classes)
        {
            var output = buildPriorityOutput(Classes.FindMatchingCourses(Priority.High), "High");
            output += buildPriorityOutput(Classes.FindMatchingCourses(Priority.Medium), "Medium");
            output += buildPriorityOutput(Classes.FindMatchingCourses(Priority.Low), "Low");

            return output;
        }

       

        private static string buildPriorityOutput(ICollection<Course> selectedPriorityClasses, string prioritySelected)
        {
            if (!selectedPriorityClasses.Any())
            {
                return string.Empty;
            }


            var output = prioritySelected + "Priority Class(es)" + Environment.NewLine;
            output += BorderLine;
            try
            {
                foreach (var currentClass in selectedPriorityClasses)
                {
                    output += currentClass.CourseTitle + ":" + Environment.NewLine;
                    output +=  buildTaskOutput(currentClass);
                    output += Environment.NewLine;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           return output;
        }


        private static string buildTaskOutput(IEnumerable<String> tasks)
        {
            var output = "";
            foreach (var currentTask in tasks)
            {
                output += Indent + currentTask + Environment.NewLine;
            }

            return output;
        }

    }
}
