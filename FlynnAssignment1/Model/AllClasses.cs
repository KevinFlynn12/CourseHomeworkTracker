using System.Collections;
using System.Collections.Generic;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;

namespace FlynnAssignment1.Model
{
    /// <summary>Class used to store all courses</summary>
    public class AllClasses : ICollection<Course>
    {
        #region Data members

        private readonly ICollection<Course> classes;

        #endregion

        #region Properties

        public int Count => this.classes.Count;

        public bool IsReadOnly => this.classes.IsReadOnly;

        #endregion

        #region Constructors

        public AllClasses()
        {
            this.classes = new List<Course>();
        }

        #endregion

        #region Methods

        /// <summary>adds selected item to the collection</summary>
        /// <param name="item">selected item</param>
        public void Add(Course item)
        {
            this.classes.Add(item);
        }

        /// <summary>Clears all items in collection</summary>
        public void Clear()
        {
            this.classes.Clear();
        }

        /// <summary>Checks if item is found in collection</summary>
        /// <param name="item">selected item</param>
        /// <returns>true if found false if not</returns>
        public bool Contains(Course item)
        {
            return this.classes.Contains(item);
        }

        /// <summary>takes selected array and copies it to a selected index</summary>
        /// <param name="array">selected array</param>
        /// <param name="arrayIndex">desired array index</param>
        public void CopyTo(Course[] array, int arrayIndex)
        {
            this.classes.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return this.classes.GetEnumerator();
        }

        /// <summary>Removes selected item from collection if found</summary>
        /// <param name="item">selected item</param>
        /// <returns>true if removed false if not</returns>
        public bool Remove(Course item)
        {
            return this.classes.Remove(item);
        }

        /// <summary>gets the enumerator</summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.classes.GetEnumerator();
        }

        /// <summary>Finds courses that have the selected priority</summary>
        /// <param name="priority">the selected priority</param>
        /// <returns>all classes that have the selected priority</returns>
        public ICollection<Course> FindMatchingCourses(Priority priority)
        {
            var selectedPriorityCourses = new List<Course>();
            foreach (var currentCourse in this.classes)
            {
                if (currentCourse.Priority == priority)
                {
                    selectedPriorityCourses.Add(currentCourse);
                }
            }

            return selectedPriorityCourses;
        }

        #endregion
    }
}