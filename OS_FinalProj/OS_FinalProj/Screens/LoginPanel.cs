using OS_FinalProj.Core;
using Supabase.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OS_FinalProj.Screens
{
    public partial class LoginPanel : UserControl
    {
        private readonly FormMain mainForm;
        private readonly SupabaseClient _supabaseClient;
        private bool isLoggingIn = false;

        // Constructor now properly accepts the SupabaseClient parameter
        public LoginPanel(FormMain form, SupabaseClient supabaseClient)
        {
            InitializeComponent();
            mainForm = form;
            _supabaseClient = supabaseClient; // Store the shared client

            // Set UI event handlers
            btnLogin.Click += BtnLogin_Click;
            lnklblSignUp.LinkClicked += LnklblSignUp_LinkClicked;

            // Set initial focus
            txtUName.Focus();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (isLoggingIn) return;

            try
            {
                isLoggingIn = true;
                btnLogin.Enabled = false;
                Cursor = Cursors.WaitCursor;

                string usernameOrEmail = txtUName.Text.Trim();
                string password = txtPWord.Text;

                // Input validation
                if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username/email and password");
                    return;
                }

                // Initialize and authenticate - FIXED SYNTAX
                await _supabaseClient.InitializeAsync();
                var (success, message) = await _supabaseClient.SignInAsync(usernameOrEmail, password);

                if (success)
                {
                    mainForm.LoadMainScreen();
                }
                else
                {
                    MessageBox.Show($"Login failed: {message}");
                    txtPWord.SelectAll();
                    txtPWord.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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