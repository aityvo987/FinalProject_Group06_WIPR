using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject_Group06
{
    public partial class TopicTaskStudent : Form
    {
        public Task Task { get; set; }
        public Topic Topic { get; set; }
        public TopicTaskStudent()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            if (!string.IsNullOrEmpty(Task.name))
            {
                lblTopicName.Text = Topic.name;
                lblContentTask.Text = Task.detail;
                lblDeadlineTask.Text = Task.deadLine.ToString();
                lblNameTask.Text = Task.name;
                lblStatusTask.Text = Task.status.ToString();
            }
        }
        private void fStudentTask_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
