namespace EduRelief
{
    partial class SponsorDonationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDonationDetails = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnBackToDetails = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDonationDetails.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();

            // panel1
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel1.Controls.Add(this.panelPayment);
            this.panel1.Controls.Add(this.panelDonationDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 667);
            this.panel1.TabIndex = 0;

            // panelDonationDetails
            this.panelDonationDetails.BackColor = System.Drawing.Color.White;
            this.panelDonationDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDonationDetails.Controls.Add(this.label5);
            this.panelDonationDetails.Controls.Add(this.txtAmount);
            this.panelDonationDetails.Controls.Add(this.label11);
            this.panelDonationDetails.Controls.Add(this.label10);
            this.panelDonationDetails.Controls.Add(this.cboPaymentMethod);
            this.panelDonationDetails.Controls.Add(this.btnConfirm);
            this.panelDonationDetails.Controls.Add(this.btnCancel);
            this.panelDonationDetails.Location = new System.Drawing.Point(250, 100);
            this.panelDonationDetails.Name = "panelDonationDetails";
            this.panelDonationDetails.Size = new System.Drawing.Size(600, 400);
            this.panelDonationDetails.TabIndex = 0;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 40);
            this.label5.Text = "Make a Donation";

            // label11
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label11.Location = new System.Drawing.Point(50, 120);
            this.label11.Text = "Amount (R):";

            // txtAmount
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmount.Location = new System.Drawing.Point(50, 150);
            this.txtAmount.Size = new System.Drawing.Size(500, 34);
            this.txtAmount.Text = "0.00";

            // label10
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label10.Location = new System.Drawing.Point(50, 210);
            this.label10.Text = "Payment Method:";

            // cboPaymentMethod
            this.cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPaymentMethod.Location = new System.Drawing.Point(50, 240);
            this.cboPaymentMethod.Size = new System.Drawing.Size(500, 31);

            // btnConfirm
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(106, 123, 162);
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(50, 310);
            this.btnConfirm.Size = new System.Drawing.Size(240, 45);
            this.btnConfirm.Text = "Proceed to Payment";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnCancel.Location = new System.Drawing.Point(310, 310);
            this.btnCancel.Size = new System.Drawing.Size(240, 45);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // panelPayment (FAKE GATEWAY)
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(255, 237, 200);
            this.panelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPayment.Controls.Add(this.lblProcessing);
            this.panelPayment.Controls.Add(this.btnPayNow);
            this.panelPayment.Controls.Add(this.btnBackToDetails);
            this.panelPayment.Controls.Add(this.txtCardNumber);
            this.panelPayment.Controls.Add(this.label6);
            this.panelPayment.Controls.Add(this.label7);
            this.panelPayment.Controls.Add(this.label8);
            this.panelPayment.Controls.Add(this.label9);
            this.panelPayment.Location = new System.Drawing.Point(250, 100);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(600, 400);
            this.panelPayment.TabIndex = 1;

            // label9
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(50, 40);
            this.label9.Text = "Secure Payment Gateway";

            // label8
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label8.Location = new System.Drawing.Point(50, 120);
            this.label8.Text = "Card Number:";

            // txtCardNumber
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCardNumber.Location = new System.Drawing.Point(50, 150);
            this.txtCardNumber.Size = new System.Drawing.Size(500, 34);
            this.txtCardNumber.Text = "1234 5678 9101 1121";

            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(50, 210);
            this.label7.Text = "Expiry: 12/28     CVV: ***";

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(50, 250);
            this.label6.Text = "*This is a simulated payment environment.";

            // btnPayNow
            this.btnPayNow.BackColor = System.Drawing.Color.FromArgb(106, 123, 162);
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(50, 310);
            this.btnPayNow.Size = new System.Drawing.Size(240, 45);
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);

            // btnBackToDetails
            this.btnBackToDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackToDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnBackToDetails.Location = new System.Drawing.Point(310, 310);
            this.btnBackToDetails.Size = new System.Drawing.Size(240, 45);
            this.btnBackToDetails.Text = "Back";
            this.btnBackToDetails.UseVisualStyleBackColor = false;
            this.btnBackToDetails.Click += new System.EventHandler(this.btnBackToDetails_Click);

            // lblProcessing
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProcessing.ForeColor = System.Drawing.Color.Green;
            this.lblProcessing.Location = new System.Drawing.Point(50, 270);
            this.lblProcessing.Text = "Processing Payment...";

            // SponsorDonationForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SponsorDonationForm";
            this.Text = "SponsorDonationForm";
            this.Load += new System.EventHandler(this.SponsorDonationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelDonationDetails.ResumeLayout(false);
            this.panelDonationDetails.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDonationDetails;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;

        // Payment Panel Controls
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnBackToDetails;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}