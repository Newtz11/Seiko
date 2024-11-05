namespace Design
{
    partial class HomeAccountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAccountant));
            groupBoxFeature = new GroupBox();
            buttonCommissionCalculation = new Button();
            buttonContractHistory = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonCreateContract = new Button();
            buttonPaymentHistory = new Button();
            buttonHome = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoAccountant = new PictureBox();
            groupBoxHome = new GroupBox();
            pictureBoxSubHome = new PictureBox();
            pictureBoxHomeMain = new PictureBox();
            labelDescribe = new Label();
            labelHome = new Label();
            pictureBoxIconHome = new PictureBox();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoAccountant).BeginInit();
            groupBoxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonCommissionCalculation);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonCreateContract);
            groupBoxFeature.Controls.Add(buttonPaymentHistory);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoAccountant);
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 986);
            groupBoxFeature.TabIndex = 8;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonCommissionCalculation
            // 
            buttonCommissionCalculation.BackColor = Color.Silver;
            buttonCommissionCalculation.FlatStyle = FlatStyle.Popup;
            buttonCommissionCalculation.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCommissionCalculation.ForeColor = SystemColors.ControlText;
            buttonCommissionCalculation.Location = new Point(6, 406);
            buttonCommissionCalculation.Name = "buttonCommissionCalculation";
            buttonCommissionCalculation.Size = new Size(200, 48);
            buttonCommissionCalculation.TabIndex = 17;
            buttonCommissionCalculation.Text = "TÍNH HOA HỒNG";
            buttonCommissionCalculation.UseVisualStyleBackColor = false;
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
            buttonContractHistory.Click += buttonContractHistory_Click;
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
            // buttonCreateContract
            // 
            buttonCreateContract.BackColor = Color.Silver;
            buttonCreateContract.FlatStyle = FlatStyle.Popup;
            buttonCreateContract.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateContract.Location = new Point(6, 307);
            buttonCreateContract.Name = "buttonCreateContract";
            buttonCreateContract.Size = new Size(200, 48);
            buttonCreateContract.TabIndex = 5;
            buttonCreateContract.Text = "TẠO HỢP ĐỒNG";
            buttonCreateContract.UseVisualStyleBackColor = false;
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
            buttonInfoUser.Location = new Point(6, 215);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(200, 48);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogoAccountant
            // 
            pictureBoxLogoAccountant.Image = (Image)resources.GetObject("pictureBoxLogoAccountant.Image");
            pictureBoxLogoAccountant.Location = new Point(6, 0);
            pictureBoxLogoAccountant.Name = "pictureBoxLogoAccountant";
            pictureBoxLogoAccountant.Size = new Size(210, 76);
            pictureBoxLogoAccountant.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogoAccountant.TabIndex = 2;
            pictureBoxLogoAccountant.TabStop = false;
            // 
            // groupBoxHome
            // 
            groupBoxHome.Controls.Add(pictureBoxSubHome);
            groupBoxHome.Controls.Add(pictureBoxHomeMain);
            groupBoxHome.Controls.Add(labelDescribe);
            groupBoxHome.Location = new Point(245, 94);
            groupBoxHome.Name = "groupBoxHome";
            groupBoxHome.Size = new Size(1209, 866);
            groupBoxHome.TabIndex = 17;
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
            labelHome.Location = new Point(300, 51);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 16;
            labelHome.Text = " TRANG CHỦ";
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(222, 9);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 15;
            pictureBoxIconHome.TabStop = false;
            // 
            // HomeAccountant
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
            Name = "HomeAccountant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoAccountant).EndInit();
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
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonCreateContract;
        private Button buttonPaymentHistory;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoAccountant;
        private Button buttonCommissionCalculation;
        private GroupBox groupBoxHome;
        private PictureBox pictureBoxSubHome;
        private PictureBox pictureBoxHomeMain;
        private Label labelDescribe;
        private Label labelHome;
        private PictureBox pictureBoxIconHome;
    }
}