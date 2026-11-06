using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class AdminStudentsVerification : Form
    {
        public AdminStudentsVerification()
        {
            InitializeComponent();
        }

        private void AdminStudentsVerification_Load(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void LoadApplications()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        a.ApplicationID,
                        s.StudentNumber,
                        s.FirstName + ' ' + s.LastName AS StudentName,
                        a.AmountRequested,
                        a.ApplicationDate,
                        a.Status
                    FROM Applications a
                    INNER JOIN Students s ON a.StudentID = s.StudentID
                    ORDER BY a.ApplicationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridVerify.DataSource = table;
                    dataGridVerify.Columns["ApplicationID"].Visible = false; // Hide ID column
                }
            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus("Approved");
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus("Rejected");
        }

        private void UpdateApplicationStatus(string status)
        {
            if (dataGridVerify.SelectedRows.Count > 0)
            {
                int appID = Convert.ToInt32(dataGridVerify.SelectedRows[0].Cells["ApplicationID"].Value);

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = "UPDATE Applications SET Status = @Status WHERE ApplicationID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@ID", appID);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Application {status} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadApplications(); // Refresh the grid
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
    }
}