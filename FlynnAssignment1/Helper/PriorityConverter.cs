using FlynnAssignment1.Helper;

namespace FlynnAssignment1.Helper
{
    /// <summary>Class created to convert data member into the proper priority enumerate type</summary>
    public static class PriorityConverter
    {
        #region Methods

        /// <summary>Takes the selected value and return a priority based on value</summary>
        /// <param name="priority">values for priority</param>
        /// <returns>matched priority</returns>
        public static Priority ConvertValueToPriority(int priority)
        {
            Priority newPriority;
            if (priority == (int) Priority.High)
            {
                newPriority = Priority.High;
            }
            else if (priority == (int) Priority.Medium)
            {
                newPriority = Priority.Medium;
            }
            else
            {
                newPriority = Priority.Low;
            }

            return newPriority;
        }

        /// <summary>Builds priority based on string passed in</summary>
        /// <param name="priority">name of priority passed in</param>
        /// <returns>Priority that matches the string passed</returns>
        public static Priority BuildPriority(string priority)
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

        #endregion
    }
}