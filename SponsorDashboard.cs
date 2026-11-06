using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class SponsorDashboard : Form
    {
        public SponsorDashboard()
        {
            InitializeComponent();
        }

        private void SponsorDashboard_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadDonationHistory();
        }

        private void LoadStats()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Get Total Donated by this Sponsor
                    string totalQuery = "SELECT ISNULL(SUM(AmountDonated), 0) FROM Donations WHERE SponsorID = @SponsorID";
                    using (SqlCommand cmd = new SqlCommand(totalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SponsorID", SponsorLogin.SponsorSession.LoggedSponsorID);
                        decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalDonated.Text = "R " + total.ToString("N2");
                    }

                    // Get Total Unfunded Students (Pending requests globally)
                    string unfundedQuery = "SELECT COUNT(*) FROM Applications WHERE Status = 'Pending'";
                    using (SqlCommand cmd = new SqlCommand(unfundedQuery, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        lblunfunded.Text = count.ToString();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error loading stats: " + ex.Message); }
            }
        }

        private void LoadDonationHistory()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        DonationDate AS 'Date', 
                        AmountDonated AS 'Amount (R)' 
                    FROM Donations 
                    WHERE SponsorID = @SponsorID 
                    ORDER BY DonationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SponsorID", SponsorLogin.SponsorSession.LoggedSponsorID);
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridHistory.DataSource = table;

                        // Styling
                        dataGridHistory.EnableHeadersVisualStyles = false;
                        dataGridHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(106, 123, 162);
                        dataGridHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                        dataGridHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 237, 200);
                        dataGridHistory.DefaultCellStyle.SelectionForeColor = Color.Black;
                        dataGridHistory.RowHeadersVisible = false;
                        dataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading history: " + ex.Message); }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblunfunded_Click(object sender, EventArgs e) { }
    }
}