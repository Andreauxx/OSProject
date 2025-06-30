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
            btnShowPass = new Button();
            btn_back = new ReaLTaiizor.Controls.Button();
            lblSignPWord = new Label();
            lblSignUName = new Label();
            txtSignUName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSignUp = new ReaLTaiizor.Controls.Button();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnHidePass = new Button();
            txtSignPWord = new TextBox();
            lblContact = new Label();
            txtContactNumber = new TextBox();
            pnlSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = Color.FromArgb(39, 39, 39);
            pnlSignUp.Controls.Add(lblContact);
            pnlSignUp.Controls.Add(txtContactNumber);
            pnlSignUp.Controls.Add(btnShowPass);
            pnlSignUp.Controls.Add(btn_back);
            pnlSignUp.Controls.Add(lblSignPWord);
            pnlSignUp.Controls.Add(lblSignUName);
            pnlSignUp.Controls.Add(txtSignUName);
            pnlSignUp.Controls.Add(lblEmail);
            pnlSignUp.Controls.Add(txtEmail);
            pnlSignUp.Controls.Add(btnSignUp);
            pnlSignUp.Controls.Add(lblLastName);
            pnlSignUp.Controls.Add(lblFirstName);
            pnlSignUp.Controls.Add(txtLastName);
            pnlSignUp.Controls.Add(txtFirstName);
            pnlSignUp.Controls.Add(btnHidePass);
            pnlSignUp.Controls.Add(txtSignPWord);
            pnlSignUp.Location = new Point(0, 0);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(881, 486);
            pnlSignUp.TabIndex = 15;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.White;
            btnShowPass.BackgroundImage = Properties.Resources.icons8_show_password_20;
            btnShowPass.BackgroundImageLayout = ImageLayout.Center;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.ForeColor = Color.Black;
            btnShowPass.Location = new Point(626, 288);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(25, 20);
            btnShowPass.TabIndex = 19;
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
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
            btn_back.Location = new Point(42, 72);
            btn_back.Name = "btn_back";
            btn_back.PressedBorderColor = Color.FromArgb(255, 131, 0);
            btn_back.PressedColor = Color.FromArgb(255, 131, 0);
            btn_back.Size = new Size(55, 29);
            btn_back.TabIndex = 18;
            btn_back.TextAlignment = StringAlignment.Center;
            btn_back.Click += btn_back_Click;
            // 
            // lblSignPWord
            // 
            lblSignPWord.AutoSize = true;
            lblSignPWord.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignPWord.ForeColor = SystemColors.ButtonFace;
            lblSignPWord.Location = new Point(391, 267);
            lblSignPWord.Name = "lblSignPWord";
            lblSignPWord.Size = new Size(67, 16);
            lblSignPWord.TabIndex = 17;
            lblSignPWord.Text = "Password";
            // 
            // lblSignUName
            // 
            lblSignUName.AutoSize = true;
            lblSignUName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignUName.ForeColor = SystemColors.ButtonFace;
            lblSignUName.Location = new Point(42, 266);
            lblSignUName.Name = "lblSignUName";
            lblSignUName.Size = new Size(70, 16);
            lblSignUName.TabIndex = 15;
            lblSignUName.Text = "Username";
            // 
            // txtSignUName
            // 
            txtSignUName.BackColor = Color.FromArgb(69, 65, 61);
            txtSignUName.BorderStyle = BorderStyle.None;
            txtSignUName.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignUName.ForeColor = Color.White;
            txtSignUName.Location = new Point(42, 288);
            txtSignUName.Name = "txtSignUName";
            txtSignUName.Size = new Size(260, 18);
            txtSignUName.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonFace;
            lblEmail.Location = new Point(42, 208);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 16);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(69, 65, 61);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(42, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 18);
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
            btnSignUp.Location = new Point(684, 395);
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
            lblLastName.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLastName.ForeColor = SystemColors.ButtonFace;
            lblLastName.Location = new Point(391, 153);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(72, 16);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ButtonFace;
            lblFirstName.Location = new Point(42, 149);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(72, 16);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(69, 65, 61);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(391, 173);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(260, 18);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(69, 65, 61);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(42, 172);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(260, 18);
            txtFirstName.TabIndex = 6;
            // 
            // btnHidePass
            // 
            btnHidePass.BackColor = Color.White;
            btnHidePass.BackgroundImage = Properties.Resources.icons8_hide_password_20;
            btnHidePass.BackgroundImageLayout = ImageLayout.Center;
            btnHidePass.FlatStyle = FlatStyle.Flat;
            btnHidePass.ForeColor = Color.Black;
            btnHidePass.Location = new Point(626, 288);
            btnHidePass.Name = "btnHidePass";
            btnHidePass.Size = new Size(25, 20);
            btnHidePass.TabIndex = 20;
            btnHidePass.UseVisualStyleBackColor = false;
            btnHidePass.Click += btnHidePass_Click;
            // 
            // txtSignPWord
            // 
            txtSignPWord.BackColor = Color.FromArgb(69, 65, 61);
            txtSignPWord.BorderStyle = BorderStyle.None;
            txtSignPWord.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignPWord.ForeColor = Color.White;
            txtSignPWord.Location = new Point(391, 288);
            txtSignPWord.Name = "txtSignPWord";
            txtSignPWord.PasswordChar = '*';
            txtSignPWord.Size = new Size(260, 18);
            txtSignPWord.TabIndex = 16;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.ForeColor = SystemColors.ButtonFace;
            lblContact.Location = new Point(391, 209);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(103, 16);
            lblContact.TabIndex = 22;
            lblContact.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BackColor = Color.FromArgb(69, 65, 61);
            txtContactNumber.BorderStyle = BorderStyle.None;
            txtContactNumber.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.ForeColor = Color.White;
            txtContactNumber.Location = new Point(391, 229);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(260, 18);
            txtContactNumber.TabIndex = 21;
            // 
            // SignUpPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSignUp);
            Name = "SignUpPanel";
            Size = new Size(881, 486);
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
        private Button btnShowPass;
        private Button btnHidePass;
        private Label lblContact;
        private TextBox txtContactNumber;
    }
}
