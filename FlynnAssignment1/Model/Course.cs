using FlynnAssignment1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace FlynnAssignment1.Model
{
    /// <summary>Class for store information relating to the course
    /// </summary>
    public class Course
    {
        public string Title { get; private set; }

        public Priority  Priority { get; set; }

        public ICollection<string> Task { get; private set; }

        /// <summary>Initalizes the instances of Course </summary>
        /// <param name="title"></param>
        /// <param name="task"></param>
        public Course(string title, ICollection<string> task)
        {
            this.Title = title;
            this.Task = task;
        }
        
    }
}
