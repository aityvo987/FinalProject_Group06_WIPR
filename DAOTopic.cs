using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{
    internal class DAOTopic
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection dbcon = new DBConnection();

        public DataTable LoadTopic()
        {
            string sqlStr = string.Format("SELECT *FROM Topic");
            return dbcon.LoadData(sqlStr);
        }
        public void AddTopic(string name, string type, string instructor, string description, string requirement, string student1, string student2)
        {
            try
            {
                string sqlStr = string.Format("INSERT INTO Topic(name , type ,instructor , description , requirement , student1 , student2) VALUES ('{0}', '{1}','{2}','{3}', '{4}','{5}','{6}')", name,  type,  instructor,  description,  requirement,  student1,  student2);
                dbcon.SqlExecution(sqlStr);
                MessageBox.Show("Add successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failed" + ex);
            }
        }
        public void DeleteTopic(string name)
        {
            try
            {
                string sqlStr = string.Format("DELETE FROM Topic WHERE name = '{0}'", name);
                dbcon.SqlExecution(sqlStr);
                MessageBox.Show("Delete successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed!" + ex);
            }
        }
    }
}

