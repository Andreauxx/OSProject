namespace OS_FinalProj.Screens.Services
{
    partial class TireServicesPanel
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
            btnTirePres = new ReaLTaiizor.Controls.Button();
            btnTireBal = new ReaLTaiizor.Controls.Button();
            btnTireMountInst = new ReaLTaiizor.Controls.Button();
            lblTireServ = new Label();
            btnBack = new Button();
            btnTireRep = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tire1;
            pictureBox1.Location = new Point(308, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // btnTirePres
            // 
            btnTirePres.BackColor = Color.Transparent;
            btnTirePres.BorderColor = Color.FromArgb(39, 39, 39);
            btnTirePres.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnTirePres.EnteredColor = Color.FromArgb(32, 34, 37);
            btnTirePres.Font = new Font("Poppins", 9.75F);
            btnTirePres.Image = null;
            btnTirePres.ImageAlign = ContentAlignment.MiddleLeft;
            btnTirePres.InactiveColor = Color.FromArgb(214, 211, 206);
            btnTirePres.Location = new Point(432, 324);
            btnTirePres.Name = "btnTirePres";
            btnTirePres.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnTirePres.PressedColor = Color.FromArgb(255, 131, 0);
            btnTirePres.Size = new Size(216, 40);
            btnTirePres.TabIndex = 72;
            btnTirePres.Text = "Tire Pressure Check";
            btnTirePres.TextAlignment = StringAlignment.Center;
            // 
            // btnTireBal
            // 
            btnTireBal.BackColor = Color.Transparent;
            btnTireBal.BorderColor = Color.FromArgb(39, 39, 39);
            btnTireBal.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnTireBal.EnteredColor = Color.FromArgb(32, 34, 37);
            btnTireBal.Font = new Font("Poppins", 9.75F);
            btnTireBal.Image = null;
            btnTireBal.ImageAlign = ContentAlignment.MiddleLeft;
            btnTireBal.InactiveColor = Color.FromArgb(214, 211, 206);
            btnTireBal.Location = new Point(139, 324);
            btnTireBal.Name = "btnTireBal";
            btnTireBal.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnTireBal.PressedColor = Color.FromArgb(255, 131, 0);
            btnTireBal.Size = new Size(216, 40);
            btnTireBal.TabIndex = 71;
            btnTireBal.Text = "Tire Balancing";
            btnTireBal.TextAlignment = StringAlignment.Center;
            // 
            // btnTireMountInst
            // 
            btnTireMountInst.BackColor = Color.Transparent;
            btnTireMountInst.BorderColor = Color.FromArgb(39, 39, 39);
            btnTireMountInst.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnTireMountInst.EnteredColor = Color.FromArgb(32, 34, 37);
            btnTireMountInst.Font = new Font("Poppins", 9.75F);
            btnTireMountInst.Image = null;
            btnTireMountInst.ImageAlign = ContentAlignment.MiddleLeft;
            btnTireMountInst.InactiveColor = Color.FromArgb(214, 211, 206);
            btnTireMountInst.Location = new Point(432, 249);
            btnTireMountInst.Name = "btnTireMountInst";
            btnTireMountInst.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnTireMountInst.PressedColor = Color.FromArgb(255, 131, 0);
            btnTireMountInst.Size = new Size(216, 40);
            btnTireMountInst.TabIndex = 70;
            btnTireMountInst.Text = "Tire Mounting and Installation";
            btnTireMountInst.TextAlignment = StringAlignment.Center;
            // 
            // lblTireServ
            // 
            lblTireServ.AutoSize = true;
            lblTireServ.BackColor = Color.Transparent;
            lblTireServ.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTireServ.ForeColor = SystemColors.ButtonFace;
            lblTireServ.Location = new Point(340, 201);
            lblTireServ.Name = "lblTireServ";
            lblTireServ.Size = new Size(111, 28);
            lblTireServ.TabIndex = 69;
            lblTireServ.Text = "Tire Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(29, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 37);
            btnBack.TabIndex = 68;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnTireRep
            // 
            btnTireRep.BackColor = Color.Transparent;
            btnTireRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnTireRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnTireRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnTireRep.Font = new Font("Poppins", 9.75F);
            btnTireRep.Image = null;
            btnTireRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnTireRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnTireRep.Location = new Point(139, 249);
            btnTireRep.Name = "btnTireRep";
            btnTireRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnTireRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnTireRep.Size = new Size(216, 40);
            btnTireRep.TabIndex = 67;
            btnTireRep.Text = "Tire Repair";
            btnTireRep.TextAlignment = StringAlignment.Center;
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
            btnAddtoServ.Location = new Point(589, 394);
            btnAddtoServ.Name = "btnAddtoServ";
            btnAddtoServ.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Size = new Size(160, 29);
            btnAddtoServ.TabIndex = 66;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // TireServicesPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pictureBox1);
            Controls.Add(btnTirePres);
            Controls.Add(btnTireBal);
            Controls.Add(btnTireMountInst);
            Controls.Add(lblTireServ);
            Controls.Add(btnBack);
            Controls.Add(btnTireRep);
            Controls.Add(btnAddtoServ);
            Name = "TireServicesPanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnTirePres;
        private ReaLTaiizor.Controls.Button btnTireBal;
        private ReaLTaiizor.Controls.Button btnTireMountInst;
        private Label lblTireServ;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnTireRep;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
    }
}
