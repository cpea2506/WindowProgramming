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
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        public int[] arr = new int[4];

        private void getResult()
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname from std", mydb.getConnection);
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

                    if (scoreTable.Rows.Count > 0)
                    {
                        table.Rows[i][table.Columns[j].ColumnName] = Convert.ToInt32(scoreTable.Rows[0][0]);
                    }
                }
            }

            // get result
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int sum = 0;
                for (int j = 3; j < table.Columns.Count; j++)
                {
                    if (!(table.Rows[i][j] is DBNull))
                        sum += Convert.ToInt32(table.Rows[i][j]);
                }

                float avg = (float)sum / (table.Columns.Count - 3);

                if (avg < 3)
                {
                    arr[0]++;
                }
                else if (avg >= 3 && avg < 6.5)
                {
                    arr[1]++;
                }
                else if (avg >= 6.5 && avg < 8)
                {
                    arr[2]++;
                }
                else
                {
                    arr[3]++;
                }
            }
   
            adpt = new SqlDataAdapter("SELECT COUNT(id) FROM std", mydb.getConnection);
            table = new DataTable();
            adpt.Fill(table);
            int numStudent = Int32.Parse(table.Rows[0][0].ToString());
            for(int i = 0; i < 4; i++)
            {
                arr[i] *=  100 / numStudent;
            }

            FailLabel.Text += arr[0].ToString() + "%";
            AverageLabel.Text += arr[1].ToString() + "%";
            GoodLabel.Text += arr[2].ToString() + "%";
            ExcellentLabel.Text += arr[3].ToString() + "%";

            table = new DataTable();
            table.Columns.Add("Result", typeof(System.String));
            table.Columns.Add("Value", typeof(System.Int32));
            table.Rows.Add("Excellent", arr[3]);
            table.Rows.Add("Good", arr[2]);
            table.Rows.Add("Average", arr[1]);
            table.Rows.Add("Fail", arr[0]);
            ResultChart.DataSource = table;
            ResultChart.Series["Result"].XValueMember = "Result";
            ResultChart.Series["Result"].YValueMembers = "Value";
        }
        private void StaticResult_Load(object sender, EventArgs e)
        {
            DataTable table = score.getAvgScoreByCourse();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                Label courseLabel = new Label();
                courseLabel.Text = table.Rows[i][0].ToString() + ": " +  table.Rows[i][1].ToString();
                courseLabel.Location = new Point(70, 80 + i * 50);
                courseLabel.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                courseLabel.ForeColor = Color.Yellow;
                courseLabel.AutoSize = true;
                Controls.Add(courseLabel);
            }

            getResult();
        }
    }
}
