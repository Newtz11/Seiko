namespace Design
{
    partial class HomeSalesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSalesManager));
            groupBoxFeature = new GroupBox();
            buttonProjectAssignment = new Button();
            buttonPerformanceReport = new Button();
            buttonContractHistory = new Button();
            buttonProjectSchedule = new Button();
            buttonContractApproval = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonContractTracking = new Button();
            buttonHome = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoHeadOfSales = new PictureBox();
            groupBoxHome = new GroupBox();
            pictureBoxSubHome = new PictureBox();
            pictureBoxHomeMain = new PictureBox();
            labelDescribe = new Label();
            labelHome = new Label();
            pictureBoxIconHome = new PictureBox();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfSales).BeginInit();
            groupBoxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonProjectAssignment);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonProjectSchedule);
            groupBoxFeature.Controls.Add(buttonContractApproval);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoHeadOfSales);
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 986);
            groupBoxFeature.TabIndex = 7;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonProjectAssignment
            // 
            buttonProjectAssignment.BackColor = Color.Silver;
            buttonProjectAssignment.FlatStyle = FlatStyle.Popup;
            buttonProjectAssignment.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectAssignment.Location = new Point(6, 457);
            buttonProjectAssignment.Name = "buttonProjectAssignment";
            buttonProjectAssignment.Size = new Size(200, 48);
            buttonProjectAssignment.TabIndex = 17;
            buttonProjectAssignment.Text = "GIAO DỰ ÁN";
            buttonProjectAssignment.UseVisualStyleBackColor = false;
            // 
            // buttonPerformanceReport
            // 
            buttonPerformanceReport.BackColor = Color.Silver;
            buttonPerformanceReport.FlatStyle = FlatStyle.Popup;
            buttonPerformanceReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerformanceReport.Location = new Point(6, 630);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(200, 48);
            buttonPerformanceReport.TabIndex = 13;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 718);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 15;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            buttonContractHistory.Click += buttonContractHistory_Click;
            // 
            // buttonProjectSchedule
            // 
            buttonProjectSchedule.BackColor = Color.Silver;
            buttonProjectSchedule.FlatStyle = FlatStyle.Popup;
            buttonProjectSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectSchedule.Location = new Point(6, 542);
            buttonProjectSchedule.Name = "buttonProjectSchedule";
            buttonProjectSchedule.Size = new Size(200, 48);
            buttonProjectSchedule.TabIndex = 14;
            buttonProjectSchedule.Text = "TIẾN ĐỘ DỰ ÁN";
            buttonProjectSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonContractApproval
            // 
            buttonContractApproval.BackColor = Color.Silver;
            buttonContractApproval.FlatStyle = FlatStyle.Popup;
            buttonContractApproval.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractApproval.ForeColor = SystemColors.ControlText;
            buttonContractApproval.Location = new Point(6, 374);
            buttonContractApproval.Name = "buttonContractApproval";
            buttonContractApproval.Size = new Size(200, 48);
            buttonContractApproval.TabIndex = 12;
            buttonContractApproval.Text = "PHÊ DUYỆT HỢP ĐỒNG";
            buttonContractApproval.UseVisualStyleBackColor = false;
            buttonContractApproval.Click += buttonContractApproval_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(6, 893);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 48);
            buttonLogout.TabIndex = 11;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBoxSecurity
            // 
            pictureBoxSecurity.Image = (Image)resources.GetObject("pictureBoxSecurity.Image");
            pictureBoxSecurity.Location = new Point(91, 826);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 288);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 5;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            buttonContractTracking.Click += buttonContractTracking_Click;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(6, 125);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 48);
            buttonHome.TabIndex = 3;
            buttonHome.Text = " TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonInfoUser
            // 
            buttonInfoUser.BackColor = Color.Silver;
            buttonInfoUser.FlatStyle = FlatStyle.Popup;
            buttonInfoUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInfoUser.ForeColor = SystemColors.ControlText;
            buttonInfoUser.Location = new Point(6, 202);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(200, 48);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogoHeadOfSales
            // 
            pictureBoxLogoHeadOfSales.Image = (Image)resources.GetObject("pictureBoxLogoHeadOfSales.Image");
            pictureBoxLogoHeadOfSales.Location = new Point(6, 0);
            pictureBoxLogoHeadOfSales.Name = "pictureBoxLogoHeadOfSales";
            pictureBoxLogoHeadOfSales.Size = new Size(205, 86);
            pictureBoxLogoHeadOfSales.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogoHeadOfSales.TabIndex = 2;
            pictureBoxLogoHeadOfSales.TabStop = false;
            // 
            // groupBoxHome
            // 
            groupBoxHome.Controls.Add(pictureBoxSubHome);
            groupBoxHome.Controls.Add(pictureBoxHomeMain);
            groupBoxHome.Controls.Add(labelDescribe);
            groupBoxHome.Location = new Point(242, 104);
            groupBoxHome.Name = "groupBoxHome";
            groupBoxHome.Size = new Size(1211, 866);
            groupBoxHome.TabIndex = 23;
            groupBoxHome.TabStop = false;
            groupBoxHome.Text = "Trang chủ";
            // 
            // pictureBoxSubHome
            // 
            pictureBoxSubHome.Image = Properties.Resources.SubHome;
            pictureBoxSubHome.Location = new Point(173, 586);
            pictureBoxSubHome.Name = "pictureBoxSubHome";
            pictureBoxSubHome.Size = new Size(941, 222);
            pictureBoxSubHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSubHome.TabIndex = 10;
            pictureBoxSubHome.TabStop = false;
            // 
            // pictureBoxHomeMain
            // 
            pictureBoxHomeMain.Image = Properties.Resources.HomeMain;
            pictureBoxHomeMain.Location = new Point(134, 78);
            pictureBoxHomeMain.Name = "pictureBoxHomeMain";
            pictureBoxHomeMain.Size = new Size(1021, 432);
            pictureBoxHomeMain.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxHomeMain.TabIndex = 8;
            pictureBoxHomeMain.TabStop = false;
            // 
            // labelDescribe
            // 
            labelDescribe.AutoSize = true;
            labelDescribe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescribe.Location = new Point(249, 532);
            labelDescribe.Name = "labelDescribe";
            labelDescribe.Size = new Size(727, 31);
            labelDescribe.TabIndex = 9;
            labelDescribe.Text = "Quản lý hợp đồng hiệu quả - Nền tảng cho sự phát triển bền vững.";
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.Location = new Point(309, 61);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 22;
            labelHome.Text = " TRANG CHỦ";
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(231, 19);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 21;
            pictureBoxIconHome.TabStop = false;
            // 
            // HomeSalesManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 953);
            Controls.Add(groupBoxHome);
            Controls.Add(labelHome);
            Controls.Add(pictureBoxIconHome);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeSalesManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfSales).EndInit();
            groupBoxHome.ResumeLayout(false);
            groupBoxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonContractHistory;
        private Button buttonPerformanceReport;
        private Button buttonProjectSchedule;
        private Button buttonContractApproval;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonContractTracking;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoHeadOfSales;
        private Button buttonProjectAssignment;
        private GroupBox groupBoxHome;
        private PictureBox pictureBoxSubHome;
        private PictureBox pictureBoxHomeMain;
        private Label labelDescribe;
        private Label labelHome;
        private PictureBox pictureBoxIconHome;
    }
}