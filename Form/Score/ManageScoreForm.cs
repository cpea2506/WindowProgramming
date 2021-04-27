using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(StudentIdTextBox.Text);
                int courseID = Convert.ToInt32(CourseComboBox.SelectedValue);
                float scoreValue = Convert.ToInt32(ScoreTextBox.Text);
                string des = DesTextBox.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, des))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridViewByOption.DataSource = score.getAllScore();
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Coruse Is Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AvgScoreBtn_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm ascf = new AvgScoreByCourseForm();
            ascf.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int studentId = Convert.ToInt32(StudentIdTextBox.Text);
                int courseId = Convert.ToInt32(CourseComboBox.SelectedValue);


                if (MessageBox.Show("Are You Sure You Want To Delete This Score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentId, courseId))
                    {
                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridViewByOption.DataSource = score.getAllScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowStdBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std", mydb.getConnection);
            GridViewByOption.DataSource = student.getStudents(command);
            GridViewByOption.Columns["bdate"].DefaultCellStyle.Format = "dd/mm/yyyy";
            GridViewByOption.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            CourseComboBox.DataSource = course.getAllCourse();
            CourseComboBox.DisplayMember = "label";
            CourseComboBox.ValueMember = "id";
           
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std", mydb.getConnection);
            GridViewByOption.DataSource = student.getStudents(command);
            GridViewByOption.AllowUserToAddRows = false;
            GridViewByOption.ReadOnly = true;
            GridViewByOption.Columns["bdate"].DefaultCellStyle.Format = "dd/mm/yyyy";
            GridViewByOption.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowScoreBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score", mydb.getConnection);
            GridViewByOption.DataSource = score.getAllScore();
            GridViewByOption.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GridViewByOption_Click(object sender, EventArgs e)
        {
            StudentIdTextBox.Text = GridViewByOption.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
