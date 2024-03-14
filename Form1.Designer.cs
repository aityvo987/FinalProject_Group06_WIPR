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
            btnManage = new Button();
            btnRegister = new Button();
            btnLogout = new Button();
            Home = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label23 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            label22 = new Label();
            label21 = new Label();
            label17 = new Label();
            label20 = new Label();
            label16 = new Label();
            label19 = new Label();
            label15 = new Label();
            label18 = new Label();
            label14 = new Label();
            label13 = new Label();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
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
            btnManage.Location = new Point(54, 521);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(296, 46);
            btnManage.TabIndex = 0;
            btnManage.Text = "Manage Topic";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(425, 521);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(296, 46);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register Topic";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(769, 521);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(296, 46);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Home.Location = new Point(506, 33);
            Home.Name = "Home";
            Home.Size = new Size(75, 30);
            Home.TabIndex = 4;
            Home.Text = "Home";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(29, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1040, 438);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1032, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Announcements";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(127, 333);
            label23.Name = "label23";
            label23.Size = new Size(61, 20);
            label23.TabIndex = 1;
            label23.Text = "Content";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(956, 261);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1032, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lecturers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(808, 290);
            label22.Name = "label22";
            label22.Size = new Size(50, 20);
            label22.TabIndex = 5;
            label22.Text = "Phone";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(808, 233);
            label21.Name = "label21";
            label21.Size = new Size(46, 20);
            label21.TabIndex = 4;
            label21.Text = "Email";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(673, 290);
            label17.Name = "label17";
            label17.Size = new Size(53, 20);
            label17.TabIndex = 5;
            label17.Text = "Phone";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(808, 177);
            label20.Name = "label20";
            label20.Size = new Size(48, 20);
            label20.TabIndex = 3;
            label20.Text = "Major";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(673, 233);
            label16.Name = "label16";
            label16.Size = new Size(47, 20);
            label16.TabIndex = 4;
            label16.Text = "Email";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(808, 121);
            label19.Name = "label19";
            label19.Size = new Size(61, 20);
            label19.TabIndex = 2;
            label19.Text = "Position";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(673, 177);
            label15.Name = "label15";
            label15.Size = new Size(50, 20);
            label15.TabIndex = 3;
            label15.Text = "Major";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(808, 63);
            label18.Name = "label18";
            label18.Size = new Size(49, 20);
            label18.TabIndex = 1;
            label18.Text = "Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(673, 121);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 2;
            label14.Text = "Position";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(673, 63);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 1;
            label13.Text = "Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(21, 47);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(567, 286);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1032, 405);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sample Topics";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(392, 339);
            button1.Name = "button1";
            button1.Size = new Size(296, 36);
            button1.TabIndex = 13;
            button1.Text = "Download Topic";
            button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(809, 280);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 12;
            label12.Text = "2023-2024";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(809, 226);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 11;
            label11.Text = "Major";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(809, 177);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 10;
            label10.Text = "Lecturer Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(809, 127);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 9;
            label9.Text = "Student Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(809, 77);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 8;
            label8.Text = "Student Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(809, 33);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 7;
            label7.Text = "Topic Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(668, 280);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 6;
            label6.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(668, 226);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Major";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(668, 177);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 4;
            label4.Text = "Lecturer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(668, 127);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Student 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(668, 77);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Student 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(668, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(17, 18);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(568, 294);
            dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 620);
            Controls.Add(tabControl1);
            Controls.Add(Home);
            Controls.Add(btnLogout);
            Controls.Add(btnRegister);
            Controls.Add(btnManage);
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
        private Label label22;
        private Label label21;
        private Label label17;
        private Label label20;
        private Label label16;
        private Label label19;
        private Label label15;
        private Label label18;
        private Label label14;
        private Label label13;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView3;
        private Label label23;
    }
}