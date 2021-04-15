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
            ScoreGridView.DataSource = student.getStudents(command);
        }
    }
}
