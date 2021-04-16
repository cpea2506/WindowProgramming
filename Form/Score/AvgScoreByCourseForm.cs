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
    public partial class AvgScoreByCourseForm : Form
    {
        public AvgScoreByCourseForm()
        {
            InitializeComponent();
        }

        private void AvgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            SCORE score = new SCORE();
            AverageScoreGridView.ReadOnly = true;
            AverageScoreGridView.DataSource = score.getAvgScoreByCourse();
            AverageScoreGridView.AllowUserToAddRows = false;
        }
    }
}
