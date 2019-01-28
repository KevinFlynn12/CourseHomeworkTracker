using System;
using System.Collections.Generic;

namespace ClassTaskLibrary.Event
{
    /// <summary>Event used to fire of course info</summary>
    public class CourseInfoEventArgs : EventArgs
    {
        #region Properties

        public int Priority { get; set; }
        public ICollection<string> Tasks { get; set; }

        #endregion

        #region Constructors

        /// <summary>Initialize CourseInfoEventArg class</summary>
        public CourseInfoEventArgs()
        {
            this.Priority = 1;
        }

        #endregion
    }
}