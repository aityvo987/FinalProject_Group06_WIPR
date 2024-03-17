namespace FInalProject_Group06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnManage = new Button();
            btnRegister = new Button();
            btnLogout = new Button();
            Home = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbContent = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            lbPhone = new Label();
            lbEmail = new Label();
            label17 = new Label();
            lbMajor = new Label();
            label16 = new Label();
            lbPosition = new Label();
            label15 = new Label();
            lbName = new Label();
            label14 = new Label();
            label13 = new Label();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            button1 = new Button();
            lbYear = new Label();
            label11 = new Label();
            lbLecturer = new Label();
            lbStu2 = new Label();
            lbStu1 = new Label();
            lbTopic = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // btnManage
            // 
            btnManage.Location = new Point(29, 391);
            btnManage.Margin = new Padding(3, 2, 3, 2);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(169, 34);
            btnManage.TabIndex = 0;
            btnManage.Text = "Manage Topic";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(396, 391);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(171, 34);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register Topic";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(772, 391);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(127, 34);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.BackColor = Color.Transparent;
            Home.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Home.ForeColor = SystemColors.ControlText;
            Home.Location = new Point(396, 9);
            Home.Name = "Home";
            Home.Size = new Size(147, 55);
            Home.TabIndex = 4;
            Home.Text = "Home";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(25, 58);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(910, 328);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(lbContent);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(902, 300);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Announcements";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(111, 250);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 1;
            lbContent.Text = "Content";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 23);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(836, 196);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(lbPhone);
            tabPage2.Controls.Add(lbEmail);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(lbMajor);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(lbPosition);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(lbName);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(902, 300);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lecturers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(707, 218);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(41, 15);
            lbPhone.TabIndex = 5;
            lbPhone.Text = "Phone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(707, 175);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(589, 218);
            label17.Name = "label17";
            label17.Size = new Size(42, 15);
            label17.TabIndex = 5;
            label17.Text = "Phone";
            // 
            // lbMajor
            // 
            lbMajor.AutoSize = true;
            lbMajor.Location = new Point(707, 133);
            lbMajor.Name = "lbMajor";
            lbMajor.Size = new Size(38, 15);
            lbMajor.TabIndex = 3;
            lbMajor.Text = "Major";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(589, 175);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 4;
            label16.Text = "Email";
            // 
            // lbPosition
            // 
            lbPosition.AutoSize = true;
            lbPosition.Location = new Point(707, 91);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(50, 15);
            lbPosition.TabIndex = 2;
            lbPosition.Text = "Position";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(589, 133);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 3;
            label15.Text = "Major";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(707, 47);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(589, 91);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 2;
            label14.Text = "Position";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(589, 47);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 1;
            label13.Text = "Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 35);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(496, 214);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImageLayout = ImageLayout.None;
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(lbYear);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(lbLecturer);
            tabPage3.Controls.Add(lbStu2);
            tabPage3.Controls.Add(lbStu1);
            tabPage3.Controls.Add(lbTopic);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(902, 300);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sample Topics";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(343, 254);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(259, 27);
            button1.TabIndex = 13;
            button1.Text = "Download Topic";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(708, 210);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(60, 15);
            lbYear.TabIndex = 12;
            lbYear.Text = "2023-2024";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(708, 170);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 11;
            label11.Text = "Major";
            // 
            // lbLecturer
            // 
            lbLecturer.AutoSize = true;
            lbLecturer.Location = new Point(708, 133);
            lbLecturer.Name = "lbLecturer";
            lbLecturer.Size = new Size(85, 15);
            lbLecturer.TabIndex = 10;
            lbLecturer.Text = "Lecturer Name";
            // 
            // lbStu2
            // 
            lbStu2.AutoSize = true;
            lbStu2.Location = new Point(708, 95);
            lbStu2.Name = "lbStu2";
            lbStu2.Size = new Size(83, 15);
            lbStu2.TabIndex = 9;
            lbStu2.Text = "Student Name";
            // 
            // lbStu1
            // 
            lbStu1.AutoSize = true;
            lbStu1.Location = new Point(708, 58);
            lbStu1.Name = "lbStu1";
            lbStu1.Size = new Size(83, 15);
            lbStu1.TabIndex = 8;
            lbStu1.Text = "Student Name";
            // 
            // lbTopic
            // 
            lbTopic.AutoSize = true;
            lbTopic.Location = new Point(708, 25);
            lbTopic.Name = "lbTopic";
            lbTopic.Size = new Size(70, 15);
            lbTopic.TabIndex = 7;
            lbTopic.Text = "Topic Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(584, 210);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(584, 170);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "Major";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(584, 133);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Lecturer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(584, 95);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Student 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(584, 58);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Student 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(584, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(15, 14);
            dataGridView3.Margin = new Padding(3, 2, 3, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(497, 220);
            dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(946, 465);
            Controls.Add(tabControl1);
            Controls.Add(Home);
            Controls.Add(btnLogout);
            Controls.Add(btnRegister);
            Controls.Add(btnManage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManage;
        private Button btnRegister;
        private Button btnLogout;
        private Label Home;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private Label lbPhone;
        private Label lbEmail;
        private Label label17;
        private Label lbMajor;
        private Label label16;
        private Label lbPosition;
        private Label label15;
        private Label lbName;
        private Label label14;
        private Label label13;
        private DataGridView dataGridView2;
        private Button button1;
        private Label lbYear;
        private Label label11;
        private Label lbLecturer;
        private Label lbStu2;
        private Label lbStu1;
        private Label lbTopic;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView3;
        private Label lbContent;
    }
}