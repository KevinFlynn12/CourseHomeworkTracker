using System.Collections;
using System.Collections.Generic;
using FlynnAssignment1.Helper;

namespace FlynnAssignment1.Model
{
    /// <summary>
    ///     Class for store information relating to the course
    /// </summary>
    public class Course : IList<Task>
    {
        #region Data members

        private readonly IList<Task> Tasks;

        #endregion

        #region Properties

        public string CourseTitle { get; set; }

        public Priority Priority { get; set; }

        public int Count => this.Tasks.Count;

        public bool IsReadOnly => this.Tasks.IsReadOnly;

        public Task this[int index]
        {
            get => this.Tasks[index];
            set => this.Tasks[index] = value;
        }

        #endregion

        #region Constructors

        /// <summary>Initalizes the instances of Course </summary>
        /// <param name="title"></param>
        /// <param name="task"></param>
        public Course(string courseTitle, Priority priority)
        {
            this.Tasks = new List<Task>();
            this.CourseTitle = courseTitle;
            this.Priority = priority;

        }

        #endregion

        #region Methods

        public int IndexOf(Task item)
        {
            return this.Tasks.IndexOf(item);
        }

        public void Insert(int index, Task item)
        {
            this.Tasks.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.Tasks.RemoveAt(index);
        }

        public void Add(Task item)
        {
            this.Tasks.Add(item);
        }

        public void Clear()
        {
            this.Tasks.Clear();
        }

        public bool Contains(Task item)
        {
            return this.Tasks.Contains(item);
        }

        public void CopyTo(Task[] array, int arrayIndex)
        {
            this.Tasks.CopyTo(array, arrayIndex);
        }

        public bool Remove(Task item)
        {
            return this.Tasks.Remove(item);
        }

        public IEnumerator<Task> GetEnumerator()
        {
            return this.Tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Tasks.GetEnumerator();
        }

        #endregion
    }
}