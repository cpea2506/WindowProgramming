using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std", mydb.getConnection);
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataGriview1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdf = new UpdateDeleteStudentForm();
            updateDeleteStdf.IDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdf.FnameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdf.LNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdf.BdateBox.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            //gender
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateDeleteStdf.FemaleRadio.Checked = true;
            }

            updateDeleteStdf.PhoneTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdf.AddressTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdf.PictureBox.Image = Image.FromStream(picture);

            updateDeleteStdf.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            StudentListForm_Load(sender, e);
        }
    }
}
