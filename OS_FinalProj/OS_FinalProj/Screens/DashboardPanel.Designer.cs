namespace OS_FinalProj.Screens
{
    partial class DashboardPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPanel));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnHistory = new Button();
            btnCustomers = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            label2 = new Label();
            btnActiveServ = new Button();
            btnBookings = new Button();
            btnTotalCars = new Button();
            btnCustSatisfaction = new Button();
            panel2 = new Panel();
            label3 = new Label();
            btnRegister = new Button();
            btnAddCust = new Button();
            btnNewBooking = new Button();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            label4 = new Label();
            btnBack = new Button();
            label5 = new Label();
            label6 = new Label();
            lblActiveServ = new Label();
            lblTotalCars = new Label();
            lblBooking = new Label();
            lblSatisfactionRate = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkOrange;
            panel1.Location = new Point(0, -11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 637);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 451);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cust_icon;
            pictureBox2.Location = new Point(25, 368);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.history_icon;
            pictureBox1.Location = new Point(25, 289);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnHistory
            // 
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(0, 219);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(184, 37);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 161);
            btnCustomers.Margin = new Padding(3, 4, 3, 4);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(184, 37);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 101);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 37);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(229, 119, 4);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 42);
            label1.TabIndex = 0;
            label1.Text = "BOSLOTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(203, 13);
            label2.Name = "label2";
            label2.Size = new Size(269, 39);
            label2.TabIndex = 3;
            label2.Text = "Dashboard Overview";
            // 
            // btnActiveServ
            // 
            btnActiveServ.BackColor = Color.FromArgb(229, 119, 4);
            btnActiveServ.BackgroundImageLayout = ImageLayout.None;
            btnActiveServ.FlatStyle = FlatStyle.Flat;
            btnActiveServ.Font = new Font("Poppins", 9F);
            btnActiveServ.Image = (Image)resources.GetObject("btnActiveServ.Image");
            btnActiveServ.ImageAlign = ContentAlignment.TopLeft;
            btnActiveServ.Location = new Point(216, 80);
            btnActiveServ.Margin = new Padding(0);
            btnActiveServ.Name = "btnActiveServ";
            btnActiveServ.Padding = new Padding(10, 5, 5, 5);
            btnActiveServ.Size = new Size(161, 100);
            btnActiveServ.TabIndex = 4;
            btnActiveServ.Text = " Active Services";
            btnActiveServ.TextAlign = ContentAlignment.BottomLeft;
            btnActiveServ.UseVisualStyleBackColor = false;
            btnActiveServ.Click += btnActiveServ_Click;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(229, 119, 4);
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Poppins", 9F);
            btnBookings.Image = (Image)resources.GetObject("btnBookings.Image");
            btnBookings.ImageAlign = ContentAlignment.TopLeft;
            btnBookings.Location = new Point(394, 80);
            btnBookings.Margin = new Padding(3, 4, 3, 4);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(158, 100);
            btnBookings.TabIndex = 5;
            btnBookings.Text = "Today's Booking";
            btnBookings.TextAlign = ContentAlignment.BottomLeft;
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnTotalCars
            // 
            btnTotalCars.BackColor = Color.FromArgb(229, 119, 4);
            btnTotalCars.FlatStyle = FlatStyle.Flat;
            btnTotalCars.Font = new Font("Poppins", 9F);
            btnTotalCars.Image = Properties.Resources.Total_Cars;
            btnTotalCars.ImageAlign = ContentAlignment.TopLeft;
            btnTotalCars.Location = new Point(570, 80);
            btnTotalCars.Margin = new Padding(3, 4, 3, 4);
            btnTotalCars.Name = "btnTotalCars";
            btnTotalCars.Size = new Size(154, 100);
            btnTotalCars.TabIndex = 6;
            btnTotalCars.Text = "Total Cars";
            btnTotalCars.TextAlign = ContentAlignment.BottomLeft;
            btnTotalCars.UseVisualStyleBackColor = false;
            btnTotalCars.Click += btnTotalCars_Click;
            // 
            // btnCustSatisfaction
            // 
            btnCustSatisfaction.BackColor = Color.FromArgb(229, 119, 4);
            btnCustSatisfaction.FlatStyle = FlatStyle.Flat;
            btnCustSatisfaction.Font = new Font("Poppins", 9F);
            btnCustSatisfaction.Image = Properties.Resources.Satisfaction_rate;
            btnCustSatisfaction.ImageAlign = ContentAlignment.TopLeft;
            btnCustSatisfaction.Location = new Point(741, 80);
            btnCustSatisfaction.Margin = new Padding(3, 4, 3, 4);
            btnCustSatisfaction.Name = "btnCustSatisfaction";
            btnCustSatisfaction.Size = new Size(155, 100);
            btnCustSatisfaction.TabIndex = 7;
            btnCustSatisfaction.Text = "Satisfaction Rate";
            btnCustSatisfaction.TextAlign = ContentAlignment.BottomLeft;
            btnCustSatisfaction.UseVisualStyleBackColor = false;
            btnCustSatisfaction.Click += btnCustSatisfaction_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnAddCust);
            panel2.Controls.Add(btnNewBooking);
            panel2.Location = new Point(216, 201);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 159);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 17);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 9;
            label3.Text = "Quick Actions";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(229, 119, 4);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Poppins", 9F);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(439, 59);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 76);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register Vehicle";
            btnRegister.TextAlign = ContentAlignment.BottomCenter;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAddCust
            // 
            btnAddCust.BackColor = Color.FromArgb(229, 119, 4);
            btnAddCust.FlatStyle = FlatStyle.Flat;
            btnAddCust.Font = new Font("Poppins", 9F);
            btnAddCust.Image = Properties.Resources.Add_Customer;
            btnAddCust.Location = new Point(264, 59);
            btnAddCust.Margin = new Padding(3, 4, 3, 4);
            btnAddCust.Name = "btnAddCust";
            btnAddCust.Size = new Size(158, 76);
            btnAddCust.TabIndex = 1;
            btnAddCust.Text = "Add Customer";
            btnAddCust.TextAlign = ContentAlignment.BottomCenter;
            btnAddCust.UseVisualStyleBackColor = false;
            btnAddCust.Click += btnAddCust_Click;
            // 
            // btnNewBooking
            // 
            btnNewBooking.BackColor = Color.FromArgb(229, 119, 4);
            btnNewBooking.FlatStyle = FlatStyle.Flat;
            btnNewBooking.Font = new Font("Poppins", 9F);
            btnNewBooking.Image = (Image)resources.GetObject("btnNewBooking.Image");
            btnNewBooking.Location = new Point(89, 59);
            btnNewBooking.Margin = new Padding(3, 4, 3, 4);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(158, 76);
            btnNewBooking.TabIndex = 0;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.TextAlign = ContentAlignment.BottomCenter;
            btnNewBooking.UseVisualStyleBackColor = false;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(216, 368);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(680, 225);
            panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3862419F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6137581F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Location = new Point(14, 65);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(653, 144);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 131, 0);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(178, 12);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 11;
            button5.Text = "View all";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(161, 30);
            label4.TabIndex = 10;
            label4.Text = "Recent Services";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(229, 119, 4);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.Back_Button;
            btnBack.Location = new Point(844, 18);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(52, 34);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 131, 0);
            label5.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(39, 39, 39);
            label5.Location = new Point(259, 95);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 131, 0);
            label6.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(39, 39, 39);
            label6.Location = new Point(431, 88);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 11;
            // 
            // lblActiveServ
            // 
            lblActiveServ.AutoSize = true;
            lblActiveServ.BackColor = Color.FromArgb(229, 119, 4);
            lblActiveServ.FlatStyle = FlatStyle.Flat;
            lblActiveServ.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveServ.ForeColor = Color.Black;
            lblActiveServ.Location = new Point(276, 110);
            lblActiveServ.Name = "lblActiveServ";
            lblActiveServ.Size = new Size(38, 36);
            lblActiveServ.TabIndex = 6;
            lblActiveServ.Text = "73";
            lblActiveServ.Click += label7_Click;
            // 
            // lblTotalCars
            // 
            lblTotalCars.AutoSize = true;
            lblTotalCars.BackColor = Color.FromArgb(229, 119, 4);
            lblTotalCars.FlatStyle = FlatStyle.Flat;
            lblTotalCars.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCars.ForeColor = Color.Black;
            lblTotalCars.Location = new Point(629, 110);
            lblTotalCars.Name = "lblTotalCars";
            lblTotalCars.Size = new Size(38, 36);
            lblTotalCars.TabIndex = 12;
            lblTotalCars.Text = "73";
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.BackColor = Color.FromArgb(229, 119, 4);
            lblBooking.FlatStyle = FlatStyle.Flat;
            lblBooking.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooking.ForeColor = Color.Black;
            lblBooking.Location = new Point(453, 110);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(38, 36);
            lblBooking.TabIndex = 13;
            lblBooking.Text = "73";
            // 
            // lblSatisfactionRate
            // 
            lblSatisfactionRate.AutoSize = true;
            lblSatisfactionRate.BackColor = Color.FromArgb(229, 119, 4);
            lblSatisfactionRate.FlatStyle = FlatStyle.Flat;
            lblSatisfactionRate.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSatisfactionRate.ForeColor = Color.Black;
            lblSatisfactionRate.Location = new Point(791, 110);
            lblSatisfactionRate.Name = "lblSatisfactionRate";
            lblSatisfactionRate.Size = new Size(63, 36);
            lblSatisfactionRate.TabIndex = 14;
            lblSatisfactionRate.Text = "100%";
            // 
            // DashboardPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(lblSatisfactionRate);
            Controls.Add(lblBooking);
            Controls.Add(lblTotalCars);
            Controls.Add(lblActiveServ);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnBookings);
            Controls.Add(btnCustSatisfaction);
            Controls.Add(btnTotalCars);
            Controls.Add(btnActiveServ);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardPanel";
            Size = new Size(927, 612);
            Load += DashboardPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnHistory;
        private Button btnCustomers;
        private Button btnDashboard;
        private Label label1;
        private Label label2;
        private Button btnActiveServ;
        private Button btnBookings;
        private Button btnTotalCars;
        private Button btnCustSatisfaction;
        private Panel panel2;
        private Button btnRegister;
        private Button btnAddCust;
        private Button btnNewBooking;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button btnBack;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label lblActiveServ;
        private Label lblTotalCars;
        private Label lblBooking;
        private Label lblSatisfactionRate;
    }
}
