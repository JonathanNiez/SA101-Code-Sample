using Microsoft.Data.SqlClient;

namespace SA101
{
    public partial class Form1 : Form
    {
        string connectionString = DbConnectionHelper.GetConnectionString();

        public Form1()
        {
            InitializeComponent();

        }

        private void loadBtn_Click(object sender, EventArgs e)
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
