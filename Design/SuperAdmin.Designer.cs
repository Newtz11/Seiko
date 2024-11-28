namespace Design
{
    partial class SuperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin));
            groupBoxFeature = new GroupBox();
            buttonContractHistory = new Button();
            buttonUserList = new Button();
            buttonHome = new Button();
            labelSuperAdmin = new Label();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            buttonFinacialReport = new Button();
            buttonContractTracking = new Button();
            buttonPerformanceReport = new Button();
            buttonProjectProgress = new Button();
            buttonInformation = new Button();
            pictureBoxSuperAdmin = new PictureBox();
            mainPanel = new Panel();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuperAdmin).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonUserList);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(labelSuperAdmin);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBox1);
            groupBoxFeature.Controls.Add(buttonFinacialReport);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonProjectProgress);
            groupBoxFeature.Controls.Add(buttonInformation);
            groupBoxFeature.Controls.Add(pictureBoxSuperAdmin);
            groupBoxFeature.Dock = DockStyle.Left;
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Margin = new Padding(0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 953);
            groupBoxFeature.TabIndex = 6;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 660);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 9;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            buttonContractHistory.Click += buttonContractHistory_Click;
            // 
            // buttonUserList
            // 
            buttonUserList.BackColor = Color.Silver;
            buttonUserList.FlatStyle = FlatStyle.Popup;
            buttonUserList.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUserList.ForeColor = SystemColors.ControlText;
            buttonUserList.Location = new Point(6, 303);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(200, 48);
            buttonUserList.TabIndex = 3;
            buttonUserList.Text = "DANH SÁCH NGƯỜI DÙNG";
            buttonUserList.UseVisualStyleBackColor = false;
            buttonUserList.Click += buttonUserList_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatAppearance.BorderColor = Color.Black;
            buttonHome.FlatAppearance.MouseDownBackColor = Color.White;
            buttonHome.FlatAppearance.MouseOverBackColor = Color.White;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(6, 155);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 48);
            buttonHome.TabIndex = 1;
            buttonHome.Text = " TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // labelSuperAdmin
            // 
            labelSuperAdmin.AutoSize = true;
            labelSuperAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuperAdmin.Location = new Point(39, 9);
            labelSuperAdmin.Name = "labelSuperAdmin";
            labelSuperAdmin.Size = new Size(142, 28);
            labelSuperAdmin.TabIndex = 13;
            labelSuperAdmin.Text = "Super ADMIN";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(6, 869);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 48);
            buttonLogout.TabIndex = 10;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 762);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonFinacialReport
            // 
            buttonFinacialReport.BackColor = Color.Silver;
            buttonFinacialReport.FlatStyle = FlatStyle.Popup;
            buttonFinacialReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinacialReport.Location = new Point(6, 588);
            buttonFinacialReport.Name = "buttonFinacialReport";
            buttonFinacialReport.Size = new Size(200, 48);
            buttonFinacialReport.TabIndex = 7;
            buttonFinacialReport.Text = "BÁO CÁO TÀI CHÍNH";
            buttonFinacialReport.UseVisualStyleBackColor = false;
            buttonFinacialReport.Click += buttonFinacialReport_Click;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 373);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 4;
            buttonContractTracking.Text = "DANH SÁCH HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            buttonContractTracking.Click += buttonContractTracking_Click;
            // 
            // buttonPerformanceReport
            // 
            buttonPerformanceReport.BackColor = Color.Silver;
            buttonPerformanceReport.FlatStyle = FlatStyle.Popup;
            buttonPerformanceReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerformanceReport.Location = new Point(6, 516);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(200, 48);
            buttonPerformanceReport.TabIndex = 6;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            buttonPerformanceReport.Click += buttonPerformanceReport_Click;
            // 
            // buttonProjectProgress
            // 
            buttonProjectProgress.BackColor = Color.Silver;
            buttonProjectProgress.FlatStyle = FlatStyle.Popup;
            buttonProjectProgress.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectProgress.Location = new Point(6, 445);
            buttonProjectProgress.Name = "buttonProjectProgress";
            buttonProjectProgress.Size = new Size(200, 48);
            buttonProjectProgress.TabIndex = 5;
            buttonProjectProgress.Text = "TIẾN ĐỘ CÔNG VIỆC";
            buttonProjectProgress.UseVisualStyleBackColor = false;
            buttonProjectProgress.Click += buttonProjectProgress_Click;
            // 
            // buttonInformation
            // 
            buttonInformation.BackColor = Color.Silver;
            buttonInformation.FlatStyle = FlatStyle.Popup;
            buttonInformation.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInformation.ForeColor = SystemColors.ControlText;
            buttonInformation.Location = new Point(6, 231);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Size = new Size(200, 48);
            buttonInformation.TabIndex = 2;
            buttonInformation.Text = "THÔNG TIN CÁ NHÂN";
            buttonInformation.UseVisualStyleBackColor = false;
            buttonInformation.Click += buttonInformation_Click;
            // 
            // pictureBoxSuperAdmin
            // 
            pictureBoxSuperAdmin.Image = (Image)resources.GetObject("pictureBoxSuperAdmin.Image");
            pictureBoxSuperAdmin.Location = new Point(0, 0);
            pictureBoxSuperAdmin.Name = "pictureBoxSuperAdmin";
            pictureBoxSuperAdmin.Size = new Size(216, 129);
            pictureBoxSuperAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSuperAdmin.TabIndex = 2;
            pictureBoxSuperAdmin.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackgroundImageLayout = ImageLayout.None;
            mainPanel.Location = new Point(216, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1366, 953);
            mainPanel.TabIndex = 7;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1582, 953);
            Controls.Add(mainPanel);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seiko";
            Load += SuperAdmin_Load;
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuperAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonUserList;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Button buttonFinacialReport;
        private Button buttonContractTracking;
        private Button buttonPerformanceReport;
        private Button buttonProjectProgress;
        private Button buttonInformation;
        private PictureBox pictureBoxSuperAdmin;
        private Label labelSuperAdmin;
        private Button buttonHome;
        private Panel mainPanel;
        private Button buttonContractHistory;
    }
}