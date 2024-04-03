namespace FInalProject_Group06
{
    partial class TopicTaskStudent
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
            lblTopicName = new Label();
            lblTaskNumber = new Label();
            lblName = new Label();
            lblContent = new Label();
            lblPoint = new Label();
            lblDeadline = new Label();
            lblNameTask = new Label();
            lblContentTask = new Label();
            lblPointTask = new Label();
            lblDeadlineTask = new Label();
            lblStatus = new Label();
            lblStatusTask = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTopicName
            // 
            lblTopicName.AutoSize = true;
            lblTopicName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopicName.Location = new Point(167, 9);
            lblTopicName.Name = "lblTopicName";
            lblTopicName.Size = new Size(124, 28);
            lblTopicName.TabIndex = 0;
            lblTopicName.Text = "Topic Name";
            // 
            // lblTaskNumber
            // 
            lblTaskNumber.AutoSize = true;
            lblTaskNumber.Location = new Point(186, 56);
            lblTaskNumber.Name = "lblTaskNumber";
            lblTaskNumber.Size = new Size(89, 20);
            lblTaskNumber.TabIndex = 1;
            lblTaskNumber.Text = "Topic Task #";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(35, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContent.Location = new Point(35, 171);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(65, 20);
            lblContent.TabIndex = 3;
            lblContent.Text = "Content";
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoint.Location = new Point(35, 225);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(46, 20);
            lblPoint.TabIndex = 4;
            lblPoint.Text = "Point";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeadline.Location = new Point(35, 280);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(70, 20);
            lblDeadline.TabIndex = 5;
            lblDeadline.Text = "Deadline";
            // 
            // lblNameTask
            // 
            lblNameTask.AutoSize = true;
            lblNameTask.Location = new Point(206, 123);
            lblNameTask.Name = "lblNameTask";
            lblNameTask.Size = new Size(49, 20);
            lblNameTask.TabIndex = 2;
            lblNameTask.Text = "Name";
            // 
            // lblContentTask
            // 
            lblContentTask.AutoSize = true;
            lblContentTask.Location = new Point(206, 171);
            lblContentTask.Name = "lblContentTask";
            lblContentTask.Size = new Size(61, 20);
            lblContentTask.TabIndex = 3;
            lblContentTask.Text = "Content";
            // 
            // lblPointTask
            // 
            lblPointTask.AutoSize = true;
            lblPointTask.Location = new Point(206, 225);
            lblPointTask.Name = "lblPointTask";
            lblPointTask.Size = new Size(42, 20);
            lblPointTask.TabIndex = 4;
            lblPointTask.Text = "Point";
            // 
            // lblDeadlineTask
            // 
            lblDeadlineTask.AutoSize = true;
            lblDeadlineTask.Location = new Point(206, 280);
            lblDeadlineTask.Name = "lblDeadlineTask";
            lblDeadlineTask.Size = new Size(69, 20);
            lblDeadlineTask.TabIndex = 5;
            lblDeadlineTask.Text = "Deadline";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(35, 331);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // lblStatusTask
            // 
            lblStatusTask.AutoSize = true;
            lblStatusTask.Location = new Point(206, 331);
            lblStatusTask.Name = "lblStatusTask";
            lblStatusTask.Size = new Size(74, 20);
            lblStatusTask.TabIndex = 5;
            lblStatusTask.Text = "Complete";
            // 
            // button1
            // 
            button1.Location = new Point(167, 392);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 6;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TopicTaskStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 442);
            Controls.Add(button1);
            Controls.Add(lblStatusTask);
            Controls.Add(lblDeadlineTask);
            Controls.Add(lblStatus);
            Controls.Add(lblPointTask);
            Controls.Add(lblDeadline);
            Controls.Add(lblContentTask);
            Controls.Add(lblPoint);
            Controls.Add(lblNameTask);
            Controls.Add(lblContent);
            Controls.Add(lblName);
            Controls.Add(lblTaskNumber);
            Controls.Add(lblTopicName);
            Name = "TopicTaskStudent";
            Text = "TopicTaskStudent";
            Load += fStudentTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTopicName;
        private Label lblTaskNumber;
        private Label lblName;
        private Label lblContent;
        private Label lblPoint;
        private Label lblDeadline;
        private Label lblNameTask;
        private Label lblContentTask;
        private Label lblPointTask;
        private Label lblDeadlineTask;
        private Label lblStatus;
        private Label lblStatusTask;
        private Button button1;
    }
}