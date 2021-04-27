using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Result_Form : Form
    {
        public Result_Form()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        private void getGridView(SqlCommand command)
        {
            DataTable table = student.getStudents(command);

            //add label
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT label FROM Course", mydb.getConnection);
            DataTable labelTable = new DataTable();
            adpt.Fill(labelTable);

            for (int i = 0; i < labelTable.Rows.Count; i++)
            {
                table.Columns.Add(labelTable.Rows[i][0].ToString(), typeof(int));
            }

            // add value to label header
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 3; j < table.Columns.Count; j++)
                {
                    command = new SqlCommand("SELECT score.student_score FROM std, score, Course WHERE Course.label = @label AND Course.id = score.course_id AND score.student_id = @sid", mydb.getConnection);
                    command.Parameters.Add("@label", SqlDbType.VarChar).Value = table.Columns[j].ColumnName;
                    command.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[i][0]);
                    adpt = new SqlDataAdapter(command);
                    DataTable scoreTable = new DataTable();
                    adpt.Fill(scoreTable);

                    if(scoreTable.Rows.Count > 0)
                    {
                        table.Rows[i][table.Columns[j].ColumnName] = Convert.ToInt32(scoreTable.Rows[0][0]);
                    }
                }
            }

            // add result
            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int sum = 0;
                for (int j = 3; j < table.Columns.Count - 1; j++)
                {
                    if (!(table.Rows[i][j] is DBNull))
                        sum += Convert.ToInt32(table.Rows[i][j]);
                }

                float avg = (float)sum / (table.Columns.Count - 4);

                if (avg < 3)
                {
                    table.Rows[i][table.Columns.Count - 1] = "Fail";
                }
                else if (avg >= 3 && avg < 6.5)
                {
                    table.Rows[i][table.Columns.Count - 1] = "Average";
                }
                else if (avg >= 6.5 && avg < 8)
                {
                    table.Rows[i][table.Columns.Count - 1] = "Good";
                }
                else
                {
                    table.Rows[i][table.Columns.Count - 1] = "Excellent";
                }
            }

            AvgGridView.DataSource = table;
            AvgGridView.Columns["id"].HeaderText = "Student ID";
            AvgGridView.Columns["fname"].HeaderText = "First Name";
            AvgGridView.Columns["lname"].HeaderText = "Last Name";
            AvgGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Result_Form_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std", mydb.getConnection);
            getGridView(command);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDialog prdi = new PrintDialog();
            PrintDocument prdo = new PrintDocument();
            prdo.DocumentName = "Print Document";
            prdi.Document = prdo;
            prdi.AllowSelection = true;
            prdi.AllowSomePages = true;
            if (prdi.ShowDialog() == DialogResult.OK)
            {
                prdo.Print();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(SearchIDTextBox.Text);
                SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std WHERE id = @sid", mydb.getConnection);
                command.Parameters.Add("@sid", SqlDbType.Int).Value = id;
                getGridView(command);

                DataTable table = student.getStudents(command);
                if (table.Rows.Count > 0)
                {
                    StudentIDTextBox.Text = table.Rows[0]["id"].ToString();
                    FNameTextBox.Text = table.Rows[0]["fname"].ToString();
                    LNameTextBox.Text = table.Rows[0]["lname"].ToString();
                }
                else
                {
                    MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std", mydb.getConnection);
            getGridView(command);
        }
    }
}
