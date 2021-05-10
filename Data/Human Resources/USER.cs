using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class USER
    {
        MY_DB mydb = new MY_DB();
        public DataTable GetUserById(Int32 UserId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = UserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //function to insert a new user
        public bool insertUser(string fname, string lname, string username, string password, MemoryStream picture, int userId)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hr (f_name,l_name,username,password,fig,id) VALUES (@fn,@ln,@un,@pass,@pic,@uid)", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM hr WHERE username = @un";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM hr WHERE username = @un AND id <> @uid";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IdExist(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool updateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE hr SET id =@uid, f_name = @fn, l_name = @ln, username = @un, password = @pass, fig = @pic WHERE id =@uid", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;


            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
