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
    public partial class FuelExhaustPanel : UserControl
    {
        FormMain mainForm;
        public FuelExhaustPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }

        private void FuelExhaustPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }
    }
}
