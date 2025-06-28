namespace OS_FinalProj.Screens
{
    partial class SignUpPanel
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
            pnlSignUp = new Panel();
            btn_back = new ReaLTaiizor.Controls.Button();
            lblSignPWord = new Label();
            txtSignPWord = new TextBox();
            lblSignUName = new Label();
            txtSignUName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSignUp = new ReaLTaiizor.Controls.Button();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            pnlSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = Color.FromArgb(39, 39, 39);
            pnlSignUp.Controls.Add(btn_back);
            pnlSignUp.Controls.Add(lblSignPWord);
            pnlSignUp.Controls.Add(txtSignPWord);
            pnlSignUp.Controls.Add(lblSignUName);
            pnlSignUp.Controls.Add(txtSignUName);
            pnlSignUp.Controls.Add(lblEmail);
            pnlSignUp.Controls.Add(txtEmail);
            pnlSignUp.Controls.Add(btnSignUp);
            pnlSignUp.Controls.Add(lblLastName);
            pnlSignUp.Controls.Add(lblFirstName);
            pnlSignUp.Controls.Add(txtLastName);
            pnlSignUp.Controls.Add(txtFirstName);
            pnlSignUp.Location = new Point(0, 0);
            pnlSignUp.Margin = new Padding(3, 4, 3, 4);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(1007, 648);
            pnlSignUp.TabIndex = 15;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BorderColor = Color.FromArgb(39, 39, 39);
            btn_back.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btn_back.EnteredColor = Color.FromArgb(32, 34, 37);
            btn_back.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Image = Properties.Resources.Back_Button;
            btn_back.ImageAlign = ContentAlignment.MiddleCenter;
            btn_back.InactiveColor = Color.FromArgb(255, 131, 0);
            btn_back.Location = new Point(48, 96);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btn_back.PressedColor = Color.FromArgb(255, 131, 0);
            btn_back.Size = new Size(63, 39);
            btn_back.TabIndex = 18;
            btn_back.TextAlignment = StringAlignment.Center;
            btn_back.Click += btn_back_Click;
            // 
            // lblSignPWord
            // 
            lblSignPWord.AutoSize = true;
            lblSignPWord.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignPWord.ForeColor = SystemColors.ButtonFace;
            lblSignPWord.Location = new Point(181, 382);
            lblSignPWord.Name = "lblSignPWord";
            lblSignPWord.Size = new Size(83, 20);
            lblSignPWord.TabIndex = 17;
            lblSignPWord.Text = "Password";
            // 
            // txtSignPWord
            // 
            txtSignPWord.BackColor = Color.FromArgb(69, 65, 61);
            txtSignPWord.BorderStyle = BorderStyle.None;
            txtSignPWord.Location = new Point(181, 417);
            txtSignPWord.Margin = new Padding(3, 4, 3, 4);
            txtSignPWord.Name = "txtSignPWord";
            txtSignPWord.Size = new Size(182, 20);
            txtSignPWord.TabIndex = 16;
            // 
            // lblSignUName
            // 
            lblSignUName.AutoSize = true;
            lblSignUName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignUName.ForeColor = SystemColors.ButtonFace;
            lblSignUName.Location = new Point(48, 382);
            lblSignUName.Name = "lblSignUName";
            lblSignUName.Size = new Size(86, 20);
            lblSignUName.TabIndex = 15;
            lblSignUName.Text = "Username";
            // 
            // txtSignUName
            // 
            txtSignUName.BackColor = Color.FromArgb(69, 65, 61);
            txtSignUName.BorderStyle = BorderStyle.None;
            txtSignUName.Location = new Point(48, 417);
            txtSignUName.Margin = new Padding(3, 4, 3, 4);
            txtSignUName.Name = "txtSignUName";
            txtSignUName.Size = new Size(126, 20);
            txtSignUName.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonFace;
            lblEmail.Location = new Point(48, 319);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(69, 65, 61);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(48, 354);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 20);
            txtEmail.TabIndex = 12;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.BorderColor = Color.FromArgb(39, 39, 39);
            btnSignUp.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnSignUp.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSignUp.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Image = null;
            btnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignUp.InactiveColor = Color.FromArgb(255, 131, 0);
            btnSignUp.Location = new Point(104, 482);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnSignUp.PressedColor = Color.FromArgb(255, 131, 0);
            btnSignUp.Size = new Size(161, 39);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "Create Account";
            btnSignUp.TextAlignment = StringAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.ButtonFace;
            lblLastName.Location = new Point(48, 259);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 20);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ButtonFace;
            lblFirstName.Location = new Point(48, 194);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 20);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(69, 65, 61);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Location = new Point(48, 294);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(297, 20);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(69, 65, 61);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Location = new Point(48, 229);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(297, 20);
            txtFirstName.TabIndex = 6;
            // 
            // SignUpPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSignUp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpPanel";
            Size = new Size(1007, 648);
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSignUp;
        private Label lblSignPWord;
        private TextBox txtSignPWord;
        private Label lblSignUName;
        private TextBox txtSignUName;
        private Label lblEmail;
        private TextBox txtEmail;
        private ReaLTaiizor.Controls.Button btnSignUp;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ReaLTaiizor.Controls.Button btn_back;
    }
}
