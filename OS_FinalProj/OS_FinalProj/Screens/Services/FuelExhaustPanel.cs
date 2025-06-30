using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_FinalProj.Core;

namespace OS_FinalProj.Screens.Services
{
    public partial class FuelExhaustPanel : UserControl
    {
        private readonly FormMain mainForm;
        private readonly SupabaseClient _supabaseClient;
        private string _userId; // Will be set from LoginPanel's LoggedInUID

        // Track selected services
        private readonly HashSet<Guid> selectedServiceIds = new HashSet<Guid>();

        // Add a public property to set the userId after instantiation
        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }

        // Map each button to its service ID (replace with your actual service GUIDs)
        private readonly Dictionary<ReaLTaiizor.Controls.Button, Guid> serviceButtonMap;

        public FuelExhaustPanel(FormMain form, SupabaseClient supabaseClient, string userId = null)
        {
            InitializeComponent();
            mainForm = form;
            _supabaseClient = supabaseClient;
            _userId = userId;

            // Map each button to its service ID
            serviceButtonMap = new Dictionary<ReaLTaiizor.Controls.Button, Guid>
            {
                { btnFuelInject,        new Guid("94837069-f370-40ff-9102-bf56d2a5fcd3") },
                { btnCatConvRep,        new Guid("9a9979c2-545f-4ca1-8c6a-a2ada0a21ed9") },
                { btnExhaustSysRep,     new Guid("81aebb49-1c64-4785-8706-19f36655d486") },
                { btnFuelPumRep,        new Guid("27b5b7e6-346a-4475-b941-4307b41be3e6") },
            };

            // Attach click handlers for service selection
            foreach (var btn in serviceButtonMap.Keys)
                btn.Click += ServiceButton_Click;

            btnAddtoServ.Click += BtnAddtoServ_Click;
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            var btn = sender as ReaLTaiizor.Controls.Button;
            var serviceId = serviceButtonMap[btn];

            if (selectedServiceIds.Contains(serviceId))
            {
                selectedServiceIds.Remove(serviceId);
                btn.ForeColor = Color.FromArgb(255, 255, 255); // Deselect visual
            }
            else
            {
                selectedServiceIds.Add(serviceId);
                btn.ForeColor = Color.Orange; // Selected visual
            }
        }

        private async void BtnAddtoServ_Click(object sender, EventArgs e)
        {
            if (selectedServiceIds.Count == 0)
            {
                MessageBox.Show("Please select at least one service.");
                return;
            }

            // Get the user's basket UID
            var basketUidStr = await _supabaseClient.GetBasketUID(_userId);
            if (basketUidStr == null)
            {
                MessageBox.Show(_userId);
                return;
            }

            if (!Guid.TryParse(basketUidStr, out var basketUid))
            {
                MessageBox.Show("Invalid basket UID.");
                return;
            }

            foreach (var serviceId in selectedServiceIds)
            {
                var basketItem = await _supabaseClient.CreateNewBasketItems(basketUid, serviceId, 1);
                if (basketItem == null)
                {
                    MessageBox.Show($"Failed to add service {serviceId} to basket.");
                }
            }

            MessageBox.Show("Selected services added to your basket!");
            selectedServiceIds.Clear();

            // Optionally reset button visuals
            foreach (var btn in serviceButtonMap.Keys)
                btn.BackColor = Color.FromArgb(214, 211, 206);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.LoadServicePopup1();
        }
    }
}
