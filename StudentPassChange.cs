using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentPassChange : Form
    {
        public StudentPassChange()
        {
            InitializeComponent();
            // Wire up the save button manually since it was missing in designer
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtNewPasswordConfirmation.Text)
            {
                MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newHash = DbHelper.HashPassword(txtNewPassword.Text.Trim());

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Students SET PasswordHash = @Hash WHERE StudentNumber = @StudentNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hash", newHash);
                    cmd.Parameters.AddWithValue("@StudentNumber", StudentLogin.LoggedStudentNumber);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Password updated successfully!", "Success");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show("❌ Error: " + ex.Message); }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1.Checked;
            txtCurrentPassword.UseSystemPasswordChar = !show;
            txtNewPassword.UseSystemPasswordChar = !show;
            txtNewPasswordConfirmation.UseSystemPasswordChar = !show;
        }
    }
}