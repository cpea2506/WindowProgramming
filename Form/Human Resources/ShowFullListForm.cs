using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ShowFullListForm : Form
    {
        public ShowFullListForm()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        private void ShowFullListForm_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            ListGridView.RowTemplate.Height = 80;
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', mygroups.name as 'Group', phone, email, address, pic FROM contact INNER JOIN mygroups ON contact.group_id = mygroups.id WHERE contact.userid = @userid", mydb.getConnection);
            command.Parameters.Add("@userid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            ListGridView.DataSource = contact.SelectContactList(command);
            ListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)ListGridView.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < ListGridView.Rows.Count; i++)
            {
                if(i % 2 != 0)
                {
                    ListGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }

            GROUP group = new GROUP();
            GroupListBox.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            GroupListBox.DisplayMember = "name";
            GroupListBox.ValueMember = "id";

            GroupListBox.SelectedItem = null;
            ListGridView.ClearSelection();
        }

        private void ListGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < ListGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    ListGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void GroupListBox_Click(object sender, EventArgs e)
        {
            try
            {
                CONTACT contact = new CONTACT();
                int groupid = (Int32)GroupListBox.SelectedValue;
                SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', mygroups.name as 'Group', phone, email, address, pic FROM contact INNER JOIN mygroups ON contact.group_id = mygroups.id WHERE contact.userid = @userid AND contact.group_id = @groupid", mydb.getConnection);
                command.Parameters.Add("@userid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
                command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;

                ListGridView.DataSource = contact.SelectContactList(command);

                for (int i = 0; i < ListGridView.Rows.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        ListGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }catch (Exception)
            {

            }

            ListGridView.ClearSelection();
        }

        private void ListGridView_Click(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.Text = ListGridView.CurrentRow.Cells[5].Value.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowFullListBtn_Click(object sender, EventArgs e)
        {
            ShowFullListForm_Load(null, null);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
