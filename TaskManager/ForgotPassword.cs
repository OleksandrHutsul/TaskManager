using Microsoft.Data.SqlClient;

namespace TaskManager
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)//adjust transparency
        {
            panel2.BackColor = Color.FromArgb(32, 255, 255, 255);//number one - set transparency
        }

        #region Button Change Password
        private void ChangePass_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Validate the email
            string email1 = EmailBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(email1))
            {
                errorProvider1.SetError(EmailBox, "Enter an email.");
                isValid = false;
            }
            else if (!email1.Contains("@gmail.com"))
            {
                errorProvider1.SetError(EmailBox, "Enter a valid email (must contain @gmail.com).");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(EmailBox, "");
            }

            // Validate the password
            string password1 = NewPassBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(password1))
            {
                errorProvider1.SetError(NewPassBox, "Enter a new password.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(NewPassBox, "");
            }

            // Validate the password
            string reppassword1 = RepPassBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(password1))
            {
                errorProvider1.SetError(RepPassBox, "Repeat a password.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(RepPassBox, "");
            }
            if (isValid)
            {
                //creating a new DataBase object
                DataBase dataBase = new DataBase();

                // Getting data from the corresponding fields of the form
                var email = EmailBox.Text;
                var newPassword = NewPassBox.Text;
                var repPassword = RepPassBox.Text;

                //We check whether the passwords match
                if (newPassword != repPassword)
                {
                    MessageBox.Show("Passwords do not match!", "Error!"); //message
                    return;
                }

                // Request to update a row into the 'Users' table of the database
                string querystring = "UPDATE Users SET password = @password WHERE email = @email";

                // We use the SqlConnection connection to perform operations with the database.
                // The getConnection() method returns the connection object to the database.
                using (SqlConnection connection = dataBase.getConnection())
                {
                    connection.Open(); // Opening a connection to the database

                    // We use the SqlCommand command to execute an SQL query in the database.
                    // querystring contains an SQL query that updates the password in the database with the specified parameters.
                    using (SqlCommand command = new SqlCommand(querystring, connection))
                    {
                        // We add parameters to the command to prevent SQL injection and transfer a new password and email.
                        command.Parameters.AddWithValue("@password", newPassword);
                        command.Parameters.AddWithValue("@email", email);

                        // Execute an SQL query and get the number of changed rows in the database.
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any database rows have changed.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success!"); //message
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Check the email you entered.", "Error"); //message
                        }
                    }
                }

                LoginForm loginForm = new LoginForm(); //creating a new LoginForm object
                loginForm.Show(); //open a Manager Task window
                this.Hide(); //hide the current form
            }
            else
            {
                MessageBox.Show("You must fill in all fields!", "Error!");
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); //creating a new LoginForm object
            loginForm.Show(); //open a Manager Task window
            this.Hide(); //hide the current form
        }
        #endregion

        #region Change of color
        private void SignIn_MouseEnter(object sender, EventArgs e)
        {
            SignIn.ForeColor = Color.Red;
        }

        private void SignIn_MouseLeave(object sender, EventArgs e)
        {
            SignIn.ForeColor = Color.FromArgb(204, 204, 204);
        }
        #endregion

        #region eyes
        private void NotVisibleBox_Click(object sender, EventArgs e)
        {
            RepPassBox.UseSystemPasswordChar = true;
            VisibleBox.Visible = true;
            NotVisibleBox.Visible = false;
        }

        private void VisibleBox_Click(object sender, EventArgs e)
        {
            RepPassBox.UseSystemPasswordChar = false;
            VisibleBox.Visible = false;
            NotVisibleBox.Visible = true;
        }

        private void NotVisibleBox1_Click(object sender, EventArgs e)
        {
            NewPassBox.UseSystemPasswordChar = true;
            VisibleBox1.Visible = true;
            NotVisibleBox1.Visible = false;
        }

        private void VisibleBox1_Click(object sender, EventArgs e)
        {
            NewPassBox.UseSystemPasswordChar = false;
            VisibleBox1.Visible = false;
            NotVisibleBox1.Visible = true;
        }
        #endregion
    }
}
