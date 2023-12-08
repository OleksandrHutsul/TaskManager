namespace TaskManager
{
    partial class AddTask
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
            panel1 = new Panel();
            panel2 = new Panel();
            Return = new Button();
            addtasks = new Button();
            PriorityBox = new ComboBox();
            DeadlineDate = new DateTimePicker();
            DescriptionBox = new TextBox();
            titleBox = new TextBox();
            Priority = new Label();
            Deadline = new Label();
            Description = new Label();
            Title = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 30);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 509);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(Return);
            panel2.Controls.Add(addtasks);
            panel2.Controls.Add(PriorityBox);
            panel2.Controls.Add(DeadlineDate);
            panel2.Controls.Add(DescriptionBox);
            panel2.Controls.Add(titleBox);
            panel2.Controls.Add(Priority);
            panel2.Controls.Add(Deadline);
            panel2.Controls.Add(Description);
            panel2.Controls.Add(Title);
            panel2.Location = new Point(78, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 384);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Return
            // 
            Return.BackColor = Color.FromArgb(30, 0, 30);
            Return.Cursor = Cursors.Hand;
            Return.FlatStyle = FlatStyle.Flat;
            Return.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Return.ForeColor = Color.FromArgb(204, 204, 204);
            Return.Location = new Point(432, 319);
            Return.Name = "Return";
            Return.Size = new Size(124, 33);
            Return.TabIndex = 1;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
            // 
            // addtasks
            // 
            addtasks.BackColor = Color.FromArgb(30, 0, 30);
            addtasks.Cursor = Cursors.Hand;
            addtasks.FlatStyle = FlatStyle.Flat;
            addtasks.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addtasks.ForeColor = Color.FromArgb(204, 204, 204);
            addtasks.Location = new Point(86, 319);
            addtasks.Name = "addtasks";
            addtasks.Size = new Size(147, 33);
            addtasks.TabIndex = 1;
            addtasks.Text = "Add task";
            addtasks.UseVisualStyleBackColor = false;
            addtasks.Click += addtasks_Click;
            // 
            // PriorityBox
            // 
            PriorityBox.FormattingEnabled = true;
            PriorityBox.Items.AddRange(new object[] { "1", "2", "3" });
            PriorityBox.Location = new Point(168, 277);
            PriorityBox.Name = "PriorityBox";
            PriorityBox.Size = new Size(201, 23);
            PriorityBox.TabIndex = 7;
            PriorityBox.Text = "1";
            // 
            // DeadlineDate
            // 
            DeadlineDate.Location = new Point(169, 238);
            DeadlineDate.Name = "DeadlineDate";
            DeadlineDate.Size = new Size(200, 23);
            DeadlineDate.TabIndex = 6;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(169, 87);
            DescriptionBox.MaxLength = 500;
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(429, 132);
            DescriptionBox.TabIndex = 5;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(169, 42);
            titleBox.MaxLength = 30;
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(429, 23);
            titleBox.TabIndex = 4;
            // 
            // Priority
            // 
            Priority.AutoSize = true;
            Priority.BackColor = Color.Transparent;
            Priority.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Priority.ForeColor = Color.FromArgb(204, 204, 204);
            Priority.Location = new Point(52, 275);
            Priority.Name = "Priority";
            Priority.Size = new Size(68, 22);
            Priority.TabIndex = 3;
            Priority.Text = "Priority";
            // 
            // Deadline
            // 
            Deadline.AutoSize = true;
            Deadline.BackColor = Color.Transparent;
            Deadline.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Deadline.ForeColor = Color.FromArgb(204, 204, 204);
            Deadline.Location = new Point(52, 238);
            Deadline.Name = "Deadline";
            Deadline.Size = new Size(77, 22);
            Deadline.TabIndex = 2;
            Deadline.Text = "Deadline";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.BackColor = Color.Transparent;
            Description.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Description.ForeColor = Color.FromArgb(204, 204, 204);
            Description.Location = new Point(52, 88);
            Description.Name = "Description";
            Description.Size = new Size(97, 22);
            Description.TabIndex = 1;
            Description.Text = "Description";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.FromArgb(204, 204, 204);
            Title.Location = new Point(52, 40);
            Title.Name = "Title";
            Title.Size = new Size(45, 22);
            Title.TabIndex = 0;
            Title.Text = "Title";
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTask";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Deadline;
        private Label Description;
        private Label Title;
        private Label Priority;
        private TextBox DescriptionBox;
        private TextBox titleBox;
        private ComboBox PriorityBox;
        private DateTimePicker DeadlineDate;
        private Button addtasks;
        private Button Return;
    }
}