namespace OS_FinalProj.Screens.Services
{
    partial class FluidFilterPanel
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
            btnPowerSteerFlush = new ReaLTaiizor.Controls.Button();
            btnBrakePadRep = new ReaLTaiizor.Controls.Button();
            btnFuelFiltRep = new ReaLTaiizor.Controls.Button();
            lblFluidFilServ = new Label();
            btnBack = new Button();
            btnCoolFlushRep = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.fluid1;
            pictureBox1.Location = new Point(339, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // btnPowerSteerFlush
            // 
            btnPowerSteerFlush.BackColor = Color.Transparent;
            btnPowerSteerFlush.BorderColor = Color.FromArgb(39, 39, 39);
            btnPowerSteerFlush.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnPowerSteerFlush.EnteredColor = Color.FromArgb(32, 34, 37);
            btnPowerSteerFlush.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPowerSteerFlush.Image = null;
            btnPowerSteerFlush.ImageAlign = ContentAlignment.MiddleLeft;
            btnPowerSteerFlush.InactiveColor = Color.FromArgb(214, 211, 206);
            btnPowerSteerFlush.Location = new Point(455, 330);
            btnPowerSteerFlush.Name = "btnPowerSteerFlush";
            btnPowerSteerFlush.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnPowerSteerFlush.PressedColor = Color.FromArgb(255, 131, 0);
            btnPowerSteerFlush.Size = new Size(216, 40);
            btnPowerSteerFlush.TabIndex = 80;
            btnPowerSteerFlush.Text = "Power Steering Fluid Flush";
            btnPowerSteerFlush.TextAlignment = StringAlignment.Center;
            // 
            // btnBrakePadRep
            // 
            btnBrakePadRep.BackColor = Color.Transparent;
            btnBrakePadRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnBrakePadRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnBrakePadRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnBrakePadRep.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrakePadRep.Image = null;
            btnBrakePadRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrakePadRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnBrakePadRep.Location = new Point(162, 330);
            btnBrakePadRep.Name = "btnBrakePadRep";
            btnBrakePadRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnBrakePadRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnBrakePadRep.Size = new Size(216, 40);
            btnBrakePadRep.TabIndex = 79;
            btnBrakePadRep.Text = "Brake Pad Replacement";
            btnBrakePadRep.TextAlignment = StringAlignment.Center;
            // 
            // btnFuelFiltRep
            // 
            btnFuelFiltRep.BackColor = Color.Transparent;
            btnFuelFiltRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnFuelFiltRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnFuelFiltRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnFuelFiltRep.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFuelFiltRep.Image = null;
            btnFuelFiltRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuelFiltRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnFuelFiltRep.Location = new Point(455, 255);
            btnFuelFiltRep.Name = "btnFuelFiltRep";
            btnFuelFiltRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnFuelFiltRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnFuelFiltRep.Size = new Size(216, 40);
            btnFuelFiltRep.TabIndex = 78;
            btnFuelFiltRep.Text = "Fuel Filter Replacement";
            btnFuelFiltRep.TextAlignment = StringAlignment.Center;
            // 
            // lblFluidFilServ
            // 
            lblFluidFilServ.AutoSize = true;
            lblFluidFilServ.BackColor = Color.Transparent;
            lblFluidFilServ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFluidFilServ.ForeColor = SystemColors.ButtonFace;
            lblFluidFilServ.Location = new Point(328, 219);
            lblFluidFilServ.Name = "lblFluidFilServ";
            lblFluidFilServ.Size = new Size(177, 20);
            lblFluidFilServ.TabIndex = 77;
            lblFluidFilServ.Text = "Fluid and Filter Services";
            lblFluidFilServ.Click += lblTireServ_Click;
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
            // btnCoolFlushRep
            // 
            btnCoolFlushRep.BackColor = Color.Transparent;
            btnCoolFlushRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnCoolFlushRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnCoolFlushRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCoolFlushRep.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCoolFlushRep.Image = null;
            btnCoolFlushRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnCoolFlushRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnCoolFlushRep.Location = new Point(162, 255);
            btnCoolFlushRep.Name = "btnCoolFlushRep";
            btnCoolFlushRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnCoolFlushRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnCoolFlushRep.Size = new Size(216, 40);
            btnCoolFlushRep.TabIndex = 75;
            btnCoolFlushRep.Text = "Coolant Flush and Replacement";
            btnCoolFlushRep.TextAlignment = StringAlignment.Center;
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
            btnAddtoServ.TabIndex = 74;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // FluidFilterPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pictureBox1);
            Controls.Add(btnPowerSteerFlush);
            Controls.Add(btnBrakePadRep);
            Controls.Add(btnFuelFiltRep);
            Controls.Add(lblFluidFilServ);
            Controls.Add(btnBack);
            Controls.Add(btnCoolFlushRep);
            Controls.Add(btnAddtoServ);
            Name = "FluidFilterPanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnPowerSteerFlush;
        private ReaLTaiizor.Controls.Button btnBrakePadRep;
        private ReaLTaiizor.Controls.Button btnFuelFiltRep;
        private Label lblFluidFilServ;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnCoolFlushRep;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
    }
}
