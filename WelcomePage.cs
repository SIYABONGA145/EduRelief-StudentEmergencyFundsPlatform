using System;
using System.Windows.Forms;

namespace EduRelief
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void EduRelief_Load(object sender, EventArgs e)
        {
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentLogin stuLogin = new StudentLogin();
            stuLogin.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btnSponsor_Click(object sender, EventArgs e)
        {
            SponsorLogin sponsorLogin = new SponsorLogin();
            sponsorLogin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}