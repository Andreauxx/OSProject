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
    public partial class ServicePopup2 : UserControl
    {
        FormMain mainForm;
        public ServicePopup2(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }

        private void btnElecLightServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadElectricalLightingServices();
        }

        private void btnTireServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadTireServices();
        }

        private void btnDiagCheckServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadDiagnosticCheckServices();
        }

        private void btnFluidFilServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadFluidFilterServices();
        }

        private void btnCustPerfServ_Click(object sender, EventArgs e)
        {
            mainForm.LoadCustomPerformanceServices();
        }
    }
}
