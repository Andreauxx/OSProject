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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Color borderColor = Color.Orange;
            int borderWidth = 2;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {

                e.Graphics.DrawRectangle(pen,
                    new Rectangle(0, 0, panel.Width - borderWidth, panel.Height - borderWidth));
            }
        }

        private void btnActiveServ_Click(object sender, EventArgs e)
        {

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalCars_Click(object sender, EventArgs e)
        {

        }

        private void btnCustSatisfaction_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
