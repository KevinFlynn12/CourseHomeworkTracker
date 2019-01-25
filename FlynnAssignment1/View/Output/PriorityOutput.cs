using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;
using Microsoft.SqlServer.Server;
using Task = System.Threading.Tasks.Task;

namespace FlynnAssignment1.View.Output
{
    public static class PriorityOutput
    {
        private static string BorderLine = "------------------------------------------------" + Environment.NewLine;
        private static string Indent = "     ";

        /// <summary></summary>
        /// <param name="Courses"> Collection of classes</param>
        public static string BuildPriorityOutput(AllClasses Classes)
        {
            var output = buildPriorityOutput(Classes.FindMatchingCourses(Priority.High), "High") + Environment.NewLine;
            output += buildPriorityOutput(Classes.FindMatchingCourses(Priority.Medium), "Medium") + Environment.NewLine;
            output += buildPriorityOutput(Classes.FindMatchingCourses(Priority.Low), "Low") + Environment.NewLine;

            return output;
        }

       

        private static string buildPriorityOutput(ICollection<Course> selectedPriorityClasses, string prioritySelected)
        {
            var output = prioritySelected + "Priority Classes" + Environment.NewLine;
            output += BorderLine;
            try
            {
                foreach (var currentClass in selectedPriorityClasses)
                {
                    output += currentClass.CourseTitle + ":" + Environment.NewLine;
                    output +=  buildTaskOutput(currentClass);

                }
            }
            catch (Exception)
            {

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
