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
    public partial class fStudentTopics : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        TaskDAO taskDAO = new TaskDAO();
        Task task = new Task();
        public Student Student { get; set; }
        public Topic Topic { get; set; }
        public fStudentTopics()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            if (!string.IsNullOrEmpty(Topic.name))
            {
                lblTopicName.Text = Topic.name;
                lblInstructorName.Text = Topic.instructor;
                lblStudentId1.Text = Topic.student1;
                lblStudentId2.Text = Topic.student2;
                lblYearNum.Text = Topic.year.ToString();
            }
        }

        private void LoadForm()
        {
            try
            {
                DataTable dtTopic = taskDAO.LoadTable(Topic.id);
                dgvTask.DataSource = dtTopic;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            finally
            {
                conn.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fStudentTopics_Load(object sender, EventArgs e)
        {
            loadData();
            LoadForm();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (taskDAO.FindTask(task))
            {
                TopicTaskStudent topicTaskStudent = new TopicTaskStudent();
                topicTaskStudent.Task = task;
                topicTaskStudent.Topic = Topic;
                topicTaskStudent.Show();
            }
            else
            {
                MessageBox.Show("Invalid Topic");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTask.Rows[e.RowIndex];
                if (int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    task.id = id;
                    lblTaskNumber.Text = row.Cells[0].Value.ToString();
                    lblTaskNameE.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Something wrong happens");
                }

            }
        }
    }
}
