namespace Design
{
    partial class AccountantManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantManager));
            groupBoxFeature = new GroupBox();
            buttonHome = new Button();
            buttonContractTracking = new Button();
            buttonPaymentSchedule = new Button();
            buttonContractHistory = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonPaymentHistory = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoHeadOfAccounting = new PictureBox();
            panel1 = new Panel();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfAccounting).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonPaymentSchedule);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonPaymentHistory);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoHeadOfAccounting);
            groupBoxFeature.Dock = DockStyle.Left;
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 953);
            groupBoxFeature.TabIndex = 9;
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
            buttonHome.Location = new Point(6, 133);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 48);
            buttonHome.TabIndex = 19;
            buttonHome.Text = " TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 307);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 18;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            buttonContractTracking.Click += buttonContractTracking_Click;
            // 
            // buttonPaymentSchedule
            // 
            buttonPaymentSchedule.BackColor = Color.Silver;
            buttonPaymentSchedule.FlatStyle = FlatStyle.Popup;
            buttonPaymentSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPaymentSchedule.ForeColor = SystemColors.ControlText;
            buttonPaymentSchedule.Location = new Point(6, 406);
            buttonPaymentSchedule.Name = "buttonPaymentSchedule";
            buttonPaymentSchedule.Size = new Size(200, 48);
            buttonPaymentSchedule.TabIndex = 17;
            buttonPaymentSchedule.Text = "TIẾN ĐỘ THANH TOÁN";
            buttonPaymentSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 608);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 15;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(6, 854);
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
            pictureBoxSecurity.Location = new Point(88, 800);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            // 
            // buttonPaymentHistory
            // 
            buttonPaymentHistory.BackColor = Color.Silver;
            buttonPaymentHistory.FlatStyle = FlatStyle.Popup;
            buttonPaymentHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPaymentHistory.Location = new Point(6, 507);
            buttonPaymentHistory.Name = "buttonPaymentHistory";
            buttonPaymentHistory.Size = new Size(200, 48);
            buttonPaymentHistory.TabIndex = 6;
            buttonPaymentHistory.Text = "LỊCH SỬ THANH TOÁN";
            buttonPaymentHistory.UseVisualStyleBackColor = false;
            // 
            // buttonInfoUser
            // 
            buttonInfoUser.BackColor = Color.Silver;
            buttonInfoUser.FlatStyle = FlatStyle.Popup;
            buttonInfoUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInfoUser.ForeColor = SystemColors.ControlText;
            buttonInfoUser.Location = new Point(6, 215);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(200, 48);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            buttonInfoUser.Click += buttonInfoUser_Click;
            // 
            // pictureBoxLogoHeadOfAccounting
            // 
            pictureBoxLogoHeadOfAccounting.Image = (Image)resources.GetObject("pictureBoxLogoHeadOfAccounting.Image");
            pictureBoxLogoHeadOfAccounting.Location = new Point(0, 0);
            pictureBoxLogoHeadOfAccounting.Name = "pictureBoxLogoHeadOfAccounting";
            pictureBoxLogoHeadOfAccounting.Size = new Size(227, 106);
            pictureBoxLogoHeadOfAccounting.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogoHeadOfAccounting.TabIndex = 2;
            pictureBoxLogoHeadOfAccounting.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(216, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 953);
            panel1.TabIndex = 10;
            // 
            // AccountantManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 953);
            Controls.Add(panel1);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountantManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += AccountantManager_Load;
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfAccounting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonPaymentSchedule;
        private Button buttonContractHistory;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonPaymentHistory;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoHeadOfAccounting;
        private Button buttonContractTracking;
        private Panel panel1;
        private Button buttonHome;
    }
}