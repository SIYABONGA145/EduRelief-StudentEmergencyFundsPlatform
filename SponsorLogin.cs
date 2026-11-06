using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class SponsorLogin : Form
    {
        public static class SponsorSession
        {
            public static int LoggedSponsorID { get; set; }
        }

        public SponsorLogin()
        {
            InitializeComponent();
        }

        private void SponsorLogin_Load(object? sender, EventArgs e)
        {
            panel2.Location = new Point(423, 313);
            panel3.Location = new Point(423, 313);
            panel2.BringToFront();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            WelcomePage welcomeForm = new();
            welcomeForm.Show();
            this.Close();
        }

        private void Button2_Click(object? sender, EventArgs e) { panel2.BringToFront(); }
        private void Button3_Click(object? sender, EventArgs e) { panel3.BringToFront(); panel3.Visible = true; }

        private void LinkLabel3_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel2.BringToFront();
        }

        private void CheckBox1_CheckedChanged(object? sender, EventArgs e) { textBox2.UseSystemPasswordChar = !checkBox1.Checked; }
        private void CheckBox3_CheckedChanged(object? sender, EventArgs e) { textBox5.UseSystemPasswordChar = !checkBox3.Checked; textBox8.UseSystemPasswordChar = !checkBox3.Checked; }
        private void LinkLabel1_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e) { MessageBox.Show("Please contact support.", "Info"); }

        private void Button4_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !textBox1.Text.Contains('@'))
            {
                MessageBox.Show("Please Enter a Valid Email Address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please Enter your Password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = textBox1.Text.Trim();
            string hashedPassword = DbHelper.HashPassword(textBox2.Text.Trim());

            using SqlConnection conn = DbHelper.GetConnection();
            string query = "SELECT SponsorID FROM Sponsors WHERE Email = @Email AND PasswordHash = @PasswordHash";
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

            try
            {
                conn.Open();
                object? result = cmd.ExecuteScalar();

                if (result != null)
                {
                    SponsorSession.LoggedSponsorID = Convert.ToInt32(result);
                    SponsorMainForm sponsorMainForm = new();
                    sponsorMainForm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("❌ Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show("❌ Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Button5_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!textBox6.Text.Contains('@'))
            {
                MessageBox.Show("Please Enter a Valid Email Address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox5.Text != textBox8.Text)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = textBox6.Text.Trim();
            string firstName = textBox3.Text.Trim();
            string lastName = textBox4.Text.Trim();
            string hashedPassword = DbHelper.HashPassword(textBox5.Text.Trim());

            using SqlConnection conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Sponsors WHERE Email = @Email";
                using SqlCommand checkCmd = new(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("⚠️ Email already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Sponsors (Email, PasswordHash, FirstName, LastName) VALUES (@Email, @PasswordHash, @FirstName, @LastName)";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);

                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Sponsor registered successfully! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel2.BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("❌ Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}