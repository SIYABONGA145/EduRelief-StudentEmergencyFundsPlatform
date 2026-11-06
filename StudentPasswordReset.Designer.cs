namespace EduRelief
{
    partial class StudentPasswordReset
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmailAddress = new TextBox();
            txtNewPasswordReset = new TextBox();
            txtConfirmPasswordReset = new TextBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(106, 123, 162);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 322);
            button1.Name = "button1";
            button1.Size = new Size(452, 51);
            button1.TabIndex = 0;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 31);
            label1.TabIndex = 1;
            label1.Text = "Reset Your Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(449, 20);
            label2.TabIndex = 2;
            label2.Text = " Enter your email and a new password to reset your account access";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 387);
            label3.Name = "label3";
            label3.Size = new Size(189, 20);
            label3.TabIndex = 3;
            label3.Text = "Remember your password?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 4;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 5;
            label5.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 226);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 6;
            label6.Text = "Confirm New Password";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAddress.Location = new Point(12, 121);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(452, 27);
            txtEmailAddress.TabIndex = 7;
            // 
            // txtNewPasswordReset
            // 
            txtNewPasswordReset.BorderStyle = BorderStyle.FixedSingle;
            txtNewPasswordReset.Location = new Point(12, 184);
            txtNewPasswordReset.Name = "txtNewPasswordReset";
            txtNewPasswordReset.Size = new Size(452, 27);
            txtNewPasswordReset.TabIndex = 8;
            txtNewPasswordReset.UseSystemPasswordChar = true;
            // 
            // txtConfirmPasswordReset
            // 
            txtConfirmPasswordReset.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPasswordReset.Location = new Point(12, 249);
            txtConfirmPasswordReset.Name = "txtConfirmPasswordReset";
            txtConfirmPasswordReset.Size = new Size(452, 27);
            txtConfirmPasswordReset.TabIndex = 9;
            txtConfirmPasswordReset.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(294, 282);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show/Hide Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.Location = new Point(309, 386);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(51, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // StudentPasswordReset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(474, 432);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(txtConfirmPasswordReset);
            Controls.Add(txtNewPasswordReset);
            Controls.Add(txtEmailAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "StudentPasswordReset";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPasswordReset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmailAddress;
        private TextBox txtNewPasswordReset;
        private TextBox txtConfirmPasswordReset;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
    }
}