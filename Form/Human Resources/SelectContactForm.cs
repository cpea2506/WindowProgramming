using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT contact.id ,  contact.fname  as 'First Name',  contact.lname  as 'Last Name',  contact.group_id  as 'Group ID', mygroups.name as 'Group Name' FROM  contact INNER JOIN mygroups on mygroups.id = contact.group_id WHERE contact.userid  = @uid AND mygroups.userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            ContactGridView.DataSource = contact.SelectContactList(command);
            ContactGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ContactGridView_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
