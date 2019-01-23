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
    public enum Priority
    {
        High = 3,
        Medium = 2,
        Low = 1

    }


    public class CourseInfoEventArgs : EventArgs
    {
        public Priority Priority { get; set; }
        public ICollection<String> Tasks { get; private set; }

    }


    public partial class CourseInfo: UserControl
    {
        public event EventHandler<CourseInfoEventArgs> ChangeHasOccured;


     

        public bool HighPrioritySelected
        {
            get => this.HighPriorityButton.Checked;
            set => this.HighPriorityButton.Checked = value;
        }


        public bool MediumPrioritySelected
        {
            get => this.MediumPriorityButton.Checked;
            set => this.MediumPriorityButton.Checked = value;
        }
        public bool LowPrioritySelected
        {
            get => this.LowPriorityButton.Checked;
            set => this.LowPriorityButton.Checked = value;
        }


        public CourseInfo()
        {
            this.InitializeComponent();
            this.LowPriorityButton.Checked = true;
           
        }



        private void PriorityChanged()
        {
            var data = new CourseInfoEventArgs();

            this.ChangeHasOccured?.Invoke(this, data);



        }



        private void PriorityGroupBox_Enter(object sender, EventArgs e)
        {
            
                this.PriorityChanged();
        }

        private void CourseTasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
