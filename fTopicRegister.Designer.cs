namespace FInalProject_Group06
{
    partial class fTopicRegister
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
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            cbxType = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            txtReqRegister = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtDesRegister = new TextBox();
            txtNameTopic = new TextBox();
            tabPage2 = new TabPage();
            btnAccept = new Button();
            btnDecline = new Button();
            lblYear = new Label();
            label14 = new Label();
            lblStudent2 = new Label();
            lblStudent1 = new Label();
            lblType = new Label();
            lblNameTopic = new Label();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label10 = new Label();
            dgvTopicList1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopicList1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 62);
            label1.TabIndex = 0;
            label1.Text = "Topic Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 52);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Name Topic";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 136);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Type of Project";
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(690, 445);
            button1.Name = "button1";
            button1.Size = new Size(229, 29);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(82, 445);
            button2.Name = "button2";
            button2.Size = new Size(229, 29);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(165, 133);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(223, 28);
            cbxType.TabIndex = 13;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(38, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(977, 535);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(cbxType);
            tabPage1.Controls.Add(txtReqRegister);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtDesRegister);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(txtNameTopic);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(969, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Topic";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 296);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 2;
            label4.Text = "Requirements";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 200);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(875, 133);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(41, 28);
            comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(627, 133);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(41, 28);
            comboBox2.TabIndex = 13;
            // 
            // txtReqRegister
            // 
            txtReqRegister.Location = new Point(163, 296);
            txtReqRegister.Multiline = true;
            txtReqRegister.Name = "txtReqRegister";
            txtReqRegister.Size = new Size(754, 107);
            txtReqRegister.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(753, 136);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 4;
            label7.Text = "Max Student(s)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(505, 136);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 4;
            label6.Text = "Min Student(s)";
            // 
            // txtDesRegister
            // 
            txtDesRegister.Location = new Point(165, 200);
            txtDesRegister.Multiline = true;
            txtDesRegister.Name = "txtDesRegister";
            txtDesRegister.Size = new Size(754, 76);
            txtDesRegister.TabIndex = 7;
            // 
            // txtNameTopic
            // 
            txtNameTopic.Location = new Point(165, 52);
            txtNameTopic.Multiline = true;
            txtNameTopic.Name = "txtNameTopic";
            txtNameTopic.Size = new Size(754, 45);
            txtNameTopic.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAccept);
            tabPage2.Controls.Add(btnDecline);
            tabPage2.Controls.Add(lblYear);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(lblStudent2);
            tabPage2.Controls.Add(lblStudent1);
            tabPage2.Controls.Add(lblType);
            tabPage2.Controls.Add(lblNameTopic);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(dgvTopicList1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(969, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pending Topic";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Chartreuse;
            btnAccept.Location = new Point(847, 365);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.IndianRed;
            btnDecline.Location = new Point(604, 365);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(94, 29);
            btnDecline.TabIndex = 6;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(729, 303);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(604, 303);
            label14.Name = "label14";
            label14.Size = new Size(39, 20);
            label14.TabIndex = 5;
            label14.Text = "Year";
            // 
            // lblStudent2
            // 
            lblStudent2.AutoSize = true;
            lblStudent2.Location = new Point(729, 237);
            lblStudent2.Name = "lblStudent2";
            lblStudent2.Size = new Size(79, 20);
            lblStudent2.TabIndex = 2;
            lblStudent2.Text = "Student ID";
            // 
            // lblStudent1
            // 
            lblStudent1.AutoSize = true;
            lblStudent1.Location = new Point(729, 170);
            lblStudent1.Name = "lblStudent1";
            lblStudent1.Size = new Size(79, 20);
            lblStudent1.TabIndex = 2;
            lblStudent1.Text = "Student ID";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(729, 107);
            lblType.Name = "lblType";
            lblType.Size = new Size(56, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Mobile";
            // 
            // lblNameTopic
            // 
            lblNameTopic.AutoSize = true;
            lblNameTopic.Location = new Point(729, 48);
            lblNameTopic.Name = "lblNameTopic";
            lblNameTopic.Size = new Size(49, 20);
            lblNameTopic.TabIndex = 1;
            lblNameTopic.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(604, 237);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 2;
            label12.Text = "Student 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(604, 170);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 2;
            label8.Text = "Student 1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(604, 107);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 2;
            label11.Text = "Type of Project";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(604, 48);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 1;
            label10.Text = "Name";
            // 
            // dgvTopicList1
            // 
            dgvTopicList1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopicList1.Location = new Point(19, 21);
            dgvTopicList1.Name = "dgvTopicList1";
            dgvTopicList1.RowHeadersWidth = 51;
            dgvTopicList1.RowTemplate.Height = 29;
            dgvTopicList1.Size = new Size(555, 404);
            dgvTopicList1.TabIndex = 0;
            dgvTopicList1.CellClick += dgvTopic_CellClick;
            dgvTopicList1.CellFormatting += dgvTopic_CellFormatting;
            // 
            // fTopicRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.whiteback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 637);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "fTopicRegister";
            Text = "fTopicRegister";
            Load += fTopicRegister_load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopicList1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Button button1;
        private Button button2;
        private ComboBox cbxType;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAccept;
        private Button btnDecline;
        private Label lblYear;
        private Label label14;
        private Label lblType;
        private Label lblNameTopic;
        private Label label11;
        private Label label10;
        private DataGridView dgvTopicList1;
        private Label label4;
        private Label label2;
        private TextBox txtReqRegister;
        private TextBox txtDesRegister;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
        private Label lblStudent2;
        private Label lblStudent1;
        private Label label12;
        private Label label8;
        private TextBox txtNameTopic;
    }
}