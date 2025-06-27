namespace OS_FinalProj.Screens.Services
{
    partial class HeatingAirConPanel
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
            btnCabAirRep = new ReaLTaiizor.Controls.Button();
            btnAcSystemRep = new ReaLTaiizor.Controls.Button();
            btnHeatCorRep = new ReaLTaiizor.Controls.Button();
            lblHeatingAircon = new Label();
            btnBack = new Button();
            btnAcRec = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.heating1;
            pictureBox1.Location = new Point(329, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // btnCabAirRep
            // 
            btnCabAirRep.BackColor = Color.Transparent;
            btnCabAirRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnCabAirRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnCabAirRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCabAirRep.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCabAirRep.Image = null;
            btnCabAirRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnCabAirRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnCabAirRep.Location = new Point(455, 330);
            btnCabAirRep.Name = "btnCabAirRep";
            btnCabAirRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnCabAirRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnCabAirRep.Size = new Size(216, 40);
            btnCabAirRep.TabIndex = 48;
            btnCabAirRep.Text = "Cabin Air Filter Replacement";
            btnCabAirRep.TextAlignment = StringAlignment.Center;
            // 
            // btnAcSystemRep
            // 
            btnAcSystemRep.BackColor = Color.Transparent;
            btnAcSystemRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnAcSystemRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnAcSystemRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAcSystemRep.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcSystemRep.Image = null;
            btnAcSystemRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcSystemRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnAcSystemRep.Location = new Point(162, 330);
            btnAcSystemRep.Name = "btnAcSystemRep";
            btnAcSystemRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAcSystemRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnAcSystemRep.Size = new Size(216, 40);
            btnAcSystemRep.TabIndex = 47;
            btnAcSystemRep.Text = "A/C System Repair";
            btnAcSystemRep.TextAlignment = StringAlignment.Center;
            // 
            // btnHeatCorRep
            // 
            btnHeatCorRep.BackColor = Color.Transparent;
            btnHeatCorRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnHeatCorRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnHeatCorRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnHeatCorRep.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeatCorRep.Image = null;
            btnHeatCorRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeatCorRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnHeatCorRep.Location = new Point(455, 255);
            btnHeatCorRep.Name = "btnHeatCorRep";
            btnHeatCorRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnHeatCorRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnHeatCorRep.Size = new Size(216, 40);
            btnHeatCorRep.TabIndex = 46;
            btnHeatCorRep.Text = "Heater Core Replacement";
            btnHeatCorRep.TextAlignment = StringAlignment.Center;
            // 
            // lblHeatingAircon
            // 
            lblHeatingAircon.AutoSize = true;
            lblHeatingAircon.BackColor = Color.Transparent;
            lblHeatingAircon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeatingAircon.ForeColor = SystemColors.ButtonFace;
            lblHeatingAircon.Location = new Point(288, 215);
            lblHeatingAircon.Name = "lblHeatingAircon";
            lblHeatingAircon.Size = new Size(275, 20);
            lblHeatingAircon.TabIndex = 45;
            lblHeatingAircon.Text = "Heating and Air Conditioning Services";
            lblHeatingAircon.Click += lblSusSteering_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(29, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 37);
            btnBack.TabIndex = 44;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAcRec
            // 
            btnAcRec.BackColor = Color.Transparent;
            btnAcRec.BorderColor = Color.FromArgb(39, 39, 39);
            btnAcRec.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnAcRec.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAcRec.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcRec.Image = null;
            btnAcRec.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcRec.InactiveColor = Color.FromArgb(214, 211, 206);
            btnAcRec.Location = new Point(162, 255);
            btnAcRec.Name = "btnAcRec";
            btnAcRec.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAcRec.PressedColor = Color.FromArgb(255, 131, 0);
            btnAcRec.Size = new Size(216, 40);
            btnAcRec.TabIndex = 43;
            btnAcRec.Text = "A/C Recharge";
            btnAcRec.TextAlignment = StringAlignment.Center;
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
            btnAddtoServ.Location = new Point(631, 400);
            btnAddtoServ.Name = "btnAddtoServ";
            btnAddtoServ.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Size = new Size(141, 29);
            btnAddtoServ.TabIndex = 42;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // HeatingAirConPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pictureBox1);
            Controls.Add(btnCabAirRep);
            Controls.Add(btnAcSystemRep);
            Controls.Add(btnHeatCorRep);
            Controls.Add(lblHeatingAircon);
            Controls.Add(btnBack);
            Controls.Add(btnAcRec);
            Controls.Add(btnAddtoServ);
            Name = "HeatingAirConPanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnCabAirRep;
        private ReaLTaiizor.Controls.Button btnAcSystemRep;
        private ReaLTaiizor.Controls.Button btnHeatCorRep;
        private Label lblHeatingAircon;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnAcRec;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
    }
}
