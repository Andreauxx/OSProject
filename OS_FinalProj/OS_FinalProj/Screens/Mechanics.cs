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

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }
    }
}
