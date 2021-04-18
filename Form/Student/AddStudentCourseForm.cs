using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddStudentCourseForm : Form
    {
        public AddStudentCourseForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();

        void reloadListBoxData()
        {
            AvailableListBox.DataSource = course.getAllCourse();
            AvailableListBox.DisplayMember = "label";
            AvailableListBox.ValueMember = "id";
            AvailableListBox.SelectedItem = null;
        }

        private void AddStudentCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }


        private void AvailableListBox_Click(object sender, EventArgs e)
        {
            int pos = AvailableListBox.SelectedIndex;
            DataRow dr = course.getAllCourse().Rows[pos];
            AvailableListBox.SelectedIndex = pos;

            SelectedCourseListBox.Items.Clear();
            SelectedCourseListBox.Items.Add(dr.ItemArray[1].ToString()); 
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //int studentId =
        }
    }
}
