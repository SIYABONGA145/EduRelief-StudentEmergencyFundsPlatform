using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class AdminManageFunds : Form
    {
        public AdminManageFunds()
        {
            InitializeComponent();
        }

        private void AdminManageFunds_Load(object sender, EventArgs e)
        {
            LoadDonations();
        }

        private void LoadDonations()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        d.DonationID,
                        s.FirstName + ' ' + s.LastName AS 'Sponsor Name',
                        d.AmountDonated AS 'Amount (R)',
                        d.DonationDate AS 'Date'
                    FROM Donations d
                    INNER JOIN Sponsors s ON d.SponsorID = s.SponsorID
                    ORDER BY d.DonationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvDonations.DataSource = table;
                    dgvDonations.Columns["DonationID"].Visible = false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}