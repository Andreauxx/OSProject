namespace OS_FinalProj.Screens
{
    partial class ServicePopup2
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
            lblCustPerfServ = new Label();
            lblFluidFilServ = new Label();
            lblDiagCheckServ = new Label();
            lblTireServ = new Label();
            lblElecLightServ = new Label();
            btnBack = new Button();
            btnFluidFilServ = new Button();
            btnDiagCheckServ = new Button();
            btnCustPerfServ = new Button();
            btnTireServ = new Button();
            btnElecLightServ = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblCustPerfServ
            // 
            lblCustPerfServ.AutoSize = true;
            lblCustPerfServ.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustPerfServ.ForeColor = SystemColors.ButtonFace;
            lblCustPerfServ.Location = new Point(587, 520);
            lblCustPerfServ.Name = "lblCustPerfServ";
            lblCustPerfServ.Size = new Size(274, 26);
            lblCustPerfServ.TabIndex = 26;
            lblCustPerfServ.Text = "Custom and Performance Services";
            // 
            // lblFluidFilServ
            // 
            lblFluidFilServ.AutoSize = true;
            lblFluidFilServ.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFluidFilServ.ForeColor = SystemColors.ButtonFace;
            lblFluidFilServ.Location = new Point(358, 520);
            lblFluidFilServ.Name = "lblFluidFilServ";
            lblFluidFilServ.Size = new Size(188, 26);
            lblFluidFilServ.TabIndex = 25;
            lblFluidFilServ.Text = "Fluid and Filter Services";
            // 
            // lblDiagCheckServ
            // 
            lblDiagCheckServ.AutoSize = true;
            lblDiagCheckServ.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagCheckServ.ForeColor = SystemColors.ButtonFace;
            lblDiagCheckServ.Location = new Point(46, 520);
            lblDiagCheckServ.Name = "lblDiagCheckServ";
            lblDiagCheckServ.Size = new Size(269, 26);
            lblDiagCheckServ.TabIndex = 24;
            lblDiagCheckServ.Text = "Diagnostic and Check up Services";
            // 
            // lblTireServ
            // 
            lblTireServ.AutoSize = true;
            lblTireServ.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTireServ.ForeColor = SystemColors.ButtonFace;
            lblTireServ.Location = new Point(539, 268);
            lblTireServ.Name = "lblTireServ";
            lblTireServ.Size = new Size(119, 30);
            lblTireServ.TabIndex = 23;
            lblTireServ.Text = "Tire Services";
            // 
            // lblElecLightServ
            // 
            lblElecLightServ.AutoSize = true;
            lblElecLightServ.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblElecLightServ.ForeColor = SystemColors.ButtonFace;
            lblElecLightServ.Location = new Point(197, 268);
            lblElecLightServ.Name = "lblElecLightServ";
            lblElecLightServ.Size = new Size(272, 30);
            lblElecLightServ.TabIndex = 22;
            lblElecLightServ.Text = "Electrical and Lighting Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(39, 39, 39);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(39, 39, 39);
            btnBack.Image = Properties.Resources.backright;
            btnBack.Location = new Point(18, 221);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(51, 96);
            btnBack.TabIndex = 21;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button6_Click;
            // 
            // btnFluidFilServ
            // 
            btnFluidFilServ.BackColor = Color.FromArgb(69, 65, 61);
            btnFluidFilServ.FlatStyle = FlatStyle.Popup;
            btnFluidFilServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnFluidFilServ.Image = Properties.Resources.fluid;
            btnFluidFilServ.Location = new Point(352, 315);
            btnFluidFilServ.Margin = new Padding(3, 4, 3, 4);
            btnFluidFilServ.Name = "btnFluidFilServ";
            btnFluidFilServ.Size = new Size(194, 184);
            btnFluidFilServ.TabIndex = 19;
            btnFluidFilServ.UseVisualStyleBackColor = false;
            btnFluidFilServ.Click += btnFluidFilServ_Click;
            // 
            // btnDiagCheckServ
            // 
            btnDiagCheckServ.BackColor = Color.FromArgb(69, 65, 61);
            btnDiagCheckServ.FlatStyle = FlatStyle.Popup;
            btnDiagCheckServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnDiagCheckServ.Image = Properties.Resources.diagnostic;
            btnDiagCheckServ.Location = new Point(75, 315);
            btnDiagCheckServ.Margin = new Padding(3, 4, 3, 4);
            btnDiagCheckServ.Name = "btnDiagCheckServ";
            btnDiagCheckServ.Size = new Size(201, 184);
            btnDiagCheckServ.TabIndex = 18;
            btnDiagCheckServ.UseVisualStyleBackColor = false;
            btnDiagCheckServ.Click += btnDiagCheckServ_Click;
            // 
            // btnCustPerfServ
            // 
            btnCustPerfServ.BackColor = Color.FromArgb(69, 65, 61);
            btnCustPerfServ.FlatStyle = FlatStyle.Popup;
            btnCustPerfServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnCustPerfServ.Image = Properties.Resources.custom;
            btnCustPerfServ.Location = new Point(622, 315);
            btnCustPerfServ.Margin = new Padding(3, 4, 3, 4);
            btnCustPerfServ.Name = "btnCustPerfServ";
            btnCustPerfServ.Size = new Size(199, 184);
            btnCustPerfServ.TabIndex = 17;
            btnCustPerfServ.UseVisualStyleBackColor = false;
            btnCustPerfServ.Click += btnCustPerfServ_Click;
            // 
            // btnTireServ
            // 
            btnTireServ.BackColor = Color.FromArgb(69, 65, 61);
            btnTireServ.FlatStyle = FlatStyle.Popup;
            btnTireServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnTireServ.Image = Properties.Resources.tire;
            btnTireServ.Location = new Point(502, 67);
            btnTireServ.Margin = new Padding(3, 4, 3, 4);
            btnTireServ.Name = "btnTireServ";
            btnTireServ.Size = new Size(194, 184);
            btnTireServ.TabIndex = 16;
            btnTireServ.UseVisualStyleBackColor = false;
            btnTireServ.Click += btnTireServ_Click;
            // 
            // btnElecLightServ
            // 
            btnElecLightServ.BackColor = Color.FromArgb(69, 65, 61);
            btnElecLightServ.FlatStyle = FlatStyle.Popup;
            btnElecLightServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnElecLightServ.Image = Properties.Resources.electrical;
            btnElecLightServ.Location = new Point(231, 67);
            btnElecLightServ.Margin = new Padding(3, 4, 3, 4);
            btnElecLightServ.Name = "btnElecLightServ";
            btnElecLightServ.Size = new Size(192, 184);
            btnElecLightServ.TabIndex = 15;
            btnElecLightServ.UseVisualStyleBackColor = false;
            btnElecLightServ.Click += btnElecLightServ_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(39, 39, 39);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(39, 39, 39);
            button5.Image = Properties.Resources.ProfIcon2;
            button5.Location = new Point(8, 4);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(55, 56);
            button5.TabIndex = 27;
            button5.UseVisualStyleBackColor = false;
            // 
            // ServicePopup2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(button5);
            Controls.Add(lblCustPerfServ);
            Controls.Add(lblFluidFilServ);
            Controls.Add(lblDiagCheckServ);
            Controls.Add(lblTireServ);
            Controls.Add(lblElecLightServ);
            Controls.Add(btnBack);
            Controls.Add(btnFluidFilServ);
            Controls.Add(btnDiagCheckServ);
            Controls.Add(btnCustPerfServ);
            Controls.Add(btnTireServ);
            Controls.Add(btnElecLightServ);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServicePopup2";
            Size = new Size(914, 601);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustPerfServ;
        private Label lblFluidFilServ;
        private Label lblDiagCheckServ;
        private Label lblTireServ;
        private Label lblElecLightServ;
        private Button btnBack;
        private Button btnFluidFilServ;
        private Button btnDiagCheckServ;
        private Button btnCustPerfServ;
        private Button btnTireServ;
        private Button btnElecLightServ;
        private Button button5;
    }
}
