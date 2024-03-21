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

        public void FindLecturer(Account account,Lecturer lecturer)
        {
            string sqlStr = string.Format("SELECT * FROM Lecturer WHERE Id = '{0}'", account.memberId);

                conn.Open();

                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lecturer.id = Convert.ToInt32(reader["Id"]);
                    lecturer.name = reader["Name"].ToString();
                }
                reader.Close();
        }
    }
}
