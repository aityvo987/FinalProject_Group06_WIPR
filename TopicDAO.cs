using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{
    public class TopicDAO 
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        private bool ExecuteNonQuery(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool Addtopic(string name, int major, string type, string student1, string student2, string student3, string instructor, string thesisLecturer, int semester, int year)
        {
            string sqlStr = string.Format("INSERT INTO Topic (Name, Major, Type, Student1, Student2, Student3, Instructor, ThesisLecturer, Semester, Year) VALUES ('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, {9})",
                                 name, major, type, student1, student2, student3, instructor, thesisLecturer, semester, year);

            return ExecuteNonQuery(sqlStr);
        }


        private void Topic_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Topic");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn); ;
                DataTable dtTopic = new DataTable();
                adapter.Fill(dtTopic);
                dgvTopic.DataSource = dtTopic;
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
