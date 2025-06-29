namespace OS_FinalProj.Screens
{
    partial class ConfirmedServicesPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmedServicesPopup));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnProfile = new Button();
            btnBackHome = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Confirmation;
            pictureBox1.Location = new Point(-96, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1207, 856);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 119, 4);
            label1.Location = new Point(394, 183);
            label1.Name = "label1";
            label1.Size = new Size(357, 60);
            label1.TabIndex = 124;
            label1.Text = "Service Confirmed!";
            label1.Click += label1_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Popup;
            btnProfile.ForeColor = Color.Transparent;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(0, -23);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(101, 115);
            btnProfile.TabIndex = 125;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.BackColor = Color.Transparent;
            btnBackHome.BorderColor = Color.FromArgb(39, 39, 39);
            btnBackHome.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnBackHome.EnteredColor = Color.FromArgb(32, 34, 37);
            btnBackHome.Font = new Font("Poppins", 9.75F);
            btnBackHome.Image = null;
            btnBackHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackHome.InactiveColor = Color.FromArgb(255, 131, 0);
            btnBackHome.Location = new Point(569, 386);
            btnBackHome.Margin = new Padding(3, 4, 3, 4);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnBackHome.PressedColor = Color.FromArgb(255, 131, 0);
            btnBackHome.Size = new Size(202, 39);
            btnBackHome.TabIndex = 126;
            btnBackHome.Text = "Go Back to Home";
            btnBackHome.TextAlignment = StringAlignment.Center;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // ConfirmedServicesPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnBackHome);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ConfirmedServicesPopup";
            Size = new Size(814, 471);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnProfile;
        private ReaLTaiizor.Controls.Button btnBackHome;
    }
}
