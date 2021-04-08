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
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        private void EditCourse_Load(object sender, EventArgs e)
        {
            CourseSelection.DataSource = course.getAllCourse();
            CourseSelection.DisplayMember = "label";
            CourseSelection.ValueMember = "id";
            CourseSelection.SelectedItem= null;
        }

        public void fillCombo(int index)
        {
            CourseSelection.DataSource = course.getAllCourse();
            CourseSelection.DisplayMember = "label";
            CourseSelection.ValueMember = "id";
            CourseSelection.SelectedIndex = index;
        }

        private void CourseSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(CourseSelection.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                Label.Text = table.Rows[0][1].ToString();
                Period.Value = Int32.Parse(table.Rows[0][2].ToString());
                Des.Text = table.Rows[0][3].ToString();
            } catch { }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id = (int) CourseSelection.SelectedValue;
            string label = Label.Text;
            int period = (int) Period.Value;
            string des = Des.Text;

            if(!course.checkCourseName(label, id))
            {
                MessageBox.Show("This Course Name Is Already Exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (course.updateCourse(id, label, period, des))
            {
                MessageBox.Show("Course Edited", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(CourseSelection.SelectedIndex);
            } else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
