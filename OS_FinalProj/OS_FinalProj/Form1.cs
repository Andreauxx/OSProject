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
            pnlMainScreen.Visible = false;
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogIn.Visible = false;
            pnlSignUp.Visible = true;
            pnlSignUp.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = false;
            pnlMainScreen.Visible = true;
            pnlMainScreen.BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlLogIn.Visible = true;
            pnlLogIn.BringToFront();
        }

    }
}
