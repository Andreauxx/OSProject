namespace OS_FinalProj.Screens.Services
{
    partial class FuelExhaustPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnFuelPumRep = new ReaLTaiizor.Controls.Button();
            btnExhaustSysRep = new ReaLTaiizor.Controls.Button();
            btnCatConvRep = new ReaLTaiizor.Controls.Button();
            lblHeatingAircon = new Label();
            btnBack = new Button();
            btnFuelInject = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.fuel1;
            pictureBox1.Location = new Point(308, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // btnFuelPumRep
            // 
            btnFuelPumRep.BackColor = Color.Transparent;
            btnFuelPumRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnFuelPumRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnFuelPumRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnFuelPumRep.Font = new Font("Poppins", 9.75F);
            btnFuelPumRep.Image = null;
            btnFuelPumRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuelPumRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnFuelPumRep.Location = new Point(434, 328);
            btnFuelPumRep.Name = "btnFuelPumRep";
            btnFuelPumRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnFuelPumRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnFuelPumRep.Size = new Size(216, 40);
            btnFuelPumRep.TabIndex = 56;
            btnFuelPumRep.Text = "Fuel Pump Replacement";
            btnFuelPumRep.TextAlignment = StringAlignment.Center;
            // 
            // btnExhaustSysRep
            // 
            btnExhaustSysRep.BackColor = Color.Transparent;
            btnExhaustSysRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnExhaustSysRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnExhaustSysRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnExhaustSysRep.Font = new Font("Poppins", 9.75F);
            btnExhaustSysRep.Image = null;
            btnExhaustSysRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnExhaustSysRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnExhaustSysRep.Location = new Point(141, 328);
            btnExhaustSysRep.Name = "btnExhaustSysRep";
            btnExhaustSysRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnExhaustSysRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnExhaustSysRep.Size = new Size(216, 40);
            btnExhaustSysRep.TabIndex = 55;
            btnExhaustSysRep.Text = "Exhaust System Repair";
            btnExhaustSysRep.TextAlignment = StringAlignment.Center;
            // 
            // btnCatConvRep
            // 
            btnCatConvRep.BackColor = Color.Transparent;
            btnCatConvRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnCatConvRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnCatConvRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCatConvRep.Font = new Font("Poppins", 9.75F);
            btnCatConvRep.Image = null;
            btnCatConvRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatConvRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnCatConvRep.Location = new Point(434, 253);
            btnCatConvRep.Name = "btnCatConvRep";
            btnCatConvRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnCatConvRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnCatConvRep.Size = new Size(216, 40);
            btnCatConvRep.TabIndex = 54;
            btnCatConvRep.Text = "Catalytic Converter Replacement";
            btnCatConvRep.TextAlignment = StringAlignment.Center;
            // 
            // lblHeatingAircon
            // 
            lblHeatingAircon.AutoSize = true;
            lblHeatingAircon.BackColor = Color.Transparent;
            lblHeatingAircon.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeatingAircon.ForeColor = SystemColors.ButtonFace;
            lblHeatingAircon.Location = new Point(267, 213);
            lblHeatingAircon.Name = "lblHeatingAircon";
            lblHeatingAircon.Size = new Size(277, 28);
            lblHeatingAircon.TabIndex = 53;
            lblHeatingAircon.Text = "Fuel and Exhaust System Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(29, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 37);
            btnBack.TabIndex = 52;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnFuelInject
            // 
            btnFuelInject.BackColor = Color.Transparent;
            btnFuelInject.BorderColor = Color.FromArgb(39, 39, 39);
            btnFuelInject.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnFuelInject.EnteredColor = Color.FromArgb(32, 34, 37);
            btnFuelInject.Font = new Font("Poppins", 9.75F);
            btnFuelInject.Image = null;
            btnFuelInject.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuelInject.InactiveColor = Color.FromArgb(214, 211, 206);
            btnFuelInject.Location = new Point(141, 253);
            btnFuelInject.Name = "btnFuelInject";
            btnFuelInject.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnFuelInject.PressedColor = Color.FromArgb(255, 131, 0);
            btnFuelInject.Size = new Size(216, 40);
            btnFuelInject.TabIndex = 51;
            btnFuelInject.Text = "Fuel Injector Cleaning";
            btnFuelInject.TextAlignment = StringAlignment.Center;
            // 
            // btnAddtoServ
            // 
            btnAddtoServ.BackColor = Color.Transparent;
            btnAddtoServ.BorderColor = Color.FromArgb(39, 39, 39);
            btnAddtoServ.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnAddtoServ.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAddtoServ.Font = new Font("Poppins", 9.75F);
            btnAddtoServ.Image = null;
            btnAddtoServ.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddtoServ.InactiveColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Location = new Point(591, 398);
            btnAddtoServ.Name = "btnAddtoServ";
            btnAddtoServ.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Size = new Size(160, 29);
            btnAddtoServ.TabIndex = 50;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // FuelExhaustPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pictureBox1);
            Controls.Add(btnFuelPumRep);
            Controls.Add(btnExhaustSysRep);
            Controls.Add(btnCatConvRep);
            Controls.Add(lblHeatingAircon);
            Controls.Add(btnBack);
            Controls.Add(btnFuelInject);
            Controls.Add(btnAddtoServ);
            Name = "FuelExhaustPanel";
            Size = new Size(800, 451);
            Load += FuelExhaustPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnFuelPumRep;
        private ReaLTaiizor.Controls.Button btnExhaustSysRep;
        private ReaLTaiizor.Controls.Button btnCatConvRep;
        private Label lblHeatingAircon;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnFuelInject;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
    }
}
