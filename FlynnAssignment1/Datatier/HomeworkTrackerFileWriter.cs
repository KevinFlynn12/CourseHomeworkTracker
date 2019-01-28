using System;
using FlynnAssignment1.Model;

namespace FlynnAssignment1.DataTier
{
    /// <summary>Class writes file based on the class AllClasses you based in</summary>
    public static class HomeworkTrackerFileWriter
    {
        #region Data members

        private static readonly string Comma = ",";

        #endregion

        #region Methods

        /// <summary>Writes csv file based on the AllClasses method you pass in</summary>
        /// <param name="allClasses">selected AllClasses object</param>
        /// <returns>string representation of all courses and courses information found in object passed in</returns>
        public static string WriteCsvFile(AllClasses allClasses)
        {
            var output = string.Empty;
            foreach (var currentClass in allClasses)
            {
                output += currentClass.CourseTitle + Comma;
                output += currentClass.Priority + Comma;
                output += writeCoursesTask(currentClass) + Environment.NewLine;
            }

            return output;
        }

        private static string writeCoursesTask(Course selectedCourse)
        {
            var output = string.Empty;
            foreach (var currentTask in selectedCourse)
            {
                var firstTask = 0;
                var notFirstTask = selectedCourse[firstTask] != currentTask;
                if (notFirstTask && currentTask != string.Empty)
                {
                    output += Comma;
                    output += currentTask;
                }
                else
                {
                    output += currentTask;
                }
            }

            return output;
        }

        #endregion
    }
}