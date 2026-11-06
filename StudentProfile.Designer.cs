namespace EduRelief
{
    partial class StudentProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            txtCourse = new TextBox();
            txtFirstName = new TextBox();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            label9 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtStudentNumber = new TextBox();
            pictureBox1 = new PictureBox();
            btnUpload = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            txtTelNumber = new TextBox();
            label4 = new Label();
            txtAcademicYear = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            label7 = new Label();
            btnEditProfile = new Button();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(245, 247, 250);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnEditProfile);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 667);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 247, 250);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCourse);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(btnSaveChanges);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtStudentNumber);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnUpload);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtTelNumber);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAcademicYear);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(81, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 478);
            panel2.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 240);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 20;
            label10.Text = "First Name";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(501, 182);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(459, 27);
            txtCourse.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(13, 263);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(459, 27);
            txtFirstName.TabIndex = 19;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(829, 416);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(129, 29);
            btnSaveChanges.TabIndex = 18;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += button4_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(729, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 210);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 15;
            label9.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(502, 233);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(459, 151);
            txtAddress.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 346);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 13;
            label8.Text = "Student Number";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(13, 369);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(459, 27);
            txtStudentNumber.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.NoProfile;
            pictureBox1.Location = new Point(167, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(167, 187);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(161, 34);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload Photo";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 418);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(459, 27);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 293);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 11;
            label5.Text = "Last Name";
            // 
            // txtTelNumber
            // 
            txtTelNumber.Location = new Point(500, 76);
            txtTelNumber.Name = "txtTelNumber";
            txtTelNumber.Size = new Size(459, 27);
            txtTelNumber.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 159);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 10;
            label4.Text = "Course";
            // 
            // txtAcademicYear
            // 
            txtAcademicYear.Location = new Point(502, 129);
            txtAcademicYear.Name = "txtAcademicYear";
            txtAcademicYear.Size = new Size(459, 27);
            txtAcademicYear.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 106);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 9;
            label3.Text = "Academic Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 8;
            label2.Text = "Tel. Number";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(14, 316);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(459, 27);
            txtLastName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 395);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 58);
            label7.Name = "label7";
            label7.Size = new Size(330, 20);
            label7.TabIndex = 13;
            label7.Text = "Your basic information used for funding requests";
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(913, 74);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(130, 29);
            btnEditProfile.TabIndex = 16;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 23);
            label6.Name = "label6";
            label6.Size = new Size(164, 28);
            label6.TabIndex = 12;
            label6.Text = "Personal Details";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 667);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentProfile";
            Text = "StudentProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtAcademicYear;
        private TextBox txtTelNumber;
        private TextBox txtEmail;
        private Button btnUpload;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private Label label9;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtStudentNumber;
        private OpenFileDialog openFileDialog1;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Button btnEditProfile;
        private Label label10;
        private TextBox txtFirstName;
        private TextBox txtCourse;
    }
}