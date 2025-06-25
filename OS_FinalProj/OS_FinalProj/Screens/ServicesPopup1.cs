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
    }
}
