namespace OS_FinalProj.Screens
{
    partial class AddVehicleForm
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
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            label1 = new Label();
            txtLicensePlate = new ReaLTaiizor.Controls.SmallTextBox();
            lblMake = new ReaLTaiizor.Controls.SmallTextBox();
            label2 = new Label();
            txtModel = new ReaLTaiizor.Controls.SmallTextBox();
            lblModel = new Label();
            txtYear = new ReaLTaiizor.Controls.SmallTextBox();
            lblYear = new Label();
            btnAdd = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel1.Location = new Point(110, 9);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(128, 26);
            headerLabel1.TabIndex = 1;
            headerLabel1.Text = "Add Vehicle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(31, 75);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 2;
            label1.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BackColor = Color.Black;
            txtLicensePlate.BorderColor = Color.FromArgb(180, 180, 180);
            txtLicensePlate.CustomBGColor = Color.White;
            txtLicensePlate.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLicensePlate.ForeColor = Color.DarkGray;
            txtLicensePlate.Location = new Point(31, 106);
            txtLicensePlate.MaxLength = 32767;
            txtLicensePlate.Multiline = false;
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.ReadOnly = false;
            txtLicensePlate.Size = new Size(281, 27);
            txtLicensePlate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtLicensePlate.TabIndex = 3;
            txtLicensePlate.TextAlignment = HorizontalAlignment.Left;
            txtLicensePlate.UseSystemPasswordChar = false;
            // 
            // lblMake
            // 
            lblMake.BackColor = Color.Black;
            lblMake.BorderColor = Color.FromArgb(180, 180, 180);
            lblMake.CustomBGColor = Color.White;
            lblMake.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMake.ForeColor = Color.DarkGray;
            lblMake.Location = new Point(31, 183);
            lblMake.MaxLength = 32767;
            lblMake.Multiline = false;
            lblMake.Name = "lblMake";
            lblMake.ReadOnly = false;
            lblMake.Size = new Size(281, 27);
            lblMake.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            lblMake.TabIndex = 5;
            lblMake.TextAlignment = HorizontalAlignment.Left;
            lblMake.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(31, 147);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 4;
            label2.Text = "Make:";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.Black;
            txtModel.BorderColor = Color.FromArgb(180, 180, 180);
            txtModel.CustomBGColor = Color.White;
            txtModel.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtModel.ForeColor = Color.DarkGray;
            txtModel.Location = new Point(31, 258);
            txtModel.MaxLength = 32767;
            txtModel.Multiline = false;
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = false;
            txtModel.Size = new Size(281, 27);
            txtModel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtModel.TabIndex = 7;
            txtModel.TextAlignment = HorizontalAlignment.Left;
            txtModel.UseSystemPasswordChar = false;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModel.ForeColor = Color.Orange;
            lblModel.Location = new Point(31, 222);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(56, 19);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model:";
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.Black;
            txtYear.BorderColor = Color.FromArgb(180, 180, 180);
            txtYear.CustomBGColor = Color.White;
            txtYear.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtYear.ForeColor = Color.DarkGray;
            txtYear.Location = new Point(31, 343);
            txtYear.MaxLength = 32767;
            txtYear.Multiline = false;
            txtYear.Name = "txtYear";
            txtYear.ReadOnly = false;
            txtYear.Size = new Size(281, 27);
            txtYear.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtYear.TabIndex = 9;
            txtYear.TextAlignment = HorizontalAlignment.Left;
            txtYear.UseSystemPasswordChar = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.ForeColor = Color.Orange;
            lblYear.Location = new Point(31, 307);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(43, 19);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor = Color.FromArgb(39, 39, 39);
            btnAdd.Enabled = false;
            btnAdd.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnAdd.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = null;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.InactiveColor = Color.FromArgb(255, 131, 0);
            btnAdd.Location = new Point(119, 403);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAdd.PressedColor = Color.FromArgb(255, 131, 0);
            btnAdd.Size = new Size(119, 38);
            btnAdd.TabIndex = 91;
            btnAdd.Text = "Add Car";
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddVehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(347, 474);
            ControlBox = false;
            Controls.Add(btnAdd);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(lblMake);
            Controls.Add(label2);
            Controls.Add(txtLicensePlate);
            Controls.Add(label1);
            Controls.Add(headerLabel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddVehicleForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += AddVehicleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private Label label1;
        private ReaLTaiizor.Controls.SmallTextBox txtLicensePlate;
        private ReaLTaiizor.Controls.SmallTextBox lblMake;
        private Label label2;
        private ReaLTaiizor.Controls.SmallTextBox txtModel;
        private Label lblModel;
        private ReaLTaiizor.Controls.SmallTextBox txtYear;
        private Label lblYear;
        private ReaLTaiizor.Controls.Button btnAdd;
    }
}
