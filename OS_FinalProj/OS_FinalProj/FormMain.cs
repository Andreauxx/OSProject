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

        public void LoadMainScreen()
        {
            pnlMain.Controls.Clear();
            var mainScreenPanel = new MainScreenPanel(this); // Pass reference
            mainScreenPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(mainScreenPanel);
        }

        public void LoadProfile()
        {
            pnlMain.Controls.Clear();
            var profilePanel = new ProfilePanel(this);
            profilePanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(profilePanel);
        }

        public void LoadServicePopup1()
        {
            pnlMain.Controls.Clear();
            var servicesPopup1 = new ServicesPopup1(this);
            servicesPopup1.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(servicesPopup1);


        }

        public void LoadServicePopup2()
        {
            pnlMain.Controls.Clear();
            var servicePopup2 = new ServicePopup2(this);
            servicePopup2.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(servicePopup2);
        }

    }
}
