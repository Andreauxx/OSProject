namespace OS_FinalProj.Screens.Services
{
    partial class DiagnosticCheckPanel
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
            btnPrePur = new ReaLTaiizor.Controls.Button();
            btnCarHealthCheck = new ReaLTaiizor.Controls.Button();
            lblDiagnostickCheck = new Label();
            btnBack = new Button();
            btnCompDiag = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.diagnostic1;
            pictureBox1.Location = new Point(310, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // btnPrePur
            // 
            btnPrePur.BackColor = Color.Transparent;
            btnPrePur.BorderColor = Color.FromArgb(39, 39, 39);
            btnPrePur.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnPrePur.EnteredColor = Color.FromArgb(32, 34, 37);
            btnPrePur.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrePur.Image = null;
            btnPrePur.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrePur.InactiveColor = Color.FromArgb(214, 211, 206);
            btnPrePur.Location = new Point(285, 320);
            btnPrePur.Name = "btnPrePur";
            btnPrePur.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnPrePur.PressedColor = Color.FromArgb(255, 131, 0);
            btnPrePur.Size = new Size(216, 40);
            btnPrePur.TabIndex = 79;
            btnPrePur.Text = "Pre-purchase Vehicle Inspection";
            btnPrePur.TextAlignment = StringAlignment.Center;
            btnPrePur.Click += btnTireBal_Click;
            // 
            // btnCarHealthCheck
            // 
            btnCarHealthCheck.BackColor = Color.Transparent;
            btnCarHealthCheck.BorderColor = Color.FromArgb(39, 39, 39);
            btnCarHealthCheck.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnCarHealthCheck.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCarHealthCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCarHealthCheck.Image = null;
            btnCarHealthCheck.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarHealthCheck.InactiveColor = Color.FromArgb(214, 211, 206);
            btnCarHealthCheck.Location = new Point(426, 251);
            btnCarHealthCheck.Name = "btnCarHealthCheck";
            btnCarHealthCheck.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnCarHealthCheck.PressedColor = Color.FromArgb(255, 131, 0);
            btnCarHealthCheck.Size = new Size(216, 40);
            btnCarHealthCheck.TabIndex = 78;
            btnCarHealthCheck.Text = "Vehicle Health Checkup";
            btnCarHealthCheck.TextAlignment = StringAlignment.Center;
            // 
            // lblDiagnostickCheck
            // 
            lblDiagnostickCheck.AutoSize = true;
            lblDiagnostickCheck.BackColor = Color.Transparent;
            lblDiagnostickCheck.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostickCheck.ForeColor = SystemColors.ButtonFace;
            lblDiagnostickCheck.Location = new Point(256, 199);
            lblDiagnostickCheck.Name = "lblDiagnostickCheck";
            lblDiagnostickCheck.Size = new Size(282, 28);
            lblDiagnostickCheck.TabIndex = 77;
            lblDiagnostickCheck.Text = "Diagnostic and Check up Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(29, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 37);
            btnBack.TabIndex = 76;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCompDiag
            // 
            btnCompDiag.BackColor = Color.Transparent;
            btnCompDiag.BorderColor = Color.FromArgb(39, 39, 39);
            btnCompDiag.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnCompDiag.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCompDiag.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompDiag.Image = null;
            btnCompDiag.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompDiag.InactiveColor = Color.FromArgb(214, 211, 206);
            btnCompDiag.Location = new Point(133, 251);
            btnCompDiag.Name = "btnCompDiag";
            btnCompDiag.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnCompDiag.PressedColor = Color.FromArgb(255, 131, 0);
            btnCompDiag.Size = new Size(216, 40);
            btnCompDiag.TabIndex = 75;
            btnCompDiag.Text = "Computer Diagnostics ";
            btnCompDiag.TextAlignment = StringAlignment.Center;
            // 
            // btnAddtoServ
            // 
            btnAddtoServ.BackColor = Color.Transparent;
            btnAddtoServ.BorderColor = Color.FromArgb(39, 39, 39);
            btnAddtoServ.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnAddtoServ.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAddtoServ.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddtoServ.Image = null;
            btnAddtoServ.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddtoServ.InactiveColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Location = new Point(602, 396);
            btnAddtoServ.Name = "btnAddtoServ";
            btnAddtoServ.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Size = new Size(141, 29);
            btnAddtoServ.TabIndex = 74;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // DiagnosticCheckPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrePur);
            Controls.Add(btnCarHealthCheck);
            Controls.Add(lblDiagnostickCheck);
            Controls.Add(btnBack);
            Controls.Add(btnCompDiag);
            Controls.Add(btnAddtoServ);
            Name = "DiagnosticCheckPanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnPrePur;
        private ReaLTaiizor.Controls.Button btnCarHealthCheck;
        private Label lblDiagnostickCheck;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnCompDiag;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
    }
}
