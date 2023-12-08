namespace TaskManager
{
    partial class ManagerTask
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
            panel3 = new Panel();
            TextDelete = new TextBox();
            Delete = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            Priority = new Label();
            TitleBox = new TextBox();
            Title = new Label();
            FilterBox = new ComboBox();
            Filter = new Label();
            dataGridView1 = new DataGridView();
            LogIn = new Label();
            userBox = new TextBox();
            LogOut = new Label();
            UserName = new Label();
            AddTask = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(LogIn);
            panel1.Controls.Add(userBox);
            panel1.Controls.Add(LogOut);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(AddTask);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 563);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextDelete);
            panel3.Controls.Add(Delete);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(283, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 100);
            panel3.TabIndex = 14;
            // 
            // TextDelete
            // 
            TextDelete.Location = new Point(78, 31);
            TextDelete.MaxLength = 30;
            TextDelete.Name = "TextDelete";
            TextDelete.Size = new Size(121, 23);
            TextDelete.TabIndex = 14;
            // 
            // Delete
            // 
            Delete.Cursor = Cursors.Hand;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = Color.FromArgb(204, 204, 204);
            Delete.Location = new Point(23, 64);
            Delete.Name = "Delete";
            Delete.Size = new Size(153, 31);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(204, 204, 204);
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 12;
            label2.Text = "Enter ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(204, 204, 204);
            label3.Location = new Point(51, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 12;
            label3.Text = "Delete task";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Priority);
            panel2.Controls.Add(TitleBox);
            panel2.Controls.Add(Title);
            panel2.Controls.Add(FilterBox);
            panel2.Controls.Add(Filter);
            panel2.Location = new Point(38, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 11;
            // 
            // Priority
            // 
            Priority.AutoSize = true;
            Priority.BackColor = Color.Transparent;
            Priority.Font = new Font("Palatino Linotype", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            Priority.ForeColor = Color.FromArgb(204, 204, 204);
            Priority.Location = new Point(3, 70);
            Priority.Name = "Priority";
            Priority.Size = new Size(68, 22);
            Priority.TabIndex = 13;
            Priority.Text = "Priority";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(74, 31);
            TitleBox.MaxLength = 30;
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(121, 23);
            TitleBox.TabIndex = 13;
            TitleBox.TextChanged += TitleBox_TextChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Palatino Linotype", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.FromArgb(204, 204, 204);
            Title.Location = new Point(3, 31);
            Title.Name = "Title";
            Title.Size = new Size(45, 22);
            Title.TabIndex = 12;
            Title.Text = "Title";
            // 
            // FilterBox
            // 
            FilterBox.FormattingEnabled = true;
            FilterBox.Items.AddRange(new object[] { "1", "2", "3", "All" });
            FilterBox.Location = new Point(74, 70);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(121, 23);
            FilterBox.TabIndex = 8;
            FilterBox.SelectedIndexChanged += FilterBox_SelectedIndexChanged;
            // 
            // Filter
            // 
            Filter.AutoSize = true;
            Filter.BackColor = Color.Transparent;
            Filter.Font = new Font("Palatino Linotype", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            Filter.ForeColor = Color.FromArgb(204, 204, 204);
            Filter.Location = new Point(74, 0);
            Filter.Name = "Filter";
            Filter.Size = new Size(50, 22);
            Filter.TabIndex = 12;
            Filter.Text = "Filter";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 320);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.BackColor = Color.Transparent;
            LogIn.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogIn.ForeColor = Color.FromArgb(204, 204, 204);
            LogIn.Location = new Point(750, 5);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(47, 18);
            LogIn.TabIndex = 6;
            LogIn.Text = "Log in";
            LogIn.Visible = false;
            // 
            // userBox
            // 
            userBox.BackColor = Color.FromArgb(30, 0, 30);
            userBox.BorderStyle = BorderStyle.None;
            userBox.Dock = DockStyle.Left;
            userBox.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            userBox.ForeColor = Color.FromArgb(204, 204, 204);
            userBox.Location = new Point(0, 0);
            userBox.MaxLength = 30;
            userBox.Name = "userBox";
            userBox.Size = new Size(262, 18);
            userBox.TabIndex = 4;
            // 
            // LogOut
            // 
            LogOut.AutoSize = true;
            LogOut.BackColor = Color.Transparent;
            LogOut.Cursor = Cursors.Hand;
            LogOut.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogOut.ForeColor = Color.FromArgb(204, 204, 204);
            LogOut.Location = new Point(742, 5);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(55, 18);
            LogOut.TabIndex = 3;
            LogOut.Text = "Log out";
            LogOut.Click += LogOut_Click;
            LogOut.MouseEnter += LogOut_MouseEnter;
            LogOut.MouseLeave += LogOut_MouseLeave;
            // 
            // UserName
            // 
            UserName.Location = new Point(0, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(100, 23);
            UserName.TabIndex = 5;
            // 
            // AddTask
            // 
            AddTask.Cursor = Cursors.Hand;
            AddTask.FlatStyle = FlatStyle.Flat;
            AddTask.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddTask.ForeColor = Color.FromArgb(204, 204, 204);
            AddTask.Location = new Point(570, 437);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(196, 31);
            AddTask.TabIndex = 0;
            AddTask.Text = "Add New Task";
            AddTask.UseVisualStyleBackColor = true;
            AddTask.Click += AddTask_Click;
            // 
            // ManagerTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 0, 30);
            ClientSize = new Size(800, 563);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ManagerTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerTask";
            Load += ManagerTask_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddTask;
        private Label UserName;
        private Label LogOut;
        private TextBox userBox;
        private Label LogIn;
        private DataGridView dataGridView1;
        private ComboBox FilterBox;
        private Panel panel2;
        private Label Priority;
        private TextBox TitleBox;
        private Label Title;
        private Label Filter;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Button Delete;
        private TextBox TextDelete;
    }
}