using OS_FinalProj.Core;
using Supabase.Postgrest.Exceptions;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj.Screens
{
    public partial class AddVehicleForm : Form
    {
        private readonly SupabaseClient _supabaseClient;

        public AddVehicleForm(SupabaseClient supabaseClient)
        {
            InitializeComponent();
            _supabaseClient = supabaseClient;
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here if needed
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtLicensePlate.Text))
                {
                    MessageBox.Show("Please enter a license plate number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMake.Text))
                {
                    MessageBox.Show("Please enter a make.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    MessageBox.Show("Please enter a model.");
                    return;
                }

                if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                // Get the current user's ID
                var currentUser = _supabaseClient.GetCurrentUser();
                if (currentUser == null)
                {
                    MessageBox.Show("No user is currently logged in.");
                    return;
                }

                // Ensure the user profile exists before adding the vehicle
                await _supabaseClient.EnsureProfileExists(currentUser.Id, currentUser.Email);

                // Now add the vehicle
                bool success = await _supabaseClient.AddVehicle(
                    txtLicensePlate.Text.Trim(),
                    txtMake.Text.Trim(),
                    txtModel.Text.Trim(),
                    year,
                    currentUser.Id);

                if (success)
                {
                    MessageBox.Show("Vehicle added successfully!");
                    ResetForm();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add vehicle. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                btnAdd.Enabled = true;
            }
        }





        private void ResetForm()
        {
            txtLicensePlate.Text = string.Empty;
            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtYear.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}