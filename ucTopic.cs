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
    public partial class ucTopic : UserControl
    {
        public ucTopic()
        {
            InitializeComponent();
        }
        public string topicName
        {
            set { lblTopicName.Text = value; }
            get { return lblTopicName.Text; }
        }
        public string student1
        {
            set { lblStudent1.Text = value; }
            get { return lblStudent1.Text; }
        }
        public string student2
        {
            set { lblStudent2.Text = value; }
            get { return lblStudent2.Text; }
        }

        public string year
        {
            set { lblYear.Text = value; }
            get { return lblYear.Text; }
        }
    }
}
