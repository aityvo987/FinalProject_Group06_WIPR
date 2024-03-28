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
    public partial class fTopicRegisterGet : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TopicDAO topicDAO = new TopicDAO();
        public Topic Topic { get; set; }
        public fTopicRegisterGet()
        {
            InitializeComponent();
        }

        private void fTopicRegisterGet_Load(object sender, EventArgs e)
        {
            GetTopic();

        }

        private void GetTopic()
        {
            if (!string.IsNullOrEmpty(Topic.name))
            {
                lblTopicName.Text = Topic.name;
                lblDescription.Text = Topic.description;
                lblRequirement.Text = Topic.requirement;
                lblInstructorName.Text = Topic.instructor;
                txtStudent1.Text = Topic.student1;
                if (!string.IsNullOrEmpty(Topic.student1))
                {
                    txtStudent1.Enabled = false;
                }
                else
                {
                    txtStudent1.Enabled = true;
                }
                txtStudent2.Text = Topic.student2;
                if (!string.IsNullOrEmpty(Topic.student2))
                {
                    txtStudent2.Enabled = false;
                }
                else
                {
                    txtStudent2.Enabled = true;
                }
                lblTopicType.Text = Topic.type;

            }
            else
            {
                MessageBox.Show("No topic Found " + Topic.id.ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Topic.student1 = txtStudent1.Text;
            Topic.student2 = txtStudent2.Text;

            if (!string.IsNullOrEmpty(Topic.student1)|| !string.IsNullOrEmpty(Topic.student2))
            {
                if(topicDAO.AddStudentTopic(Topic)){
                    MessageBox.Show("Register successfully");
                    GetTopic();
                }
                else
                {
                    MessageBox.Show("Register unsuccessfully");
                }

            }
        }
    }
}
