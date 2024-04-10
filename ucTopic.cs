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
            set { lblTopicStu1.Text = value; }
            get { return lblTopicStu1.Text; }
        }
        public string student2
        {
            set { lblTopicStu2.Text = value; }
            get { return lblTopicStu2.Text; }
        }

        public string year
        {
            set { lblTopicYear.Text = value; }
            get { return lblTopicYear.Text; }
        }
        public string tech
        {
            set { lblTopicTech.Text = value; }
            get { return lblTopicTech.Text; }
        }
    }
}
