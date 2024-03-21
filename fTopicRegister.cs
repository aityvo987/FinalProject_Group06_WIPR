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
        public Account Account { get; set; }
        public Lecturer Lecturer { get; set; }
        public fTopicRegister()
        {
            InitializeComponent();
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
    }
}
