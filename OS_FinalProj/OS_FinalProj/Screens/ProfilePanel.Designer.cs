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
            label1 = new Label();
            label2 = new Label();
            btnAddCar = new ReaLTaiizor.Controls.Button();
            btnEditProfile = new ReaLTaiizor.Controls.Button();
            txtName = new TextBox();
            txtContact = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnSaveChanges = new ReaLTaiizor.Controls.Button();
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
            lblName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(98, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 16);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblContactNum
            // 
            lblContactNum.AutoSize = true;
            lblContactNum.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNum.ForeColor = Color.White;
            lblContactNum.Location = new Point(98, 76);
            lblContactNum.Name = "lblContactNum";
            lblContactNum.Size = new Size(65, 16);
            lblContactNum.TabIndex = 4;
            lblContactNum.Text = "Contact #:";
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleInfo.ForeColor = Color.White;
            lblVehicleInfo.Location = new Point(98, 99);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(79, 16);
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
            rbServices.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbServices.ForeColor = SystemColors.ButtonHighlight;
            rbServices.Location = new Point(442, 99);
            rbServices.Name = "rbServices";
            rbServices.Size = new Size(164, 19);
            rbServices.TabIndex = 7;
            rbServices.TabStop = true;
            rbServices.Text = "Ongoing Service/Services";
            rbServices.UseVisualStyleBackColor = true;
            // 
            // rbHistory
            // 
            rbHistory.AutoSize = true;
            rbHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbHistory.ForeColor = SystemColors.ButtonHighlight;
            rbHistory.Location = new Point(627, 98);
            rbHistory.Name = "rbHistory";
            rbHistory.Size = new Size(62, 19);
            rbHistory.TabIndex = 8;
            rbHistory.TabStop = true;
            rbHistory.Text = "History";
            rbHistory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(355, 53);
            label1.Name = "label1";
            label1.Size = new Size(73, 16);
            label1.TabIndex = 9;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(384, 76);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 10;
            label2.Text = "Email:";
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.Transparent;
            btnAddCar.BorderColor = Color.FromArgb(39, 39, 39);
            btnAddCar.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnAddCar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAddCar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCar.Image = null;
            btnAddCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCar.InactiveColor = Color.FromArgb(255, 131, 0);
            btnAddCar.Location = new Point(659, 403);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddCar.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddCar.Size = new Size(106, 32);
            btnAddCar.TabIndex = 83;
            btnAddCar.Text = "Add Vehicle";
            btnAddCar.TextAlignment = StringAlignment.Center;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.Transparent;
            btnEditProfile.BorderColor = Color.FromArgb(39, 39, 39);
            btnEditProfile.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnEditProfile.EnteredColor = Color.FromArgb(32, 34, 37);
            btnEditProfile.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.Image = null;
            btnEditProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditProfile.InactiveColor = Color.FromArgb(255, 131, 0);
            btnEditProfile.Location = new Point(532, 403);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnEditProfile.PressedColor = Color.FromArgb(255, 131, 0);
            btnEditProfile.Size = new Size(106, 32);
            btnEditProfile.TabIndex = 84;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.TextAlignment = StringAlignment.Center;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GrayText;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(151, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 14);
            txtName.TabIndex = 85;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.Gray;
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(169, 76);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(209, 14);
            txtContact.TabIndex = 87;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Gray;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(434, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(204, 14);
            txtUsername.TabIndex = 88;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(434, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 14);
            txtEmail.TabIndex = 89;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Transparent;
            btnSaveChanges.BorderColor = Color.FromArgb(39, 39, 39);
            btnSaveChanges.Enabled = false;
            btnSaveChanges.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnSaveChanges.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSaveChanges.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.Image = null;
            btnSaveChanges.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveChanges.InactiveColor = Color.FromArgb(255, 131, 0);
            btnSaveChanges.Location = new Point(408, 403);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnSaveChanges.PressedColor = Color.FromArgb(255, 131, 0);
            btnSaveChanges.Size = new Size(106, 32);
            btnSaveChanges.TabIndex = 90;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.TextAlignment = StringAlignment.Center;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // ProfilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(btnEditProfile);
            Controls.Add(btnAddCar);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Load += ProfilePanel_Load;
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
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.Button btnAddCar;
        private ReaLTaiizor.Controls.Button btnEditProfile;
        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private ReaLTaiizor.Controls.Button btnSaveChanges;
    }
}
