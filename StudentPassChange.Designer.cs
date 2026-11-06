namespace EduRelief
{
    partial class StudentPassChange
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
            txtNewPasswordConfirmation = new TextBox();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtNewPasswordConfirmation
            // 
            txtNewPasswordConfirmation.BorderStyle = BorderStyle.FixedSingle;
            txtNewPasswordConfirmation.Location = new Point(12, 257);
            txtNewPasswordConfirmation.Name = "txtNewPasswordConfirmation";
            txtNewPasswordConfirmation.Size = new Size(410, 27);
            txtNewPasswordConfirmation.TabIndex = 0;
            txtNewPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.Location = new Point(12, 138);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(410, 27);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Location = new Point(12, 193);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(410, 27);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 31);
            label1.TabIndex = 3;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 4;
            label2.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 170);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "New Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(106, 123, 162);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 340);
            button1.Name = "button1";
            button1.Size = new Size(410, 52);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(146, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(160, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 8;
            label4.Text = "Confirm New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 40);
            label5.Name = "label5";
            label5.Size = new Size(282, 20);
            label5.TabIndex = 9;
            label5.Text = "Update your password for better security.";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(252, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show/Hide Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // StudentPassChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 433);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(txtNewPasswordConfirmation);
            Name = "StudentPassChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPassChange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPasswordConfirmation;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
    }
}