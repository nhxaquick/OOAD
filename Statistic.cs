using System.Data;
using System.Data.SqlClient;

namespace Student_Management
{
    public partial class Statistic : Form
    {
        public string connectionSql = ("Data Source=PANHA\\SQLEXPRESS;Initial Catalog=db_student;Integrated Security=True;Persist Security Info=False;Pooling=False;");

        public Statistic()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        public void ChartStatisticsClick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();

                string query = "SELECT stu_gender, COUNT(*) AS RecordCount FROM students GROUP BY stu_gender";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                chart.DataSource = dataTable;

                chart.Series["Series1"].Points.DataBindXY(dataTable.Rows, "stu_gender", dataTable.Rows, "RecordCount");

                //chart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }

        private void Statistic_Load_1(object sender, EventArgs e)
        {
            ChartStatisticsClick(sender, e);
        }
    }
}


