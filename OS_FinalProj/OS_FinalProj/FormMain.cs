using OS_FinalProj.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadLogin(); // Start with login form
        }

        public void LoadLogin()
        {
            pnlMain.Controls.Clear();
            var loginPanel = new LoginPanel(this); // Pass reference
            loginPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(loginPanel);
        }

        public void LoadSignUp()
        {
            pnlMain.Controls.Clear();
            var signUpPanel = new SignUpPanel(this); // Pass reference
            signUpPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(signUpPanel);
        }

      

        // You can add more LoadX() methods here for basket, profile, etc.
    }

}
