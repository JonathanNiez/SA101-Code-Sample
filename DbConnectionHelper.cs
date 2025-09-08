using Microsoft.Data.SqlClient;

namespace SA101
{
    public static class DbConnectionHelper
    {
        private static readonly string connectionString =
            "Data Source=JONATHANNIEZ\\SQLEXPRESS;Initial Catalog=SA101;Integrated Security=True;Encrypt=False";

        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static void CheckConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed: {ex.Message}");
                }
            }
        }
    }
}
