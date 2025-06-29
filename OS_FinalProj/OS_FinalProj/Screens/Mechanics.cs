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
    public partial class Mechanics : UserControl
    {
        FormMain mainForm;
        public Mechanics(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnMechanic1_Click(object sender, EventArgs e)
        {
            mainForm.LoadChicol();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadServiceBasketPanel();
        }

        private void btnMechanic2_Click(object sender, EventArgs e)
        {
            mainForm.LoadBetina();
        }

        private void btnMechanic3_Click(object sender, EventArgs e)
        {
            mainForm.LoadJambie();
        }

        private void btnMechanic4_Click(object sender, EventArgs e)
        {
            mainForm.LoadKaja();
        }

        private void btnMechanic5_Click(object sender, EventArgs e)
        {
            mainForm.LoadManny();
        }
    }
}
