using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        public bool Verif()
        {
            if (IDTextBox.Text.Trim() == "" || Fname.Text.Trim() == "" || Lname.Text.Trim() == ""  || PictureBoxImage.Image == null)
            {
                return false;
            }

            return true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = Fname.Text;
            string lname = Lname.Text;
            string phone = Phone.Text;
            string address = Address.Text;
            string email = EmailTextBox.Text;
            int userid = GLOBAL.GlobalUserId;

            try
            {
                int groupId = (int)GroupComboBox.SelectedValue;
                MemoryStream pic = new MemoryStream();
                PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                CONTACT contact = new CONTACT();
                if(!contact.checkID(id))
                {
                    if(contact.insertContact(id, fname, lname, phone, address, email, userid, groupId, pic)){
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Fields Are Empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();

            GroupComboBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            GroupComboBox.DisplayMember = "name";
            GroupComboBox.ValueMember = "id";
        }
    }
}
