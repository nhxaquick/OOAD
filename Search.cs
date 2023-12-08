﻿using System.Data;
using System.Data.SqlClient;

namespace Student_Management
{
    public partial class Search : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private Dashboard prevForm;
        public string connectionSql = ("Data Source=PANHA\\SQLEXPRESS;Initial Catalog=db_student;Integrated Security=True;Persist Security Info=False;Pooling=False;");
        private object txt;
        //private ReadOnlySpan<char> searchTerm;

        public Search()
        {
            InitializeComponent();
            dvg1_CellContentClick(components, null);
            this.prevForm = prevForm;
        }

        //Load data
        public void LaodData()
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT * FROM students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dvg1.DataSource = dataTable;
            }
            dvg1.Refresh();
        }

        //DataGridView students (Load data)
        private void dvg1_CellContentClick(object sender, DataGridViewCellEventArgs? e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT * FROM students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dvg1.DataSource = dataTable;
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row in the DataGridView
                if (dvg1.SelectedRows.Count > 0)
                {
                    // Get the value from the "stu_id" column in the selected row
                    int selectedStuId = Convert.ToInt32(dvg1.SelectedRows[0].Cells["stu_id"].Value);

                    // Call a method to delete the data from SQL Server
                    DeleteData(selectedStuId);

                    // Refresh the DataGridView to reflect the changes
                    LaodData();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the delete operation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Delete data
        private void DeleteData(int selectedStuId)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "DELETE FROM students WHERE stu_id = @stu_id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@stu_id", selectedStuId);

                command.ExecuteNonQuery();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard student = new Dashboard();
            student.Show();

            // Show the previous form (DashboardForm)
            if (prevForm != null)
            {
                prevForm.Show();
            }
        }

        //Search btn
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from the TextBox
                string searchTerm = txtSearch.Text.Trim();

                // Call a method to perform the search based on the term
                SearchData(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search operation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchData(string searchTerm)
        {
            try
            {
                if (dvg1.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = "";

                    // Check if the search term is numeric
                    if (int.TryParse(searchTerm, out _))
                    {
                        string filterExpression = $"stu_id = {searchTerm} OR " +
                                                  $"stu_name LIKE '%{searchTerm}%' OR " +
                                                  $"stu_gender LIKE '%{searchTerm}%' OR " +
                                                  $"stu_province LIKE '%{searchTerm}%'";
                        dataTable.DefaultView.RowFilter = filterExpression;
                    }
                    else
                    {
                        // For non-numeric search terms, use LIKE
                        string filterExpression = $"stu_name LIKE '%{searchTerm}%' OR " +
                                                  $"stu_gender LIKE '%{searchTerm}%' OR " +
                                                  $"stu_province LIKE '%{searchTerm}%'";
                        dataTable.DefaultView.RowFilter = filterExpression;
                    }

                    // Refresh the DataGridView to reflect the changes
                    dvg1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search operation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //not fisnish yet search textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT * FROM students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dvg1.DataSource = dataTable;
            }
            dvg1.Refresh();
        }
    }
}
