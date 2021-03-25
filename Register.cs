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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        MY_DB mydb = new MY_DB();
        private bool updateRegister(string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO info(username,password) VALUES(@user, @pass)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(passwordRegisterTextBox.Text == confirmPasswordRegisterTextBox.Text)
            {
                string username = usernameRegisterTextBox.Text;
                string password = passwordRegisterTextBox.Text;
                if(updateRegister(username, password)) {
                    MessageBox.Show("Registry Completely", "Registed User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Password Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
