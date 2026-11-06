namespace EduRelief
{
    partial class SponsorDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            this.pnlUnfunded = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblunfunded = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDonated = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            this.pnlUnfunded.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // panel1
            this.panel1.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHistory);
            this.panel1.Controls.Add(this.dataGridHistory);
            this.panel1.Controls.Add(this.pnlUnfunded);
            this.panel1.Controls.Add(this.pnlTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 667);
            this.panel1.TabIndex = 0;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 23);
            this.label2.Text = "Because of you, hope is more than just a word, it\'s a reality.";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 37);
            this.label1.Text = "Your kindness lights someone\'s darkest hour";

            // pnlTotal
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.label3);
            this.pnlTotal.Controls.Add(this.lblTotalDonated);
            this.pnlTotal.Location = new System.Drawing.Point(45, 120);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(300, 120);
            this.pnlTotal.TabIndex = 2;

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Text = "Total Donated";

            this.lblTotalDonated.AutoSize = true;
            this.lblTotalDonated.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalDonated.ForeColor = System.Drawing.Color.FromArgb(106, 123, 162);
            this.lblTotalDonated.Location = new System.Drawing.Point(20, 55);
            this.lblTotalDonated.Text = "R 0.00";

            // pnlUnfunded
            this.pnlUnfunded.BackColor = System.Drawing.Color.White;
            this.pnlUnfunded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnfunded.Controls.Add(this.label4);
            this.pnlUnfunded.Controls.Add(this.lblunfunded);
            this.pnlUnfunded.Location = new System.Drawing.Point(370, 120);
            this.pnlUnfunded.Name = "pnlUnfunded";
            this.pnlUnfunded.Size = new System.Drawing.Size(300, 120);
            this.pnlUnfunded.TabIndex = 0;

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Text = "Students Unfunded";

            this.lblunfunded.AutoSize = true;
            this.lblunfunded.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblunfunded.ForeColor = System.Drawing.Color.Red;
            this.lblunfunded.Location = new System.Drawing.Point(20, 55);
            this.lblunfunded.Text = "0";

            // lblHistory
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblHistory.Location = new System.Drawing.Point(45, 270);
            this.lblHistory.Text = "Your Transactions";

            // dataGridHistory
            this.dataGridHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Location = new System.Drawing.Point(45, 310);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.Size = new System.Drawing.Size(1050, 300);
            this.dataGridHistory.TabIndex = 1;

            // SponsorDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SponsorDashboard";
            this.Text = "SponsorDashboard";
            this.Load += new System.EventHandler(this.SponsorDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.pnlUnfunded.ResumeLayout(false);
            this.pnlUnfunded.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblunfunded;
        private System.Windows.Forms.DataGridView dataGridHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUnfunded;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDonated;
        private System.Windows.Forms.Label label4;
    }
}