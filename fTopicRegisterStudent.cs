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

        public fTopicRegisterStudent()
        {
            InitializeComponent();

        }

        private void fTopicRegisterStudent_Load(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
