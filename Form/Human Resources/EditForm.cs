using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                UserPicture.BackgroundImageLayout = ImageLayout.Stretch;
                UserPicture.Image = Image.FromFile(opf.FileName);
            }
        }

        USER user = new USER();
        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userIdTextBox.Text);
            string fname = userFNameTextBox.Text;
            string lname = userLNameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string opera = "edit";
            MemoryStream pic = new MemoryStream();

            if (user.usernameExist(username, opera, id)) {
                MessageBox.Show("This Username Is Already Exist!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                UserPicture.Image.Save(pic, UserPicture.Image.RawFormat);
                if (user.updateUser(id, fname, lname, username, password, pic))
                {
                    MessageBox.Show("Edit User Successfully", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            DataTable table = user.GetUserById(GLOBAL.GlobalUserId);
            userIdTextBox.Text = table.Rows[0]["id"].ToString();
            userFNameTextBox.Text = table.Rows[0]["f_name"].ToString();
            userLNameTextBox.Text = table.Rows[0]["l_name"].ToString();
            usernameTextBox.Text = table.Rows[0]["username"].ToString();
            passwordTextBox.Text = table.Rows[0]["password"].ToString();
            byte[] pic = (byte[])table.Rows[0]["fig"];
            MemoryStream picture = new MemoryStream(pic);
            UserPicture.Image = Image.FromStream(picture);
        }
    }
}
