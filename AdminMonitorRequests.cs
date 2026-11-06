using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class AdminMonitorRequests : Form
    {
        public AdminMonitorRequests()
        {
            InitializeComponent();
        }

        private void AdminMonitorRequests_Load(object? sender, EventArgs e)
        {
            LoadAllRequests();
        }

        // Fixed: Added 'static' to fix the warning
        private static void LoadAllRequests()
        {
            using SqlConnection conn = DbHelper.GetConnection();
            string query = @"
                SELECT 
                    s.StudentNumber AS 'Student No',
                    s.FirstName + ' ' + s.LastName AS 'Name',
                    a.Reason AS 'Reason',
                    a.AmountRequested AS 'Amount (R)',
                    a.ApplicationDate AS 'Date',
                    a.Status
                FROM Applications a
                INNER JOIN Students s ON a.StudentID = s.StudentID
                ORDER BY a.ApplicationDate DESC";

            using SqlCommand cmd = new(query, conn);
            SqlDataAdapter adapter = new(cmd);
            DataTable table = new();
            adapter.Fill(table);

            // Add a DataGridView to this form in the designer and set its DataSource to table.
        }
    }
}