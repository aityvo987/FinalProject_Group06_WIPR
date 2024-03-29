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
    public partial class fTopicRegisterCreate : Form
    {
        DAOTopic topic = new DAOTopic();
        public fTopicRegisterCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topic.AddTopic(txtName.Text,cbType.Text,cbInstructor.Text,txtDescription.Text,txtRequirement.Text,txtStudent1.Text,txtStudent2.Text);
        }
    }
}
