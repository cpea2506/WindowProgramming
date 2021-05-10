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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                errorProvider1.SetError(usernameTextBox, "Invalid Username");
            }
            else
            {
                errorProvider1.SetError(usernameTextBox, null);
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                errorProvider2.SetError(passwordTextBox, "Invalid password");
            }
            else
            {
                errorProvider2.SetError(usernameTextBox, null);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            percent.Text = progressBar1.Value + "%";
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                MY_DB db = new MY_DB();

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand();
                if (StudentRadioBtn.Checked)
                {
                    command = new SqlCommand("SELECT * FROM info WHERE username = @user AND password = @pass", db.getConnection);
                } else
                {
                    command = new SqlCommand("SELECT * FROM hr WHERE username = @user AND password = @pass", db.getConnection);
                }

                command.Parameters.Add("@user", SqlDbType.VarChar).Value = usernameTextBox.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordTextBox.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {

                    int userId = Convert.ToInt32(table.Rows[0][0].ToString());
                    GLOBAL.SetGlobalUserId(userId);

                    if(StudentRadioBtn.Checked)
                    {
                        MainForm mf = new MainForm();
                        mf.Show();
                    } else
                    {
                        ContactForm cf = new ContactForm();
                        cf.Show();
                    }

                    progressBar1.Value = 0;
                    percent.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    percent.Text = "";
                    progressBar1.Value = 0;
                    percent.Text = "";
                }
            }
        }
    }
}
