namespace OS_FinalProj.Screens
{
    partial class MainScreenPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenPanel));
            btnServices = new Button();
            btnAbout = new Button();
            lblServices = new Label();
            lblAbout = new Label();
            lblDashboard = new Label();
            btnProfile = new Button();
            btnServiceBasket = new Button();
            btnDashbaord = new Button();
            SuspendLayout();
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(39, 39, 39);
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.ForeColor = Color.FromArgb(39, 39, 39);
            btnServices.Image = Properties.Resources.services;
            btnServices.Location = new Point(291, 163);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(217, 185);
            btnServices.TabIndex = 2;
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(39, 39, 39);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.ForeColor = Color.FromArgb(39, 39, 39);
            btnAbout.Image = Properties.Resources.about;
            btnAbout.Location = new Point(543, 162);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(217, 194);
            btnAbout.TabIndex = 3;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.BackColor = Color.Transparent;
            lblServices.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServices.ForeColor = SystemColors.ButtonFace;
            lblServices.Location = new Point(370, 317);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(78, 28);
            lblServices.TabIndex = 5;
            lblServices.Text = "Services";
            lblServices.Click += lblServices_Click;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbout.ForeColor = SystemColors.ButtonFace;
            lblAbout.Location = new Point(631, 318);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(60, 28);
            lblAbout.TabIndex = 6;
            lblAbout.Text = "About";
            lblAbout.Click += lblAbout_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ControlLightLight;
            lblDashboard.Location = new Point(106, 320);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(101, 28);
            lblDashboard.TabIndex = 9;
            lblDashboard.Text = "Dashboard";
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.FromArgb(39, 39, 39);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(40, 16);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(52, 57);
            btnProfile.TabIndex = 35;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // btnServiceBasket
            // 
            btnServiceBasket.BackgroundImageLayout = ImageLayout.None;
            btnServiceBasket.FlatStyle = FlatStyle.Flat;
            btnServiceBasket.ForeColor = Color.FromArgb(39, 39, 39);
            btnServiceBasket.Image = (Image)resources.GetObject("btnServiceBasket.Image");
            btnServiceBasket.Location = new Point(724, 21);
            btnServiceBasket.Name = "btnServiceBasket";
            btnServiceBasket.Size = new Size(59, 52);
            btnServiceBasket.TabIndex = 36;
            btnServiceBasket.UseVisualStyleBackColor = false;
            btnServiceBasket.Click += btnServiceBasket_Click;
            // 
            // btnDashbaord
            // 
            btnDashbaord.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashbaord.FlatAppearance.BorderSize = 0;
            btnDashbaord.FlatStyle = FlatStyle.Popup;
            btnDashbaord.ForeColor = Color.FromArgb(39, 39, 39);
            btnDashbaord.Image = Properties.Resources.dboard;
            btnDashbaord.Location = new Point(44, 165);
            btnDashbaord.Name = "btnDashbaord";
            btnDashbaord.Size = new Size(214, 181);
            btnDashbaord.TabIndex = 8;
            btnDashbaord.UseVisualStyleBackColor = true;
            btnDashbaord.Click += btnDashbaord_Click;
            // 
            // MainScreenPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnServiceBasket);
            Controls.Add(btnProfile);
            Controls.Add(lblDashboard);
            Controls.Add(btnDashbaord);
            Controls.Add(lblAbout);
            Controls.Add(lblServices);
            Controls.Add(btnAbout);
            Controls.Add(btnServices);
            Name = "MainScreenPanel";
            Size = new Size(821, 451);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnServices;
        private Button btnAbout;
        private Label lblServices;
        private Label lblAbout;
        private Label lblDashboard;
        private Button btnProfile;
        private Button btnServiceBasket;
        private Button btnDashbaord;
    }
}
