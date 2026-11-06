namespace EduRelief
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridRecent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecent)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // panel1
            this.panel1.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 667);
            this.panel1.TabIndex = 0;

            // panel5
            this.panel5.BackColor = System.Drawing.Color.FromArgb(255, 237, 200);
            this.panel5.Controls.Add(this.dataGridRecent);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(24, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1102, 290);
            this.panel5.TabIndex = 13;

            // dataGridRecent
            this.dataGridRecent.AllowUserToAddRows = false;
            this.dataGridRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRecent.BackgroundColor = System.Drawing.Color.FromArgb(255, 237, 200);
            this.dataGridRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecent.Location = new System.Drawing.Point(23, 80);
            this.dataGridRecent.Name = "dataGridRecent";
            this.dataGridRecent.ReadOnly = true;
            this.dataGridRecent.RowHeadersVisible = false;
            this.dataGridRecent.RowHeadersWidth = 51;
            this.dataGridRecent.Size = new System.Drawing.Size(1056, 190);
            this.dataGridRecent.TabIndex = 10;

            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(23, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Your latest requests and updates";

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Recent Activity";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome back! here's an overview of your requests and account.";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";

            // panel4 (Pending)
            this.panel4.BackColor = System.Drawing.Color.FromArgb(255, 237, 200);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(797, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 142);
            this.panel4.TabIndex = 2;

            // label5
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.TabIndex = 7;
            this.label5.Text = "Pending";

            // panel3 (Approved)
            this.panel3.BackColor = System.Drawing.Color.FromArgb(255, 237, 200);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(413, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 142);
            this.panel3.TabIndex = 1;

            // label4
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.TabIndex = 6;
            this.label4.Text = "Approved";

            // panel2 (Total Requested)
            this.panel2.BackColor = System.Drawing.Color.FromArgb(255, 237, 200);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(24, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 142);
            this.panel2.TabIndex = 0;

            // label3
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Requested";

            // StudentDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load); // <--- THIS WAS MISSING
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecent)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridRecent;
    }
}