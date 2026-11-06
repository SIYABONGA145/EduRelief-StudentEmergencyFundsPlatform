using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduRelief
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.TopLevel = false;
            panel3.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.TopLevel = false;
            panel3.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStudentsVerification studentsVerification = new AdminStudentsVerification();
            studentsVerification.TopLevel = false;
            panel3.Controls.Add(studentsVerification);
            studentsVerification.BringToFront();
            studentsVerification.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMonitorRequests monitorRequests = new AdminMonitorRequests();
            monitorRequests.TopLevel = false;
            panel3.Controls.Add(monitorRequests);
            monitorRequests.BringToFront();
            monitorRequests.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminManageFunds manageFunds = new AdminManageFunds();
            manageFunds.TopLevel = false;
            panel3.Controls.Add(manageFunds);
            manageFunds.BringToFront();
            manageFunds.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ADDED THIS LOGOUT METHOD
        private void button5_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Close();
            welcomePage.Show();
        }
    }
}