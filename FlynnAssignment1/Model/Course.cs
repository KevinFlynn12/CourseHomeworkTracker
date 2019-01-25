using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FlynnAssignment1.Helper;

namespace FlynnAssignment1.Model
{
    /// <summary>
    ///     Class for store information relating to the course
    /// </summary>
    public class Course : IList<String>
    {
        #region Data members

        private readonly IList<String> Tasks;

        #endregion

        #region Properties

        public string CourseTitle { get; set; }

        public Priority Priority { get; set; }

        public int Count => this.Tasks.Count;

        public bool IsReadOnly => this.Tasks.IsReadOnly;

        public String this[int index]
        {
            get => this.Tasks[index];
            set => this.Tasks[index] = value;
        }

        #endregion

        #region Constructors

        /// <summary>Initalizes the instances of Course </summary>
        /// <param name="title"></param>
        /// <param name="task"></param>
        public Course(string courseTitle)
        {
            this.Tasks = new List<String>();
            this.CourseTitle = courseTitle;
            this.Priority = Priority.Low;
        }

        public int IndexOf(string item)
        {
            return Tasks.IndexOf(item);
        }

        public void Insert(int index, string item)
        {
            Tasks.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            Tasks.RemoveAt(index);
        }

        public void Add(string item)
        {
            Tasks.Add(item);
        }

        public void Clear()
        {
            Tasks.Clear();
        }

        public bool Contains(string item)
        {
            return Tasks.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            Tasks.CopyTo(array, arrayIndex);
        }

        public bool Remove(string item)
        {
            return Tasks.Remove(item);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return Tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Tasks.GetEnumerator();
        }



        public void UpdateTasks(ICollection<String> newTasks)
        {
              this.CheckToAddNewTasks(newTasks);
              this.CheckToRemoveTasks(newTasks);
        }

        private void CheckToRemoveTasks(ICollection<string> newTasks)
        {
            for (int i = this.Tasks.Count - 1; i >= 0; i--)
            {
                var currentTask = this.Tasks[i];
                if (!newTasks.Contains(currentTask))
                {
                    this.Remove(currentTask);
                }
            }
        }

        private void CheckToAddNewTasks(ICollection<string> newTasks)
        {
            try
            {
                foreach (var currNewTask in newTasks)
                {
                    if (!this.Tasks.Contains(currNewTask))
                    {
                        this.Tasks.Add(currNewTask);
                    }
                }
            }
            catch (Exception)
            {

            }

            
        }

        #endregion

        #region Methods





        #endregion
    }
}