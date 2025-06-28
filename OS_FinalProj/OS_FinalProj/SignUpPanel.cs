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
    public partial class SignUpPanel : UserControl
    {
        FormMain mainForm;

        public SignUpPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.LoadLogin(); // Switch back to LoginPanel

        }
    }
}
