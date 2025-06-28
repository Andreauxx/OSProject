namespace OS_FinalProj.Screens.Services
{
    partial class CustomPerfPanel
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
            btnCustomFab = new ReaLTaiizor.Controls.Button();
            btnExhaustSys = new ReaLTaiizor.Controls.Button();
            btnSuspUp = new ReaLTaiizor.Controls.Button();
            lblCustomPerfSer = new Label();
            btnBack = new Button();
            btnPerfTuning = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.custom1;
            pictureBox1.Location = new Point(365, 35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // btnCustomFab
            // 
            btnCustomFab.BackColor = Color.Transparent;
            btnCustomFab.BorderColor = Color.FromArgb(39, 39, 39);
            btnCustomFab.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnCustomFab.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCustomFab.Font = new Font("Poppins", 9.75F);
            btnCustomFab.Image = null;
            btnCustomFab.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomFab.InactiveColor = Color.FromArgb(214, 211, 206);
            btnCustomFab.Location = new Point(472, 393);
            btnCustomFab.Margin = new Padding(3, 4, 3, 4);
            btnCustomFab.Name = "btnCustomFab";
            btnCustomFab.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnCustomFab.PressedColor = Color.FromArgb(255, 131, 0);
            btnCustomFab.Size = new Size(247, 53);
            btnCustomFab.TabIndex = 88;
            btnCustomFab.Text = "Custom Fabrication and Parts Replacement";
            btnCustomFab.TextAlignment = StringAlignment.Center;
            // 
            // btnExhaustSys
            // 
            btnExhaustSys.BackColor = Color.Transparent;
            btnExhaustSys.BorderColor = Color.FromArgb(39, 39, 39);
            btnExhaustSys.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnExhaustSys.EnteredColor = Color.FromArgb(32, 34, 37);
            btnExhaustSys.Font = new Font("Poppins", 9.75F);
            btnExhaustSys.Image = null;
            btnExhaustSys.ImageAlign = ContentAlignment.MiddleLeft;
            btnExhaustSys.InactiveColor = Color.FromArgb(214, 211, 206);
            btnExhaustSys.Location = new Point(186, 393);
            btnExhaustSys.Margin = new Padding(3, 4, 3, 4);
            btnExhaustSys.Name = "btnExhaustSys";
            btnExhaustSys.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnExhaustSys.PressedColor = Color.FromArgb(255, 131, 0);
            btnExhaustSys.Size = new Size(247, 53);
            btnExhaustSys.TabIndex = 87;
            btnExhaustSys.Text = "Exhaust System Upgrade";
            btnExhaustSys.TextAlignment = StringAlignment.Center;
            // 
            // btnSuspUp
            // 
            btnSuspUp.BackColor = Color.Transparent;
            btnSuspUp.BorderColor = Color.FromArgb(39, 39, 39);
            btnSuspUp.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnSuspUp.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSuspUp.Font = new Font("Poppins", 9.75F);
            btnSuspUp.Image = null;
            btnSuspUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuspUp.InactiveColor = Color.FromArgb(214, 211, 206);
            btnSuspUp.Location = new Point(472, 309);
            btnSuspUp.Margin = new Padding(3, 4, 3, 4);
            btnSuspUp.Name = "btnSuspUp";
            btnSuspUp.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnSuspUp.PressedColor = Color.FromArgb(255, 131, 0);
            btnSuspUp.Size = new Size(247, 53);
            btnSuspUp.TabIndex = 86;
            btnSuspUp.Text = "Suspension Upgrade";
            btnSuspUp.TextAlignment = StringAlignment.Center;
            // 
            // lblCustomPerfSer
            // 
            lblCustomPerfSer.AutoSize = true;
            lblCustomPerfSer.BackColor = Color.Transparent;
            lblCustomPerfSer.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomPerfSer.ForeColor = SystemColors.ButtonFace;
            lblCustomPerfSer.Location = new Point(270, 248);
            lblCustomPerfSer.Name = "lblCustomPerfSer";
            lblCustomPerfSer.Size = new Size(364, 36);
            lblCustomPerfSer.TabIndex = 85;
            lblCustomPerfSer.Text = "Custom and Performance Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(31, 24);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(51, 49);
            btnBack.TabIndex = 84;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnPerfTuning
            // 
            btnPerfTuning.BackColor = Color.Transparent;
            btnPerfTuning.BorderColor = Color.FromArgb(39, 39, 39);
            btnPerfTuning.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnPerfTuning.EnteredColor = Color.FromArgb(32, 34, 37);
            btnPerfTuning.Font = new Font("Poppins", 9.75F);
            btnPerfTuning.Image = null;
            btnPerfTuning.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerfTuning.InactiveColor = Color.FromArgb(214, 211, 206);
            btnPerfTuning.Location = new Point(186, 309);
            btnPerfTuning.Margin = new Padding(3, 4, 3, 4);
            btnPerfTuning.Name = "btnPerfTuning";
            btnPerfTuning.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnPerfTuning.PressedColor = Color.FromArgb(255, 131, 0);
            btnPerfTuning.Size = new Size(247, 53);
            btnPerfTuning.TabIndex = 83;
            btnPerfTuning.Text = "Performance Tuning";
            btnPerfTuning.TextAlignment = StringAlignment.Center;
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
            btnAddtoServ.Location = new Point(667, 494);
            btnAddtoServ.Margin = new Padding(3, 4, 3, 4);
            btnAddtoServ.Name = "btnAddtoServ";
            btnAddtoServ.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Size = new Size(202, 39);
            btnAddtoServ.TabIndex = 82;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(39, 39, 39);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.FromArgb(39, 39, 39);
            btn_back.Image = Properties.Resources.backright;
            btn_back.Location = new Point(31, 217);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(51, 96);
            btn_back.TabIndex = 90;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // CustomPerfPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btn_back);
            Controls.Add(pictureBox1);
            Controls.Add(btnCustomFab);
            Controls.Add(btnExhaustSys);
            Controls.Add(btnSuspUp);
            Controls.Add(lblCustomPerfSer);
            Controls.Add(btnBack);
            Controls.Add(btnPerfTuning);
            Controls.Add(btnAddtoServ);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomPerfPanel";
            Size = new Size(914, 553);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnCustomFab;
        private ReaLTaiizor.Controls.Button btnExhaustSys;
        private ReaLTaiizor.Controls.Button btnSuspUp;
        private Label lblCustomPerfSer;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnPerfTuning;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
        private Button btn_back;
    }
}
