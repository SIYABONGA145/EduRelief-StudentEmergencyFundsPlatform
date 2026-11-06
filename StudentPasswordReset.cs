using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentPasswordReset : Form
    {
        public StudentPasswordReset()
        {
            InitializeComponent();
            // Wire up the reset button manually
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPasswordReset.Text != txtConfirmPasswordReset.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = txtEmailAddress.Text.Trim();
            string newHash = DbHelper.HashPassword(txtNewPasswordReset.Text.Trim());

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Students SET PasswordHash = @Hash WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hash", newHash);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) MessageBox.Show("✅ Password reset successfully!");
                        else MessageBox.Show("❌ Email not found. Make sure you updated your profile with an email first.");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentLogin login = new StudentLogin();
            login.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1.Checked;
            txtEmailAddress.UseSystemPasswordChar = !show;
            txtNewPasswordReset.UseSystemPasswordChar = !show;
            txtConfirmPasswordReset.UseSystemPasswordChar = !show;
        }
    }
}