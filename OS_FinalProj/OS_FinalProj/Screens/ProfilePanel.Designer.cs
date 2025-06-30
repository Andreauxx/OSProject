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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnBack = new Button();
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
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnSaveChanges = new ReaLTaiizor.Controls.Button();
            txtContact = new TextBox();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(39, 39, 39);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(39, 39, 39);
            btnBack.Image = Properties.Resources.ProfIcon;
            btnBack.Location = new Point(685, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 80);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            lblContactNum.Location = new Point(98, 86);
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
            lblVehicleInfo.Location = new Point(98, 114);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(79, 16);
            lblVehicleInfo.TabIndex = 5;
            lblVehicleInfo.Text = "Vehicle Info:";
            // 
            // cboVehicleInfo
            // 
            cboVehicleInfo.Font = new Font("Poppins", 8.25F);
            cboVehicleInfo.FormattingEnabled = true;
            cboVehicleInfo.Location = new Point(190, 114);
            cboVehicleInfo.Name = "cboVehicleInfo";
            cboVehicleInfo.Size = new Size(161, 27);
            cboVehicleInfo.TabIndex = 6;
            // 
            // rbServices
            // 
            rbServices.AutoSize = true;
            rbServices.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbServices.ForeColor = SystemColors.ButtonHighlight;
            rbServices.Location = new Point(395, 114);
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
            rbHistory.Location = new Point(565, 114);
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
            label1.Location = new Point(373, 53);
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
            label2.Location = new Point(386, 84);
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
            btnAddCar.Location = new Point(685, 413);
            btnAddCar.Margin = new Padding(3, 2, 3, 2);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddCar.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddCar.Size = new Size(93, 24);
            btnAddCar.TabIndex = 83;
            btnAddCar.Text = "Add Vehicle";
            btnAddCar.TextAlignment = StringAlignment.Center;
            btnAddCar.Click += btnAddCar_Click;
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
            btnEditProfile.Location = new Point(577, 413);
            btnEditProfile.Margin = new Padding(3, 2, 3, 2);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnEditProfile.PressedColor = Color.FromArgb(255, 131, 0);
            btnEditProfile.Size = new Size(93, 24);
            btnEditProfile.TabIndex = 84;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.TextAlignment = StringAlignment.Center;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GrayText;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Enabled = false;
            txtName.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = SystemColors.Menu;
            txtName.Location = new Point(151, 55);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 17);
            txtName.TabIndex = 85;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.GrayText;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Poppins", 8.25F);
            txtUsername.ForeColor = SystemColors.MenuBar;
            txtUsername.Location = new Point(452, 55);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 17);
            txtUsername.TabIndex = 88;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.GrayText;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Poppins", 8.25F);
            txtEmail.ForeColor = SystemColors.MenuBar;
            txtEmail.Location = new Point(436, 88);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 17);
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
            btnSaveChanges.Location = new Point(466, 413);
            btnSaveChanges.Margin = new Padding(3, 2, 3, 2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnSaveChanges.PressedColor = Color.FromArgb(255, 131, 0);
            btnSaveChanges.Size = new Size(93, 24);
            btnSaveChanges.TabIndex = 90;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.TextAlignment = StringAlignment.Center;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtContact
            // 
            txtContact.BackColor = SystemColors.GrayText;
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Enabled = false;
            txtContact.Font = new Font("Poppins", 8.25F);
            txtContact.ForeColor = SystemColors.MenuBar;
            txtContact.Location = new Point(168, 88);
            txtContact.Margin = new Padding(3, 2, 3, 2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(183, 17);
            txtContact.TabIndex = 87;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 128, 0);
            poisonDataGridView1.BorderStyle = BorderStyle.Fixed3D;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(60, 156);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(680, 242);
            poisonDataGridView1.TabIndex = 91;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 39, 39);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(39, 39, 39);
            button1.Image = Properties.Resources.backright;
            button1.Location = new Point(16, 8);
            button1.Name = "button1";
            button1.Size = new Size(45, 72);
            button1.TabIndex = 92;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProfilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(button1);
            Controls.Add(poisonDataGridView1);
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
            Controls.Add(btnBack);
            Name = "ProfilePanel";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
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
        private TextBox txtUsername;
        private TextBox txtEmail;
        private ReaLTaiizor.Controls.Button btnSaveChanges;
        private TextBox txtContact;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private Button button1;
    }
}
