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
            btnProfile = new Button();
            btnServices = new Button();
            btnAbout = new Button();
            lblServices = new Label();
            lblAbout = new Label();
            pictureBox1 = new PictureBox();
            btnDashbaord = new Button();
            lblDashboard = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(69, 65, 61);
            btnProfile.FlatStyle = FlatStyle.Popup;
            btnProfile.ForeColor = Color.FromArgb(69, 65, 61);
            btnProfile.Location = new Point(13, 14);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(45, 37);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(39, 39, 39);
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.ForeColor = Color.FromArgb(39, 39, 39);
            btnServices.Image = Properties.Resources.services;
            btnServices.Location = new Point(269, 136);
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
            btnAbout.Location = new Point(530, 136);
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
            lblServices.Location = new Point(346, 324);
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
            lblAbout.Location = new Point(616, 324);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(60, 28);
            lblAbout.TabIndex = 6;
            lblAbout.Text = "About";
            lblAbout.Click += lblAbout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(736, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 37);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnDashbaord
            // 
            btnDashbaord.FlatStyle = FlatStyle.Flat;
            btnDashbaord.ForeColor = Color.FromArgb(39, 39, 39);
            btnDashbaord.Image = Properties.Resources.dboard;
            btnDashbaord.Location = new Point(28, 136);
            btnDashbaord.Name = "btnDashbaord";
            btnDashbaord.Size = new Size(214, 181);
            btnDashbaord.TabIndex = 8;
            btnDashbaord.UseVisualStyleBackColor = true;
            btnDashbaord.Click += btnDashbaord_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ControlLightLight;
            lblDashboard.Location = new Point(89, 324);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(101, 28);
            lblDashboard.TabIndex = 9;
            lblDashboard.Text = "Dashboard";
            // 
            // MainScreenPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(lblDashboard);
            Controls.Add(btnDashbaord);
            Controls.Add(pictureBox1);
            Controls.Add(lblAbout);
            Controls.Add(lblServices);
            Controls.Add(btnAbout);
            Controls.Add(btnServices);
            Controls.Add(btnProfile);
            Name = "MainScreenPanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfile;
        private Button btnServices;
        private Button btnAbout;
        private Label lblServices;
        private Label lblAbout;
        private PictureBox pictureBox1;
        private Button btnDashbaord;
        private Label lblDashboard;
    }
}
