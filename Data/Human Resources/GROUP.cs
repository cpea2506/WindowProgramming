using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class GROUP
    {
        MY_DB mydb = new MY_DB();

        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroups (id, name, userid) VALUES (@id,@gn,@uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gname;
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

        public bool updateGroup(int id, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroups SET name = @gn WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gname;
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

        public bool deleteGroup(int gid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mygroups WHERE id = @gid", mydb.getConnection);
            command.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
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
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE userid = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = command;
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool groupExist(string name, string opera, int userid, int groupid)
        {

            SqlCommand command = new SqlCommand();

            string query;
            if(opera == "add")
            {
                query = "SELECT * FROM mygroups WHERE userid = @uid AND id = @gid";
                //command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            } else
            {
                query = "SELECT * FROM mygroups WHERE name = @name AND userid = @uid AND id <> @gid";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }

            command.Connection = mydb.getConnection;
            command.CommandText = query;

            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable table = new DataTable();

            adpt.SelectCommand = command;

            adpt.Fill(table);

            if(table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
