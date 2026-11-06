namespace EduRelief
{
    partial class AdminStudentsVerification
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridVerify = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVerify).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 250);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridVerify);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 620);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(883, 553);
            button3.Name = "button3";
            button3.Size = new Size(82, 37);
            button3.TabIndex = 3;
            button3.Text = "Reject";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Reject_Click;
            // 
            // button2
            // 
            button2.Location = new Point(784, 553);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 2;
            button2.Text = "Approve";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Approve_Click;
            // 
            // button1
            // 
            button1.Location = new Point(679, 553);
            button1.Name = "button1";
            button1.Size = new Size(99, 37);
            button1.TabIndex = 1;
            button1.Text = "View Profile";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridVerify
            // 
            dataGridVerify.BackgroundColor = SystemColors.ControlLight;
            dataGridVerify.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVerify.Location = new Point(138, 152);
            dataGridVerify.Name = "dataGridVerify";
            dataGridVerify.RowHeadersWidth = 51;
            dataGridVerify.Size = new Size(827, 395);
            dataGridVerify.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 118);
            label1.Name = "label1";
            label1.Size = new Size(211, 31);
            label1.TabIndex = 13;
            label1.Text = "VERIFY STUDENTS";
            // 
            // AdminStudentsVerification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 620);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminStudentsVerification";
            Text = "AdminStudentsVerification";
            Load += AdminStudentsVerification_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVerify).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridVerify;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}