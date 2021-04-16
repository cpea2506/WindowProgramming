using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        SCORE score = new SCORE();
        MY_DB mydb = new MY_DB();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            SelectCourseComboBox.DataSource = course.getAllCourse();
            SelectCourseComboBox.DisplayMember = "label";
            SelectCourseComboBox.ValueMember = "id";

            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std", mydb.getConnection);
            StudentGridView.DataSource = student.getStudents(command);
        }

        private void ScoreGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentIdTextBox.Text = StudentGridView.CurrentRow.Cells[0].Value.ToString();

        }

        private void StudentGridView_Click(object sender, EventArgs e)
        {
            StudentIdTextBox.Text = StudentGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void AddScoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(StudentIdTextBox.Text);
                int courseID = Convert.ToInt32(SelectCourseComboBox.SelectedValue);
                float scoreValue = Convert.ToInt32(ScoreTextBox.Text);
                string des = DesTextBox.Text;

                if(!score.studentScoreExist(studentID, courseID))
                {
                    if(score.insertScore(studentID, courseID, scoreValue, des))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    MessageBox.Show("The Score For This Coruse Is Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
