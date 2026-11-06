using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class StudentRequest : Form
    {
        public StudentRequest()
        {
            InitializeComponent();
        }

        private void StudentRequest_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Relief funds");
            comboBox1.Items.Add("Study Material");
            comboBox1.Items.Add("Utilities");
            comboBox1.Items.Add("Transport");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0 || numericUpDown1.Value > 500)
            {
                MessageBox.Show("Amount must be between R1 and R500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = comboBox1.SelectedItem?.ToString();
            string purpose = txtRequestPurpose.Text.Trim();
            decimal amountRequested = numericUpDown1.Value;

            if (string.IsNullOrWhiteSpace(purpose) || purpose == "Briefly describe how you will use the funds ...")
            {
                MessageBox.Show("Please describe how you will use the funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to request R {amountRequested:N2}?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    int studentID = 0;
                    using (SqlCommand idCmd = new SqlCommand("SELECT StudentID FROM Students WHERE StudentNumber = @StudentNumber", conn))
                    {
                        idCmd.Parameters.AddWithValue("@StudentNumber", StudentLogin.LoggedStudentNumber);
                        object res = idCmd.ExecuteScalar();
                        if (res != null) studentID = Convert.ToInt32(res);
                    }

                    string insertQuery = @"INSERT INTO Applications (StudentID, AmountRequested, Reason, ApplicationDate, Status) 
                                           VALUES (@StudentID, @AmountRequested, @Reason, @ApplicationDate, 'Pending')";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@AmountRequested", amountRequested);
                        cmd.Parameters.AddWithValue("@Reason", reason);
                        cmd.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        numericUpDown1.Value = 0;
                        txtRequestPurpose.Text = "Briefly describe how you will use the funds ...";
                    }
                }
                catch (Exception ex) { MessageBox.Show("❌ Submission failed: " + ex.Message); }
            }
        }

        // File upload placeholders to prevent crashes
        private void label10_Click(object sender, EventArgs e) { }
        private void textBox1_Enter(object sender, EventArgs e) { }
        private void textBox1_Leave(object sender, EventArgs e) { }
        private void lblProofOfEnrollment_DragEnter(object sender, DragEventArgs e) { }
        private void lblProofOfEnrollment_DragDrop(object sender, DragEventArgs e) { }
        private void lblProofOfRegistration_DragEnter(object sender, DragEventArgs e) { }
        private void lblProofOfRegistration_DragDrop(object sender, DragEventArgs e) { }
        private void lblStudentCard_DragEnter(object sender, DragEventArgs e) { }
        private void lblStudentCard_DragDrop(object sender, DragEventArgs e) { }
        private void lblAffidavit_DragEnter(object sender, DragEventArgs e) { }
        private void lblAffidavit_DragDrop(object sender, DragEventArgs e) { }
        private void btnProofOfEnrollment_Click(object sender, EventArgs e) { }
        private void btnProofOfRegistration_Click(object sender, EventArgs e) { }
        private void btnStudentCard_Click(object sender, EventArgs e) { }
        private void btnAffidavit_Click(object sender, EventArgs e) { }
        private void lblStudentCard_Click(object sender, EventArgs e) { }
        private void lblProofOfEnrollment_Click(object sender, EventArgs e) { }
    }
}