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

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCourse csf = new AddNewCourse();
            csf.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse rmc = new RemoveCourse();
            rmc.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourse edc = new EditCourse();
            edc.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm mcf = new ManageCoursesForm();
            mcf.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm asf = new AddScoreForm();
            asf.Show();
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm asbf = new AvgScoreByCourseForm();
            asbf.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm msf = new ManageScoreForm();
            msf.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm rsf = new RemoveScoreForm();
            rsf.Show();
        }
    }
}
