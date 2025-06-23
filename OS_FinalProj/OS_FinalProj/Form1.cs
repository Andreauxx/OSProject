namespace OS_FinalProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlLogIn.Visible = true;
            pnlSignUp.Visible = false;
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogIn.Visible = false;
            pnlSignUp.Visible = true;
            pnlSignUp.BringToFront(); // Ensure it's not hidden
        }
        private void pnlSignUp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
