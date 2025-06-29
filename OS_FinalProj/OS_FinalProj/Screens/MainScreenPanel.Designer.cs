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
            pictureBox1 = new PictureBox();
            btnDashbaord = new Button();
            lblDashboard = new Label();
            btnProfile = new Button();
            btnServiceBasket = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(39, 39, 39);
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.ForeColor = Color.FromArgb(39, 39, 39);
            btnServices.Image = Properties.Resources.services;
            btnServices.Location = new Point(313, 220);
            btnServices.Margin = new Padding(3, 4, 3, 4);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(248, 247);
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
            btnAbout.Location = new Point(601, 218);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(248, 259);
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
            lblServices.Location = new Point(394, 423);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(96, 36);
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
            lblAbout.Location = new Point(694, 423);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(75, 36);
            lblAbout.TabIndex = 6;
            lblAbout.Text = "About";
            lblAbout.Click += lblAbout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(841, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 49);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnDashbaord
            // 
            btnDashbaord.FlatStyle = FlatStyle.Flat;
            btnDashbaord.ForeColor = Color.FromArgb(39, 39, 39);
            btnDashbaord.Image = Properties.Resources.dboard;
            btnDashbaord.Location = new Point(31, 223);
            btnDashbaord.Margin = new Padding(3, 4, 3, 4);
            btnDashbaord.Name = "btnDashbaord";
            btnDashbaord.Size = new Size(245, 241);
            btnDashbaord.TabIndex = 8;
            btnDashbaord.UseVisualStyleBackColor = true;
            btnDashbaord.Click += btnDashbaord_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ControlLightLight;
            lblDashboard.Location = new Point(88, 427);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(128, 36);
            lblDashboard.TabIndex = 9;
            lblDashboard.Text = "Dashboard";
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(-9, -33);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(101, 115);
            btnProfile.TabIndex = 35;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // btnServiceBasket
            // 
            btnServiceBasket.BackgroundImageLayout = ImageLayout.None;
            btnServiceBasket.FlatStyle = FlatStyle.Flat;
            btnServiceBasket.Image = (Image)resources.GetObject("btnServiceBasket.Image");
            btnServiceBasket.Location = new Point(98, 0);
            btnServiceBasket.Margin = new Padding(3, 4, 3, 4);
            btnServiceBasket.Name = "btnServiceBasket";
            btnServiceBasket.Size = new Size(79, 82);
            btnServiceBasket.TabIndex = 36;
            btnServiceBasket.UseVisualStyleBackColor = false;
            btnServiceBasket.Click += btnServiceBasket_Click;
            // 
            // MainScreenPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnServiceBasket);
            Controls.Add(btnProfile);
            Controls.Add(lblDashboard);
            Controls.Add(btnDashbaord);
            Controls.Add(pictureBox1);
            Controls.Add(lblAbout);
            Controls.Add(lblServices);
            Controls.Add(btnAbout);
            Controls.Add(btnServices);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainScreenPanel";
            Size = new Size(914, 601);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnServices;
        private Button btnAbout;
        private Label lblServices;
        private Label lblAbout;
        private PictureBox pictureBox1;
        private Button btnDashbaord;
        private Label lblDashboard;
        private Button btnProfile;
        private Button btnServiceBasket;
    }
}
