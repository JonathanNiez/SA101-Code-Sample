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

        private void backBtn_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
