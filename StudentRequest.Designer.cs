namespace EduRelief
{
    partial class StudentRequest
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAffidavit = new System.Windows.Forms.Button();
            this.btnStudentCard = new System.Windows.Forms.Button();
            this.btnProofOfRegistration = new System.Windows.Forms.Button();
            this.btnProofOfEnrollment = new System.Windows.Forms.Button();
            this.lblAffidavit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudentCard = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProofOfRegistration = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtRequestPurpose = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProofOfEnrollment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();

            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 647);
            this.panel1.TabIndex = 0;

            this.panel4.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnSubmitRequest);
            this.panel4.Location = new System.Drawing.Point(93, 946);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(919, 187);
            this.panel4.TabIndex = 6;

            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(757, 44);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "I confirm that the information provided is accurate and complete. I understand that it will be kept confidential\r\nand used only to evaluate my funding request.";
            this.checkBox1.UseVisualStyleBackColor = true;

            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View full Terms && Conditions";

            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(8, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Terms and Conditions";

            this.btnSubmitRequest.BackColor = System.Drawing.Color.FromArgb(106, 123, 162);
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRequest.Location = new System.Drawing.Point(3, 135);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(911, 47);
            this.btnSubmitRequest.TabIndex = 5;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(672, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Submit the new request of funds. Your personal details from your profile will bw used automatically. ";

            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(93, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Request Funds";

            this.panel2.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnAffidavit);
            this.panel2.Controls.Add(this.btnStudentCard);
            this.panel2.Controls.Add(this.btnProofOfRegistration);
            this.panel2.Controls.Add(this.btnProofOfEnrollment);
            this.panel2.Controls.Add(this.lblAffidavit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblStudentCard);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.lblProofOfRegistration);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.txtRequestPurpose);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblProofOfEnrollment);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(93, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 804);
            this.panel2.TabIndex = 0;

            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(9, 475);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(428, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Click to upload or drag and drop\\nPDF, JPG, PNG up to 10MB";
            this.label15.Visible = false;

            this.btnAffidavit.Location = new System.Drawing.Point(627, 742);
            this.btnAffidavit.Name = "btnAffidavit";
            this.btnAffidavit.Size = new System.Drawing.Size(143, 29);
            this.btnAffidavit.TabIndex = 3;
            this.btnAffidavit.Text = "Upload File";
            this.btnAffidavit.UseVisualStyleBackColor = true;
            this.btnAffidavit.Click += new System.EventHandler(this.btnAffidavit_Click);

            this.btnStudentCard.Location = new System.Drawing.Point(627, 668);
            this.btnStudentCard.Name = "btnStudentCard";
            this.btnStudentCard.Size = new System.Drawing.Size(143, 29);
            this.btnStudentCard.TabIndex = 2;
            this.btnStudentCard.Text = "Upload File";
            this.btnStudentCard.UseVisualStyleBackColor = true;
            this.btnStudentCard.Click += new System.EventHandler(this.btnStudentCard_Click);

            this.btnProofOfRegistration.Location = new System.Drawing.Point(627, 592);
            this.btnProofOfRegistration.Name = "btnProofOfRegistration";
            this.btnProofOfRegistration.Size = new System.Drawing.Size(143, 29);
            this.btnProofOfRegistration.TabIndex = 1;
            this.btnProofOfRegistration.Text = "Upload File";
            this.btnProofOfRegistration.UseVisualStyleBackColor = true;
            this.btnProofOfRegistration.Click += new System.EventHandler(this.btnProofOfRegistration_Click);

            this.btnProofOfEnrollment.Location = new System.Drawing.Point(627, 519);
            this.btnProofOfEnrollment.Name = "btnProofOfEnrollment";
            this.btnProofOfEnrollment.Size = new System.Drawing.Size(143, 29);
            this.btnProofOfEnrollment.TabIndex = 0;
            this.btnProofOfEnrollment.Text = "Upload File";
            this.btnProofOfEnrollment.UseVisualStyleBackColor = true;
            this.btnProofOfEnrollment.Click += new System.EventHandler(this.btnProofOfEnrollment_Click);

            this.lblAffidavit.AllowDrop = true;
            this.lblAffidavit.BackColor = System.Drawing.Color.White;
            this.lblAffidavit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAffidavit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAffidavit.Location = new System.Drawing.Point(9, 725);
            this.lblAffidavit.Name = "lblAffidavit";
            this.lblAffidavit.Size = new System.Drawing.Size(772, 64);
            this.lblAffidavit.TabIndex = 10;
            this.lblAffidavit.Text = "Drag and Drop Affidavit here or use Upload button";
            this.lblAffidavit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAffidavit.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblAffidavit_DragDrop);
            this.lblAffidavit.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblAffidavit_DragEnter);

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Purpose of funds";

            this.lblStudentCard.AllowDrop = true;
            this.lblStudentCard.BackColor = System.Drawing.Color.White;
            this.lblStudentCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentCard.Location = new System.Drawing.Point(9, 650);
            this.lblStudentCard.Name = "lblStudentCard";
            this.lblStudentCard.Size = new System.Drawing.Size(772, 64);
            this.lblStudentCard.TabIndex = 9;
            this.lblStudentCard.Text = "Drag and Drop Student Card here or use Upload button";
            this.lblStudentCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentCard.Click += new System.EventHandler(this.lblStudentCard_Click);
            this.lblStudentCard.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblStudentCard_DragDrop);
            this.lblStudentCard.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblStudentCard_DragEnter);

            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(362, 28);
            this.comboBox1.TabIndex = 8;

            this.lblProofOfRegistration.AllowDrop = true;
            this.lblProofOfRegistration.BackColor = System.Drawing.Color.White;
            this.lblProofOfRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProofOfRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProofOfRegistration.Location = new System.Drawing.Point(9, 574);
            this.lblProofOfRegistration.Name = "lblProofOfRegistration";
            this.lblProofOfRegistration.Size = new System.Drawing.Size(772, 64);
            this.lblProofOfRegistration.TabIndex = 8;
            this.lblProofOfRegistration.Text = "Drag and Drop Proof of Registration here or use Upload button";
            this.lblProofOfRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProofOfRegistration.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblProofOfRegistration_DragDrop);
            this.lblProofOfRegistration.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblProofOfRegistration_DragEnter);

            this.numericUpDown1.Location = new System.Drawing.Point(437, 112);
            this.numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(291, 27);
            this.numericUpDown1.TabIndex = 7;

            this.txtRequestPurpose.Location = new System.Drawing.Point(19, 180);
            this.txtRequestPurpose.Multiline = true;
            this.txtRequestPurpose.Name = "txtRequestPurpose";
            this.txtRequestPurpose.Size = new System.Drawing.Size(751, 164);
            this.txtRequestPurpose.TabIndex = 5;
            this.txtRequestPurpose.Text = "Briefly describe how you will use the funds ...";
            this.txtRequestPurpose.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtRequestPurpose.Leave += new System.EventHandler(this.textBox1_Leave);

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(763, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Please upload the required documents and confirm your academic standing to proceed with your funding request.";
            this.label10.Click += new System.EventHandler(this.label10_Click);

            this.lblProofOfEnrollment.AllowDrop = true;
            this.lblProofOfEnrollment.BackColor = System.Drawing.Color.White;
            this.lblProofOfEnrollment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProofOfEnrollment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProofOfEnrollment.Location = new System.Drawing.Point(9, 501);
            this.lblProofOfEnrollment.Name = "lblProofOfEnrollment";
            this.lblProofOfEnrollment.Size = new System.Drawing.Size(772, 64);
            this.lblProofOfEnrollment.TabIndex = 5;
            this.lblProofOfEnrollment.Text = "Drag and Drop Proof of Enrollment here or use Upload button";
            this.lblProofOfEnrollment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProofOfEnrollment.Click += new System.EventHandler(this.lblProofOfEnrollment_Click);
            this.lblProofOfEnrollment.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblProofOfEnrollment_DragDrop);
            this.lblProofOfEnrollment.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblProofOfEnrollment_DragEnter);

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reason for request";

            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(8, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Supporting Documents";

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(437, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requested Amount :";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(772, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specify the amount and purpose of the funds you are requesting and ensure all details are accurate and up-to-date.\r\n";

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funds Request Details";

            this.openFileDialog1.FileName = "openFileDialog1";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRequest";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "StudentRequest";
            this.Load += new System.EventHandler(this.StudentRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtRequestPurpose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAffidavit;
        private System.Windows.Forms.Label lblStudentCard;
        private System.Windows.Forms.Label lblProofOfRegistration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProofOfEnrollment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAffidavit;
        private System.Windows.Forms.Button btnStudentCard;
        private System.Windows.Forms.Button btnProofOfRegistration;
        private System.Windows.Forms.Button btnProofOfEnrollment;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label15;
    }
}