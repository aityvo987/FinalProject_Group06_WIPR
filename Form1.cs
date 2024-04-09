namespace FInalProject_Group06
{
    public partial class Form1 : Form
    {
        TopicDAO topicDAO = new TopicDAO();
        Topic topic = new Topic();
        public Account Account { get; set; }
        public Lecturer Lecturer { get; set; }
        public Student  Student { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private bool findStudentTopic()
        {
            if (Account.role == "1")
            {
                if (topicDAO.FindTopicOnStudent(topic, Student.citizenId))
                {
                    btnManage.Enabled = true;
                    btnRegister.Enabled = false;
                    return true;
                }
                else
                {
                    btnManage.Enabled = false;
                    btnRegister.Enabled = true;
                    return false;
                }

            }
            return true;


        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            bool re = findStudentTopic();
            if (!re)
            {
                MessageBox.Show("You have not registered a topic");
                return;
            }
            if (Account.role == "1")
            {
                fStudentTopics f2 = new fStudentTopics();
                f2.Student = Student;
                f2.Topic = topic;
                f2.Show();
            }
            else { 
                fLecturerTopics f2 = new fLecturerTopics();
                f2.Show();
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool re = findStudentTopic();
            
            if (Account.role == "1")
            {
                if (re)
                {
                    MessageBox.Show("You have already registered a topic");
                    return;
                }
                fTopicRegisterStudent f3 = new fTopicRegisterStudent();
                f3.Account = Account;
                f3.Student = Student;
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