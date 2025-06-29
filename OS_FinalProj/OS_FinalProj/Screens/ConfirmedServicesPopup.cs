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
    public partial class ConfirmedServicesPopup : UserControl
    {
        FormMain mainForm;
        public ConfirmedServicesPopup(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            mainForm.LoadMainScreen();
        }
    }
}
