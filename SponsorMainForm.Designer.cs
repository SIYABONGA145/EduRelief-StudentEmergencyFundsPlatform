namespace EduRelief
{
    partial class SponsorMainForm
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            btnDonate = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 123, 162);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1402, 76);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Graduation_Cap;
            pictureBox4.Location = new Point(35, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Minus;
            pictureBox3.Location = new Point(1273, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Rounded_Square;
            pictureBox2.Location = new Point(1314, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close;
            pictureBox1.Location = new Point(1355, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(106, 123, 162);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnDonate);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 667);
            panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Logout;
            pictureBox6.Location = new Point(35, 611);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(35, 75);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Combo_Chart;
            pictureBox5.Location = new Point(35, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(106, 123, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 601);
            button2.Name = "button2";
            button2.Size = new Size(250, 54);
            button2.TabIndex = 2;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnDonate
            // 
            btnDonate.BackColor = Color.FromArgb(106, 123, 162);
            btnDonate.ForeColor = Color.White;
            btnDonate.Location = new Point(3, 66);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(250, 54);
            btnDonate.TabIndex = 1;
            btnDonate.Text = "Donate";
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(106, 123, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(250, 54);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 247, 250);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(259, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 667);
            panel3.TabIndex = 2;
            // 
            // SponsorMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 743);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SponsorMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SponsorMainForm";
            Load += SponsorMainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button btnDonate;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
    }
}