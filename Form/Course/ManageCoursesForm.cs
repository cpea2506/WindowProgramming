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
    public partial class ManageCoursesForm : Form
    {
        COURSE course = new COURSE();
        int pos;
        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        void reloadListBoxData()
        {
            CourseListBox.DataSource = course.getAllCourse();
            CourseListBox.DisplayMember = "label";
            CourseListBox.ValueMember = "id";
            CourseListBox.SelectedItem = null;

            TotalCourseLabel.Text = "Total Courses: " + course.totalCourse();
        }

        void showData(int pos)
        {
            DataRow dr = course.getAllCourse().Rows[pos];
            CourseListBox.SelectedIndex = pos;
            IDTextBox.Text = dr.ItemArray[0].ToString();
            LabelTextBox.Text = dr.ItemArray[1].ToString();
            HoursNumberNumeric.Value = Int32.Parse(dr.ItemArray[2].ToString());
            DesTextBox.Text = dr.ItemArray[3].ToString();
        }

        private void CourseListBox_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)CourseListBox.SelectedItem;
            pos = CourseListBox.SelectedIndex;
            showData(pos);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string label = LabelTextBox.Text;
            int hrs = (int)HoursNumberNumeric.Value;
            string des = DesTextBox.Text;


            if (label.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(label))
            {
                if (course.insertCourse(id, label, hrs, des))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Is Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string label = LabelTextBox.Text;
            int hrs = (int)HoursNumberNumeric.Value;
            string des = DesTextBox.Text;

            if (!course.checkCourseName(label, id))
            {
                MessageBox.Show("This Course Name Is Already Exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, label, hrs, des))
            {
                MessageBox.Show("Course Edited", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IDTextBox.Text);

                if (MessageBox.Show("Are You Sure You Want To Delete This Course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.removeCourseById(id))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IDTextBox.Text = "";
                        LabelTextBox.Text = "";
                        HoursNumberNumeric.Value = 10;
                        DesTextBox.Text = "";
                        reloadListBoxData();
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

            pos = 0;
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if(pos < (course.getAllCourse().Rows.Count - 1)) {
                pos++;
                showData(pos);
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if(pos > 0)
            {
                pos--;
                showData(pos);
            }
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
        }
    }


}
