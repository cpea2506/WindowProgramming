using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CourseIDTxtb.Text);
            COURSE course = new COURSE();
            try
            {
                
                if (MessageBox.Show("Are You Sure You Want To Delete This Course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.removeCourseById(id))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
