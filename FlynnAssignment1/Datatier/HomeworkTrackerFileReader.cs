using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using FlynnAssignment1.View.Helper;
using FlynnAssignment1.View.Model;

namespace FlynnAssignment1.View.Datatier
{
    public static class HomeworkTrackerFileReader
    {
        private const string Commas = ",";
        private const int priority = 1;
        private const int BeginingTask = 2;
        private const int CourseName = 0;


        /// <summary>
        ///     Reads the CSV file.
        /// </summary>
        /// <param name="inputFile">The input file.</param>
        /// <returns></returns>
        public static AllClasses ParseHomeWorkTrackerCSVFile(string[] allRows)
        {
            var newClasses = new AllClasses();
         
            foreach (var currentRow in allRows)
            {
                var currentLine = currentRow.Split(Commas.ToCharArray());

                var newCourse = BuildNewCourse(currentLine);
                newClasses.Add(newCourse);

            }
            return newClasses;
        }


        private static Course BuildNewCourse(string[] currLine)
        {
            var newCourseName = currLine[CourseName];
            var course = new Course(newCourseName);
            var newPriority = currLine[priority];
            course.Priority = BuildPriority(newPriority);
            var newTask = BuildClassesTasks(currLine);
            course.Tasks = newTask;
           
            return course;
        }

        private static IList<String> BuildClassesTasks(string[] coursesLine)
        {
            var coursesTasks = new List<String>();
            for (int i = BeginingTask; i < coursesLine.Length; i++)
            {
                if (coursesLine[i] != String.Empty)
                {
                    coursesTasks.Add(coursesLine[i]);
                }
            }

            return coursesTasks;
        }


        private static Priority BuildPriority(string priority)
        {
            Priority newPriority;
            if (priority.Equals(Priority.High.ToString()))
            {
                newPriority = Priority.High;
            }
            else if (priority.Equals(Priority.Medium.ToString()))
            {
                newPriority = Priority.Medium;
            }
            else
            {
                newPriority = Priority.Low;
            }

            return newPriority;
        }

        
    }
}
