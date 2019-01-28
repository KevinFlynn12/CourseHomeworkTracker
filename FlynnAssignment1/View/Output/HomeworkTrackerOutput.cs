using System;
using System.Collections.Generic;
using System.Linq;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;


namespace FlynnAssignment1.View.Output
{



    /// <summary>Creates output for homeworkTracker
    /// </summary>
    public static class HomeworkTrackerOutput
    {
        private static string BorderLine = "------------------------------------------------" + Environment.NewLine;
        private const string Indent = "     ";


        /// <summary>Builds output based object classes passed in</summary>
        /// <param name="classes">All classes store in program</param>
        /// <returns>A string of all information regarding courses stored in classes object</returns>
        public static string BuildCoursesHomeworkByPriority(AllClasses classes)
        {
            var output = buildPriorityOutput(classes.FindMatchingCourses(Priority.High), "High");
            output += buildPriorityOutput(classes.FindMatchingCourses(Priority.Medium), "Medium");
            output += buildPriorityOutput(classes.FindMatchingCourses(Priority.Low), "Low");

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
