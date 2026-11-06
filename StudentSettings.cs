using System;
using System.Windows.Forms;

namespace EduRelief
{
    public partial class StudentSettings : Form
    {
        public StudentSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentPassChange changePass = new StudentPassChange();
            changePass.ShowDialog();
        }
    }
}