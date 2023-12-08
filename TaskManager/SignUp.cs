using System.Data;
using Microsoft.Data.SqlClient;

namespace TaskManager
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            UserBox.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)//adjust transparency
        {
            panel2.BackColor = Color.FromArgb(32, 255, 255, 255); //number one - set transparency
            NotVisibleBox.Visible = true;
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); //creating a new Login Form object
            loginForm.Show(); //open a Login Form window
            this.Hide(); //hide the current form
        }

        #region The colour button SignIn
        private void SignIn_MouseEnter(object sender, EventArgs e)
        {
            SignIn.ForeColor = Color.Red;
        }

        private void SignIn_MouseLeave(object sender, EventArgs e)
        {
            SignIn.ForeColor = Color.FromArgb(204, 204, 204);
        }
        #endregion

        // The event that is called when the "Sign" button is clicked.
        private void Sign_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Validate the username
            string username1 = UserBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(username1))
            {
                errorProvider2.SetError(UserBox, "Enter a username.");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(UserBox, "");
            }

            // Validate the email
            string email1 = EmailBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(email1))
            {
                errorProvider2.SetError(EmailBox, "Enter an email.");
                isValid = false;
            }
            else if (!email1.Contains("@gmail.com"))
            {
                errorProvider1.SetError(EmailBox, "Enter a valid email (must contain @gmail.com).");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(EmailBox, "");
            }

            // Validate the password
            string password1 = PassBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(password1))
            {
                errorProvider2.SetError(PassBox, "Enter a password.");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(PassBox, "");
            }

            if (isValid)
            {
                // Get the username, email, and password values from the corresponding text fields.
                var username = UserBox.Text;
                var email = EmailBox.Text;
                var password = PassBox.Text;

                // Check if a user with this name or email already exists.
                if (СheckUsers())
                {
                    return;
                }

                // SQL query to insert a new user into the Users table.
                string querystring = "INSERT INTO Users (username, email, password) VALUES (@username, @email, @password)";

                DataBase dataBase = new DataBase();
                using (SqlConnection connection = dataBase.getConnection())
                {
                    using (SqlCommand command = new SqlCommand(querystring, connection))
                    {
                        // Use SqlParameter to add parameters and their values to the command.
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        try
                        {
                            // Open a connection to the database.
                            connection.Open();

                            // Execute an SQL query to insert a new user into the table.
                            // If the command returns 1, then the account was successfully created.
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account successfully created!", "Success!"); // Message

                                LoginForm loginForm = new LoginForm(); // Creating a new Login Form object
                                loginForm.Show(); // Open a Login Form window
                                this.Hide(); // Hide the current form
                            }
                            else
                            {
                                MessageBox.Show("Account not created!", "Error!"); // Message
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error!"); // Handle any exceptions
                        }
                    } // SqlCommand is automatically disposed when exiting this block
                } // SqlConnection is automatically disposed when exiting this block
            } // DataBase is automatically disposed when exiting this block
            else
            {
                MessageBox.Show("You must fill in all fields!", "Error!");
            }

        }

        // Method to check if a user with this name or email exists in the database.
        private bool СheckUsers()
        {
            // Get the username, email, and password values from the corresponding text fields.
            var UserName = UserBox.Text;
            var Email = EmailBox.Text;
            var Password = PassBox.Text;

            // Create a DataTable to save the results of a query to the database.
            DataTable table = new DataTable();
            //creating a new DataBase object
            DataBase dataBase = new DataBase();

            // SQL query to select a user from the Users table by name or email.
            string querystring = "SELECT id_user, username, email FROM Users WHERE username = @UserName OR email = @Email";

            // We use SqlCommand to execute an SQL query with parameters.
            using (SqlCommand command = new SqlCommand(querystring, dataBase.getConnection()))
            {
                // Add the @UserName and @Email parameters to the variable values command.
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Email", Email);

                // We use the SqlDataAdapter to execute the query and fill the DataTable with the results.
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }

            // If the number of rows in the DataTable is greater than 0, then a user with this name or email already exists.
            if (table.Rows.Count > 0)
            {
                // Display a message about the presence of a user with this name or e-mail.
                MessageBox.Show("The user already exists!");
                return true;
            }
            else
            {
                return false; // No user found with this name or email.
            }
        }

        #region eye
        private void VisibleBox_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = false;
            VisibleBox.Visible = false;
            NotVisibleBox.Visible = true;
        }

        private void NotVisibleBox_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = true;
            VisibleBox.Visible = true;
            NotVisibleBox.Visible = false;
        }
        #endregion
    }
}
