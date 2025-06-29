<<<<<<< Updated upstream
﻿using OS_FinalProj.Screens;
using OS_FinalProj.Screens.MechanicsPopup;
=======
﻿using OS_FinalProj.Core;
using OS_FinalProj.Screens;
>>>>>>> Stashed changes
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
            var loginPanel = new LoginPanel(this, _supabaseClient); // Pass the client
            loginPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(loginPanel);
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
            var generalServicesPanel = new GeneralServicesPanel(this);
            generalServicesPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(generalServicesPanel);
        }

        public void LoadEngineTransitionServices()
        {
            pnlMain.Controls.Clear();
            var engineTransPanel = new EngineTransPanel(this);
            engineTransPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(engineTransPanel);
        }

        public void LoadSuspensionSteeringServices()
        {
            pnlMain.Controls.Clear();
            var suspensionSteeringPanel = new SuspensionSteeringPanel(this);
            suspensionSteeringPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(suspensionSteeringPanel);
        }

        public void LoadHeatingAirConServices()
        {
            pnlMain.Controls.Clear();
            var heatingAirConPanel = new HeatingAirConPanel(this);
            heatingAirConPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(heatingAirConPanel);
        }
        public void LoadFuelExhaustServices()
        {
            pnlMain.Controls.Clear();
            var fuelExhaustPanel = new FuelExhaustPanel(this);
            fuelExhaustPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(fuelExhaustPanel);
        }
        public void LoadElectricalLightingServices()
        {
            pnlMain.Controls.Clear();
            var electricLightPanel = new ElectricalLightPanel(this);
            electricLightPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(electricLightPanel);
        }
        public void LoadTireServices()
        {
            pnlMain.Controls.Clear();
            var tireServicesPanel = new TireServicesPanel(this);
            tireServicesPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(tireServicesPanel);
        }
        public void LoadDiagnosticCheckServices()
        {
            pnlMain.Controls.Clear();
            var diagnosticCheckPanel = new DiagnosticCheckPanel(this);
            diagnosticCheckPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(diagnosticCheckPanel);
        }
        public void LoadFluidFilterServices()
        {
            pnlMain.Controls.Clear();
            var fluidFilterPanel = new FluidFilterPanel(this);
            fluidFilterPanel.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(fluidFilterPanel);
        }
        public void LoadCustomPerformanceServices()
        {
            pnlMain.Controls.Clear();
            var customPerfPanel = new CustomPerfPanel(this);
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
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
