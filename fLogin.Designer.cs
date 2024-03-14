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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // lblUserLogin
            // 
            lblUserLogin.AutoSize = true;
            lblUserLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserLogin.Location = new Point(98, 144);
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new Size(41, 20);
            lblUserLogin.TabIndex = 1;
            lblUserLogin.Text = "User";
            // 
            // lblPasswordLogin
            // 
            lblPasswordLogin.AutoSize = true;
            lblPasswordLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordLogin.Location = new Point(98, 227);
            lblPasswordLogin.Name = "lblPasswordLogin";
            lblPasswordLogin.Size = new Size(76, 20);
            lblPasswordLogin.TabIndex = 2;
            lblPasswordLogin.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(256, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 27);
            textBox2.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(447, 338);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPasswordLogin);
            Controls.Add(lblUserLogin);
            Controls.Add(label1);
            Name = "fLogin";
            Text = "fLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserLogin;
        private Label lblPasswordLogin;
        private Button btnLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRegister;
    }
}