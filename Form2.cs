using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SA101
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        private readonly string connectionString = DbConnectionHelper.GetConnectionString();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void LoadStudents()
        {
            string query = "SELECT * FROM Students";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        studentsDGV.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }
        private void UpdateStudent()
        {
            if (studentsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            int studentId = Convert.ToInt32(studentsDGV.SelectedRows[0].Cells["StudentID"].Value);
            string firstName = firstNameTB.Text;
            string lastName = lastNameTB.Text;
            if (!int.TryParse(ageTB.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string query = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Age = @Age WHERE StudentID = @StudentID";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully.");
                }
                LoadStudents(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
            }
        }
        private void DeleteStudent()
        {
            if (studentsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            int studentId = Convert.ToInt32(studentsDGV.SelectedRows[0].Cells["StudentID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            string query = "DELETE FROM Students WHERE StudentID = @StudentID";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully.");
                }
                LoadStudents(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void studentsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (studentsDGV.SelectedRows.Count > 0)
            {
                var row = studentsDGV.SelectedRows[0];
                firstNameTB.Text = row.Cells["FirstName"].Value?.ToString();
                lastNameTB.Text = row.Cells["LastName"].Value?.ToString();
                ageTB.Text = row.Cells["Age"].Value?.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }
    }
}
