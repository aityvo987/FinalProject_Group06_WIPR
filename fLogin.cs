using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject_Group06
{
    public partial class fLogin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        LecturerDAO lecturerDAO = new LecturerDAO();
        StudentDAO studentDAO = new StudentDAO();
        AccountDAO accountDAO = new AccountDAO();
        Account account = new Account();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            accountDAO.CreateAccount(account, txtUser.Text, txtPass.Text);
            try
            {
                if (accountDAO.Login(account))
                {

                    account.role = accountDAO.GetAccountRole(account);
                    account.memberId = accountDAO.GetMemberId(account);
                    if (account.role == "2")
                    {
                        Lecturer lecturer = lecturerDAO.FindLecturer(account);
                        Form1 f1 = new Form1();
                        f1.Account = account;
                        f1.Lecturer = lecturer;
                        f1.Show();
                    }
                    else if (account.role=="1")
                    {
                        Student student = studentDAO.FindStudent(account);
                        Form1 f1 = new Form1();
                        f1.Account = account;
                        f1.Student = student;
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong roles"+ account.role);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Wrong credentials");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua that bai" + ex);
            }
            
        }
    }
}
