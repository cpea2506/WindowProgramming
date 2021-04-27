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
        MY_DB mydb = new MY_DB();
        void reloadListBoxData()
        {
            int semester = Convert.ToInt32(SemesterComboBox.SelectedItem.ToString());
            SqlCommand command = new SqlCommand("SELECT id, label FROM Course WHERE semester = @semes",mydb.getConnection);
            command.Parameters.Add("@semes", SqlDbType.Int).Value = semester;
            AvailableListBox.DataSource = course.getCourse(command);
            AvailableListBox.DisplayMember = "label";
            AvailableListBox.ValueMember = "id";
            AvailableListBox.SelectedItem = null;
        }

        private void AvailableListBox_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(SemesterComboBox.SelectedItem.ToString());
            int pos = AvailableListBox.SelectedIndex;
            SqlCommand command = new SqlCommand("SELECT id, label FROM Course WHERE semester = @semes", mydb.getConnection);
            command.Parameters.Add("@semes", SqlDbType.Int).Value = semester;
            DataRow dr = course.getCourse(command).Rows[pos];
            AvailableListBox.SelectedIndex = pos;

            SelectedCourseListBox.Items.Clear();
            SelectedCourseListBox.Items.Add(dr.ItemArray[1].ToString()); 
        }
        private bool addCourse(int id, string selectedCourse)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET selected_course = @scourse WHERE id = @sid", mydb.getConnection);
            command.Parameters.Add("@scourse", SqlDbType.VarChar).Value = selectedCourse;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = id;

            mydb.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(StudentID.Text);
            string selectedCourse = SelectedCourseListBox.Items[0].ToString();

            try
            {
                if(addCourse(studentId, selectedCourse))
                {
                    MessageBox.Show("Course Added", "Add Student Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error", "Add Student Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Student Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
    }
}
