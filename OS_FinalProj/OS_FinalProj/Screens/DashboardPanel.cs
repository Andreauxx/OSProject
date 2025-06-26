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
    public partial class DashboardPanel : UserControl
    {
        FormMain mainForm;
        public DashboardPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void DashboardPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadMainScreen();
        }
    }
}
