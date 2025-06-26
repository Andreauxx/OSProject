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
            panel1 = new Panel();
            label1 = new Label();
            btnDashboard = new Button();
            btnCustomers = new Button();
            btnHistory = new Button();
            label2 = new Label();
            btnActiveServ = new Button();
            btnBookings = new Button();
            btnTotalCars = new Button();
            btnCustSatisfaction = new Button();
            panel2 = new Panel();
            btnNewBooking = new Button();
            btnAddCust = new Button();
            btnRegister = new Button();
            button4 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 36, 36);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 459);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 131, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(105, 34);
            label1.TabIndex = 0;
            label1.Text = "BOSLOTS";
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(0, 76);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(158, 28);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(-3, 121);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(161, 28);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.FlatStyle = FlatStyle.Popup;
            btnHistory.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(-3, 168);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(164, 28);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 10);
            label2.Name = "label2";
            label2.Size = new Size(221, 31);
            label2.TabIndex = 3;
            label2.Text = "Dashboard Overview";
            // 
            // btnActiveServ
            // 
            btnActiveServ.Location = new Point(189, 60);
            btnActiveServ.Name = "btnActiveServ";
            btnActiveServ.Size = new Size(136, 75);
            btnActiveServ.TabIndex = 4;
            btnActiveServ.Text = "Active Servies";
            btnActiveServ.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            btnBookings.Location = new Point(342, 60);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(138, 75);
            btnBookings.TabIndex = 5;
            btnBookings.Text = "Today's Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnTotalCars
            // 
            btnTotalCars.Location = new Point(495, 60);
            btnTotalCars.Name = "btnTotalCars";
            btnTotalCars.Size = new Size(135, 75);
            btnTotalCars.TabIndex = 6;
            btnTotalCars.Text = "Total Cars";
            btnTotalCars.UseVisualStyleBackColor = true;
            // 
            // btnCustSatisfaction
            // 
            btnCustSatisfaction.Location = new Point(648, 60);
            btnCustSatisfaction.Name = "btnCustSatisfaction";
            btnCustSatisfaction.Size = new Size(136, 75);
            btnCustSatisfaction.TabIndex = 7;
            btnCustSatisfaction.Text = "Customer Satisfaction";
            btnCustSatisfaction.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnAddCust);
            panel2.Controls.Add(btnNewBooking);
            panel2.Location = new Point(189, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 119);
            panel2.TabIndex = 8;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Location = new Point(12, 47);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(124, 57);
            btnNewBooking.TabIndex = 0;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = true;
            // 
            // btnAddCust
            // 
            btnAddCust.Location = new Point(153, 47);
            btnAddCust.Name = "btnAddCust";
            btnAddCust.Size = new Size(138, 57);
            btnAddCust.TabIndex = 1;
            btnAddCust.Text = "Add Customer";
            btnAddCust.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(306, 47);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 57);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register Vehicle";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(459, 47);
            button4.Name = "button4";
            button4.Size = new Size(124, 57);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 9;
            label3.Text = "Quick Actions";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(189, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(595, 169);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 10;
            label4.Text = "Recent Services";
            // 
            // button5
            // 
            button5.Location = new Point(156, 9);
            button5.Name = "button5";
            button5.Size = new Size(75, 22);
            button5.TabIndex = 11;
            button5.Text = "View all";
            button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3862419F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6137581F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel1.Location = new Point(12, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(571, 108);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(727, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(57, 25);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DashboardPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnCustSatisfaction);
            Controls.Add(btnTotalCars);
            Controls.Add(btnBookings);
            Controls.Add(btnActiveServ);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "DashboardPanel";
            Size = new Size(811, 459);
            Load += DashboardPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button4;
        private Button btnRegister;
        private Button btnAddCust;
        private Button btnNewBooking;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button btnBack;
    }
}
