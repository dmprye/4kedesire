using Rise_of_Programming_Gods;
using System;
using System.Windows.Forms;

namespace Rise_of_Programming_Gods
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 battleForm = new Form1();
            battleForm.FormClosed += (s, args) => this.Close();

            battleForm.Show();
            this.Hide();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}