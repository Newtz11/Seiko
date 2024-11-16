namespace Design
{
    partial class Director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Director));
            groupBoxFeature = new GroupBox();
            buttonContractHistory = new Button();
            buttonPerformanceReport = new Button();
            buttonFinacialReports = new Button();
            buttonProjectProgress = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonContractTracking = new Button();
            buttonHome = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoDirector = new PictureBox();
            mainpanel = new Panel();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoDirector).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonFinacialReports);
            groupBoxFeature.Controls.Add(buttonProjectProgress);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoDirector);
            groupBoxFeature.Dock = DockStyle.Left;
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 953);
            groupBoxFeature.TabIndex = 6;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatAppearance.BorderColor = Color.Black;
            buttonContractHistory.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractHistory.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractHistory.FlatStyle = FlatStyle.Flat;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 659);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 7;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            buttonContractHistory.Click += buttonContractHistory_Click;
            // 
            // buttonPerformanceReport
            // 
            buttonPerformanceReport.BackColor = Color.Silver;
            buttonPerformanceReport.FlatAppearance.BorderColor = Color.Black;
            buttonPerformanceReport.FlatAppearance.MouseDownBackColor = Color.White;
            buttonPerformanceReport.FlatAppearance.MouseOverBackColor = Color.White;
            buttonPerformanceReport.FlatStyle = FlatStyle.Flat;
            buttonPerformanceReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerformanceReport.Location = new Point(6, 483);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(200, 48);
            buttonPerformanceReport.TabIndex = 5;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            buttonPerformanceReport.Click += buttonPerformanceReport_Click;
            // 
            // buttonFinacialReports
            // 
            buttonFinacialReports.BackColor = Color.Silver;
            buttonFinacialReports.FlatAppearance.BorderColor = Color.Black;
            buttonFinacialReports.FlatAppearance.MouseDownBackColor = Color.White;
            buttonFinacialReports.FlatAppearance.MouseOverBackColor = Color.White;
            buttonFinacialReports.FlatStyle = FlatStyle.Flat;
            buttonFinacialReports.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinacialReports.Location = new Point(6, 571);
            buttonFinacialReports.Name = "buttonFinacialReports";
            buttonFinacialReports.Size = new Size(200, 48);
            buttonFinacialReports.TabIndex = 6;
            buttonFinacialReports.Text = "BÁO CÁO TÀI CHÍNH";
            buttonFinacialReports.UseVisualStyleBackColor = false;
            buttonFinacialReports.Click += buttonFinacialReports_Click;
            // 
            // buttonProjectProgress
            // 
            buttonProjectProgress.BackColor = Color.Silver;
            buttonProjectProgress.FlatAppearance.BorderColor = Color.Black;
            buttonProjectProgress.FlatAppearance.MouseDownBackColor = Color.White;
            buttonProjectProgress.FlatAppearance.MouseOverBackColor = Color.White;
            buttonProjectProgress.FlatStyle = FlatStyle.Flat;
            buttonProjectProgress.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectProgress.ForeColor = SystemColors.ControlText;
            buttonProjectProgress.Location = new Point(6, 395);
            buttonProjectProgress.Name = "buttonProjectProgress";
            buttonProjectProgress.Size = new Size(200, 48);
            buttonProjectProgress.TabIndex = 4;
            buttonProjectProgress.Text = "TIẾN ĐỘ CÔNG VIỆC ";
            buttonProjectProgress.UseVisualStyleBackColor = false;
            buttonProjectProgress.Click += buttonProjectSchedule_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatAppearance.BorderColor = Color.Black;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.White;
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.White;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(6, 855);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 48);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBoxSecurity
            // 
            pictureBoxSecurity.Image = (Image)resources.GetObject("pictureBoxSecurity.Image");
            pictureBoxSecurity.Location = new Point(93, 772);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            pictureBoxSecurity.Click += pictureBoxSecurity_Click;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatAppearance.BorderColor = Color.Black;
            buttonContractTracking.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractTracking.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractTracking.FlatStyle = FlatStyle.Flat;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 307);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 3;
            buttonContractTracking.Text = "DANH SÁCH HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            buttonContractTracking.Click += buttonContractTracking_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatAppearance.BorderColor = Color.Black;
            buttonHome.FlatAppearance.MouseDownBackColor = Color.White;
            buttonHome.FlatAppearance.MouseOverBackColor = Color.White;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(6, 131);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 48);
            buttonHome.TabIndex = 1;
            buttonHome.Text = " TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonInfoUser
            // 
            buttonInfoUser.BackColor = Color.Silver;
            buttonInfoUser.FlatAppearance.BorderColor = Color.Black;
            buttonInfoUser.FlatAppearance.MouseDownBackColor = Color.White;
            buttonInfoUser.FlatAppearance.MouseOverBackColor = Color.White;
            buttonInfoUser.FlatStyle = FlatStyle.Flat;
            buttonInfoUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInfoUser.ForeColor = SystemColors.ControlText;
            buttonInfoUser.Location = new Point(6, 219);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(200, 48);
            buttonInfoUser.TabIndex = 2;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            buttonInfoUser.Click += buttonInfoUser_Click;
            // 
            // pictureBoxLogoDirector
            // 
            pictureBoxLogoDirector.Image = (Image)resources.GetObject("pictureBoxLogoDirector.Image");
            pictureBoxLogoDirector.Location = new Point(0, 0);
            pictureBoxLogoDirector.Name = "pictureBoxLogoDirector";
            pictureBoxLogoDirector.Size = new Size(215, 94);
            pictureBoxLogoDirector.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoDirector.TabIndex = 2;
            pictureBoxLogoDirector.TabStop = false;
            // 
            // mainpanel
            // 
            mainpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainpanel.Location = new Point(216, 0);
            mainpanel.Margin = new Padding(0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1266, 953);
            mainpanel.TabIndex = 7;
            // 
            // Director
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 953);
            Controls.Add(mainpanel);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Director";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seiko";
            Load += Director_Load;
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoDirector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonContractTracking;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoDirector;
        private Button buttonPerformanceReport;
        private Button buttonFinacialReports;
        private Button buttonProjectProgress;
        private Button buttonContractHistory;
        private Panel mainpanel;
    }
}