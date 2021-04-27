using System;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddNewCourse : Form
    {
        public AddNewCourse()
        {
            InitializeComponent();
        }


        private void AddBtnCourse_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int id = Convert.ToInt32(CourseIdTxtb.Text);
            string label = LabelTxtb.Text;
            int period = Convert.ToInt32(PeriodTxtb.Text);
            string description = DesTxtb.Text;
            int semester = Convert.ToInt32(SemesterComboBox.SelectedItem.ToString());

            if (period < 10)
            {
                MessageBox.Show("The Period must larger than 10!", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (label.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if(course.checkCourseName(label))
            {
                if(course.insertCourse(id, label, period, description, semester))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Is Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }
    }
}
