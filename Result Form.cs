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
    public partial class Result_Form : Form
    {
        public Result_Form()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();

        private void Result_Form_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname  score from std", mydb.getConnection);
        }
    }
}
