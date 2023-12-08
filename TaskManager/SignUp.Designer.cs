namespace TaskManager
{
    partial class SignUp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            panel2 = new Panel();
            VisibleBox = new PictureBox();
            NotVisibleBox = new PictureBox();
            SignIn = new Label();
            label1 = new Label();
            Sign = new Button();
            PassBox = new TextBox();
            EmailBox = new TextBox();
            UserBox = new TextBox();
            Password = new Label();
            Email = new Label();
            Username = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisibleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 30);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 351);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(VisibleBox);
            panel2.Controls.Add(NotVisibleBox);
            panel2.Controls.Add(SignIn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Sign);
            panel2.Controls.Add(PassBox);
            panel2.Controls.Add(EmailBox);
            panel2.Controls.Add(UserBox);
            panel2.Controls.Add(Password);
            panel2.Controls.Add(Email);
            panel2.Controls.Add(Username);
            panel2.Location = new Point(39, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 229);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // VisibleBox
            // 
            VisibleBox.BackColor = Color.Transparent;
            VisibleBox.BackgroundImageLayout = ImageLayout.None;
            VisibleBox.Cursor = Cursors.Hand;
            VisibleBox.Image = (Image)resources.GetObject("VisibleBox.Image");
            VisibleBox.Location = new Point(259, 92);
            VisibleBox.Name = "VisibleBox";
            VisibleBox.Size = new Size(28, 29);
            VisibleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            VisibleBox.TabIndex = 19;
            VisibleBox.TabStop = false;
            VisibleBox.Click += VisibleBox_Click;
            // 
            // NotVisibleBox
            // 
            NotVisibleBox.BackColor = Color.Transparent;
            NotVisibleBox.BackgroundImageLayout = ImageLayout.None;
            NotVisibleBox.Cursor = Cursors.Hand;
            NotVisibleBox.Image = (Image)resources.GetObject("NotVisibleBox.Image");
            NotVisibleBox.Location = new Point(259, 92);
            NotVisibleBox.Name = "NotVisibleBox";
            NotVisibleBox.Size = new Size(28, 29);
            NotVisibleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NotVisibleBox.TabIndex = 20;
            NotVisibleBox.TabStop = false;
            NotVisibleBox.Click += NotVisibleBox_Click;
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.BackColor = Color.Transparent;
            SignIn.Cursor = Cursors.Hand;
            SignIn.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            SignIn.ForeColor = Color.FromArgb(204, 204, 204);
            SignIn.Location = new Point(204, 192);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(42, 16);
            SignIn.TabIndex = 8;
            SignIn.Text = "Sign In";
            SignIn.Click += SignIn_Click;
            SignIn.MouseEnter += SignIn_MouseEnter;
            SignIn.MouseLeave += SignIn_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 204, 204);
            label1.Location = new Point(74, 192);
            label1.Name = "label1";
            label1.Size = new Size(133, 16);
            label1.TabIndex = 7;
            label1.Text = "Already have an account?";
            // 
            // Sign
            // 
            Sign.BackColor = Color.FromArgb(30, 0, 30);
            Sign.Cursor = Cursors.Hand;
            Sign.FlatStyle = FlatStyle.Flat;
            Sign.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sign.ForeColor = Color.FromArgb(204, 204, 204);
            Sign.Location = new Point(88, 142);
            Sign.Name = "Sign";
            Sign.Size = new Size(138, 38);
            Sign.TabIndex = 6;
            Sign.Text = "Sign Up";
            Sign.UseVisualStyleBackColor = false;
            Sign.Click += Sign_Click;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(115, 98);
            PassBox.MaxLength = 50;
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(138, 23);
            PassBox.TabIndex = 5;
            PassBox.UseSystemPasswordChar = true;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(115, 57);
            EmailBox.MaxLength = 50;
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(138, 23);
            EmailBox.TabIndex = 4;
            // 
            // UserBox
            // 
            UserBox.Location = new Point(115, 18);
            UserBox.MaxLength = 50;
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(138, 23);
            UserBox.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.FromArgb(204, 204, 204);
            Password.Location = new Point(16, 99);
            Password.Name = "Password";
            Password.Size = new Size(81, 22);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Email.ForeColor = Color.FromArgb(204, 204, 204);
            Email.Location = new Point(16, 58);
            Email.Name = "Email";
            Email.Size = new Size(53, 22);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.FromArgb(204, 204, 204);
            Username.Location = new Point(16, 19);
            Username.Name = "Username";
            Username.Size = new Size(85, 22);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 351);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisibleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Password;
        private Label Email;
        private Label Username;
        private TextBox UserBox;
        private TextBox PassBox;
        private TextBox EmailBox;
        private Button Sign;
        private Label label1;
        private Label SignIn;
        private PictureBox VisibleBox;
        private PictureBox NotVisibleBox;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}