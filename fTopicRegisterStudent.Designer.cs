namespace FInalProject_Group06
{
    partial class fTopicRegisterStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            TopicName = new DataGridViewTextBoxColumn();
            TopicType = new DataGridViewTextBoxColumn();
            MaxStu = new DataGridViewTextBoxColumn();
            MinStu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 0;
            label1.Text = "Topic Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(340, 68);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Type of Project";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(464, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 68);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Lecturer";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(173, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(49, 528);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.Location = new Point(262, 528);
            button2.Name = "button2";
            button2.Size = new Size(192, 29);
            button2.TabIndex = 3;
            button2.Text = "Detail";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(473, 528);
            button3.Name = "button3";
            button3.Size = new Size(192, 29);
            button3.TabIndex = 3;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TopicName, TopicType, MaxStu, MinStu });
            dataGridView1.Location = new Point(49, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(616, 390);
            dataGridView1.TabIndex = 2;
            // 
            // TopicName
            // 
            TopicName.HeaderText = "TopicName";
            TopicName.MinimumWidth = 6;
            TopicName.Name = "TopicName";
            TopicName.Width = 125;
            // 
            // TopicType
            // 
            TopicType.HeaderText = "TopicType";
            TopicType.MinimumWidth = 6;
            TopicType.Name = "TopicType";
            TopicType.Width = 125;
            // 
            // MaxStu
            // 
            MaxStu.HeaderText = "MaxStu";
            MaxStu.MinimumWidth = 6;
            MaxStu.Name = "MaxStu";
            MaxStu.Width = 125;
            // 
            // MinStu
            // 
            MinStu.HeaderText = "MinStu";
            MinStu.MinimumWidth = 6;
            MinStu.Name = "MinStu";
            MinStu.Width = 125;
            // 
            // fTopicRegisterStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.whiteback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(714, 581);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fTopicRegisterStudent";
            Text = "fTopicRegisterStudent";
            Load += fTopicRegisterStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TopicName;
        private DataGridViewTextBoxColumn TopicType;
        private DataGridViewTextBoxColumn MaxStu;
        private DataGridViewTextBoxColumn MinStu;
    }
}