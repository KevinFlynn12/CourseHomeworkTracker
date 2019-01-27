using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FlynnAssignment1.View.Controller;
using FlynnAssignment1.View.Helper;
using FlynnAssignment1.View.Model;

namespace FlynnAssignment1.View.Datatier
{
    public static class HomeworkTrackerFileWriter
    {
        private static string Comma = ",";

    
        public static string WriteCSVFile(AllClasses allClasses)
        {
            var output = String.Empty;
            foreach (var currentClass in allClasses)
            {
                output += currentClass.CourseTitle + Comma;
                output += currentClass.Priority + Comma;
                output += writeCoursesTask(currentClass) + Environment.NewLine;
            }
            return output;
        }



        private static String writeCoursesTask(Course selectedCourse)
        {
            var output = string.Empty;
            foreach (var currentTask in selectedCourse)
            {
                var firstTask = 0;
                var notFirstTask = selectedCourse[firstTask] != currentTask;
                if (notFirstTask)
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




        


        private sealed class ExtendedStringWriter : StringWriter
        {
            #region Properties

            public override Encoding Encoding { get; }

            #endregion

            #region Constructors

            public ExtendedStringWriter(StringBuilder builder, Encoding desiredEncoding)
                : base(builder)
            {
                this.Encoding = desiredEncoding;
            }

            #endregion
        }
    }

}
