using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public partial class SponsorDonationForm : Form
    {
        public SponsorDonationForm()
        {
            InitializeComponent();
        }

        private void SponsorDonationForm_Load(object sender, EventArgs e)
        {
            cboPaymentMethod.Items.Add("Credit/Debit Card");
            cboPaymentMethod.Items.Add("Bank Transfer");
            cboPaymentMethod.SelectedIndex = 0;
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            panelPayment.Visible = false;
            lblProcessing.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text) || !decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid donation amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panelDonationDetails.Visible = false;
            panelPayment.Visible = true;
            panelPayment.BringToFront();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) || txtCardNumber.Text.Length < 16)
            {
                MessageBox.Show("Please enter a valid 16-digit card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblProcessing.Visible = true;
            btnPayNow.Enabled = false;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500; // 1.5 seconds
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                ProcessDonation();
            };
            timer.Start();
        }

        private void ProcessDonation()
        {
            decimal amount = decimal.Parse(txtAmount.Text);
            int sponsorID = SponsorLogin.SponsorSession.LoggedSponsorID;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Donations (SponsorID, AmountDonated, DonationDate) VALUES (@SponsorID, @Amount, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SponsorID", sponsorID);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Payment Successful!\n\nThank you for donating R {amount:N2}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtAmount.Clear();
                    txtCardNumber.Clear();
                    panelPayment.Visible = false;
                    panelDonationDetails.Visible = true;
                    btnPayNow.Enabled = true;
                    lblProcessing.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnPayNow.Enabled = true;
                    lblProcessing.Visible = false;
                }
            }
        }

        private void btnBackToDetails_Click(object sender, EventArgs e)
        {
            panelPayment.Visible = false;
            panelDonationDetails.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
    }
}