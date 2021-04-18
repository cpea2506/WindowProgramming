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
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(IDTextBox.Text);
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
                DataTable table = student.getStudents(command);
                if (table.Rows.Count > 0)
                {
                    FnameTextBox.Text = table.Rows[0]["fname"].ToString();
                    LNameTextBox.Text = table.Rows[0]["lname"].ToString();
                    BdateBox.Value = (DateTime)table.Rows[0]["bdate"];

                    //gender
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        FemaleRadio.Checked = true;
                    }
                    else
                    {
                        MaleRadio.Checked = true;
                    }

                    PhoneTextBox.Text = table.Rows[0]["phone"].ToString();
                    AddressTextBox.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBox.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void TextBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    PictureBox.Image = Image.FromFile(opf.FileName);
                }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(IDTextBox.Text);
                if (MessageBox.Show("Are You Sure You Want To Delete This Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IDTextBox.Text = "";
                        FnameTextBox.Text = "";
                        LNameTextBox.Text = "";
                        AddressTextBox.Text = "";
                        PhoneTextBox.Text = "";
                        BdateBox.Value = DateTime.Now;
                        PictureBox.Image = null;
                    } else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verif()
        {
            return !(IDTextBox.Text.Trim() == ""
                || LNameTextBox.Text.Trim() == ""
                || FnameTextBox.Text.Trim() == ""
                || PictureBox.Image == null);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = FnameTextBox.Text;
            string lname = LNameTextBox.Text;
            DateTime bdate = BdateBox.Value;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            string gender = "Male";

            if (FemaleRadio.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int bornYear = BdateBox.Value.Year;
            int thisYear = DateTime.Now.Year;

            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 And 100 Years", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(IDTextBox.Text);
                    PictureBox.Image.Save(pic, PictureBox.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student Information Update", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            AddStudentCourseForm ascf = new AddStudentCourseForm();
            ascf.Show();
        }
    }
}
