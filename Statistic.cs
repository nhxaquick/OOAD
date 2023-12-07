using System.Data;
using System.Data.SqlClient;

namespace Student_Management
{
    public partial class Statistic : Form
    {
        string connectionSql = @"Data Source=DESKTOP-6QJ7MGV\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
        private object chartStatistics;
        private object DataSource;

        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSql);
            connection.Open();

            string query = "SELECT stu_id, COUNT(*) AS RecordCount FROM students GROUP BY stu_id";

            //string query = "SELECT COUNT(*) AS RecordCount FROM students";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            //chartStatistics.DataSource = dataTable;

        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Dashboard dashboard = new Dashboard();
        //    dashboard.Show();
        //}
    }
}


