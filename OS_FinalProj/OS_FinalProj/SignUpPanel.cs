using OS_FinalProj.Core;
using System;
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
            string contactNumber = txtContactNumber.Text; // Get contact number from the TextBox

            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(contactNumber)) // Ensure contact number is provided
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

            // Validate the contact number (e.g., must be a valid phone number format)
            if (!IsValidPhoneNumber(contactNumber))
            {
                MessageBox.Show("Please enter a valid 11-digit phone number starting with '09'.");
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
                    lastName: lastName,
                    contactNumber: contactNumber); // Pass contact number to the profile

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


        // Helper function to validate phone number format (11 digits starting with '09')
        private bool IsValidPhoneNumber(string contactNumber)
        {
            // Check if the contact number is exactly 11 digits and starts with '09'
            return contactNumber.Length == 11 && contactNumber.StartsWith("09") && contactNumber.All(char.IsDigit);
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

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtSignPWord.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtSignPWord.PasswordChar = '\0';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtSignPWord.PasswordChar == '\0')
            {
                btnHidePass.BringToFront();
                txtSignPWord.PasswordChar = '*';
            }
        }
    }
}
