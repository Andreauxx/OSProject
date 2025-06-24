namespace OS_FinalProj
{
    partial class ServiceBasket
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceBasket));
            btnNext = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label1 = new Label();
            btnUser = new Button();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(234, 122, 3);
            btnNext.BackgroundImageLayout = ImageLayout.None;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Location = new Point(669, 395);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 29);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(182, 180, 176);
            flowLayoutPanel1.Location = new Point(206, 142);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(170, 22);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(182, 180, 176);
            flowLayoutPanel2.Location = new Point(396, 142);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(170, 22);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(182, 180, 176);
            flowLayoutPanel3.Location = new Point(206, 183);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(170, 22);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(182, 180, 176);
            flowLayoutPanel4.Location = new Point(396, 183);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(170, 22);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.FromArgb(182, 180, 176);
            flowLayoutPanel5.Location = new Point(206, 226);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(170, 22);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.FromArgb(182, 180, 176);
            flowLayoutPanel6.Location = new Point(396, 226);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(170, 22);
            flowLayoutPanel6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(234, 122, 3);
            label1.Location = new Point(306, 75);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 6;
            label1.Text = "Service Basket";
            // 
            // btnUser
            // 
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.Location = new Point(16, 15);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(66, 69);
            btnUser.TabIndex = 7;
            btnUser.UseVisualStyleBackColor = true;
            // 
            // ServiceBasket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnUser);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnNext);
            Name = "ServiceBasket";
            Size = new Size(800, 450);
            Load += ServiceBasket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNext;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label1;
        private Button btnUser;
    }
}