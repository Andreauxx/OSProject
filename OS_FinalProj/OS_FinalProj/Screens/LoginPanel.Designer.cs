namespace OS_FinalProj.Screens
{
    partial class LoginPanel
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
            pnlLogIn = new Panel();
            btnLogin = new ReaLTaiizor.Controls.Button();
            lnklblSignUp = new LinkLabel();
            lblPWord = new Label();
            lblUName = new Label();
            txtPWord = new TextBox();
            txtUName = new TextBox();
            pnlLogIn.SuspendLayout();
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
            pnlLogIn.Location = new Point(3, 3);
            pnlLogIn.Name = "pnlLogIn";
            pnlLogIn.Size = new Size(804, 453);
            pnlLogIn.TabIndex = 7;
            pnlLogIn.Paint += pnlLogIn_Paint;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(39, 39, 39);
            btnLogin.EnteredBorderColor = Color.FromArgb(39, 39, 39);
            btnLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnLogin.Click += btnLogin_Click_1;
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
            lblPWord.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPWord.ForeColor = SystemColors.ButtonFace;
            lblPWord.Location = new Point(355, 313);
            lblPWord.Name = "lblPWord";
            lblPWord.Size = new Size(67, 16);
            lblPWord.TabIndex = 9;
            lblPWord.Text = "Password";
            // 
            // lblUName
            // 
            lblUName.AutoSize = true;
            lblUName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUName.ForeColor = SystemColors.ButtonFace;
            lblUName.Location = new Point(352, 264);
            lblUName.Name = "lblUName";
            lblUName.Size = new Size(70, 16);
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
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(pnlLogIn);
            Name = "LoginPanel";
            Size = new Size(811, 459);
            pnlLogIn.ResumeLayout(false);
            pnlLogIn.PerformLayout();
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
    }
}
