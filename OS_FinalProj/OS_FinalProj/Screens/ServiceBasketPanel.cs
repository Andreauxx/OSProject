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
    public partial class ServiceBasketPanel : UserControl
    {
        FormMain mainForm;
        public ServiceBasketPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainForm.LoadProfile();
        }
    }
}
