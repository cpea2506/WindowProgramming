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
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std", mydb.getConnection);
            StudentGridView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            StudentGridView.RowTemplate.Height = 80;
            StudentGridView.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)StudentGridView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StudentGridView.AllowUserToAddRows = false;
        }

        bool verif()
        {
            return !(StudentID.Text.Trim() == ""
                || Lname.Text.Trim() == ""
                || Fname.Text.Trim() == ""
                || PictureBoxStudentImage.Image == null);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(StudentID.Text);
            string fname = Fname.Text;
            string lname = Lname.Text;
            DateTime bdate = Bdate.Value;
            string phone = Phone.Text;
            string address = Address.Text;
            string gender = "Female";

            if (Male.Checked)
            {
                gender = "Male";
            }

            MemoryStream pic = new MemoryStream();

            int bornYear = Bdate.Value.Year;
            int thisYear = DateTime.Now.Year;

            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 And 100 Years", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (verif())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic))
                {
                    MessageBox.Show("New Student Add", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id;
            string fname = Fname.Text;
            string lname = Lname.Text;
            DateTime bdate = Bdate.Value;
            string phone = Phone.Text;
            string address = Address.Text;
            string gender = "Male";

            if (Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int bornYear = Bdate.Value.Year;
            int thisYear = DateTime.Now.Year;

            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 And 100 Years", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(StudentID.Text);
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student Information Update", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ManageStudentForm_Load(sender, e);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(StudentID.Text);
                if (MessageBox.Show("Are You Sure You Want To Delete This Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentID.Text = "";
                        Fname.Text = "";
                        Lname.Text = "";
                        Address.Text = "";
                        Phone.Text = "";
                        Bdate.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentGridView_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrv = StudentGridView.CurrentRow;
            StudentID.Text = dgrv.Cells[0].Value.ToString();
            Fname.Text = dgrv.Cells[1].Value.ToString();
            Lname.Text = dgrv.Cells[2].Value.ToString();
            Bdate.Value = (DateTime)dgrv.Cells[3].Value;

            if(dgrv.Cells[4].Value.ToString() == "Female")
            {
                Female.Checked = true;
            } else
            {
                Male.Checked = true;
            }
            

            Phone.Text = dgrv.Cells[5].Value.ToString();
            Address.Text = dgrv.Cells[6].Value.ToString();
            byte[] pic = (byte[])dgrv.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage.Image = Image.FromStream(picture);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(SearchTextBox.Text);
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = @sid", mydb.getConnection);
                command.Parameters.Add("@sid", SqlDbType.Int).Value = id;
                StudentGridView.DataSource = student.getStudents(command);

                DataTable table = student.getStudents(command);
                if (table.Rows.Count > 0)
                {
                    StudentID.Text = table.Rows[0]["id"].ToString();
                    Fname.Text = table.Rows[0]["fname"].ToString();
                    Lname.Text = table.Rows[0]["lname"].ToString();
                    Bdate.Value = (DateTime)table.Rows[0]["bdate"];

                    //gender
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        Female.Checked = true;
                    }
                    else
                    {
                        Male.Checked = true;
                    }

                    Phone.Text = table.Rows[0]["phone"].ToString();
                    Address.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Select Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
            DataGridViewRow dgrv = StudentGridView.CurrentRow;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = "Image Downloaded";
                byte[] pic = (byte[])dgrv.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                Image img = Image.FromStream(picture);
                img.Save(fileName);
            }
        }
    }
}
