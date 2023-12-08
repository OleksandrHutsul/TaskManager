using Microsoft.Data.SqlClient;
using System.Data;

namespace TaskManager
{
    public partial class LoginForm : Form
    {
        DataBase dataBase = new DataBase(); //creating a new DataBase object

        public LoginForm()
        {
            InitializeComponent();

            this.textPassword.AutoSize = false;
            this.textPassword.Size = new Size(this.textPassword.Width, 23);
        }

        private void panel2_Paint(object sender, PaintEventArgs e) //adjust transparency
        {
            panel2.BackColor = Color.FromArgb(32, 255, 255, 255);//number one - set transparency
            NotVisibleBox.Visible = true;
        }

        #region The color changes when hovering over the button
        private void FogPass_MouseEnter(object sender, EventArgs e)
        {
            FogPass.ForeColor = Color.Red;
        }

        private void FogPass_MouseLeave(object sender, EventArgs e)
        {
            FogPass.ForeColor = Color.FromArgb(204, 204, 204);
        }

        private void CreateAcc_MouseEnter(object sender, EventArgs e)
        {
            CreateAcc.ForeColor = Color.Red;
        }

        private void CreateAcc_MouseLeave(object sender, EventArgs e)
        {
            CreateAcc.ForeColor = Color.FromArgb(204, 204, 204);
        }

        private void checkRemem_MouseEnter(object sender, EventArgs e)
        {
            checkRemem.ForeColor = Color.Red;
        }

        private void checkRemem_MouseLeave(object sender, EventArgs e)
        {
            checkRemem.ForeColor = Color.FromArgb(204, 204, 204);
        }
        #endregion

        private void Login_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            string username1 = textUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username1))
            {
                errorProvider1.SetError(textUsername, "Enter a username.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textUsername, "");
            }

            // Validate the password
            string password1 = textPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(password1))
            {
                errorProvider1.SetError(textPassword, "Enter a new password.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textPassword, "");
            }

            if (isValid)
            {
                // Getting data from the corresponding fields of the form
                var loginUser = textUsername.Text;
                var passUser = textPassword.Text;

                // Store the user's name in the global variable Program.userName.
                Program.userName = loginUser;

                // Create a DataTable to store the results of a database query.
                using (DataTable table = new DataTable())
                {
                    // SQL query to select a record from the Users table with the entered login and password.
                    string querystring = "SELECT id_user, username, password FROM Users WHERE username = @username AND password = @password";

                    DataBase dataBase = new DataBase();
                    using (SqlConnection connection = dataBase.getConnection())
                    using (SqlCommand command = new SqlCommand(querystring, connection))
                    {
                        // Use SqlParameter to add parameters and their values to the command.
                        command.Parameters.AddWithValue("@username", loginUser);
                        command.Parameters.AddWithValue("@password", passUser);

                        try
                        {
                            connection.Open(); // Open a connection to the database

                            // Create a SqlDataAdapter to execute the query and fill the DataTable with the query results.
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                // Fill the DataTable with the query results.
                                adapter.Fill(table);
                            }

                            // Check whether at least one record was found in the table.
                            if (table.Rows.Count == 1)
                            {
                                // Get the user ID from the first row of the result table.
                                Program.userId = Convert.ToInt32(table.Rows[0]["id_user"]);

                                MessageBox.Show("You have successfully logged in!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Message

                                // Update the Program.isUserLoggedIn variable to indicate that the user is logged in.
                                Program.isUserLoggedIn = true;

                                // Pass the user ID to the ManagerTask window and open it.
                                ManagerTask managerTask = new ManagerTask(Program.userId); // Creating a new ManagerTask object
                                this.Hide(); // Hide the current form
                                managerTask.Show(); // Open a Manager Task window
                            }
                            else
                            {
                                MessageBox.Show("Invalid login or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Message
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error!"); // Handle any exceptions
                        }
                    } // SqlCommand and SqlConnection are automatically disposed when exiting this block
                } // DataTable is automatically disposed when exiting this block
            }
            else
            {
                MessageBox.Show("You must fill in all fields!", "Error!");
            }
        }

        private void FogPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(); //creating a new Forgot Password object
            forgotPassword.Show(); //open a Forgot Password window
            this.Hide(); //hide the current form
        }

        #region eyes
        private void VisibleBox_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = false;
            VisibleBox.Visible = false;
            NotVisibleBox.Visible = true;
        }

        private void NotVisibleBox_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
            VisibleBox.Visible = true;
            NotVisibleBox.Visible = false;
        }
        #endregion

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(); //creating a new Sign Up object
            signUp.Show(); //open a Sign Up window
            this.Hide(); //hide the current form
        }
    }
}