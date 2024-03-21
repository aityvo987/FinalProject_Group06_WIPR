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
    public partial class fTopicRegister : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        LecturerDAO lecturerDAO = new LecturerDAO();
        TopicDAO topicDAO = new TopicDAO();
        Topic topicNew = new Topic();
        public Account Account { get; set; }
        public Lecturer Lecturer { get; set; }
        public fTopicRegister()
        {
            InitializeComponent();
            cbxType.Items.Add("Mobile Application");
            cbxType.Items.Add("Web Application");
            cbxType.Items.Add("Winform Application");
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void fTopicRegister_load(object sender, EventArgs e)
        {
            LoadForm();

        }
        private void LoadForm()
        {
            try
            {
                DataTable dtTopic = topicDAO.LoadTable();
                dgvTopicList1.DataSource = dtTopic;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Topic topic = new Topic();
                topicDAO.CreateTopic(topic, txtNameTopic.Text, Lecturer.major, cbxType.SelectedItem.ToString(), txtDesRegister.Text, txtReqRegister.Text, null, null, null,
                    Lecturer.id.ToString(), null, 1, 2023);
                dgvTopicList1.Refresh();
                if (topicDAO.AddTopic(topic))
                    MessageBox.Show("Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add" + ex);
            }

            finally
            {
                conn.Close();
                LoadForm();
            }
        }
        private void dgvTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTopicList1.Rows[e.RowIndex];
                if (int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    topicNew.id = id;
                    lblNameTopic.Text = row.Cells[1].Value.ToString();
                    lblType.Text = row.Cells[3].Value.ToString();
                    lblYear.Text = row.Cells[12].Value.ToString();
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
                DataGridViewRow row = dgvTopicList1.Rows[e.RowIndex];
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
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (topicNew.id < 1)
                {
                    return;
                }
                if (topicNew.status == 1)
                {
                    MessageBox.Show("This topic was already approved!");
                }
                else
                {
                    if (topicDAO.ApproveTopic(topicNew))
                    {
                        dgvTopicList1.Refresh();
                        MessageBox.Show("This topic is approve successful");
                    }
                    else
                    {
                        MessageBox.Show("Failed to approve");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to approve " + ex);
            }

            finally
            {
                conn.Close();
                LoadForm();
            }

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                if (topicNew.id < 1)
                {
                    return;
                }
                if (topicNew.status == -1)
                {
                    MessageBox.Show("This topic was already disapproved!");
                }
                else
                {


                    if (topicDAO.DisapproveTopic(topicNew))
                    {
                        dgvTopicList1.Refresh();
                        MessageBox.Show("This topic is disapprove successful");
                    }
                    else
                    {
                        MessageBox.Show("Failed to disapprove");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to disapprove " + ex);
            }

            finally
            {
                conn.Close();
                LoadForm();
            }

        }
    }
}
