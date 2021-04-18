using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();

        public bool checkCourseName(string CourseName, int CourseID = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@Name AND id <> @cID", mydb.getConnection);
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = CourseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = CourseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return (table.Rows.Count <= 0);
           
        }

        public bool insertCourse(int id, string label, int period, string des)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, period, description) VALUES(@id, @label, @period, @des)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

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

        public bool removeCourseById(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id=@id", mydb.getConnection);
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

        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        public DataTable getSpecificCourse(int cid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id = @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            SqlDataAdapter adpt = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public DataTable getCourseById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        public bool updateCourse(int id, string label, int period, string des)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET label = @label, period = @period, description = @des WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;
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

        public string totalCourse()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT COUNT(label) FROM Course", mydb.getConnection);
            adpt.Fill(table);

            return table.Rows[0][0].ToString();
        }
    }
}
