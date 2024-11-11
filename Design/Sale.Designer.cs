namespace Design
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            groupBoxFeature = new GroupBox();
            buttonProjectSchedule = new Button();
            buttonContractHistory = new Button();
            buttonPerformanceReport = new Button();
            buttonCommission = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonCreateContract = new Button();
            buttonContractTracking = new Button();
            buttonHome = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoSale = new PictureBox();
            mainpanel = new Panel();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSale).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonProjectSchedule);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonCommission);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonCreateContract);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoSale);
            groupBoxFeature.Dock = DockStyle.Left;
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 953);
            groupBoxFeature.TabIndex = 7;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonProjectSchedule
            // 
            buttonProjectSchedule.BackColor = Color.Silver;
            buttonProjectSchedule.FlatAppearance.BorderColor = Color.Black;
            buttonProjectSchedule.FlatAppearance.MouseDownBackColor = Color.White;
            buttonProjectSchedule.FlatAppearance.MouseOverBackColor = Color.White;
            buttonProjectSchedule.FlatStyle = FlatStyle.Flat;
            buttonProjectSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectSchedule.Location = new Point(6, 475);
            buttonProjectSchedule.Name = "buttonProjectSchedule";
            buttonProjectSchedule.Size = new Size(200, 48);
            buttonProjectSchedule.TabIndex = 16;
            buttonProjectSchedule.Text = "TIẾN ĐỘ DỰ ÁN ";
            buttonProjectSchedule.UseVisualStyleBackColor = false;
            buttonProjectSchedule.Click += buttonProjectSchedule_Click;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatAppearance.BorderColor = Color.Black;
            buttonContractHistory.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractHistory.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractHistory.FlatStyle = FlatStyle.Flat;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 751);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 15;
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
            buttonPerformanceReport.Location = new Point(6, 657);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(200, 48);
            buttonPerformanceReport.TabIndex = 13;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            buttonPerformanceReport.Click += buttonPerformanceReport_Click;
            // 
            // buttonCommission
            // 
            buttonCommission.BackColor = Color.Silver;
            buttonCommission.FlatAppearance.BorderColor = Color.Black;
            buttonCommission.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCommission.FlatAppearance.MouseOverBackColor = Color.White;
            buttonCommission.FlatStyle = FlatStyle.Flat;
            buttonCommission.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCommission.ForeColor = SystemColors.ControlText;
            buttonCommission.Location = new Point(6, 566);
            buttonCommission.Name = "buttonCommission";
            buttonCommission.Size = new Size(200, 48);
            buttonCommission.TabIndex = 12;
            buttonCommission.Text = "XEM HOA HỒNG";
            buttonCommission.UseVisualStyleBackColor = false;
            buttonCommission.Click += buttonCommission_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatAppearance.BorderColor = Color.Black;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.White;
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.White;
            buttonLogout.FlatStyle = FlatStyle.Flat;
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
            pictureBoxSecurity.Location = new Point(90, 823);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            // 
            // buttonCreateContract
            // 
            buttonCreateContract.BackColor = Color.Silver;
            buttonCreateContract.FlatAppearance.BorderColor = Color.Black;
            buttonCreateContract.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCreateContract.FlatAppearance.MouseOverBackColor = Color.White;
            buttonCreateContract.FlatStyle = FlatStyle.Flat;
            buttonCreateContract.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateContract.Location = new Point(6, 296);
            buttonCreateContract.Name = "buttonCreateContract";
            buttonCreateContract.Size = new Size(200, 48);
            buttonCreateContract.TabIndex = 5;
            buttonCreateContract.Text = "TẠO HỢP ĐỒNG";
            buttonCreateContract.UseVisualStyleBackColor = false;
            buttonCreateContract.Click += buttonContractTracking_Click;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatAppearance.BorderColor = Color.Black;
            buttonContractTracking.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractTracking.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractTracking.FlatStyle = FlatStyle.Flat;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 385);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 6;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            buttonContractTracking.Click += buttonContractTracking_Click_1;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatAppearance.BorderColor = Color.Black;
            buttonHome.FlatAppearance.MouseDownBackColor = Color.White;
            buttonHome.FlatAppearance.MouseOverBackColor = Color.White;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(6, 125);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 48);
            buttonHome.TabIndex = 3;
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
            buttonInfoUser.Location = new Point(6, 210);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(200, 48);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            buttonInfoUser.Click += buttonInfoUser_Click;
            // 
            // pictureBoxLogoSale
            // 
            pictureBoxLogoSale.Image = (Image)resources.GetObject("pictureBoxLogoSale.Image");
            pictureBoxLogoSale.Location = new Point(0, 0);
            pictureBoxLogoSale.Name = "pictureBoxLogoSale";
            pictureBoxLogoSale.Size = new Size(215, 94);
            pictureBoxLogoSale.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoSale.TabIndex = 2;
            pictureBoxLogoSale.TabStop = false;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Right;
            mainpanel.Location = new Point(216, 0);
            mainpanel.Margin = new Padding(0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1266, 953);
            mainpanel.TabIndex = 8;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 953);
            Controls.Add(mainpanel);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seiko";
            Load += HomeSale_Load;
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonContractHistory;
        private Button buttonPerformanceReport;
        private Button buttonFinacialReports;
        private Button buttonCommission;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonCreateContract;
        private Button buttonContractTracking;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoSale;
        private Button buttonProjectSchedule;
        private Panel mainpanel;
    }
}