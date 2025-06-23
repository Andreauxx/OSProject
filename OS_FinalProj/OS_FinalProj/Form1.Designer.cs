namespace OS_FinalProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogIn = new Panel();
            btnLogin = new ReaLTaiizor.Controls.Button();
            lnklblSignUp = new LinkLabel();
            lblPWord = new Label();
            lblUName = new Label();
            txtPWord = new TextBox();
            txtUName = new TextBox();
            pnlSignUp = new Panel();
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
            pnlLogIn.SuspendLayout();
            pnlSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogIn
            // 
            pnlLogIn.Controls.Add(btnLogin);
            pnlLogIn.Controls.Add(lnklblSignUp);
            pnlLogIn.Controls.Add(lblPWord);
            pnlLogIn.Controls.Add(lblUName);
            pnlLogIn.Controls.Add(txtPWord);
            pnlLogIn.Controls.Add(txtUName);
            pnlLogIn.Location = new Point(-2, -1);
            pnlLogIn.Name = "pnlLogIn";
            pnlLogIn.Size = new Size(804, 453);
            pnlLogIn.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(39, 39, 39);
            btnLogin.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLogin.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = null;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.FromArgb(255, 131, 0);
            btnLogin.Location = new Point(332, 396);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnLogin.PressedColor = Color.FromArgb(255, 131, 0);
            btnLogin.Size = new Size(122, 29);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Log In";
            btnLogin.TextAlignment = StringAlignment.Center;
            // 
            // lnklblSignUp
            // 
            lnklblSignUp.AutoSize = true;
            lnklblSignUp.LinkColor = Color.FromArgb(0, 74, 147);
            lnklblSignUp.Location = new Point(369, 368);
            lnklblSignUp.Name = "lnklblSignUp";
            lnklblSignUp.Size = new Size(48, 15);
            lnklblSignUp.TabIndex = 10;
            lnklblSignUp.TabStop = true;
            lnklblSignUp.Text = "Sign Up";
            lnklblSignUp.LinkClicked += lnklblSignUp_LinkClicked;
            // 
            // lblPWord
            // 
            lblPWord.AutoSize = true;
            lblPWord.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPWord.ForeColor = SystemColors.ButtonFace;
            lblPWord.Location = new Point(355, 313);
            lblPWord.Name = "lblPWord";
            lblPWord.Size = new Size(74, 23);
            lblPWord.TabIndex = 9;
            lblPWord.Text = "Password";
            // 
            // lblUName
            // 
            lblUName.AutoSize = true;
            lblUName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUName.ForeColor = SystemColors.ButtonFace;
            lblUName.Location = new Point(352, 264);
            lblUName.Name = "lblUName";
            lblUName.Size = new Size(77, 23);
            lblUName.TabIndex = 8;
            lblUName.Text = "Username";
            // 
            // txtPWord
            // 
            txtPWord.BackColor = Color.FromArgb(69, 65, 61);
            txtPWord.BorderStyle = BorderStyle.None;
            txtPWord.Location = new Point(261, 339);
            txtPWord.Name = "txtPWord";
            txtPWord.Size = new Size(260, 16);
            txtPWord.TabIndex = 7;
            // 
            // txtUName
            // 
            txtUName.BackColor = Color.FromArgb(69, 65, 61);
            txtUName.BorderStyle = BorderStyle.None;
            txtUName.Location = new Point(261, 290);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(260, 16);
            txtUName.TabIndex = 6;
            // 
            // pnlSignUp
            // 
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
            pnlSignUp.Location = new Point(6, 7);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(804, 453);
            pnlSignUp.TabIndex = 13;
            // 
            // lblSignPWord
            // 
            lblSignPWord.AutoSize = true;
            lblSignPWord.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignPWord.ForeColor = SystemColors.ButtonFace;
            lblSignPWord.Location = new Point(159, 261);
            lblSignPWord.Name = "lblSignPWord";
            lblSignPWord.Size = new Size(74, 23);
            lblSignPWord.TabIndex = 17;
            lblSignPWord.Text = "Password";
            // 
            // txtSignPWord
            // 
            txtSignPWord.BackColor = Color.FromArgb(69, 65, 61);
            txtSignPWord.BorderStyle = BorderStyle.None;
            txtSignPWord.Location = new Point(159, 287);
            txtSignPWord.Name = "txtSignPWord";
            txtSignPWord.Size = new Size(159, 16);
            txtSignPWord.TabIndex = 16;
            // 
            // lblSignUName
            // 
            lblSignUName.AutoSize = true;
            lblSignUName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignUName.ForeColor = SystemColors.ButtonFace;
            lblSignUName.Location = new Point(43, 261);
            lblSignUName.Name = "lblSignUName";
            lblSignUName.Size = new Size(77, 23);
            lblSignUName.TabIndex = 15;
            lblSignUName.Text = "Username";
            // 
            // txtSignUName
            // 
            txtSignUName.BackColor = Color.FromArgb(69, 65, 61);
            txtSignUName.BorderStyle = BorderStyle.None;
            txtSignUName.Location = new Point(43, 287);
            txtSignUName.Name = "txtSignUName";
            txtSignUName.Size = new Size(110, 16);
            txtSignUName.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonFace;
            lblEmail.Location = new Point(43, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 23);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(69, 65, 61);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(43, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 16);
            txtEmail.TabIndex = 12;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.BorderColor = Color.FromArgb(39, 39, 39);
            btnSignUp.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnSignUp.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSignUp.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Image = null;
            btnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignUp.InactiveColor = Color.FromArgb(255, 131, 0);
            btnSignUp.Location = new Point(92, 336);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btnSignUp.PressedColor = Color.FromArgb(255, 131, 0);
            btnSignUp.Size = new Size(141, 29);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "Create Account";
            btnSignUp.TextAlignment = StringAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.ButtonFace;
            lblLastName.Location = new Point(43, 169);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 23);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ButtonFace;
            lblFirstName.Location = new Point(43, 120);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(79, 23);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(69, 65, 61);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Location = new Point(43, 195);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(260, 16);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(69, 65, 61);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Location = new Point(43, 146);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(260, 16);
            txtFirstName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlSignUp);
            Controls.Add(pnlLogIn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlLogIn.ResumeLayout(false);
            pnlLogIn.PerformLayout();
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogIn;
        private ReaLTaiizor.Controls.Button btnLogin;
        private LinkLabel lnklblSignUp;
        private Label lblPWord;
        private Label lblUName;
        private TextBox txtPWord;
        private TextBox txtUName;
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
    }
}
