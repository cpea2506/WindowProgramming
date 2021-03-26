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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        private void fillChart()
        {
            STUDENT std = new STUDENT();
            MY_DB db = new MY_DB();

            db.openConnection();
            //query count number of female and male
            SqlCommand command = new SqlCommand("SELECT gender, COUNT(id) AS amount FROM std GROUP BY gender", db.getConnection);
            genderChart.DataSource = std.getStudents(command);

            // Add value to male chart
            genderChart.Series["Gender"].XValueMember = "gender";
            genderChart.Series["Gender"].YValueMembers = "amount";


            DataTable dt = new DataTable();
            //query count total number of gender
            command = new SqlCommand("SELECT COUNT(gender) FROM std", db.getConnection);
            dt = std.getStudents(command);

            // Add value to total student label
            totalStd.Text = dt.Rows[0][0].ToString();
            
            db.closeConnection();
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
