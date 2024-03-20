namespace FInalProject_Group06
{
    partial class fRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegister));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtPassConfirm = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(66, 301);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(251, 300);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 194);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 250);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(136, 9);
            label5.Name = "label5";
            label5.Size = new Size(191, 53);
            label5.TabIndex = 6;
            label5.Text = "Register";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(165, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(218, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(165, 191);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(218, 27);
            txtPass.TabIndex = 9;
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.Location = new Point(165, 247);
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.Size = new Size(218, 27);
            txtPassConfirm.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(524, 446);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(8, 27);
            textBox5.TabIndex = 11;
            // 
            // fRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(420, 363);
            Controls.Add(textBox5);
            Controls.Add(txtPassConfirm);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "fRegister";
            Text = "fRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtPassConfirm;
        private TextBox textBox5;
    }
}