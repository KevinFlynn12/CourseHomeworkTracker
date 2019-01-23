using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTaskLibrary
{
    public class CourseInfoEvent : EventArgs
    {
        public int Priority { get; set; }
        public ICollection<String> Tasks { get; private set; }
    }


    public partial class UserControl1: UserControl
    {


        public UserControl1()
        {
            InitializeComponent();
        }

        private void PriorityGroupBox_Enter(object sender, EventArgs e)
        {
            

        }

        private void CourseTasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
