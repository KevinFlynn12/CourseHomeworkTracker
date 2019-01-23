using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlynnAssignment1.Model;

namespace FlynnAssignment1.View.Output
{
    public static class PriorityOutput
    {
        private static string BorderLine = "------------------------------------------------";


        /// <summary></summary>
        /// <param name="Courses"> Collection of classes</param>
        public static string BuildPriorityOutput(ICollection<Course> Courses)
        {
            var output = buildHighPriorityOutput(Courses);
            output += buildMediumPriorityOutput(Courses);
            output += buildLowPriorityOutput(Courses);

            return output;
        }

        private static string buildHighPriorityOutput(ICollection<Course> lowPriorityClasses)
        {
            var output = "High Priority Classes" + Environment.NewLine;
            output += BorderLine + Environment.NewLine;

            return output;
        }

        private static string buildMediumPriorityOutput(ICollection<Course> lowPriorityClasses)
        {
            var output = "Medium Priority Classes" + Environment.NewLine;

            output += BorderLine + Environment.NewLine;

            return output;
        }


        private static string buildLowPriorityOutput(ICollection<Course> lowPriorityClasses)
        {
            var output = "Low Priority Classes" + Environment.NewLine;
            output += BorderLine + Environment.NewLine;

            return output;
        } 


    }
}
