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
    public partial class ServicesPopup1 : UserControl
    {
        FormMain mainForm;
        public ServicesPopup1(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSusSteerServ_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup2();
        }

        private void btnGenServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadGeneralServices();
        }

        private void btnEngTransServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadEngineTransitionServices();
        }

        private void btnSusSteerServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadSuspensionSteeringServices();
        }

        private void btnHeatAirServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadHeatingAirConServices();
        }

        private void btnFuelExhServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadFuelExhaustServices();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ServicesPopup1_Load(object sender, EventArgs e)
        {

        }
    }
}
