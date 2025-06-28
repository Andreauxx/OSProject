using OS_FinalProj.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj.Screens
{
    public partial class SignUpPanel : UserControl
    {
        private FormMain mainForm;

        public SignUpPanel(FormMain form)
        {
            InitializeComponent();
            mainForm = form;

            // Assigning event handlers to the buttons
            btn_back.Click += btn_back_Click;
            btnSignUp.Click += btnSignUp_Click;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Switch back to LoginPanel
            mainForm.LoadLogin();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtSignPWord.Text;
            string username = txtSignUName.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            var supabaseClient = new SupabaseClient();
            await supabaseClient.InitializeAsync();

            try
            {
                // 1. Sign up (auth)
                var (session, user) = await supabaseClient.SignUpAsync(email, password);
                if (user == null)
                {
                    MessageBox.Show("Sign-up failed. No user session found.");
                    return;
                }

                Console.WriteLine($"User signed up with ID: {user.Id}");

                // 2. Create profile with the user's ID
                bool profileCreated = await supabaseClient.CreateUserProfileAsync(
                    userId: user.Id,
                    email: email,  // Make sure this is passed
                    username: username,
                    firstName: firstName,
                    lastName: lastName);

                if (profileCreated)
                {
                    MessageBox.Show("Account created successfully!");
                    mainForm.LoadLogin();
                }
                else
                {
                    MessageBox.Show("Profile creation failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Console.WriteLine($"Error during signup: {ex}");
            }
        }


        // Helper function to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
