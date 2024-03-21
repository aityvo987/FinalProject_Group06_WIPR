using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FInalProject_Group06
{
    public class Member
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public int citizenId { get; set; }
        
        public string address { get; set; }
        public int major { get; set; }
        
        public bool CheckValid(string email, string soDienThoai, DateTime ngaySinh)
        {
            // Check age
            DateTime today = DateTime.Today;
            int age = today.Year - ngaySinh.Year;
            if (ngaySinh > today.AddYears(-age))
                age--;

            if (age < 17)
            {
                MessageBox.Show("Ban chua du 17 tuoi.");
                return false;
            }

            // Check phone number format
            if (!Regex.IsMatch(soDienThoai, @"^\d{3}-\d{4}-\d{3}$"))
            {
                MessageBox.Show("So dien thoai phai co dang xxx-xxxx-xxx.");
                return false;
            }

            // Check email validity
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email khong hop le.");
                return false;
            }

            return true;
        }
    }
}
