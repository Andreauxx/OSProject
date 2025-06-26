using OS_FinalProj.Screens;
using OS_FinalProj.Screens.Services;
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
        public FormMain()
        {
            InitializeComponent();
            LoadLogin(); // Start with login form
        }

        public void LoadLogin()
        {
            pnlMain.Controls.Clear();
            var loginPanel = new LoginPanel(this); // Pass reference
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
            var profilePanel = new ProfilePanel(this);
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
    }
}
