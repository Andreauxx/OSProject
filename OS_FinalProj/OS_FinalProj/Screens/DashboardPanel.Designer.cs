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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView_dashboard = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnBack = new Button();
            label5 = new Label();
            label6 = new Label();
            btnServiceHistory = new Button();
            label1 = new Label();
            tableLayoutPanel_queueList = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dashboard).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 18);
            label2.Name = "label2";
            label2.Size = new Size(196, 22);
            label2.TabIndex = 3;
            label2.Text = "Dashboard Overview";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView_dashboard);
            panel2.Location = new Point(22, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 170);
            panel2.TabIndex = 8;
            // 
            // dataGridView_dashboard
            // 
            dataGridView_dashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_dashboard.BackgroundColor = Color.FromArgb(39, 39, 39);
            dataGridView_dashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_dashboard.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(39, 39, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_dashboard.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_dashboard.Dock = DockStyle.Fill;
            dataGridView_dashboard.GridColor = Color.FromArgb(255, 128, 0);
            dataGridView_dashboard.Location = new Point(0, 0);
            dataGridView_dashboard.Name = "dataGridView_dashboard";
            dataGridView_dashboard.RowHeadersVisible = false;
            dataGridView_dashboard.Size = new Size(762, 170);
            dataGridView_dashboard.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(423, 240);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 10;
            label4.Text = "SERVICE HISTORY";
            label4.Click += label4_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(229, 119, 4);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.Back_Button;
            btnBack.Location = new Point(738, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 26);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 131, 0);
            label5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(39, 39, 39);
            label5.Location = new Point(227, 71);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(0, 13);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 131, 0);
            label6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(39, 39, 39);
            label6.Location = new Point(377, 66);
            label6.Name = "label6";
            label6.Size = new Size(0, 13);
            label6.TabIndex = 11;
            // 
            // btnServiceHistory
            // 
            btnServiceHistory.BackColor = Color.FromArgb(255, 131, 0);
            btnServiceHistory.FlatStyle = FlatStyle.Popup;
            btnServiceHistory.Location = new Point(709, 235);
            btnServiceHistory.Name = "btnServiceHistory";
            btnServiceHistory.Size = new Size(75, 22);
            btnServiceHistory.TabIndex = 11;
            btnServiceHistory.Text = "View all";
            btnServiceHistory.UseVisualStyleBackColor = false;
            btnServiceHistory.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 243);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 14;
            label1.Text = "QUEUE LIST";
            // 
            // tableLayoutPanel_queueList
            // 
            tableLayoutPanel_queueList.ColumnCount = 5;
            tableLayoutPanel_queueList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.76271F));
            tableLayoutPanel_queueList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.23729F));
            tableLayoutPanel_queueList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel_queueList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tableLayoutPanel_queueList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel_queueList.Location = new Point(22, 268);
            tableLayoutPanel_queueList.Name = "tableLayoutPanel_queueList";
            tableLayoutPanel_queueList.RowCount = 6;
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Percent, 35.08772F));
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Percent, 64.91228F));
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel_queueList.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_queueList.Size = new Size(334, 156);
            tableLayoutPanel_queueList.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.76271F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.23729F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.Location = new Point(423, 268);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.08772F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.91228F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(361, 156);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // DashboardPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel_queueList);
            Controls.Add(btnServiceHistory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "DashboardPanel";
            Size = new Size(811, 459);
            Load += DashboardPanel_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_dashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Button btnBack;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView_dashboard;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnServiceHistory;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel_queueList;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
