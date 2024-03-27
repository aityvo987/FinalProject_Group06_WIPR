using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FInalProject_Group06
{
    public partial class fTopicRegisterStudent : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        StudentDAO studentDAO = new StudentDAO();
        TopicDAO topicDAO = new TopicDAO();
        Topic topicNew = new Topic();
        public Account Account { get; set; }
        public Student Student { get; set; }
        public fTopicRegisterStudent()
        {
            InitializeComponent();

        }

        private void fTopicRegisterStudent_Load(object sender, EventArgs e)
        {
            LoadForm();

        }
        private void LoadForm()
        {
            try
            {
                DataTable dtTopic = topicDAO.LoadTable();
                dgvStudentTopic.DataSource = dtTopic;

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
        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void dgvTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudentTopic.Rows[e.RowIndex];
                if (int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    topicNew.id = id;
                }
                else
                {
                    MessageBox.Show("Something wrong happens");
                }

            }
        }
        private void dgvTopic_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 13) // Assuming the target column index is 12
            {
                DataGridViewRow row = dgvStudentTopic.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];

                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int value))
                {
                    if (value == 1)
                    {
                        cell.Style.BackColor = Color.Green;
                        cell.Style.ForeColor = Color.White;
                    }
                    else if (value == -1)
                    {
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.White;
                    }
                    else if (value == 0)
                    {
                        cell.Style.BackColor = Color.Orange;
                        cell.Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void dgvStudentTopic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fTopicRegisterCreate fTopicRegisterCreate = new fTopicRegisterCreate();
            fTopicRegisterCreate.Show();
            this.Close();
        }
    }
}
