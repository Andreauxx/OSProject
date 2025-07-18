﻿namespace OS_FinalProj.Screens.Services
{
    partial class SuspensionSteeringPanel
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
            btnPowSteerRep = new ReaLTaiizor.Controls.Button();
            btnSuspSysRep = new ReaLTaiizor.Controls.Button();
            btnWheelAlign = new ReaLTaiizor.Controls.Button();
            lblSusSteering = new Label();
            btnBack = new Button();
            btnShockAbsRep = new ReaLTaiizor.Controls.Button();
            btnAddtoServ = new ReaLTaiizor.Controls.Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.suspension1;
            pictureBox1.Location = new Point(368, 65);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnPowSteerRep
            // 
            btnPowSteerRep.BackColor = Color.Transparent;
            btnPowSteerRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnPowSteerRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnPowSteerRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnPowSteerRep.Font = new Font("Poppins", 9.75F);
            btnPowSteerRep.Image = null;
            btnPowSteerRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnPowSteerRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnPowSteerRep.Location = new Point(484, 422);
            btnPowSteerRep.Margin = new Padding(3, 4, 3, 4);
            btnPowSteerRep.Name = "btnPowSteerRep";
            btnPowSteerRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnPowSteerRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnPowSteerRep.Size = new Size(247, 53);
            btnPowSteerRep.TabIndex = 40;
            btnPowSteerRep.Text = "Power Steering Fluid Check & Replacement";
            btnPowSteerRep.TextAlignment = StringAlignment.Center;
            // 
            // btnSuspSysRep
            // 
            btnSuspSysRep.BackColor = Color.Transparent;
            btnSuspSysRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnSuspSysRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnSuspSysRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSuspSysRep.Font = new Font("Poppins", 9.75F);
            btnSuspSysRep.Image = null;
            btnSuspSysRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuspSysRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnSuspSysRep.Location = new Point(193, 422);
            btnSuspSysRep.Margin = new Padding(3, 4, 3, 4);
            btnSuspSysRep.Name = "btnSuspSysRep";
            btnSuspSysRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnSuspSysRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnSuspSysRep.Size = new Size(247, 53);
            btnSuspSysRep.TabIndex = 39;
            btnSuspSysRep.Text = "Suspension System Repair";
            btnSuspSysRep.TextAlignment = StringAlignment.Center;
            btnSuspSysRep.Click += btnSuspSysRep_Click;
            // 
            // btnWheelAlign
            // 
            btnWheelAlign.BackColor = Color.Transparent;
            btnWheelAlign.BorderColor = Color.FromArgb(39, 39, 39);
            btnWheelAlign.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnWheelAlign.EnteredColor = Color.FromArgb(32, 34, 37);
            btnWheelAlign.Font = new Font("Poppins", 9.75F);
            btnWheelAlign.Image = null;
            btnWheelAlign.ImageAlign = ContentAlignment.MiddleLeft;
            btnWheelAlign.InactiveColor = Color.FromArgb(214, 211, 206);
            btnWheelAlign.Location = new Point(484, 339);
            btnWheelAlign.Margin = new Padding(3, 4, 3, 4);
            btnWheelAlign.Name = "btnWheelAlign";
            btnWheelAlign.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnWheelAlign.PressedColor = Color.FromArgb(255, 131, 0);
            btnWheelAlign.Size = new Size(247, 53);
            btnWheelAlign.TabIndex = 38;
            btnWheelAlign.Text = "Wheel Alignment";
            btnWheelAlign.TextAlignment = StringAlignment.Center;
            // 
            // lblSusSteering
            // 
            lblSusSteering.AutoSize = true;
            lblSusSteering.BackColor = Color.Transparent;
            lblSusSteering.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSusSteering.ForeColor = SystemColors.ButtonFace;
            lblSusSteering.Location = new Point(287, 279);
            lblSusSteering.Name = "lblSusSteering";
            lblSusSteering.Size = new Size(352, 36);
            lblSusSteering.TabIndex = 37;
            lblSusSteering.Text = "Suspension and Steering Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(69, 65, 61);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(69, 65, 61);
            btnBack.Location = new Point(33, 29);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(51, 49);
            btnBack.TabIndex = 36;
            btnBack.Text = "profile";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnShockAbsRep
            // 
            btnShockAbsRep.BackColor = Color.Transparent;
            btnShockAbsRep.BorderColor = Color.FromArgb(39, 39, 39);
            btnShockAbsRep.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnShockAbsRep.EnteredColor = Color.FromArgb(32, 34, 37);
            btnShockAbsRep.Font = new Font("Poppins", 9.75F);
            btnShockAbsRep.Image = null;
            btnShockAbsRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnShockAbsRep.InactiveColor = Color.FromArgb(214, 211, 206);
            btnShockAbsRep.Location = new Point(193, 339);
            btnShockAbsRep.Margin = new Padding(3, 4, 3, 4);
            btnShockAbsRep.Name = "btnShockAbsRep";
            btnShockAbsRep.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnShockAbsRep.PressedColor = Color.FromArgb(255, 131, 0);
            btnShockAbsRep.Size = new Size(247, 53);
            btnShockAbsRep.TabIndex = 35;
            btnShockAbsRep.Text = "Shock Absorber Replacement";
            btnShockAbsRep.TextAlignment = StringAlignment.Center;
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
            btnAddtoServ.Location = new Point(666, 535);
            btnAddtoServ.Margin = new Padding(3, 4, 3, 4);
            btnAddtoServ.Name = "btnAddtoServ";
            btnAddtoServ.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.PressedColor = Color.FromArgb(255, 131, 0);
            btnAddtoServ.Size = new Size(200, 39);
            btnAddtoServ.TabIndex = 34;
            btnAddtoServ.Text = "Add to Service Basket";
            btnAddtoServ.TextAlignment = StringAlignment.Center;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(39, 39, 39);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.FromArgb(39, 39, 39);
            btn_back.Image = Properties.Resources.backright;
            btn_back.Location = new Point(33, 230);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(51, 96);
            btn_back.TabIndex = 42;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // SuspensionSteeringPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btn_back);
            Controls.Add(pictureBox1);
            Controls.Add(btnPowSteerRep);
            Controls.Add(btnSuspSysRep);
            Controls.Add(btnWheelAlign);
            Controls.Add(lblSusSteering);
            Controls.Add(btnBack);
            Controls.Add(btnShockAbsRep);
            Controls.Add(btnAddtoServ);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SuspensionSteeringPanel";
            Size = new Size(914, 601);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btnPowSteerRep;
        private ReaLTaiizor.Controls.Button btnSuspSysRep;
        private ReaLTaiizor.Controls.Button btnWheelAlign;
        private Label lblSusSteering;
        private Button btnBack;
        private ReaLTaiizor.Controls.Button btnShockAbsRep;
        private ReaLTaiizor.Controls.Button btnAddtoServ;
        private Button btn_back;
    }
}
