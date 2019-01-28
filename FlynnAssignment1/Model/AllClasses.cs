using System.Collections;
using System.Collections.Generic;
using FlynnAssignment1.Helper;
using FlynnAssignment1.Model;

namespace FlynnAssignment1.Model
{
    /// <summary>Class used to store all courses</summary>
    public class AllClasses : IList<Course>
    {
        #region Data members

        private readonly IList<Course> allClasses;

        #endregion

        #region Properties

        public int Count => this.allClasses.Count;

        public bool IsReadOnly => this.allClasses.IsReadOnly;

        public Course this[int index] { get => this.allClasses[index]; set => this.allClasses[index] = value; }

        #endregion

        #region Constructors

        /// <summary>Initializes AllClasses object</summary>
        public AllClasses()
        {
            this.allClasses = new List<Course>();
        }

        #endregion

        #region Methods

        /// <summary>adds selected item to the collection</summary>
        /// <param name="item">selected item</param>
        public void Add(Course item)
        {
            this.allClasses.Add(item);
        }

        /// <summary>Clears all items in collection</summary>
        public void Clear()
        {
            this.allClasses.Clear();
        }

        /// <summary>Checks if item is found in collection</summary>
        /// <param name="item">selected item</param>
        /// <returns>true if found false if not</returns>
        public bool Contains(Course item)
        {
            return this.allClasses.Contains(item);
        }

        /// <summary>takes selected array and copies it to a selected index</summary>
        /// <param name="array">selected array</param>
        /// <param name="arrayIndex">desired array index</param>
        public void CopyTo(Course[] array, int arrayIndex)
        {
            this.allClasses.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return this.allClasses.GetEnumerator();
        }

        /// <summary>Removes selected item from collection if found</summary>
        /// <param name="item">selected item</param>
        /// <returns>true if removed false if not</returns>
        public bool Remove(Course item)
        {
            return this.allClasses.Remove(item);
        }

        /// <summary>gets the enumerator</summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.allClasses.GetEnumerator();
        }

        /// <summary>Finds courses that have the selected priority</summary>
        /// <param name="priority">the selected priority</param>
        /// <returns>all AllClasses that have the selected priority</returns>
        public ICollection<Course> FindMatchingCourses(Priority priority)
        {
            var selectedPriorityCourses = new List<Course>();
            foreach (var currentCourse in this.allClasses)
            {
                if (currentCourse.Priority == priority)
                {
                    selectedPriorityCourses.Add(currentCourse);
                }
            }

            return selectedPriorityCourses;
        }

        /// <summary>gets index of selected item</summary>
        /// <param name="item">Selected item</param>
        /// <returns>value for the index of selected item</returns>
        public int IndexOf(Course item)
        {
            return this.allClasses.IndexOf(item);
        }

        /// <summary>Inserts value in selected index</summary>
        /// <param name="index">index selected</param>
        /// <param name="item">item you wish to insert</param>
        public void Insert(int index, Course item)
        {
            this.allClasses.Insert(index, item);
        }

        /// <summary>Removes item at selected index</summary>
        /// <param name="index">selected index you wish to remove item at</param>
        public void RemoveAt(int index)
        {
            this.allClasses.RemoveAt(index);
        }

        #endregion
    }
}