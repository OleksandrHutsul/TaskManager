using Microsoft.Data.SqlClient;

namespace TaskManager
{
    internal class DataBase
    {
        // Connect to the database using the SqlConnection connection.
        // A connection will be created with a connection term that specifies the database connection parameters.
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-HRKS8LT;Initial Catalog=TaskManagerDB;Integrated Security=True;TrustServerCertificate=True");

        // Opening a connection to the database.
        // This method checks the state of the connection and opens it if it is closed.
        public void openConnection()
        {
            if(sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }

        // Closing the connection to the database.
        // This method checks the state of the connection and closes it if it is open.
        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        // Get the SqlConnection object to connect to the database.
        // This method returns a sqlconnection object that can be used to query the database.
        public SqlConnection getConnection()
        {
            return sqlconnection;
        }
    }
}