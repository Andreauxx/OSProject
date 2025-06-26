using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj.Screens
{
    public partial class LoginPanel : UserControl
    {
        FormMain mainForm;

        public LoginPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.LoadSignUp(); // Switch back to LoginPanel

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            mainForm.LoadMainScreen();
        }

        private void pnlLogIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
