using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        USER user = new USER();
        private void ContactForm_Load(object sender, EventArgs e)
        {
            DataTable table = user.GetUserById(GLOBAL.GlobalUserId);
            byte[] pic = (byte[])table.Rows[0]["fig"];
            MemoryStream picture = new MemoryStream(pic);
            userPicture.Image = Image.FromStream(picture);

            WelcomeLabel.Text += " " + table.Rows[0]["f_name"].ToString() + " " + table.Rows[0]["l_name"].ToString();

            GROUP group = new GROUP();
            EditGroupComboBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            EditGroupComboBox.DisplayMember = "name";
            EditGroupComboBox.ValueMember = "id";

            RemoveGroupComboBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            RemoveGroupComboBox.DisplayMember = "name";
            RemoveGroupComboBox.ValueMember = "id";
        }

        private void EditContactBtn_Click(object sender, EventArgs e)
        {
            EditContactForm ecf = new EditContactForm();
            ecf.Show();
        }

        private void EditInfoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditForm ef = new EditForm();
            ef.Show();
        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            AddContactForm acf = new AddContactForm();
            acf.Show();
        }

        private void ShowListBtn_Click(object sender, EventArgs e)
        {
            ShowFullListForm sflf = new ShowFullListForm();
            sflf.Show();
        }

        private void RemoveContactBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(RemoveContactId.Text);

            try
            {
                CONTACT contact = new CONTACT();
                if (contact.deleteContact(id))
                {
                    MessageBox.Show("Contact Removed", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception)
            {

            }
        }

        private void SelectContactBtn_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            int contactId = Convert.ToInt32(SelectContactF.ContactGridView.CurrentRow.Cells[0].Value.ToString());

            RemoveContactId.Text = contactId.ToString();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            int groupid = Convert.ToInt32(GroupIDTextBox.Text);
            string groupName = AddGroupNameTextBox.Text;
            int userid = GLOBAL.GlobalUserId;
            try
            {
                GROUP group = new GROUP();
                if(!group.groupExist(groupName, "add", userid, groupid))
                {
                    if (group.insertGroup(groupid, groupName, userid))
                    {
                        MessageBox.Show("Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("This ID Has Exist", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditGroupBtn_Click(object sender, EventArgs e)
        {
            int groupid = Convert.ToInt32(RemoveGroupComboBox.SelectedValue);
            string groupName = EditGroupNameTextBox.Text;
            try
            {
                GROUP group = new GROUP();
                if(group.updateGroup(groupid, groupName))
                {
                    MessageBox.Show("Group Name Changed", "Change Group Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Change Group Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception)
            {

            }
        }

        private void RemoveGroupBtn_Click(object sender, EventArgs e)
        {
            int groupid = Convert.ToInt32(RemoveGroupComboBox.SelectedValue);

            try
            {
                GROUP group = new GROUP();
                if(group.deleteGroup(groupid))
                {
                    MessageBox.Show("Group Removed", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GROUP group = new GROUP();
            EditGroupComboBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            EditGroupComboBox.DisplayMember = "name";
            EditGroupComboBox.ValueMember = "id";

            RemoveGroupComboBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            RemoveGroupComboBox.DisplayMember = "name";
            RemoveGroupComboBox.ValueMember = "id";
        }
    }
}