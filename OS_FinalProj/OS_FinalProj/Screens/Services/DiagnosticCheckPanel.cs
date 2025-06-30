using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj.Screens.Services
{
    public partial class DiagnosticCheckPanel : UserControl
    {
        FormMain mainForm;
        public DiagnosticCheckPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnTireBal_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup2();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup2();
        }

        private void btnAddtoServ_Click(object sender, EventArgs e)
        {

        }
    }
}
