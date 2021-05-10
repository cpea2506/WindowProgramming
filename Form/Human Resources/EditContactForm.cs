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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = Fname.Text;
            string lname = Lname.Text;
            string phone = Phone.Text;
            string address = Address.Text;
            string email = EmailTextBox.Text;

            try
            {
                int groupId = (int)GroupComboBox.SelectedValue;
                
                MemoryStream pic = new MemoryStream();
                PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                CONTACT contact = new CONTACT();
                if (contact.updateContact(id, fname, lname, phone, address, email, groupId, pic))
                {
                    MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();

            GroupComboBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            GroupComboBox.DisplayMember = "name";
            GroupComboBox.ValueMember = "id";
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();

            try
            {

                int contactId = Convert.ToInt32(SelectContactF.ContactGridView.CurrentRow.Cells[0].Value.ToString());

                CONTACT contact = new CONTACT();
                DataTable table = contact.GetContactById(contactId);

                IDTextBox.Text = table.Rows[0]["id"].ToString();
                Fname.Text = table.Rows[0]["fname"].ToString();
                Lname.Text = table.Rows[0]["lname"].ToString();
                GroupComboBox.SelectedValue = table.Rows[0]["group_id"];
                Phone.Text = table.Rows[0]["phone"].ToString();
                EmailTextBox.Text = table.Rows[0]["email"].ToString();
                Address.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxImage.Image = Image.FromStream(picture);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
