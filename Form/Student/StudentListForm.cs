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
            SqlCommand command = new SqlCommand("SELECT id,fname,lname, bdate, gender,phone,address, picture FROM std", mydb.getConnection);
            StudentGridView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            StudentGridView.RowTemplate.Height = 80;
            StudentGridView.DataSource = student.getStudents(command);
            StudentGridView.Columns[3].DefaultCellStyle.Format = "dd/mm/yyyy";
            picCol = (DataGridViewImageColumn)StudentGridView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StudentGridView.AllowUserToAddRows = false;
            StudentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataGriview1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdf = new UpdateDeleteStudentForm();
            updateDeleteStdf.IDTextBox.Text = StudentGridView.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdf.FnameTextBox.Text = StudentGridView.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdf.LNameTextBox.Text = StudentGridView.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdf.BdateBox.Value = (DateTime)StudentGridView.CurrentRow.Cells[3].Value;

            //gender
            if (StudentGridView.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateDeleteStdf.FemaleRadio.Checked = true;
            }

            updateDeleteStdf.PhoneTextBox.Text = StudentGridView.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdf.AddressTextBox.Text = StudentGridView.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])StudentGridView.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdf.StudentPictureBox.Image = Image.FromStream(picture);

            updateDeleteStdf.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            StudentListForm_Load(sender, e);
        }
    }
}
