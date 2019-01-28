using System.Collections;
using System.Collections.Generic;
using FlynnAssignment1.Helper;

namespace FlynnAssignment1.Model
{
    /// <summary>
    ///     Class for store information relating to the course
    /// </summary>
    public class Course : IList<string>
    {
        #region Properties

        public IList<string> Tasks { get; set; }
        public string CourseTitle { get; set; }

        public Priority Priority { get; set; }

        public int Count => this.Tasks.Count;

        public bool IsReadOnly => this.Tasks.IsReadOnly;

        public string this[int index]
        {
            get => this.Tasks[index];
            set => this.Tasks[index] = value;
        }

        #endregion

        #region Constructors


        /// <summary>intalizes a Course object</summary>
        /// <param name="courseTitle"> title of the course</param>
        public Course(string courseTitle)
        {
            this.Tasks = new List<string>();
            this.CourseTitle = courseTitle;
            this.Priority = Priority.Low;
        }

        #endregion

        #region Methods

        /// <summary>Gets the index of item in Course</summary>
        /// <param name="item"> Item you are searching for</param>
        public int IndexOf(string item)
        {
            return this.Tasks.IndexOf(item);
        }

        /// <summary>Inserts item into the collection</summary>
        /// <param name="index">index the item will be located</param>
        /// <param name="item"> item you wish to insert</param>
        public void Insert(int index, string item)
        {
            this.Tasks.Insert(index, item);
        }

        /// <summary>Removes the item at the index selected</summary>
        /// <param name="index">index of item</param>
        public void RemoveAt(int index)
        {
            this.Tasks.RemoveAt(index);
        }

        /// <summary>Adds item into collection</summary>
        /// <param name="item">Item you desire to add</param>
        public void Add(string item)
        {
            this.Tasks.Add(item);
        }

        /// <summary>Clears all items in collection</summary>
        public void Clear()
        {
            this.Tasks.Clear();
        }

        /// <summary>Checks if item is in the collection</summary>
        /// <param name="item">item searched</param>
        /// <returns>true if it does and false if otherwise</returns>
        public bool Contains(string item)
        {
            return this.Tasks.Contains(item);
        }

        /// <summary>Copies array to selected index</summary>
        /// <param name="array">selected array</param>
        /// <param name="arrayIndex">index of the array</param>
        public void CopyTo(string[] array, int arrayIndex)
        {
            this.Tasks.CopyTo(array, arrayIndex);
        }

        /// <summary>removes item if such item is in collection</summary>
        /// <param name="item"> selected item wished to be removed</param>
        /// <returns>true if it does and false if other wise </returns>
        public bool Remove(string item)
        {
            return this.Tasks.Remove(item);
        }

        /// <summary>Gets the Enumerator</summary>
        /// <returns>the Enumerator</returns>
        public IEnumerator<string> GetEnumerator()
        {
            return this.Tasks.GetEnumerator();
        }

        /// <summary>gets enumerator</summary>
        /// <returns> getEnumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Tasks.GetEnumerator();
        }

        #endregion
    }
}