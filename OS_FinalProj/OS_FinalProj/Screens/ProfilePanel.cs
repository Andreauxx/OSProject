using OS_FinalProj.Core;
using Supabase.Postgrest.Exceptions;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OS_FinalProj.Screens
{
    public partial class ProfilePanel : UserControl
    {
        private readonly FormMain _mainForm;
        private readonly SupabaseClient _supabaseClient;
        private Profile _currentProfile;

        public ProfilePanel(FormMain form, SupabaseClient supabaseClient)
        {
            InitializeComponent();
            _mainForm = form;
            _supabaseClient = supabaseClient;
            LoadProfileDetails();
        }

        private async void LoadProfileDetails()
        {
            try
            {
                var user = _supabaseClient.GetCurrentUser();
                if (user == null) return;

                Debug.WriteLine($"Loading profile for: {user.Email} (ID: {user.Id})");

                // Use the SupabaseClient's method directly
                var profile = await _supabaseClient.GetUserProfile(user.Id);

                // If not found, try by email
                if (profile == null && !string.IsNullOrEmpty(user.Email))
                {
                    Debug.WriteLine("Trying to find profile by email");
                    profile = await _supabaseClient.GetProfileByEmail(user.Email);
                }

                if (profile == null)
                {
                    Debug.WriteLine("No profile found - creating new one");
                    await _supabaseClient.EnsureProfileExists(user.Id, user.Email);
                    profile = await _supabaseClient.GetUserProfile(user.Id); // Fixed: Use _supabaseClient instead of local method
                }

                if (profile != null)
                {
                    _currentProfile = profile;
                    UpdateUIWithProfile(profile);
                }
                else
                {
                    ClearProfileFields();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Load error: {ex}");
                MessageBox.Show("Error loading profile data");
            }
        }

        private void UpdateUIWithProfile(Profile profile)
        {
            txtName.Text = $"{profile.FirstName} {profile.LastName}".Trim();
            txtContact.Text = profile.Phone ?? string.Empty;
            txtUsername.Text = profile.Username ?? string.Empty;
            txtEmail.Text = profile.Email ?? string.Empty;

            cboVehicleInfo.Items.Clear();
            cboVehicleInfo.Items.Add("Vehicle 1");
            cboVehicleInfo.Items.Add("Vehicle 2");
            cboVehicleInfo.SelectedIndex = 0;
        }

        private void ClearProfileFields()
        {
            txtName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cboVehicleInfo.Items.Clear();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // Enable editing controls
            txtName.Enabled = true;
            txtContact.Enabled = true;
            txtUsername.Enabled = true;
            txtEmail.Enabled = true;
            cboVehicleInfo.Enabled = true;
            btnSaveChanges.Visible = true;
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _supabaseClient.GetCurrentUser();
                if (user == null) return;

                // Split name into first/last
                var nameParts = txtName.Text.Split(new[] { ' ' }, 2);
                var firstName = nameParts.Length > 0 ? nameParts[0] : "";
                var lastName = nameParts.Length > 1 ? nameParts[1] : "";

                // Create or update profile
                if (_currentProfile == null)
                {
                    var newProfile = new Profile
                    {
                        Id = Guid.Parse(user.Id),
                        Email = txtEmail.Text,
                        FirstName = firstName,
                        LastName = lastName,
                        Username = txtUsername.Text,
                        Phone = txtContact.Text,
                        Role = "customer",
                        CreatedAt = DateTime.UtcNow
                    };

                    var success = await _supabaseClient.CreateUserProfile(newProfile);
                    if (success)
                    {
                        _currentProfile = newProfile;
                        MessageBox.Show("Profile created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create profile.");
                        return;
                    }
                }
                else
                {
                    _currentProfile.FirstName = firstName;
                    _currentProfile.LastName = lastName;
                    _currentProfile.Phone = txtContact.Text;
                    _currentProfile.Username = txtUsername.Text;
                    _currentProfile.Email = txtEmail.Text;

                    var success = await _supabaseClient.UpdateUserProfile(_currentProfile);
                    if (!success)
                    {
                        MessageBox.Show("Failed to update profile.");
                        return;
                    }
                    MessageBox.Show("Profile updated successfully!");
                }

                // Disable editing
                txtName.Enabled = false;
                txtContact.Enabled = false;
                txtUsername.Enabled = false;
                txtEmail.Enabled = false;
                cboVehicleInfo.Enabled = false;
                btnSaveChanges.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}");
                Debug.WriteLine($"Error saving profile: {ex}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.LoadMainScreen();
        }

        private void ProfilePanel_Load(object sender, EventArgs e)
        {

        }
    }
}