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

        private void CreateTable()
        {
            string query = @"
                        CREATE TABLE Students (
                        Student_id INT PRIMARY KEY IDENTITY,
                        FirstName NVARCHAR(100) NOT NULL,
                        LastName NVARCHAR(100) NOT NULL,
                        Age INT NOT NULL
                        )";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Table created successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating table: {ex.Message}");

            }
        }

        private void DropTable()
        {
            string query = "DROP TABLE Students";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Table dropped successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dropping table: {ex.Message}");
            }
        }

        private void CheckConnection()
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

        private void InsertStudent()
        {
            string firstName = firstNameTB.Text;
            string lastName = lastNameTB.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Fields must not be empty");
                return;
            }

            if (!int.TryParse(ageTB.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string query = "INSERT INTO Students (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Age", age);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting student: {ex.Message}");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DropTable();
        }

        private void checkConnectionBtn_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }
        private void goToForm2Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertStudent();
        }
    }
}
