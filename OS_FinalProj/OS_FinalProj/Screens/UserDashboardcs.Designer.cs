namespace OS_FinalProj.Screens
{
    partial class UserDashboardcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboardcs));
            panel1 = new Panel();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(107, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 418);
            panel1.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.FromArgb(39, 39, 39);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(0, 0);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(84, 76);
            btnProfile.TabIndex = 5;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // UserDashboardcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnProfile);
            Controls.Add(panel1);
            Name = "UserDashboardcs";
            Size = new Size(921, 556);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnProfile;
    }
}
