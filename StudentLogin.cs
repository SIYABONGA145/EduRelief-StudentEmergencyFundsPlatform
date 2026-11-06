using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentLogin : Form
    {
        public static string LoggedStudentNumber { get; set; } = string.Empty;

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void StudentLogin_Load(object? sender, EventArgs e)
        {
            panel2.Location = new Point(423, 313);
            panel3.Location = new Point(423, 313);
            panel2.BringToFront();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            WelcomePage welcomePage = new();
            welcomePage.Show();
            this.Close();
        }

        private void BtnLogin_Click(object? sender, EventArgs e) { panel2.BringToFront(); }
        private void BtnSignUp_Click(object? sender, EventArgs e) { panel3.BringToFront(); panel3.Visible = true; }

        private void LinkLabel2_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel2.BringToFront();
        }

        private void CheckBox1_CheckedChanged(object? sender, EventArgs e) { txtStudentPasswordLogin.UseSystemPasswordChar = !checkBox1.Checked; }
        private void CheckBox3_CheckedChanged(object? sender, EventArgs e) { txtPasswordReg.UseSystemPasswordChar = !checkBox3.Checked; txtPasswordConfirmReg.UseSystemPasswordChar = !checkBox3.Checked; }
        private void PictureBox4_Click(object? sender, EventArgs e) { Application.Exit(); }
        private void TextBox6_TextChanged(object? sender, EventArgs e) { }
        private void TxtFirstNameReg_TextChanged(object? sender, EventArgs e) { }

        private void LinkLabel1_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentPasswordReset reset = new();
            reset.Show();
            this.Hide();
        }

        private void Button5_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNoLogin.Text) || txtStudentNoLogin.Text.Trim().Length != 9)
            {
                MessageBox.Show("Student Number must be exactly 9 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStudentPasswordLogin.Text))
            {
                MessageBox.Show("Please enter your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentNumber = txtStudentNoLogin.Text.Trim();
            string hashedPassword = DbHelper.HashPassword(txtStudentPasswordLogin.Text.Trim());

            using SqlConnection conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Students WHERE StudentNumber = @StudentNumber AND PasswordHash = @PasswordHash";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    LoggedStudentNumber = studentNumber;
                    StudentMainForm mainForm = new();
                    mainForm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("❌ Invalid Student Number or Password."); }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameReg.Text) || string.IsNullOrWhiteSpace(txtLastNameReg.Text) || string.IsNullOrWhiteSpace(txtStudentNumReg.Text) || string.IsNullOrWhiteSpace(txtPasswordReg.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtStudentNumReg.Text.Trim().Length != 9)
            {
                MessageBox.Show("Student Number must be exactly 9 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPasswordReg.Text != txtPasswordConfirmReg.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentNumber = txtStudentNumReg.Text.Trim();
            string firstName = txtFirstNameReg.Text.Trim();
            string lastName = txtLastNameReg.Text.Trim();
            string hashedPassword = DbHelper.HashPassword(txtPasswordReg.Text.Trim());

            using SqlConnection conn = DbHelper.GetConnection();
            try
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Students WHERE StudentNumber = @StudentNumber";
                using SqlCommand checkCmd = new(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);

                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("⚠️ Student number already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Students (StudentNumber, PasswordHash, FirstName, LastName) VALUES (@StudentNumber, @PasswordHash, @FirstName, @LastName)";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.ExecuteNonQuery();

                MessageBox.Show("✅ Student registered successfully! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel2.BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("❌ Registration failed: " + ex.Message); }
        }
    }
}