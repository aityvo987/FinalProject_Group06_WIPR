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
            btnDetail = new Button();
            btnCreate = new Button();
            dgvStudentTopic = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudentTopic).BeginInit();
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
            // btnDetail
            // 
            btnDetail.BackColor = Color.Chartreuse;
            btnDetail.Location = new Point(262, 528);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(192, 29);
            btnDetail.TabIndex = 3;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Yellow;
            btnCreate.Location = new Point(473, 528);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvStudentTopic
            // 
            dgvStudentTopic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentTopic.Location = new Point(49, 114);
            dgvStudentTopic.Name = "dgvStudentTopic";
            dgvStudentTopic.RowHeadersWidth = 51;
            dgvStudentTopic.RowTemplate.Height = 29;
            dgvStudentTopic.Size = new Size(616, 390);
            dgvStudentTopic.TabIndex = 2;
            dgvStudentTopic.CellClick += dgvStudentTopic_CellContentClick;
            dgvStudentTopic.CellContentClick += dgvStudentTopic_CellContentClick;
            dgvStudentTopic.CellFormatting += dgvTopic_CellFormatting;
            // 
            // fTopicRegisterStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.whiteback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(714, 581);
            Controls.Add(btnCreate);
            Controls.Add(btnDetail);
            Controls.Add(button1);
            Controls.Add(dgvStudentTopic);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fTopicRegisterStudent";
            Text = "fTopicRegisterStudent";
            Load += fTopicRegisterStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentTopic).EndInit();
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
        private Button btnDetail;
        private Button btnCreate;
        private DataGridView dgvStudentTopic;
    }
}