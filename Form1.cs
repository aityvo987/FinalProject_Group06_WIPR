namespace FInalProject_Group06
{
    public partial class Form1 : Form
    {
        public Account Account { get; set; }
        public Lecturer Lecturer { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (Account.role == "1")
            {
                fStudentTopics f2 = new fStudentTopics();
                f2.Show();
            }
            else { 
                fLecturerTopics f2 = new fLecturerTopics();
                f2.Show();
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Account.role == "1")
            {
                fTopicRegisterStudent f3 = new fTopicRegisterStudent();
                f3.Show();
            }
            else
            {
                fTopicRegister f3 = new fTopicRegister();
                f3.Account = Account;
                f3.Lecturer = Lecturer;
                f3.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin fLogin = new fLogin();
            fLogin.Show();
            this.Close();
        }
    }
}