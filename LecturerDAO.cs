using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{
    public class Lecturer : Member
    {

    }
    public class LecturerDAO
    {
        

        DBConnection dbConn = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void CreateLecturer(Lecturer lecturer, string name, DateTime dateOfBirth, string email,
            int Phone, int CitizenId, string Address, int Major)
        {
            if (name != null)
            {
                lecturer.name = name;
                lecturer.dateOfBirth = dateOfBirth;
                lecturer.email = email;
                lecturer.phone = Phone;
                lecturer.citizenId = CitizenId;
                lecturer.address = Address;
                lecturer.major = Major;
            }
        }

        public Lecturer FindLecturer(Account account)
        {
            Lecturer lecturer = new Lecturer();
            string sqlStr = string.Format("SELECT * FROM Lecturer WHERE Id = '{0}'", account.memberId);
            conn.Open();
            SqlCommand command = new SqlCommand(sqlStr, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lecturer.id = Convert.ToInt32(reader["Id"]);
                lecturer.name = reader["Name"].ToString();
                lecturer.dateOfBirth = Convert.ToDateTime(reader["DateofBirth"]);
                lecturer.name = reader["Email"].ToString();
                lecturer.phone = Convert.ToInt32(reader["Phone"]);
                lecturer.citizenId = Convert.ToInt32(reader["CitizenId"]);
                lecturer.name = reader["Name"].ToString();
                lecturer.major = Convert.ToInt32(reader["Major"]);
                reader.Close();
                return lecturer;
            }
            reader.Close();
            return null;
        }
    }
}
