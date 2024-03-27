using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{

    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable LoadTable(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            conn.Close();
            return data;
        }
        public bool Execute(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool ExecuteY(string sqlStr)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            bool hasMatch = reader.Read();

            reader.Close();
            conn.Close();

            return hasMatch;
        }

        public List<Dictionary<string, string>> ExecuteQuery(string sqlStr)
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sqlStr, conn))
            {
                List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, string> row = new Dictionary<string, string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string columnName = reader.GetName(i);
                            string columnValue = reader.IsDBNull(i) ? null : reader.GetValue(i).ToString();
                            row[columnName] = columnValue;
                        }

                        result.Add(row);
                    }
                }
                return result;
            }
            
        }

        public string ExecuteResult(string sqlStr)
        {
            string result = null;
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                }
            }

            conn.Close();
            return result;
        }

        public bool ExecuteNonQuery(string sqlQuery, Dictionary<string, object> parameters = null)
        {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    // Add parameters to the command if provided
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
            
        }
    }
}



