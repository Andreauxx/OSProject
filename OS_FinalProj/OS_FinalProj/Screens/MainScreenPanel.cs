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
    public partial class MainScreenPanel : UserControl
    {
        FormMain mainForm;
        public MainScreenPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;

            StyleButton(btnDashbaord);
            StyleButton(btnServices);
            StyleButton(btnAbout);
        }

        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            btn.BackColor = Color.FromArgb(37, 36, 36);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            btn.TabStop = false;

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            mainForm.LoadAboutUs();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            mainForm.LoadDashboard(); 
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {

        }

        private void lblServices_Click(object sender, EventArgs e)
        {

        }

        private void btnDashbaord_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserDashboardcs();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }

        private void btnServiceBasket_Click(object sender, EventArgs e)
        {
            mainForm.LoadServiceBasketPanel();
        }
    }
}
