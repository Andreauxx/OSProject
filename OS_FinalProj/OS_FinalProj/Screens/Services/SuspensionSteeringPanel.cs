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
    public partial class SuspensionSteeringPanel : UserControl
    {
        FormMain mainForm;
        public SuspensionSteeringPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }
    }
}
