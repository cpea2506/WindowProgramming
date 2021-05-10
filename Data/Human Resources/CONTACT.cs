using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QLSV
{
    class CONTACT
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(int id, string fname, string lname, string phone, string address, string email, int userid, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO contact (id, fname, lname, group_id, phone, email, address, pic, userid) VALUES(@id, @fn, @ln, @grid, @phn, @email, @adrs, @pic, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.Text).Value = address;
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

        public bool updateContact(int contactId, string fname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE contact SET fname = @fn, lname = @ln, group_id = @grid, phone = @phn, email = @email, address = @adrs, pic = @picture WHERE id = @cid", mydb.getConnection);

            command.Parameters.Add("@cid", SqlDbType.Int).Value = contactId;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            

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

        public bool deleteContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM contact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id = @uid", mydb.getConnection);
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

        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adpt = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public DataTable GetContactById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, group_id, phone, email, address, pic, userid FROM contact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }
    }
}
