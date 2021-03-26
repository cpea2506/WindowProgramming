using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm stf = new AddStudentForm();
            stf.Show();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stlf = new StudentListForm();
            stlf.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm uStdf = new UpdateDeleteStudentForm();
            uStdf.Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm stf = new StaticsForm();
            stf.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print prt = new Print();
            prt.Show();
        }
    }
}
