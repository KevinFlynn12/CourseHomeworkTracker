using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FlynnAssignment1.Helper;

namespace FlynnAssignment1.Model
{
    public class Classes : ICollection<Course>
    {
        #region Data members

        private readonly ICollection<Course> classes;

        #endregion

        #region Properties

        public int Count => this.classes.Count;

        public bool IsReadOnly => this.classes.IsReadOnly;

        #endregion

        #region Constructors

        public Classes()
        {
            this.classes = new List<Course>();
        }

        #endregion

        #region Methods

        public void Add(Course item)
        {
            this.classes.Add(item);
        }

        public void Clear()
        {
            this.classes.Clear();
        }

        public bool Contains(Course item)
        {
            return this.classes.Contains(item);
        }

        public void CopyTo(Course[] array, int arrayIndex)
        {
            this.classes.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return this.classes.GetEnumerator();
        }

        public bool Remove(Course item)
        {
            return this.classes.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.classes.GetEnumerator();
        }

        public ICollection<Course> FindMatchPriorityCourses(Priority priority)
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