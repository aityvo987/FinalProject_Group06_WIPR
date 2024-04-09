namespace FInalProject_Group06
{
    partial class fCreateTask
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
            label5 = new Label();
            txtDescription = new TextBox();
            txtName = new TextBox();
            button2 = new Button();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(268, 2);
            label5.Name = "label5";
            label5.Size = new Size(277, 62);
            label5.TabIndex = 52;
            label5.Text = "Create Task";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(211, 151);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(499, 75);
            txtDescription.TabIndex = 46;
            // 
            // txtName
            // 
            txtName.Location = new Point(211, 84);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(499, 40);
            txtName.TabIndex = 47;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Location = new Point(585, 348);
            button2.Name = "button2";
            button2.Size = new Size(125, 33);
            button2.TabIndex = 44;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(94, 255);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 43;
            label9.Text = "Deadline";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 151);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 40;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 41;
            label3.Text = "Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(211, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(499, 27);
            dateTimePicker1.TabIndex = 53;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(94, 348);
            button1.Name = "button1";
            button1.Size = new Size(125, 33);
            button1.TabIndex = 44;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // fCreateTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 410);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "fCreateTask";
            Text = "fCreateTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtDescription;
        private TextBox txtName;
        private Button button2;
        private Label label9;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}