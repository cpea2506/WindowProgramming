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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(ScoreGridView.CurrentRow.Cells[0].Value.ToString());
                int courseId = Convert.ToInt32(ScoreGridView.CurrentRow.Cells[3].Value.ToString());


                if (MessageBox.Show("Are You Sure You Want To Delete This Score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentId, courseId))
                    {
                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadGrid();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reloadGrid()
        {
            ScoreGridView.DataSource = score.getAllScore();
            ScoreGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            reloadGrid();
        }
    }
}
