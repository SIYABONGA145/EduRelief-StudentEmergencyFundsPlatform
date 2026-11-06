namespace EduRelief
{
    partial class StudentRequestHistory
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
            this.dateTimePickerSubmission = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.submissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundsPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proofOfEnrollment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proofOfRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affidavit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePickerSubmission);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 667);
            this.panel1.TabIndex = 0;

            this.dateTimePickerSubmission.Enabled = false;
            this.dateTimePickerSubmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSubmission.Location = new System.Drawing.Point(385, 94);
            this.dateTimePickerSubmission.Name = "dateTimePickerSubmission";
            this.dateTimePickerSubmission.Size = new System.Drawing.Size(188, 27);
            this.dateTimePickerSubmission.TabIndex = 1;

            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.submissionDate,
            this.reasonForRequest,
            this.reqestedAmount,
            this.fundsPurpose,
            this.proofOfEnrollment,
            this.proofOfRegistration,
            this.studentCard,
            this.affidavit,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 445);
            this.dataGridView1.TabIndex = 0;

            this.submissionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.submissionDate.HeaderText = "Date Submitted";
            this.submissionDate.MinimumWidth = 6;
            this.submissionDate.Name = "submissionDate";

            this.reasonForRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reasonForRequest.HeaderText = "Reason for Request";
            this.reasonForRequest.MinimumWidth = 6;
            this.reasonForRequest.Name = "reasonForRequest";

            this.reqestedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reqestedAmount.HeaderText = "Requested Amount";
            this.reqestedAmount.MinimumWidth = 6;
            this.reqestedAmount.Name = "reqestedAmount";

            this.fundsPurpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fundsPurpose.HeaderText = "Purpose";
            this.fundsPurpose.MinimumWidth = 6;
            this.fundsPurpose.Name = "fundsPurpose";

            this.proofOfEnrollment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proofOfEnrollment.HeaderText = "Enrollment Proof";
            this.proofOfEnrollment.MinimumWidth = 6;
            this.proofOfEnrollment.Name = "proofOfEnrollment";

            this.proofOfRegistration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proofOfRegistration.HeaderText = "Registration Proof";
            this.proofOfRegistration.MinimumWidth = 6;
            this.proofOfRegistration.Name = "proofOfRegistration";

            this.studentCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentCard.HeaderText = "Student Card";
            this.studentCard.MinimumWidth = 6;
            this.studentCard.Name = "studentCard";

            this.affidavit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.affidavit.HeaderText = "Affidavit";
            this.affidavit.MinimumWidth = 6;
            this.affidavit.Name = "affidavit";

            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";

            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 28);
            this.comboBox1.TabIndex = 2;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status :";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "From :";

            this.button1.Location = new System.Drawing.Point(937, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;

            this.button2.Location = new System.Drawing.Point(1037, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;

            this.button3.Location = new System.Drawing.Point(937, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;

            this.button4.Location = new System.Drawing.Point(1037, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funding History";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRequestHistory";
            this.Text = "StudentRequestHistory";
            this.Load += new System.EventHandler(this.StudentRequestHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqestedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundsPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn proofOfEnrollment;
        private System.Windows.Forms.DataGridViewTextBoxColumn proofOfRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn affidavit;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DateTimePicker dateTimePickerSubmission;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}