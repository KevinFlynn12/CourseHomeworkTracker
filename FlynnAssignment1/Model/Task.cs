using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlynnAssignment1.Model
{
    public class Task
    {
        public string Assignment { get; set; }

        public bool Completed { get; set; }

        public Task(bool completed, string assignment)
        {
            this.Completed = completed;
            this.Assignment = assignment;
        }
    }
}
