namespace TaskManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel2 = new Panel();
            VisibleBox = new PictureBox();
            NotVisibleBox = new PictureBox();
            CreateAcc = new Label();
            label2 = new Label();
            FogPass = new Label();
            Login = new Button();
            checkRemem = new CheckBox();
            Username = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            Password = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisibleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 30);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 390);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(VisibleBox);
            panel2.Controls.Add(NotVisibleBox);
            panel2.Controls.Add(CreateAcc);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(FogPass);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(checkRemem);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(textUsername);
            panel2.Controls.Add(textPassword);
            panel2.Controls.Add(Password);
            panel2.Location = new Point(41, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 212);
            panel2.TabIndex = 15;
            panel2.Paint += panel2_Paint;
            // 
            // VisibleBox
            // 
            VisibleBox.BackColor = Color.Transparent;
            VisibleBox.BackgroundImageLayout = ImageLayout.None;
            VisibleBox.Cursor = Cursors.Hand;
            VisibleBox.Image = (Image)resources.GetObject("VisibleBox.Image");
            VisibleBox.Location = new Point(278, 58);
            VisibleBox.Name = "VisibleBox";
            VisibleBox.Size = new Size(28, 29);
            VisibleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            VisibleBox.TabIndex = 18;
            VisibleBox.TabStop = false;
            VisibleBox.Click += VisibleBox_Click;
            // 
            // NotVisibleBox
            // 
            NotVisibleBox.BackColor = Color.Transparent;
            NotVisibleBox.BackgroundImageLayout = ImageLayout.None;
            NotVisibleBox.Cursor = Cursors.Hand;
            NotVisibleBox.Image = (Image)resources.GetObject("NotVisibleBox.Image");
            NotVisibleBox.Location = new Point(278, 58);
            NotVisibleBox.Name = "NotVisibleBox";
            NotVisibleBox.Size = new Size(28, 29);
            NotVisibleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NotVisibleBox.TabIndex = 17;
            NotVisibleBox.TabStop = false;
            NotVisibleBox.Click += NotVisibleBox_Click;
            // 
            // CreateAcc
            // 
            CreateAcc.AutoSize = true;
            CreateAcc.BackColor = Color.Transparent;
            CreateAcc.Cursor = Cursors.Hand;
            CreateAcc.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateAcc.ForeColor = Color.FromArgb(204, 204, 204);
            CreateAcc.Location = new Point(178, 179);
            CreateAcc.Name = "CreateAcc";
            CreateAcc.Size = new Size(100, 16);
            CreateAcc.TabIndex = 16;
            CreateAcc.Text = "Create an account.";
            CreateAcc.Click += CreateAcc_Click;
            CreateAcc.MouseEnter += CreateAcc_MouseEnter;
            CreateAcc.MouseLeave += CreateAcc_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(204, 204, 204);
            label2.Location = new Point(36, 179);
            label2.Name = "label2";
            label2.Size = new Size(150, 16);
            label2.TabIndex = 15;
            label2.Text = "For the first time in the app? ";
            // 
            // FogPass
            // 
            FogPass.Anchor = AnchorStyles.None;
            FogPass.AutoSize = true;
            FogPass.BackColor = Color.Transparent;
            FogPass.Cursor = Cursors.Hand;
            FogPass.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            FogPass.ForeColor = Color.FromArgb(204, 204, 204);
            FogPass.Location = new Point(195, 86);
            FogPass.Name = "FogPass";
            FogPass.Size = new Size(93, 16);
            FogPass.TabIndex = 14;
            FogPass.Text = "Forgot password?";
            FogPass.Click += FogPass_Click;
            FogPass.MouseEnter += FogPass_MouseEnter;
            FogPass.MouseLeave += FogPass_MouseLeave;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.None;
            Login.BackColor = Color.FromArgb(30, 0, 30);
            Login.BackgroundImageLayout = ImageLayout.None;
            Login.Cursor = Cursors.Hand;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.FromArgb(204, 204, 204);
            Login.Location = new Point(83, 116);
            Login.Name = "Login";
            Login.Size = new Size(145, 34);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // checkRemem
            // 
            checkRemem.Anchor = AnchorStyles.None;
            checkRemem.AutoSize = true;
            checkRemem.BackColor = Color.Transparent;
            checkRemem.Cursor = Cursors.Hand;
            checkRemem.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkRemem.ForeColor = Color.FromArgb(204, 204, 204);
            checkRemem.Location = new Point(102, 156);
            checkRemem.Name = "checkRemem";
            checkRemem.Size = new Size(98, 20);
            checkRemem.TabIndex = 13;
            checkRemem.Text = "Remember me";
            checkRemem.UseVisualStyleBackColor = false;
            checkRemem.MouseEnter += checkRemem_MouseEnter;
            checkRemem.MouseLeave += checkRemem_MouseLeave;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.FromArgb(204, 204, 204);
            Username.Location = new Point(12, 15);
            Username.Name = "Username";
            Username.Size = new Size(85, 22);
            Username.TabIndex = 9;
            Username.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.Anchor = AnchorStyles.None;
            textUsername.Location = new Point(102, 17);
            textUsername.MaxLength = 50;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(174, 23);
            textUsername.TabIndex = 11;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.None;
            textPassword.BackColor = SystemColors.Window;
            textPassword.Location = new Point(102, 60);
            textPassword.MaxLength = 50;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(174, 23);
            textPassword.TabIndex = 12;
            textPassword.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.FromArgb(204, 204, 204);
            Password.Location = new Point(12, 58);
            Password.Name = "Password";
            Password.Size = new Size(81, 22);
            Password.TabIndex = 10;
            Password.Text = "Password";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(377, 390);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisibleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label FogPass;
        private CheckBox checkRemem;
        private Label Username;
        private TextBox textPassword;
        private Label Password;
        private Button Login;
        private TextBox textUsername;
        private Panel panel2;
        private Label label2;
        private Label CreateAcc;
        private Label label3;
        private PictureBox NotVisibleBox;
        private PictureBox VisibleBox;
        private ErrorProvider errorProvider1;
    }
}