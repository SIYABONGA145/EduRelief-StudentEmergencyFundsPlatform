using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Close();
            welcomePage.Show();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(423, 313);
            panel3.Location = new Point(423, 313);
            panel2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel3.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel2.BringToFront();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = !checkBox1.Checked;
            textBox6.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // LOGIN BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please Enter your Admin ID");
                textBox2.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length != 9 || !long.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Admin ID must be exactly 9 digits and contain numbers only!");
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please Enter your Password!");
                textBox1.Focus();
                return;
            }

            string adminCode = textBox2.Text.Trim();
            string hashedPassword = DbHelper.HashPassword(textBox1.Text.Trim());

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Admins WHERE AdminCode = @AdminCode AND PasswordHash = @PasswordHash";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminCode", adminCode);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                    try
                    {
                        conn.Open();
                        int matchCount = (int)cmd.ExecuteScalar();

                        if (matchCount == 1)
                        {
                            AdminMainForm adminMainForm = new AdminMainForm();
                            this.Close();
                            adminMainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("❌ Invalid admin ID or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // REGISTER BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox7.Text.Trim().Length != 9 || !long.TryParse(textBox7.Text, out _))
            {
                MessageBox.Show("Admin ID must be exactly 9 digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string adminCode = textBox7.Text.Trim();
            string fullName = textBox3.Text.Trim() + " " + textBox4.Text.Trim();
            string hashedPassword = DbHelper.HashPassword(textBox5.Text.Trim());

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Admins WHERE AdminCode = @AdminCode";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@AdminCode", adminCode);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("⚠️ Admin ID already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "INSERT INTO Admins (AdminCode, Name, PasswordHash) VALUES (@AdminCode, @Name, @PasswordHash)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AdminCode", adminCode);
                        cmd.Parameters.AddWithValue("@Name", fullName);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Admin registered successfully! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel2.BringToFront();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}