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
            buttonProjectProgress = new Button();
            buttonContractHistory = new Button();
            buttonCommission = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
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
            groupBoxFeature.Controls.Add(buttonProjectProgress);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonCommission);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
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
            // buttonProjectProgress
            // 
            buttonProjectProgress.BackColor = Color.Silver;
            buttonProjectProgress.FlatAppearance.BorderColor = Color.Black;
            buttonProjectProgress.FlatAppearance.MouseDownBackColor = Color.White;
            buttonProjectProgress.FlatAppearance.MouseOverBackColor = Color.White;
            buttonProjectProgress.FlatStyle = FlatStyle.Flat;
            buttonProjectProgress.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectProgress.Location = new Point(6, 474);
            buttonProjectProgress.Name = "buttonProjectProgress";
            buttonProjectProgress.Size = new Size(200, 48);
            buttonProjectProgress.TabIndex = 16;
            buttonProjectProgress.Text = "TIẾN ĐỘ CÔNG VIỆC";
            buttonProjectProgress.UseVisualStyleBackColor = false;
            buttonProjectProgress.Click += buttonProjectSchedule_Click;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatAppearance.BorderColor = Color.Black;
            buttonContractHistory.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractHistory.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractHistory.FlatStyle = FlatStyle.Flat;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 690);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 15;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            buttonContractHistory.Click += buttonContractHistory_Click;
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
            buttonCommission.Location = new Point(6, 582);
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
            pictureBoxSecurity.Location = new Point(92, 815);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatAppearance.BorderColor = Color.Black;
            buttonContractTracking.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractTracking.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractTracking.FlatStyle = FlatStyle.Flat;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(6, 366);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(200, 48);
            buttonContractTracking.TabIndex = 6;
            buttonContractTracking.Text = "DANH SÁCH HỢP ĐỒNG";
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
            buttonHome.Location = new Point(6, 150);
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
            buttonInfoUser.Location = new Point(6, 258);
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
            mainpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            Load += Sale_Load;
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonContractHistory;
        private Button buttonFinacialReports;
        private Button buttonCommission;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonContractTracking;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoSale;
        private Button buttonProjectProgress;
        private Panel mainpanel;
    }
}