using System.Collections.Generic;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;

namespace FlynnAssignment1.DataTier
{
    /// <summary>Class created to read csv file and </summary>
    public static class HomeworkTrackerFileReader
    {
        #region Data members

        private const string Commas = ",";
        private const int Priority = 1;
        private const int BeginningTask = 2;
        private const int CourseName = 0;

        #endregion

        #region Methods

        /// <summary>Parses array of string into a AllClasses object </summary>
        /// <param name="allCsvRows">All rows of csv file</param>
        /// <returns>object of AllClasses object</returns>
        public static AllClasses ParseHomeWorkTrackerCsvFile(string[] allCsvRows)
        {
            var newClasses = new AllClasses();

            foreach (var currentRow in allCsvRows)
            {
                var currentLine = currentRow.Split(Commas.ToCharArray());

                var newCourse = buildNewCourse(currentLine);
                newClasses.Add(newCourse);
            }

            return newClasses;
        }

        private static Course buildNewCourse(string[] currentLine)
        {
            var newCourseName = currentLine[CourseName];
            var course = new Course(newCourseName);
            var newPriority = currentLine[Priority];
            course.Priority = PriorityConverter.BuildPriority(newPriority);
            var newTask = buildClassesTasks(currentLine);
            course.Tasks = newTask;

            return course;
        }

        private static IList<string> buildClassesTasks(string[] coursesLine)
        {
            var coursesTasks = new List<string>();
            for (var i = BeginningTask; i < coursesLine.Length; i++)
            {
                if (coursesLine[i] != string.Empty)
                {
                    coursesTasks.Add(coursesLine[i]);
                }
            }

            return coursesTasks;
        }

        #endregion
    }
}