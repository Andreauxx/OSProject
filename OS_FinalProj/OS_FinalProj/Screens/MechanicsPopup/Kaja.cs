using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj.Screens.MechanicsPopup
{
    public partial class Kaja : UserControl
    {
        FormMain mainForm;
        public Kaja(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadMechanics();
        }

        private void btnConfirmServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadConfirmedServicesPopup();
        }
    }
}
