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
            btnDashBoard = new Button();
            btnServices = new Button();
            btnAbout = new Button();
            lblDashBoard = new Label();
            lblServices = new Label();
            lblAbout = new Label();
            pictureBox1 = new PictureBox();
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
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.FromArgb(69, 65, 61);
            btnDashBoard.FlatStyle = FlatStyle.Popup;
            btnDashBoard.ForeColor = Color.FromArgb(69, 65, 61);
            btnDashBoard.Location = new Point(24, 115);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(217, 197);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "profile";
            btnDashBoard.UseVisualStyleBackColor = false;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(69, 65, 61);
            btnServices.FlatStyle = FlatStyle.Popup;
            btnServices.ForeColor = Color.FromArgb(69, 65, 61);
            btnServices.Location = new Point(291, 115);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(217, 197);
            btnServices.TabIndex = 2;
            btnServices.Text = "profile";
            btnServices.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(69, 65, 61);
            btnAbout.FlatStyle = FlatStyle.Popup;
            btnAbout.ForeColor = Color.FromArgb(69, 65, 61);
            btnAbout.Location = new Point(557, 115);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(217, 197);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "profile";
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // lblDashBoard
            // 
            lblDashBoard.AutoSize = true;
            lblDashBoard.BackColor = Color.Transparent;
            lblDashBoard.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = SystemColors.ButtonFace;
            lblDashBoard.Location = new Point(82, 334);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(101, 28);
            lblDashBoard.TabIndex = 4;
            lblDashBoard.Text = "Dashboard";
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.BackColor = Color.Transparent;
            lblServices.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServices.ForeColor = SystemColors.ButtonFace;
            lblServices.Location = new Point(365, 334);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(78, 28);
            lblServices.TabIndex = 5;
            lblServices.Text = "Services";
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbout.ForeColor = SystemColors.ButtonFace;
            lblAbout.Location = new Point(633, 334);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(60, 28);
            lblAbout.TabIndex = 6;
            lblAbout.Text = "About";
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
            // MainScreenPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pictureBox1);
            Controls.Add(lblAbout);
            Controls.Add(lblServices);
            Controls.Add(lblDashBoard);
            Controls.Add(btnAbout);
            Controls.Add(btnServices);
            Controls.Add(btnDashBoard);
            Controls.Add(btnProfile);
            Name = "MainScreenPanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfile;
        private Button btnDashBoard;
        private Button btnServices;
        private Button btnAbout;
        private Label lblDashBoard;
        private Label lblServices;
        private Label lblAbout;
        private PictureBox pictureBox1;
    }
}
