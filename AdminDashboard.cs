using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. Total Applications (Label6)
                    string totalAppsQuery = "SELECT COUNT(*) FROM Applications";
                    using (SqlCommand cmd = new SqlCommand(totalAppsQuery, conn))
                    {
                        label6.Text = cmd.ExecuteScalar().ToString();
                    }

                    // 2. Funds Awarded (Label7)
                    string fundsQuery = "SELECT ISNULL(SUM(AmountRequested), 0) FROM Applications WHERE Status = 'Approved'";
                    using (SqlCommand cmd = new SqlCommand(fundsQuery, conn))
                    {
                        label7.Text = "R " + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");
                    }

                    // 3. Pending Requests (Label8)
                    string pendingQuery = "SELECT COUNT(*) FROM Applications WHERE Status = 'Pending'";
                    using (SqlCommand cmd = new SqlCommand(pendingQuery, conn))
                    {
                        label8.Text = cmd.ExecuteScalar().ToString();
                    }

                    // 4. Recent Requests Grid
                    string recentQuery = @"
                        SELECT TOP 10 
                            s.FirstName + ' ' + s.LastName AS 'Student Name',
                            a.ApplicationDate AS 'Submission Date',
                            a.AmountRequested AS 'Amount Requested',
                            a.Status
                        FROM Applications a
                        INNER JOIN Students s ON a.StudentID = s.StudentID
                        ORDER BY a.ApplicationDate DESC";

                    using (SqlCommand cmd = new SqlCommand(recentQuery, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridRecent.Columns.Clear();
                        dataGridRecent.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}