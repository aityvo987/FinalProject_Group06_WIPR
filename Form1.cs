namespace FInalProject_Group06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            fStudentTopics f2 = new fStudentTopics();
            f2.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fTopicRegisterStudent f2 = new fTopicRegisterStudent();
            f2.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin fLogin = new fLogin();
            fLogin.Show();
        }
    }
}