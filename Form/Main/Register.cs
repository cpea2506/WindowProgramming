using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Register : Form
    {
        USER user = new USER();
        STUDENT student = new STUDENT();
        loginForm login = new loginForm();

        public Register()
        {
            InitializeComponent();
        }



        public bool Verif()
        {
            if (IDTextBox.Text.Trim() == "" || FnameTextBox.Text.Trim() == "" || LNameTextBox.Text.Trim() == "" || usernameRegisterTextBox.Text.Trim() == ""
                || passwordRegisterTextBox.Text.Trim() == "" || pictureBoxProfileImage.Image == null) {
                return false;
            }
            
            return true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = FnameTextBox.Text;
            string lname = LNameTextBox.Text;
            string username = usernameRegisterTextBox.Text;
            string password = passwordRegisterTextBox.Text;
            string opera = "register";

            MemoryStream pic = new MemoryStream();
            if (HumanRadioBtn.Checked)
            {
                if (Verif())
                {
                    if (!user.IdExist(id))
                    {
                        if (!user.usernameExist(username, opera, id))
                        {
                            pictureBoxProfileImage.Image.Save(pic, pictureBoxProfileImage.Image.RawFormat);
                            if (user.insertUser(fname, lname, username, password, pic, id))
                            {

                                MessageBox.Show("Registrator Completed Successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Somethings Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(" This Name Have Already Exists", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("This ID Have Already Exists", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Fill All The Information!!!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (StudentRadioBtn.Checked)
            {
                if (Verif())
                {
                    if (!student.IdExist(id))
                    {
                        if (!student.usernameExist(username, opera, id))
                        {
                            pictureBoxProfileImage.Image.Save(pic, pictureBoxProfileImage.Image.RawFormat);
                            if (student.insertStudentRegister(username, password, id))
                            {
                                MessageBox.Show("Registrator Completed Successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Somethings Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(" This Name Have Already Exists", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("This ID Have Already Exists", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Fill All The Information!!!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UploadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfileImage.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBoxProfileImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
