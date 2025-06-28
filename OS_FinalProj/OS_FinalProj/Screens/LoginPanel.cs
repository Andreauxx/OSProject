using OS_FinalProj.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OS_FinalProj.Screens
{
    public partial class LoginPanel : UserControl
    {
        private readonly FormMain mainForm;
        private bool isLoggingIn = false;

        public LoginPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;

            // Set UI event handlers
            btnLogin.Click += BtnLogin_Click;
            lnklblSignUp.LinkClicked += LnklblSignUp_LinkClicked;

            // Set initial focus
            txtUName.Focus();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            // Prevent multiple simultaneous login attempts
            if (isLoggingIn) return;

            try
            {
                isLoggingIn = true;
                btnLogin.Enabled = false;
                Cursor = Cursors.WaitCursor;

                string usernameOrEmail = txtUName.Text.Trim();
                string password = txtPWord.Text;

                // Validate inputs
                if (string.IsNullOrWhiteSpace(usernameOrEmail))
                {
                    MessageBox.Show("Please enter your username or email.", "Input Required",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter your password.", "Input Required",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPWord.Focus();
                    return;
                }

                // Initialize and authenticate
                var supabaseClient = new SupabaseClient();
                await supabaseClient.InitializeAsync();
                var (success, message) = await supabaseClient.SignInAsync(usernameOrEmail, password);
                if (success)
                {
                    // Successful login
                    mainForm.LoadMainScreen();
                }
                else
                {
                    MessageBox.Show($"Login failed: {message}", "Authentication Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPWord.SelectAll();
                    txtPWord.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoggingIn = false;
                btnLogin.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void LnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.LoadSignUp();
        }

        // Handle Enter key press in password field to trigger login
        private void TxtPWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

     
    }
}

