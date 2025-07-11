﻿namespace OS_FinalProj.Screens
{
    partial class ServicesPopup1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesPopup1));
            btnGenServ = new Button();
            btnEngTransServ = new Button();
            btnFuelExhServ = new Button();
            btnSusSteerServ = new Button();
            btnHeatAirServ = new Button();
            button5 = new Button();
            btnNext = new Button();
            lblGenServ = new Label();
            lblGenTransServ = new Label();
            lblSusSteerServ = new Label();
            lblHeatAirServ = new Label();
            lblFuelExhServ = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnGenServ
            // 
            btnGenServ.BackColor = Color.FromArgb(69, 65, 61);
            btnGenServ.FlatStyle = FlatStyle.Popup;
            btnGenServ.ForeColor = Color.FromArgb(39, 39, 39);
            btnGenServ.Image = (Image)resources.GetObject("btnGenServ.Image");
            btnGenServ.Location = new Point(200, 55);
            btnGenServ.Name = "btnGenServ";
            btnGenServ.Size = new Size(168, 138);
            btnGenServ.TabIndex = 3;
            btnGenServ.UseVisualStyleBackColor = false;
            btnGenServ.Click += btnGenServ_Click;
            // 
            // btnEngTransServ
            // 
            btnEngTransServ.BackColor = Color.FromArgb(69, 65, 61);
            btnEngTransServ.FlatStyle = FlatStyle.Popup;
            btnEngTransServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnEngTransServ.Image = Properties.Resources.engine;
            btnEngTransServ.Location = new Point(447, 55);
            btnEngTransServ.Name = "btnEngTransServ";
            btnEngTransServ.Size = new Size(170, 138);
            btnEngTransServ.TabIndex = 4;
            btnEngTransServ.Text = "profile";
            btnEngTransServ.UseVisualStyleBackColor = false;
            btnEngTransServ.Click += btnEngTransServ_Click;
            // 
            // btnFuelExhServ
            // 
            btnFuelExhServ.BackColor = Color.FromArgb(69, 65, 61);
            btnFuelExhServ.FlatStyle = FlatStyle.Popup;
            btnFuelExhServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnFuelExhServ.Image = Properties.Resources.fuel;
            btnFuelExhServ.Location = new Point(562, 236);
            btnFuelExhServ.Name = "btnFuelExhServ";
            btnFuelExhServ.Size = new Size(174, 138);
            btnFuelExhServ.TabIndex = 5;
            btnFuelExhServ.UseVisualStyleBackColor = false;
            btnFuelExhServ.Click += btnFuelExhServ_Click;
            // 
            // btnSusSteerServ
            // 
            btnSusSteerServ.BackColor = Color.FromArgb(69, 65, 61);
            btnSusSteerServ.FlatStyle = FlatStyle.Popup;
            btnSusSteerServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnSusSteerServ.Image = Properties.Resources.suspension;
            btnSusSteerServ.Location = new Point(67, 236);
            btnSusSteerServ.Name = "btnSusSteerServ";
            btnSusSteerServ.Size = new Size(176, 138);
            btnSusSteerServ.TabIndex = 6;
            btnSusSteerServ.UseVisualStyleBackColor = false;
            btnSusSteerServ.Click += btnSusSteerServ_Click;
            // 
            // btnHeatAirServ
            // 
            btnHeatAirServ.BackColor = Color.FromArgb(69, 65, 61);
            btnHeatAirServ.FlatStyle = FlatStyle.Popup;
            btnHeatAirServ.ForeColor = Color.FromArgb(69, 65, 61);
            btnHeatAirServ.Image = Properties.Resources.heating;
            btnHeatAirServ.Location = new Point(317, 236);
            btnHeatAirServ.Name = "btnHeatAirServ";
            btnHeatAirServ.Size = new Size(170, 138);
            btnHeatAirServ.TabIndex = 7;
            btnHeatAirServ.UseVisualStyleBackColor = false;
            btnHeatAirServ.Click += btnHeatAirServ_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(39, 39, 39);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(39, 39, 39);
            button5.Image = Properties.Resources.ProfIcon1;
            button5.Location = new Point(715, 0);
            button5.Name = "button5";
            button5.Size = new Size(82, 85);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(39, 39, 39);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.FromArgb(39, 39, 39);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(752, 177);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 59);
            btnNext.TabIndex = 9;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += button6_Click;
            // 
            // lblGenServ
            // 
            lblGenServ.AutoSize = true;
            lblGenServ.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenServ.ForeColor = SystemColors.ButtonFace;
            lblGenServ.Location = new Point(218, 196);
            lblGenServ.Name = "lblGenServ";
            lblGenServ.Size = new Size(118, 23);
            lblGenServ.TabIndex = 10;
            lblGenServ.Text = "General Services";
            lblGenServ.Click += label1_Click;
            // 
            // lblGenTransServ
            // 
            lblGenTransServ.AutoSize = true;
            lblGenTransServ.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenTransServ.ForeColor = SystemColors.ButtonFace;
            lblGenTransServ.Location = new Point(407, 196);
            lblGenTransServ.Name = "lblGenTransServ";
            lblGenTransServ.Size = new Size(227, 23);
            lblGenTransServ.TabIndex = 11;
            lblGenTransServ.Text = "Engine and Transmission Services";
            // 
            // lblSusSteerServ
            // 
            lblSusSteerServ.AutoSize = true;
            lblSusSteerServ.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSusSteerServ.ForeColor = SystemColors.ButtonFace;
            lblSusSteerServ.Location = new Point(35, 390);
            lblSusSteerServ.Name = "lblSusSteerServ";
            lblSusSteerServ.Size = new Size(208, 22);
            lblSusSteerServ.TabIndex = 12;
            lblSusSteerServ.Text = "Suspension and Steering Services";
            lblSusSteerServ.Click += lblSusSteerServ_Click;
            // 
            // lblHeatAirServ
            // 
            lblHeatAirServ.AutoSize = true;
            lblHeatAirServ.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeatAirServ.ForeColor = SystemColors.ButtonFace;
            lblHeatAirServ.Location = new Point(273, 390);
            lblHeatAirServ.Name = "lblHeatAirServ";
            lblHeatAirServ.Size = new Size(233, 22);
            lblHeatAirServ.TabIndex = 13;
            lblHeatAirServ.Text = "Heating and Air Conditioning Services";
            // 
            // lblFuelExhServ
            // 
            lblFuelExhServ.AutoSize = true;
            lblFuelExhServ.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuelExhServ.ForeColor = SystemColors.ButtonFace;
            lblFuelExhServ.Location = new Point(538, 390);
            lblFuelExhServ.Name = "lblFuelExhServ";
            lblFuelExhServ.Size = new Size(207, 22);
            lblFuelExhServ.TabIndex = 14;
            lblFuelExhServ.Text = "Fuel and Exhaust System Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(39, 39, 39);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(39, 39, 39);
            btnBack.Image = Properties.Resources.backright;
            btnBack.Location = new Point(6, 170);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 66);
            btnBack.TabIndex = 22;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ServicesPopup1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnBack);
            Controls.Add(lblFuelExhServ);
            Controls.Add(lblHeatAirServ);
            Controls.Add(lblSusSteerServ);
            Controls.Add(lblGenTransServ);
            Controls.Add(lblGenServ);
            Controls.Add(btnNext);
            Controls.Add(button5);
            Controls.Add(btnHeatAirServ);
            Controls.Add(btnSusSteerServ);
            Controls.Add(btnFuelExhServ);
            Controls.Add(btnEngTransServ);
            Controls.Add(btnGenServ);
            Name = "ServicesPopup1";
            Size = new Size(800, 451);
            Load += ServicesPopup1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenServ;
        private Button btnEngTransServ;
        private Button btnFuelExhServ;
        private Button btnSusSteerServ;
        private Button btnHeatAirServ;
        private Button button5;
        private Button btnNext;
        private Label lblGenServ;
        private Label lblGenTransServ;
        private Label lblSusSteerServ;
        private Label lblHeatAirServ;
        private Label lblFuelExhServ;
        private Button btnBack;
    }
}
