namespace OS_FinalProj
{
    partial class FormMain
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
            pnlMain = new Panel();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ActiveCaptionText;
            pnlMain.Location = new Point(-4, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(837, 486);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 481);
            Controls.Add(pnlMain);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
    }
}