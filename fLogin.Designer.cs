namespace FInalProject_Group06
{
    partial class fLogin
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
            lblUserLogin = new Label();
            lblPasswordLogin = new Label();
            btnLogin = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnRegister = new Button();
            btnHidePass = new Button();
            btnShowPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 42);
            label1.TabIndex = 0;
            label1.Text = "Management Student";
            // 
            // lblUserLogin
            // 
            lblUserLogin.AutoSize = true;
            lblUserLogin.BackColor = Color.Transparent;
            lblUserLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserLogin.Location = new Point(75, 89);
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new Size(39, 15);
            lblUserLogin.TabIndex = 1;
            lblUserLogin.Text = "User :";
            // 
            // lblPasswordLogin
            // 
            lblPasswordLogin.AutoSize = true;
            lblPasswordLogin.BackColor = Color.Transparent;
            lblPasswordLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordLogin.Location = new Point(75, 151);
            lblPasswordLogin.Name = "lblPasswordLogin";
            lblPasswordLogin.Size = new Size(65, 15);
            lblPasswordLogin.TabIndex = 2;
            lblPasswordLogin.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 211);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 28);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(148, 86);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(216, 23);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(148, 148);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(216, 23);
            txtPass.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(273, 211);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 28);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnHidePass
            // 
            btnHidePass.BackColor = Color.Transparent;
            btnHidePass.BackgroundImage = Properties.Resources.closeeye;
            btnHidePass.BackgroundImageLayout = ImageLayout.Stretch;
            btnHidePass.Location = new Point(370, 142);
            btnHidePass.Name = "btnHidePass";
            btnHidePass.Size = new Size(32, 32);
            btnHidePass.TabIndex = 7;
            btnHidePass.UseVisualStyleBackColor = false;
            btnHidePass.Click += btnHidePass_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.Transparent;
            btnShowPass.BackgroundImage = Properties.Resources.openeye;
            btnShowPass.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowPass.Location = new Point(370, 142);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(32, 32);
            btnShowPass.TabIndex = 6;
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.chainsawman01;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 273);
            Controls.Add(btnShowPass);
            Controls.Add(btnHidePass);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPasswordLogin);
            Controls.Add(lblUserLogin);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserLogin;
        private Label lblPasswordLogin;
        private Button btnLogin;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnRegister;
        private Button btnHidePass;
        private Button btnShowPass;
    }
}