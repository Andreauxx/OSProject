using OS_FinalProj.Screens;
using OS_FinalProj.Screens.MechanicsPopup;
﻿using OS_FinalProj.Core;
using OS_FinalProj.Screens;
using OS_FinalProj.Screens.Services;
using Supabase.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProj
{
    public partial class FormMain : Form
    {

        private SupabaseClient _supabaseClient; // Declare _supabaseClient here
        private LoginPanel _loginPanel; // Store LoginPanel instance

        public FormMain()
        {
            InitializeComponent();
            InitializeSupabase(); // Initialize SupabaseClient asynchronously
        }

        // Asynchronous method to initialize SupabaseClient
        private async void InitializeSupabase()
        {
            _supabaseClient = new SupabaseClient(); // Initialize the SupabaseClient
            await _supabaseClient.InitializeAsync(); // Initialize SupabaseClient asynchronously
            LoadLogin(); // Start with login form after initialization
        }
        public void LoadLogin()
        {
            pnlMain.Controls.Clear();
            _loginPanel = new LoginPanel(this, _supabaseClient); // Store the instance
            _loginPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(_loginPanel);
        }

        // Public method to get the logged-in UID from LoginPanel
        public string? GetLoggedInUID()
        {
            return _loginPanel?.LoggedInUID;
        }

        public void LoadSignUp()
        {
            pnlMain.Controls.Clear();
            var signUpPanel = new SignUpPanel(this); // Pass reference
            signUpPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(signUpPanel);
        }

        public void LoadMainScreen()
        {
            pnlMain.Controls.Clear();
            var mainScreenPanel = new MainScreenPanel(this); // Pass reference
            mainScreenPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(mainScreenPanel);
        }

        public void LoadProfile()
        {
            pnlMain.Controls.Clear();
            var profilePanel = new ProfilePanel(this, _supabaseClient);
            profilePanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(profilePanel);
        }

        public void LoadServicePopup1()
        {
            pnlMain.Controls.Clear();
            var servicesPopup1 = new ServicesPopup1(this);
            servicesPopup1.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(servicesPopup1);


        }

        public void LoadServicePopup2()
        {
            pnlMain.Controls.Clear();
            var servicePopup2 = new ServicePopup2(this);
            servicePopup2.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(servicePopup2);
        }

        // Services

        public void LoadGeneralServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var generalServicesPanel = new GeneralServicesPanel(this, _supabaseClient, userId);
            generalServicesPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(generalServicesPanel);
        }

        public void LoadEngineTransitionServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var engineTransPanel = new EngineTransPanel(this, _supabaseClient, userId);
            engineTransPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(engineTransPanel);
        }

        public void LoadSuspensionSteeringServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var suspensionSteeringPanel = new SuspensionSteeringPanel(this, _supabaseClient, userId);
            suspensionSteeringPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(suspensionSteeringPanel);
        }

        public void LoadHeatingAirConServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var heatingAirConPanel = new HeatingAirConPanel(this, _supabaseClient, userId);
            heatingAirConPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(heatingAirConPanel);
        }
        public void LoadFuelExhaustServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var fuelExhaustPanel = new FuelExhaustPanel(this, _supabaseClient, userId);
            fuelExhaustPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(fuelExhaustPanel);
        }
        public void LoadElectricalLightingServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var electricLightPanel = new ElectricalLightPanel(this, _supabaseClient, userId);
            electricLightPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(electricLightPanel);
        }
        public void LoadTireServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var tireServicesPanel = new TireServicesPanel(this, _supabaseClient, userId);
            tireServicesPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(tireServicesPanel);
        }
        public void LoadDiagnosticCheckServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var diagnosticCheckPanel = new DiagnosticCheckPanel(this, _supabaseClient, userId);
            diagnosticCheckPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(diagnosticCheckPanel);
        }
        public void LoadFluidFilterServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var fluidFilterPanel = new FluidFilterPanel(this, _supabaseClient, userId);
            fluidFilterPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(fluidFilterPanel);
        }
        public void LoadCustomPerformanceServices()
        {
            pnlMain.Controls.Clear();
            string userId = GetLoggedInUID();
            var customPerfPanel = new CustomPerfPanel(this, _supabaseClient, userId);
            customPerfPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(customPerfPanel);
        }

        public void LoadAboutUs()
        {
            pnlMain.Controls.Clear();
            var aboutUsPanel = new AboutUsPanel(this);
            aboutUsPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(aboutUsPanel);
        }

        public void LoadDashboard()
        {
            pnlMain.Controls.Clear();
            var dashboard = new DashboardPanel(this);
            dashboard.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(dashboard);
        }

        public void LoadMechanics()
        {
            pnlMain.Controls.Clear();
            var mechanic = new Mechanics(this);
            mechanic.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(mechanic);
        }
        public void LoadServiceBasketPanel()
        {
            pnlMain.Controls.Clear();
            var serviceBP = new ServiceBasketPanel(this);
            serviceBP.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(serviceBP);
        }
        public void LoadChicol()
        {
            pnlMain.Controls.Clear();
            var chico = new Chico(this);
            chico.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(chico);
        }
        public void LoadBetina()
        {
            pnlMain.Controls.Clear();
            var betina = new Betina(this);
            betina.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(betina);
        }
        public void LoadJambie()
        {
            pnlMain.Controls.Clear();
            var jambie = new Jambie(this);
            jambie.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(jambie);
        }
        public void LoadKaja()
        {
            pnlMain.Controls.Clear();
            var kaja = new Kaja(this);
            kaja.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(kaja);
        }
        public void LoadManny()
        {
            pnlMain.Controls.Clear();
            var manny = new Manny(this);
            manny.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(manny);
        }
        public void LoadMainScreenPanel()
        {
            pnlMain.Controls.Clear();
            var msPanel = new MainScreenPanel(this);
            msPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(msPanel);
        }
        public void LoadConfirmedServicesPopup()
        {
            pnlMain.Controls.Clear();
            var csPopup = new ConfirmedServicesPopup(this);
            csPopup.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(csPopup);
        }
        public void LoadUserDashboardcs()
        {
            pnlMain.Controls.Clear();
            var userDashboard = new UserDashboardcs(this);
            userDashboard.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userDashboard);
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
