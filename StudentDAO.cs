using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{
    public class Student : Member
    {
        public float GPAPoint { get; set; }
    }
    public class StudentDAO
    {


        DBConnection dbConn = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void CreateStudent(Student student, string name, DateTime dateOfBirth, string email,
            int Phone, int CitizenId, string Address, int Major, float GPAPoint)
        {
            if (name != null)
            {
                student.name = name;
                student.dateOfBirth = dateOfBirth;
                student.email = email;
                student.phone = Phone;
                student.citizenId = CitizenId;
                student.address = Address;
                student.major = Major;
                student.GPAPoint = GPAPoint;
            }
        }

        public Student FindStudent(Account account)
        {
            Student student = new Student();
            string sqlStr = string.Format("SELECT * FROM Student WHERE Id = '{0}'", account.memberId);
            conn.Open();
            SqlCommand command = new SqlCommand(sqlStr, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                student.id = Convert.ToInt32(reader["Id"]);
                student.name = reader["Name"].ToString();
                student.dateOfBirth = Convert.ToDateTime(reader["DateofBirth"]);
                student.name = reader["Email"].ToString();
                student.phone = Convert.ToInt32(reader["Phone"]);
                student.citizenId = Convert.ToInt32(reader["CitizenId"]);
                student.name = reader["Name"].ToString();
                student.major = Convert.ToInt32(reader["Major"]);
                reader.Close();
                return student;
            }
            reader.Close();
            return null;
        }
    }
}
