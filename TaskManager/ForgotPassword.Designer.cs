namespace TaskManager
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            panel1 = new Panel();
            panel2 = new Panel();
            VisibleBox = new PictureBox();
            NotVisibleBox = new PictureBox();
            VisibleBox1 = new PictureBox();
            SignIn = new Label();
            NotVisibleBox1 = new PictureBox();
            label1 = new Label();
            ChangePass = new Button();
            RepPassBox = new TextBox();
            NewPassBox = new TextBox();
            EmailBox = new TextBox();
            RepPass = new Label();
            NewPass = new Label();
            Email = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisibleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisibleBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox1).BeginInit();
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
            panel1.Size = new Size(422, 328);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(VisibleBox);
            panel2.Controls.Add(NotVisibleBox);
            panel2.Controls.Add(VisibleBox1);
            panel2.Controls.Add(SignIn);
            panel2.Controls.Add(NotVisibleBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ChangePass);
            panel2.Controls.Add(RepPassBox);
            panel2.Controls.Add(NewPassBox);
            panel2.Controls.Add(EmailBox);
            panel2.Controls.Add(RepPass);
            panel2.Controls.Add(NewPass);
            panel2.Controls.Add(Email);
            panel2.Location = new Point(50, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 235);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // VisibleBox
            // 
            VisibleBox.BackColor = Color.Transparent;
            VisibleBox.BackgroundImageLayout = ImageLayout.None;
            VisibleBox.Cursor = Cursors.Hand;
            VisibleBox.Image = (Image)resources.GetObject("VisibleBox.Image");
            VisibleBox.Location = new Point(279, 120);
            VisibleBox.Name = "VisibleBox";
            VisibleBox.Size = new Size(28, 29);
            VisibleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            VisibleBox.TabIndex = 23;
            VisibleBox.TabStop = false;
            VisibleBox.Click += VisibleBox_Click;
            // 
            // NotVisibleBox
            // 
            NotVisibleBox.BackColor = Color.Transparent;
            NotVisibleBox.BackgroundImageLayout = ImageLayout.None;
            NotVisibleBox.Cursor = Cursors.Hand;
            NotVisibleBox.Image = (Image)resources.GetObject("NotVisibleBox.Image");
            NotVisibleBox.Location = new Point(279, 120);
            NotVisibleBox.Name = "NotVisibleBox";
            NotVisibleBox.Size = new Size(28, 29);
            NotVisibleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NotVisibleBox.TabIndex = 24;
            NotVisibleBox.TabStop = false;
            NotVisibleBox.Click += NotVisibleBox_Click;
            // 
            // VisibleBox1
            // 
            VisibleBox1.BackColor = Color.Transparent;
            VisibleBox1.BackgroundImageLayout = ImageLayout.None;
            VisibleBox1.Cursor = Cursors.Hand;
            VisibleBox1.Image = (Image)resources.GetObject("VisibleBox1.Image");
            VisibleBox1.Location = new Point(279, 84);
            VisibleBox1.Name = "VisibleBox1";
            VisibleBox1.Size = new Size(28, 29);
            VisibleBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            VisibleBox1.TabIndex = 21;
            VisibleBox1.TabStop = false;
            VisibleBox1.Click += VisibleBox1_Click;
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.BackColor = Color.Transparent;
            SignIn.Cursor = Cursors.Hand;
            SignIn.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            SignIn.ForeColor = Color.FromArgb(204, 204, 204);
            SignIn.Location = new Point(217, 204);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(41, 16);
            SignIn.TabIndex = 8;
            SignIn.Text = "Sign in";
            SignIn.Click += SignIn_Click;
            SignIn.MouseEnter += SignIn_MouseEnter;
            SignIn.MouseLeave += SignIn_MouseLeave;
            // 
            // NotVisibleBox1
            // 
            NotVisibleBox1.BackColor = Color.Transparent;
            NotVisibleBox1.BackgroundImageLayout = ImageLayout.None;
            NotVisibleBox1.Cursor = Cursors.Hand;
            NotVisibleBox1.Image = (Image)resources.GetObject("NotVisibleBox1.Image");
            NotVisibleBox1.Location = new Point(279, 85);
            NotVisibleBox1.Name = "NotVisibleBox1";
            NotVisibleBox1.Size = new Size(28, 29);
            NotVisibleBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            NotVisibleBox1.TabIndex = 22;
            NotVisibleBox1.TabStop = false;
            NotVisibleBox1.Click += NotVisibleBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 204, 204);
            label1.Location = new Point(74, 204);
            label1.Name = "label1";
            label1.Size = new Size(146, 16);
            label1.TabIndex = 7;
            label1.Text = "Remembered the password?";
            // 
            // ChangePass
            // 
            ChangePass.BackColor = Color.FromArgb(30, 0, 30);
            ChangePass.FlatStyle = FlatStyle.Flat;
            ChangePass.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ChangePass.ForeColor = Color.FromArgb(204, 204, 204);
            ChangePass.Location = new Point(99, 160);
            ChangePass.Name = "ChangePass";
            ChangePass.Size = new Size(150, 32);
            ChangePass.TabIndex = 6;
            ChangePass.Text = "Change Password";
            ChangePass.UseVisualStyleBackColor = false;
            ChangePass.Click += ChangePass_Click;
            // 
            // RepPassBox
            // 
            RepPassBox.Location = new Point(146, 120);
            RepPassBox.MaxLength = 50;
            RepPassBox.Name = "RepPassBox";
            RepPassBox.Size = new Size(127, 23);
            RepPassBox.TabIndex = 5;
            RepPassBox.UseSystemPasswordChar = true;
            // 
            // NewPassBox
            // 
            NewPassBox.Location = new Point(146, 84);
            NewPassBox.MaxLength = 50;
            NewPassBox.Name = "NewPassBox";
            NewPassBox.Size = new Size(127, 23);
            NewPassBox.TabIndex = 4;
            NewPassBox.UseSystemPasswordChar = true;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(146, 50);
            EmailBox.MaxLength = 50;
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(127, 23);
            EmailBox.TabIndex = 3;
            // 
            // RepPass
            // 
            RepPass.AutoSize = true;
            RepPass.BackColor = Color.Transparent;
            RepPass.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RepPass.ForeColor = Color.FromArgb(204, 204, 204);
            RepPass.Location = new Point(4, 118);
            RepPass.Name = "RepPass";
            RepPass.Size = new Size(136, 22);
            RepPass.TabIndex = 2;
            RepPass.Text = "Repeat Password";
            // 
            // NewPass
            // 
            NewPass.AutoSize = true;
            NewPass.BackColor = Color.Transparent;
            NewPass.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewPass.ForeColor = Color.FromArgb(204, 204, 204);
            NewPass.Location = new Point(4, 85);
            NewPass.Name = "NewPass";
            NewPass.Size = new Size(120, 22);
            NewPass.TabIndex = 1;
            NewPass.Text = "New Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Email.ForeColor = Color.FromArgb(204, 204, 204);
            Email.Location = new Point(4, 51);
            Email.Name = "Email";
            Email.Size = new Size(53, 22);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 328);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisibleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisibleBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotVisibleBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ChangePass;
        private TextBox RepPassBox;
        private TextBox NewPassBox;
        private TextBox EmailBox;
        private Label RepPass;
        private Label NewPass;
        private Label Email;
        private Label label1;
        private Label SignIn;
        private PictureBox VisibleBox;
        private PictureBox NotVisibleBox;
        private PictureBox VisibleBox1;
        private PictureBox NotVisibleBox1;
        private ErrorProvider errorProvider1;
    }
}