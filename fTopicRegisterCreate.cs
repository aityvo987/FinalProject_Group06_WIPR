using Microsoft.VisualBasic;
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
using System.Xml.Linq;

namespace FInalProject_Group06
{
    public partial class fTopicRegisterCreate : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public fTopicRegisterCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                TopicDAO topic = new TopicDAO();
                if (topic.AddTopic(txtNametp.Text, txtTypetp.Text, txtNameins.Text, txtDescription.Text, txtRequirements.Text, txtStudent1.Text, txtStudent2.Text))
                MessageBox.Show("Them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }*/
        }
    }
}
