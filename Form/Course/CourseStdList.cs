using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class CourseStdList : Form
    {
        public CourseStdList()
        {
            InitializeComponent();
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


    }
}
