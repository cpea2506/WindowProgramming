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
            MY_DB db = new MY_DB();
            db.openConnection();
            DataSet ds = new DataSet();
            //query count number of female and male
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT gender, COUNT(id) AS amount FROM std GROUP BY gender", db.getConnection);
            adpt.Fill(ds);
            genderChart.DataSource = ds;

            // Add value to male chart
            genderChart.Series["Gender"].XValueMember = "gender";
            genderChart.Series["Gender"].YValueMembers = "amount";


            ds = new DataSet();
            //query count total number of gender
            adpt = new SqlDataAdapter("SELECT COUNT(gender) FROM std", db.getConnection);
            adpt.Fill(ds);

            // Add value to total student label
            totalStd.Text = ds.Tables[0].Rows[0][0].ToString();
            

            db.closeConnection();
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
