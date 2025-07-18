﻿namespace OS_FinalProj.Screens
{
    partial class ServiceBasketPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceBasketPanel));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            btnNext = new Button();
            btnProfile = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 119, 4);
            label1.Location = new Point(299, 95);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 0;
            label1.Text = "Service Basket";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel1.Location = new Point(176, 151);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(192, 29);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel2.Location = new Point(402, 151);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(192, 29);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel3.Location = new Point(176, 203);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(192, 29);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel4.Location = new Point(176, 255);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(192, 29);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel5.Location = new Point(402, 203);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(192, 29);
            flowLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel6.Location = new Point(402, 255);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(192, 29);
            flowLayoutPanel6.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(229, 119, 4);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Image = Properties.Resources.Next_Button;
            btnNext.Location = new Point(694, 398);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(54, 30);
            btnNext.TabIndex = 3;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.FromArgb(39, 39, 39);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(3, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(74, 57);
            btnProfile.TabIndex = 4;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel7.Location = new Point(176, 303);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(192, 29);
            flowLayoutPanel7.TabIndex = 3;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.FromArgb(167, 164, 161);
            flowLayoutPanel8.Location = new Point(402, 303);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(192, 29);
            flowLayoutPanel8.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(229, 119, 4);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = Properties.Resources.Back_Button;
            btnBack.Location = new Point(56, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(52, 30);
            btnBack.TabIndex = 5;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // ServiceBasketPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel8);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(btnProfile);
            Controls.Add(btnNext);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "ServiceBasketPanel";
            Size = new Size(800, 451);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button btnNext;
        private Button btnProfile;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button btnBack;
    }
}
