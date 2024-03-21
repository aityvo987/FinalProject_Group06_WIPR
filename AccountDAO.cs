using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{
    public class AccountDAO
    {
        DBConnection dbConn = new DBConnection();


        public void CreateAccount(Account account, string username, string password)
        {
            if (username != null)
            {
                account.username = username;
                account.password = password;
            }
        }
        public bool Login(Account account)
        {
            string sqlStr = string.Format("SELECT * FROM Account WHERE Username = '{0}' AND Password = '{1}'", account.username, account.password);
            
            return dbConn.ExecuteY(sqlStr);
        }

        public string GetAccountRole(Account account)
        {
            string sqlStr = string.Format("SELECT Role FROM Account WHERE Username = '{0}' AND Password = '{1}'", account.username, account.password);
            return dbConn.ExecuteResult(sqlStr) as string;
        }
        public string GetMemberId(Account account)
        {
            string sqlStr = string.Format("SELECT MemberId FROM Account WHERE Username = '{0}' AND Password = '{1}'", account.username, account.password);
            return dbConn.ExecuteResult(sqlStr) as string;
        }
    }

    
}
