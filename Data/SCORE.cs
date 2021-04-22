using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();

        public bool studentScoreExist(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id=@sid AND course_id=@cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return (table.Rows.Count != 0);

        }

        public DataTable getAllScore()
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id, std.fname, std.lname, score.course_id, Course.label, score.student_score FROM std, Course, score WHERE score.student_id = std.id AND Course.id = score.course_id ORDER BY student_id", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public bool insertScore(int studentId, int courseId, float scoreValue , string des)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (student_id, course_id, student_score, description) VALUES(@sid, @cid, @score, @des)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@score", SqlDbType.Float).Value = scoreValue;
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

        public DataTable getAvgScoreByCourse()
        {
            SqlDataAdapter adpt  = new SqlDataAdapter("SELECT Course.label, AVG(score.student_score) as AverageGrade FROM Course, score WHERE Course.id = score.course_id GROUP BY Course.label", mydb.getConnection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool deleteScore(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE student_id = @sid AND course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
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
