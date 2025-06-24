namespace OS_FinalProj.Screens
{
    partial class ProfilePanel
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
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            lblContactNum = new Label();
            lblVehicleInfo = new Label();
            cboVehicleInfo = new ComboBox();
            rbServices = new RadioButton();
            rbHistory = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(18, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 37);
            btnBack.TabIndex = 1;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(730, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 37);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(98, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 23);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblContactNum
            // 
            lblContactNum.AutoSize = true;
            lblContactNum.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNum.ForeColor = Color.White;
            lblContactNum.Location = new Point(98, 76);
            lblContactNum.Name = "lblContactNum";
            lblContactNum.Size = new Size(80, 23);
            lblContactNum.TabIndex = 4;
            lblContactNum.Text = "Contact #:";
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleInfo.ForeColor = Color.White;
            lblVehicleInfo.Location = new Point(98, 99);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(86, 23);
            lblVehicleInfo.TabIndex = 5;
            lblVehicleInfo.Text = "Vehicle Info:";
            // 
            // cboVehicleInfo
            // 
            cboVehicleInfo.FormattingEnabled = true;
            cboVehicleInfo.Location = new Point(190, 99);
            cboVehicleInfo.Name = "cboVehicleInfo";
            cboVehicleInfo.Size = new Size(161, 23);
            cboVehicleInfo.TabIndex = 6;
            // 
            // rbServices
            // 
            rbServices.AutoSize = true;
            rbServices.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbServices.ForeColor = SystemColors.ButtonHighlight;
            rbServices.Location = new Point(442, 99);
            rbServices.Name = "rbServices";
            rbServices.Size = new Size(179, 26);
            rbServices.TabIndex = 7;
            rbServices.TabStop = true;
            rbServices.Text = "Ongoing Service/Services";
            rbServices.UseVisualStyleBackColor = true;
            // 
            // rbHistory
            // 
            rbHistory.AutoSize = true;
            rbHistory.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbHistory.ForeColor = SystemColors.ButtonHighlight;
            rbHistory.Location = new Point(627, 98);
            rbHistory.Name = "rbHistory";
            rbHistory.Size = new Size(68, 26);
            rbHistory.TabIndex = 8;
            rbHistory.TabStop = true;
            rbHistory.Text = "History";
            rbHistory.UseVisualStyleBackColor = true;
            // 
            // ProfilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(rbHistory);
            Controls.Add(rbServices);
            Controls.Add(cboVehicleInfo);
            Controls.Add(lblVehicleInfo);
            Controls.Add(lblContactNum);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Name = "ProfilePanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private PictureBox pictureBox1;
        private Label lblName;
        private Label lblContactNum;
        private Label lblVehicleInfo;
        private ComboBox cboVehicleInfo;
        private RadioButton rbServices;
        private RadioButton rbHistory;
    }
}
