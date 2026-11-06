using System;
using System.Windows.Forms;

namespace EduRelief
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new StudentDashboard());
        }

        // Helper method to load forms cleanly into panel3
        private void LoadForm(Form form)
        {
            panel3.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { Application.Exit(); }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentLogin login = new StudentLogin();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) { LoadForm(new StudentDashboard()); }
        private void button2_Click(object sender, EventArgs e) { LoadForm(new StudentRequest()); }
        private void button3_Click(object sender, EventArgs e) { LoadForm(new StudentRequestHistory()); }
        private void button4_Click(object sender, EventArgs e) { LoadForm(new StudentProfile()); }
        private void button6_Click(object sender, EventArgs e) { LoadForm(new StudentSettings()); }
        private void pictureBox2_Click(object sender, EventArgs e) { this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized; }
    }
}