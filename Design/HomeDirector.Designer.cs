namespace Design
{
    partial class HomeDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDirector));
            pictureBoxIconHome = new PictureBox();
            labelHome = new Label();
            pictureBoxHomeMain = new PictureBox();
            labelDescribe = new Label();
            groupBoxHome = new GroupBox();
            pictureBoxSubHome = new PictureBox();
            pictureBoxSuperAdmin = new PictureBox();
            buttonInformation = new Button();
            buttonHome = new Button();
            buttonProjectSchedule = new Button();
            buttonPerformanceReport = new Button();
            buttonContractTracking = new Button();
            buttonCreateAccount = new Button();
            buttonRole = new Button();
            buttonFinacialReports = new Button();
            pictureBox1 = new PictureBox();
            buttonLogout = new Button();
            groupBoxFeature = new GroupBox();
            buttonUserList = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            groupBoxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuperAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxFeature.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(221, 9);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 6;
            pictureBoxIconHome.TabStop = false;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.Location = new Point(299, 51);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 7;
            labelHome.Text = " TRANG CHỦ";
            labelHome.Click += labelHome_Click;
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
            // groupBoxHome
            // 
            groupBoxHome.Controls.Add(pictureBoxSubHome);
            groupBoxHome.Controls.Add(pictureBoxHomeMain);
            groupBoxHome.Controls.Add(labelDescribe);
            groupBoxHome.Location = new Point(245, 82);
            groupBoxHome.Name = "groupBoxHome";
            groupBoxHome.Size = new Size(1208, 878);
            groupBoxHome.TabIndex = 10;
            groupBoxHome.TabStop = false;
            groupBoxHome.Text = "Trang chủ";
            groupBoxHome.Enter += groupBoxHome_Enter;
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
            // pictureBoxSuperAdmin
            // 
            pictureBoxSuperAdmin.Image = Properties.Resources.homeSuperAdmin;
            pictureBoxSuperAdmin.Location = new Point(0, 26);
            pictureBoxSuperAdmin.Name = "pictureBoxSuperAdmin";
            pictureBoxSuperAdmin.Size = new Size(210, 76);
            pictureBoxSuperAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSuperAdmin.TabIndex = 2;
            pictureBoxSuperAdmin.TabStop = false;
            // 
            // buttonInformation
            // 
            buttonInformation.BackColor = Color.Silver;
            buttonInformation.FlatStyle = FlatStyle.Popup;
            buttonInformation.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInformation.ForeColor = SystemColors.ControlText;
            buttonInformation.Location = new Point(6, 302);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Size = new Size(200, 48);
            buttonInformation.TabIndex = 4;
            buttonInformation.Text = "THÔNG TIN CÁ NHÂN";
            buttonInformation.UseVisualStyleBackColor = false;
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
            // buttonProjectSchedule
            // 
            buttonProjectSchedule.BackColor = Color.Silver;
            buttonProjectSchedule.FlatStyle = FlatStyle.Popup;
            buttonProjectSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectSchedule.Location = new Point(6, 465);
            buttonProjectSchedule.Name = "buttonProjectSchedule";
            buttonProjectSchedule.Size = new Size(200, 48);
            buttonProjectSchedule.TabIndex = 6;
            buttonProjectSchedule.Text = "TIẾN ĐỘ DỰ ÁN ";
            buttonProjectSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonPerformanceReport
            // 
            buttonPerformanceReport.BackColor = Color.Silver;
            buttonPerformanceReport.FlatStyle = FlatStyle.Popup;
            buttonPerformanceReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerformanceReport.Location = new Point(6, 550);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(200, 48);
            buttonPerformanceReport.TabIndex = 7;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 381);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 5;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            buttonContractTracking.Click += button3_Click;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.BackColor = Color.Silver;
            buttonCreateAccount.FlatStyle = FlatStyle.Popup;
            buttonCreateAccount.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateAccount.Location = new Point(6, 723);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(200, 48);
            buttonCreateAccount.TabIndex = 9;
            buttonCreateAccount.Text = "TẠO TÀI KHOẢN";
            buttonCreateAccount.UseVisualStyleBackColor = false;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // buttonRole
            // 
            buttonRole.BackColor = Color.Silver;
            buttonRole.FlatStyle = FlatStyle.Popup;
            buttonRole.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRole.Location = new Point(6, 801);
            buttonRole.Name = "buttonRole";
            buttonRole.Size = new Size(200, 48);
            buttonRole.TabIndex = 10;
            buttonRole.Text = "PHÂN QUYỀN ";
            buttonRole.UseVisualStyleBackColor = false;
            // 
            // buttonFinacialReports
            // 
            buttonFinacialReports.BackColor = Color.Silver;
            buttonFinacialReports.FlatStyle = FlatStyle.Popup;
            buttonFinacialReports.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinacialReports.Location = new Point(6, 640);
            buttonFinacialReports.Name = "buttonFinacialReports";
            buttonFinacialReports.Size = new Size(200, 48);
            buttonFinacialReports.TabIndex = 8;
            buttonFinacialReports.Text = "BÁO CÁO TÀI CHÍNH";
            buttonFinacialReports.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 866);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(6, 919);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 48);
            buttonLogout.TabIndex = 11;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonUserList);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBox1);
            groupBoxFeature.Controls.Add(buttonFinacialReports);
            groupBoxFeature.Controls.Add(buttonRole);
            groupBoxFeature.Controls.Add(buttonCreateAccount);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonProjectSchedule);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInformation);
            groupBoxFeature.Controls.Add(pictureBoxSuperAdmin);
            groupBoxFeature.Location = new Point(-1, -26);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 986);
            groupBoxFeature.TabIndex = 5;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonUserList
            // 
            buttonUserList.BackColor = Color.Silver;
            buttonUserList.FlatStyle = FlatStyle.Popup;
            buttonUserList.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUserList.ForeColor = SystemColors.ControlText;
            buttonUserList.Location = new Point(6, 213);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(200, 48);
            buttonUserList.TabIndex = 12;
            buttonUserList.Text = "DANH SÁCH NGƯỜI DÙNG";
            buttonUserList.UseVisualStyleBackColor = false;
            buttonUserList.Click += button1_Click;
            // 
            // HomeDirector
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
            Name = "HomeDirector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomeDirector_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).EndInit();
            groupBoxHome.ResumeLayout(false);
            groupBoxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuperAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconHome;
        private Label labelHome;
        private PictureBox pictureBoxHomeMain;
        private Label labelDescribe;
        private GroupBox groupBoxHome;
        private PictureBox pictureBoxSubHome;
        private PictureBox pictureBoxSuperAdmin;
        private Button buttonInformation;
        private Button buttonHome;
        private Button buttonProjectSchedule;
        private Button buttonPerformanceReport;
        private Button buttonContractTracking;
        private Button buttonCreateAccount;
        private Button buttonRole;
        private Button buttonFinacialReports;
        private PictureBox pictureBox1;
        private Button buttonLogout;
        private GroupBox groupBoxFeature;
        private Button buttonUserList;
    }
}