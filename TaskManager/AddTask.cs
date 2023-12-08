using Microsoft.Data.SqlClient;

namespace TaskManager
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)//adjust transparency
        {
            panel2.BackColor = Color.FromArgb(32, 255, 255, 255);//number one - set transparency
        }

        #region Button Add Task
        private void addtasks_Click(object sender, EventArgs e)
        {
            // Getting data from the corresponding fields of the form
            var title = titleBox.Text;
            var description = DescriptionBox.Text;
            var deadline = DeadlineDate.Value;
            var priority = PriorityBox.Text;

            DataBase dataBase = new DataBase();
            using (SqlConnection connection = dataBase.getConnection())
            {
                // Request to insert a new row into the 'Tasks' table of the database
                string querystring = "INSERT INTO Tasks (title, description, deadline, priority, id_user) VALUES (@title, @description, @deadline, @priority, @id_user)";

                using (SqlCommand command = new SqlCommand(querystring, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@deadline", deadline);
                    command.Parameters.AddWithValue("@priority", priority);
                    command.Parameters.AddWithValue("@id_user", Program.userId);

                    try
                    {
                        connection.Open(); // Opening a connection to the database

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Task successfully added!", "Success!"); // Message

                            ManagerTask managerTask = new ManagerTask(); // Creating a new ManagerTask object
                            this.Hide(); // Hide the current form
                            managerTask.Show(); // Open a Manager Task window
                        }
                        else
                        {
                            MessageBox.Show("Task not added! Fill in all fields", "Error!"); // Message
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error!"); // Handle any exceptions
                    }
                } // SqlCommand is automatically disposed when exiting this block
            } // SqlConnection is automatically disposed when exiting this block
        }
        #endregion

        #region Button return
        private void Return_Click(object sender, EventArgs e)
        {
            ManagerTask managerTask = new ManagerTask(); //creating a new ManagerTask object
            managerTask.Show(); //open a Manager Task window
            this.Hide(); //hide the current form
        }
        #endregion
    }
}
