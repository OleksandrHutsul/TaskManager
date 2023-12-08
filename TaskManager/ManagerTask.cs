using Microsoft.Data.SqlClient;
using System.Data;

namespace TaskManager
{
    public partial class ManagerTask : Form
    {
        public ManagerTask()
        {
            InitializeComponent();
        }

        private int currentUserId;

        // Constructor to retrieve the user ID from the previous window.
        public ManagerTask(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(); //creating a new Add Task object
            addTask.Show(); //open a Add Task window
            this.Hide(); //hide the current form
        }

        // Event that is called when the ManagerTask form is loaded.
        private void ManagerTask_Load(object sender, EventArgs e)
        {
            // Set the text of the userBox field with the name of the current user.
            userBox.Text = Program.userName;

            // We get a DataTable with a list of tasks for the current user (by his ID).
            DataTable tasksTable = GetTasksForCurrentUser(Program.userId);

            // Set the resulting DataTable as the data source for the DataGridView.
            dataGridView1.DataSource = tasksTable;
        }

        // Method to get a list of tasks for a specific user from the database.
        private DataTable GetTasksForCurrentUser(int userID)
        {
            // Create a DataTable to save the results of a query to the database.
            DataTable tasksTable = new DataTable();
            //creating a new DataBase object
            DataBase dataBase = new DataBase();

            // We use SqlConnection to establish a connection with the database.
            // Code to select tasks for a specific user using the @id_user parameter.
            using (SqlConnection connection = dataBase.getConnection())
            {
                // SQL query to select tasks for a user using the @id_user parameter.
                string query = "SELECT id_task, title, description, deadline, priority, completed FROM Tasks WHERE id_user = @id_user";
                // Create a SqlCommand command to execute an SQL query with parameters.
                SqlCommand command = new SqlCommand(query, connection);

                // Add the @id_user parameter to the command with the userID value.
                command.Parameters.AddWithValue("@id_user", userID);

                // Create a SqlDataAdapter to execute the query and fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                // Execute the query and fill the DataTable with the query results.
                adapter.Fill(tasksTable);
            }
            // Return a DataTable with a list of tasks for the user.
            return tasksTable;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            userBox.Text = "Guest";
            LogOut.Visible = false;
            LogIn.Visible = true;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        #region The color changes when hovering over the button
        private void LogOut_MouseEnter(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.Red;
        }

        private void LogOut_MouseLeave(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.FromArgb(204, 204, 204);
        }
        #endregion

        // Event raised when the value of a cell in the DataGridView changes.
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the data in any cell has changed (excluding the ID column).
            if (e.RowIndex >= 0)
            {
                // We get a reference to the DataGridView from which the event occurred.
                DataGridView dataGridView = (DataGridView)sender;
                // We get the unique identifier of the task (taskID) from the corresponding line where the changes occurred.
                int taskID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id_task"].Value);

                // Iterate through all columns (excluding the ID column).
                for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    // Skip the ID column.
                    if (dataGridView.Columns[columnIndex].Name != "id_task")
                    {
                        // Get the new value (newValue) of the changed column.
                        object newValue = dataGridView.Rows[e.RowIndex].Cells[columnIndex].Value;

                        // Get the name of the column for updating.
                        string columnName = dataGridView.Columns[columnIndex].Name;

                        // Update the corresponding data in the database for the current column.
                        UpdateDataInDatabase(taskID, columnName, newValue);
                    }
                }
            }
        }

        private void DeleteTaskFromDatabase(int taskID)
        {
            // Creating a new DataBase object
            DataBase dataBase = new DataBase();

            // Code to delete the task from the database using an SQL query.
            using (SqlConnection connection = dataBase.getConnection())
            {
                // SQL query to delete a task based on taskID.
                string query = "DELETE FROM Tasks WHERE id_task = @id_task";
                SqlCommand command = new SqlCommand(query, connection);

                // Add the parameter for taskID.
                command.Parameters.AddWithValue("@id_task", taskID);

                // Open a connection to the database.
                connection.Open();
                // Execute the SQL query to delete the task.
                command.ExecuteNonQuery();
            }
        }

        // Method to update the data in the database for a specific column.
        private void UpdateDataInDatabase(int taskID, string columnName, object newValue)
        {
            //creating a new DataBase object
            DataBase dataBase = new DataBase();

            // Code to update the specified column in the Tasks table using an SQL query.
            using (SqlConnection connection = dataBase.getConnection())
            {
                // SQL query to update the specified column in the Tasks table using parameters.
                string query = $"UPDATE Tasks SET {columnName} = @value WHERE id_task = @id_task";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the command to update the specified column.
                command.Parameters.AddWithValue("@value", newValue);
                command.Parameters.AddWithValue("@id_task", taskID);

                // Open a connection to the database.
                connection.Open();
                // Execute the SQL query without receiving results (because it is an UPDATE query).
                command.ExecuteNonQuery();
            }
        }

        // Event raised when the text in the TitleBox text field changes.
        // Used to filter the data in the DataGridView by task name.
        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            // Set the filter for the DataTable, which is the data source for the DataGridView.
            // Apply a filter on the "title" column using the value from the TitleBox text field.
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"title LIKE '%{TitleBox.Text}%'";
        }

        // Event raised when the selected value in the ComboBox FilterBox changes.
        // Used to filter data in the DataGridView by task priority.
        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perform data filtering in the DataGridView depending on the selected value in the ComboBox FilterBox.
            switch (FilterBox.SelectedIndex)
            {
                case 0:
                    // Filter the data in the DataGridView by priority 1.
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"priority = 1";
                    break;
                case 1:
                    // Filter the data in the DataGridView by priority 2.
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"priority = 2";
                    break;
                case 2:
                    // Filter the data in the DataGridView by priority 3.
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"priority = 3";
                    break;
                case 3:
                    // Remove the filter, showing all the data in the DataGridView.
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int taskIDToDelete = Convert.ToInt32(TextDelete.Text); // Replace with the actual task ID you want to delete.

            // Delete the task from the DataGridView.
            // Find the row with the matching taskID and remove it.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int taskID = Convert.ToInt32(row.Cells["id_task"].Value);
                if (taskID == taskIDToDelete)
                {
                    dataGridView1.Rows.Remove(row);
                    break; // Break out of the loop once the row is found and removed.
                }
            }

            // Delete the task from the database.
            DeleteTaskFromDatabase(taskIDToDelete);

            MessageBox.Show("Data successfully deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}