using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentRequestHistory : Form
    {
        public StudentRequestHistory()
        {
            InitializeComponent();
        }

        private void StudentRequestHistory_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
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

                        // THIS CLEARS THE DUMMY COLUMNS YOU HAD IN THE DESIGNER
                        dataGridView1.Columns.Clear();
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = table;

                        // Styling
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.EnableHeadersVisualStyles = false;
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(106, 123, 162);
                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridView1.ColumnHeadersHeight = 40;
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 237, 200);
                        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading history: " + ex.Message); }
                }
            }
        }
    }
}