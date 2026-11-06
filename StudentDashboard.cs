using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadRecentActivity();
        }

        private void LoadStats()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        ISNULL(SUM(a.AmountRequested), 0) AS TotalRequested,
                        ISNULL(SUM(CASE WHEN a.Status = 'Approved' THEN 1 ELSE 0 END), 0) AS ApprovedCount,
                        ISNULL(SUM(CASE WHEN a.Status = 'Pending' THEN 1 ELSE 0 END), 0) AS PendingCount
                    FROM Applications a
                    INNER JOIN Students s ON a.StudentID = s.StudentID
                    WHERE s.StudentNumber = @StudentNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentNumber", StudentLogin.LoggedStudentNumber);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label3.Text = $"Total Requested\n\nR {Convert.ToDecimal(reader["TotalRequested"]):N2}";
                                label4.Text = $"Approved\n\n{reader["ApprovedCount"]}";
                                label5.Text = $"Pending\n\n{reader["PendingCount"]}";
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading stats: " + ex.Message); }
                }
            }
        }

        private void LoadRecentActivity()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT TOP 5 
                        a.ApplicationDate AS 'Date Submitted', 
                        a.Reason AS 'Reason',
                        a.AmountRequested AS 'Amount (R)', 
                        a.Status 
                    FROM Applications a
                    INNER JOIN Students s ON a.StudentID = s.StudentID
                    WHERE s.StudentNumber = @StudentNumber
                    ORDER BY a.ApplicationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentNumber", StudentLogin.LoggedStudentNumber);
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridRecent.DataSource = table;

                        // Styling the grid to look clean
                        dataGridRecent.EnableHeadersVisualStyles = false;
                        dataGridRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(106, 123, 162);
                        dataGridRecent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridRecent.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                        dataGridRecent.DefaultCellStyle.SelectionBackColor = Color.White;
                        dataGridRecent.DefaultCellStyle.SelectionForeColor = Color.Black;
                        dataGridRecent.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
                        dataGridRecent.AllowUserToResizeRows = false;
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading recent activity: " + ex.Message); }
                }
            }
        }
    }
}