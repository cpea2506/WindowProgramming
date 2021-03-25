using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool verif()
        {
            return !(StudentID.Text.Trim() == ""
                || Lname.Text.Trim() == ""
                || Fname.Text.Trim() == ""
                || PictureBoxStudentImage.Image == null);
        }

        private void UploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(StudentID.Text);
            string fname = Fname.Text;
            string lname = Lname.Text;
            DateTime bdate = Bdate.Value;
            string phone = Phone.Text;
            string address = Address.Text;
            string gender = "Male";

            if(Male.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int bornYear = Bdate.Value.Year;
            int thisYear = DateTime.Now.Year;

            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 And 100 Years", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (verif())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if(student.insertStudent(id,fname,lname,bdate,gender,phone,address,pic))
                {
                    MessageBox.Show("New Student Add", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
