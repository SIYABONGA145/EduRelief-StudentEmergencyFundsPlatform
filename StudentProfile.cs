using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
            // CRITICAL: This tells the form to load the data when it opens
            this.Load += new EventHandler(StudentProfile_Load);
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT FirstName, LastName, Email, Phone, AcademicYear, Course, Address FROM Students WHERE StudentNumber = @StudentNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentNumber", StudentLogin.LoggedStudentNumber);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtTelNumber.Text = reader["Phone"].ToString();
                            txtAcademicYear.Text = reader["AcademicYear"].ToString();
                            txtCourse.Text = reader["Course"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtStudentNumber.Text = StudentLogin.LoggedStudentNumber;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading profile: " + ex.Message); }
                }
            }
        }

        // Save Button
        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"UPDATE Students SET FirstName=@FirstName, LastName=@LastName, Email=@Email, 
                                 Phone=@Phone, AcademicYear=@AcademicYear, Course=@Course, Address=@Address 
                                 WHERE StudentNumber=@StudentNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtTelNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@AcademicYear", txtAcademicYear.Text.Trim());
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@StudentNumber", StudentLogin.LoggedStudentNumber);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Profile updated successfully!", "Success");
                    }
                    catch (Exception ex) { MessageBox.Show("❌ Error updating profile: " + ex.Message); }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) pictureBox1.Image = new Bitmap(ofd.FileName);
        }
    }
}