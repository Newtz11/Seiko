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
            buttonHome = new Button();
            labelSuperAdmin = new Label();
            buttonUserList = new Button();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            buttonFinacialReports = new Button();
            buttonRole = new Button();
            buttonCreateAccount = new Button();
            buttonContractTracking = new Button();
            buttonPerformanceReport = new Button();
            buttonProjectSchedule = new Button();
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
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(labelSuperAdmin);
            groupBoxFeature.Controls.Add(buttonUserList);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBox1);
            groupBoxFeature.Controls.Add(buttonFinacialReports);
            groupBoxFeature.Controls.Add(buttonRole);
            groupBoxFeature.Controls.Add(buttonCreateAccount);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonProjectSchedule);
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
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatAppearance.BorderColor = Color.Black;
            buttonHome.FlatAppearance.MouseDownBackColor = Color.White;
            buttonHome.FlatAppearance.MouseOverBackColor = Color.White;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(6, 135);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 48);
            buttonHome.TabIndex = 7;
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
            buttonUserList.Click += buttonUserList_Click;
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
            buttonLogout.Click += buttonLogout_Click;
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
            buttonFinacialReports.Click += buttonFinacialReports_Click;
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
            buttonRole.Click += buttonRole_Click;
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
            buttonContractTracking.Click += buttonContractTracking_Click;
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
            buttonProjectSchedule.Click += buttonProjectSchedule_Click;
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
            mainPanel.Dock = DockStyle.Right;
            mainPanel.Location = new Point(216, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1266, 953);
            mainPanel.TabIndex = 7;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1482, 953);
            Controls.Add(mainPanel);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += HomeSuperAdmin_Load;
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
        private Button buttonFinacialReports;
        private Button buttonRole;
        private Button buttonCreateAccount;
        private Button buttonContractTracking;
        private Button buttonPerformanceReport;
        private Button buttonProjectSchedule;
        private Button buttonInformation;
        private PictureBox pictureBoxSuperAdmin;
        private Label labelSuperAdmin;
        private Button buttonHome;
        private Panel mainPanel;
    }
}