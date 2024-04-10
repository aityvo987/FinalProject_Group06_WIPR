namespace FInalProject_Group06
{
    partial class ucTopic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTopicName = new Label();
            lblTopicDescription = new Label();
            lblStudent1 = new Label();
            lblStudent2 = new Label();
            lblYear = new Label();
            SuspendLayout();
            // 
            // lblTopicName
            // 
            lblTopicName.AutoSize = true;
            lblTopicName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopicName.Location = new Point(290, 15);
            lblTopicName.Name = "lblTopicName";
            lblTopicName.Size = new Size(135, 30);
            lblTopicName.TabIndex = 0;
            lblTopicName.Text = "Topic Name";
            lblTopicName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopicDescription
            // 
            lblTopicDescription.AutoSize = true;
            lblTopicDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopicDescription.Location = new Point(20, 58);
            lblTopicDescription.Name = "lblTopicDescription";
            lblTopicDescription.Size = new Size(119, 25);
            lblTopicDescription.TabIndex = 1;
            lblTopicDescription.Text = "Technologiy";
            // 
            // lblStudent1
            // 
            lblStudent1.AutoSize = true;
            lblStudent1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudent1.Location = new Point(20, 106);
            lblStudent1.Name = "lblStudent1";
            lblStudent1.Size = new Size(50, 25);
            lblStudent1.TabIndex = 3;
            lblStudent1.Text = "Year";
            // 
            // lblStudent2
            // 
            lblStudent2.AutoSize = true;
            lblStudent2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudent2.Location = new Point(20, 160);
            lblStudent2.Name = "lblStudent2";
            lblStudent2.Size = new Size(94, 25);
            lblStudent2.TabIndex = 4;
            lblStudent2.Text = "Student1";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(360, 160);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(94, 25);
            lblYear.TabIndex = 4;
            lblYear.Text = "Student2";
            // 
            // ucTopic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lblYear);
            Controls.Add(lblStudent2);
            Controls.Add(lblStudent1);
            Controls.Add(lblTopicDescription);
            Controls.Add(lblTopicName);
            Name = "ucTopic";
            Size = new Size(708, 216);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTopicName;
        private Label lblTopicDescription;
        private Label lblStudent1;
        private Label lblStudent2;
        private Label lblYear;
    }
}
