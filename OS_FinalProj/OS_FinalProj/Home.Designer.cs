namespace OS_FinalProj
{
    partial class Home
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.No;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.UlawowOS_removebg_preview;
            button1.Location = new Point(80, 186);
            button1.Name = "button1";
            button1.Size = new Size(308, 251);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.UlawowOS__1__removebg_preview;
            button2.Location = new Point(355, 177);
            button2.Name = "button2";
            button2.Size = new Size(347, 268);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.UlawowOS__2__removebg_preview;
            button3.Location = new Point(652, 177);
            button3.Name = "button3";
            button3.Size = new Size(349, 268);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1068, 670);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(39, 39, 39);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}