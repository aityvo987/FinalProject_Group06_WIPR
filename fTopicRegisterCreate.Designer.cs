namespace FInalProject_Group06
{
    partial class fTopicRegisterCreate
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
            txtStudent2 = new TextBox();
            txtStudent1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            label9 = new Label();
            label1 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtRequirement = new TextBox();
            cbInstructor = new ComboBox();
            label2 = new Label();
            cbType = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtStudent2
            // 
            txtStudent2.Location = new Point(142, 363);
            txtStudent2.Margin = new Padding(3, 2, 3, 2);
            txtStudent2.Name = "txtStudent2";
            txtStudent2.Size = new Size(110, 23);
            txtStudent2.TabIndex = 34;
            // 
            // txtStudent1
            // 
            txtStudent1.Location = new Point(142, 326);
            txtStudent1.Margin = new Padding(3, 2, 3, 2);
            txtStudent1.Name = "txtStudent1";
            txtStudent1.Size = new Size(110, 23);
            txtStudent1.TabIndex = 33;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(373, 394);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 25);
            button2.TabIndex = 31;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            button1.BackColor = Color.LawnGreen;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(142, 394);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 25);
            button1.TabIndex = 32;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(39, 363);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 29;
            label11.Text = "Student 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(39, 326);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 30;
            label9.Text = "Student 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 112);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 25;
            label1.Text = "Instructor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 226);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 26;
            label7.Text = "Requirements";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 156);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 27;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 68);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 68);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(437, 31);
            txtName.TabIndex = 33;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 156);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(437, 57);
            txtDescription.TabIndex = 33;
            // 
            // txtRequirement
            // 
            txtRequirement.Location = new Point(142, 226);
            txtRequirement.Margin = new Padding(3, 2, 3, 2);
            txtRequirement.Multiline = true;
            txtRequirement.Name = "txtRequirement";
            txtRequirement.Size = new Size(437, 68);
            txtRequirement.TabIndex = 33;
            // 
            // cbInstructor
            // 
            cbInstructor.FormattingEnabled = true;
            cbInstructor.Location = new Point(429, 110);
            cbInstructor.Margin = new Padding(3, 2, 3, 2);
            cbInstructor.Name = "cbInstructor";
            cbInstructor.Size = new Size(150, 23);
            cbInstructor.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 110);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 25;
            label2.Text = "Type of Project";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(142, 110);
            cbType.Margin = new Padding(3, 2, 3, 2);
            cbType.Name = "cbType";
            cbType.Size = new Size(150, 23);
            cbType.TabIndex = 35;
            // 
            // txtNameins
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(192, 7);
            label5.Name = "label5";
            label5.Size = new Size(253, 51);
            label5.TabIndex = 36;
            label5.Text = "Create Topic ";
            // 
           
            // 
            // fTopicRegisterCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.whiteback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(636, 431);
            Controls.Add(label5);
            Controls.Add(cbType);
            Controls.Add(cbInstructor);
            Controls.Add(txtStudent2);
            Controls.Add(txtRequirement);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtStudent1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fTopicRegisterCreate";
            Text = "fTopicRegisterCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudent2;
        private TextBox txtStudent1;
        private Button button2;
        private Button btnCreate;
        private Label label11;
        private Label label9;
        private Label label1;
        private Label label7;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtRequirement;
        private ComboBox cbInstructor;
        private Label label2;
        private ComboBox cbType;
        private Label label5;
    }
}