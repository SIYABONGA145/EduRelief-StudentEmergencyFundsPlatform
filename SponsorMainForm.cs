using System;
using System.Windows.Forms;

namespace EduRelief
{
    public partial class SponsorMainForm : Form
    {
        public SponsorMainForm()
        {
            InitializeComponent();
        }

        private void SponsorMainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new SponsorDashboard());
        }

        private void LoadForm(Form form)
        {
            panel3.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new SponsorDashboard());
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            LoadForm(new SponsorDonationForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SponsorLogin login = new SponsorLogin();
            login.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}