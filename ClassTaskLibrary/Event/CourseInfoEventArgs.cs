using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskLibrary.Event
{
    public class CourseInfoEventArgs : EventArgs
    {
        public int Priority { get; set; }
        public ICollection<String> Tasks { get; set; }

        public CourseInfoEventArgs()
        {
            this.Priority = 1;
        }

    }
}
