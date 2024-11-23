namespace Design
{
    partial class Accountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant));
            groupBoxFeature = new GroupBox();
            buttonGiaiDoanThanhToan = new Button();
            mainpanel = new Panel();
            buttonContractHistory = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonContractTracking = new Button();
            buttonHome = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoAccountant = new PictureBox();
            panel1 = new Panel();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoAccountant).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonGiaiDoanThanhToan);
            groupBoxFeature.Controls.Add(mainpanel);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoAccountant);
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Size = new Size(216, 953);
            groupBoxFeature.TabIndex = 8;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonGiaiDoanThanhToan
            // 
            buttonGiaiDoanThanhToan.BackColor = Color.Silver;
            buttonGiaiDoanThanhToan.FlatAppearance.BorderColor = Color.Black;
            buttonGiaiDoanThanhToan.FlatAppearance.MouseDownBackColor = Color.White;
            buttonGiaiDoanThanhToan.FlatAppearance.MouseOverBackColor = Color.White;
            buttonGiaiDoanThanhToan.FlatStyle = FlatStyle.Flat;
            buttonGiaiDoanThanhToan.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGiaiDoanThanhToan.Location = new Point(6, 464);
            buttonGiaiDoanThanhToan.Name = "buttonGiaiDoanThanhToan";
            buttonGiaiDoanThanhToan.Size = new Size(200, 48);
            buttonGiaiDoanThanhToan.TabIndex = 19;
            buttonGiaiDoanThanhToan.Text = "GIAI ĐOẠN THANH TOÁN";
            buttonGiaiDoanThanhToan.UseVisualStyleBackColor = false;
            buttonGiaiDoanThanhToan.Click += buttonGiaiDoanThanhToan_Click;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(221, 4);
            mainpanel.Margin = new Padding(2);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1546, 1099);
            mainpanel.TabIndex = 18;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatAppearance.BorderColor = Color.Black;
            buttonContractHistory.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContractHistory.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContractHistory.FlatStyle = FlatStyle.Flat;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(6, 576);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(200, 48);
            buttonContractHistory.TabIndex = 5;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            buttonContractHistory.Click += buttonContractHistory_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatAppearance.BorderColor = Color.Black;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.White;
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.White;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(6, 854);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 48);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBoxSecurity
            // 
            pictureBoxSecurity.Image = (Image)resources.GetObject("pictureBoxSecurity.Image");
            pictureBoxSecurity.Location = new Point(94, 735);
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
            buttonContractTracking.Location = new Point(6, 352);
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
            buttonHome.Location = new Point(6, 136);
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
            buttonInfoUser.Location = new Point(6, 244);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(200, 48);
            buttonInfoUser.TabIndex = 2;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            buttonInfoUser.Click += buttonInfoUser_Click;
            // 
            // pictureBoxLogoAccountant
            // 
            pictureBoxLogoAccountant.Image = (Image)resources.GetObject("pictureBoxLogoAccountant.Image");
            pictureBoxLogoAccountant.Location = new Point(0, 0);
            pictureBoxLogoAccountant.Name = "pictureBoxLogoAccountant";
            pictureBoxLogoAccountant.Size = new Size(215, 94);
            pictureBoxLogoAccountant.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoAccountant.TabIndex = 2;
            pictureBoxLogoAccountant.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(216, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 953);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // Accountant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 953);
            Controls.Add(panel1);
            Controls.Add(groupBoxFeature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Accountant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seiko";
            Load += Accountant_Load;
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoAccountant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonContractHistory;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonContractTracking;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoAccountant;
        private Panel mainpanel;
        private Panel panel1;
        private Button buttonGiaiDoanThanhToan;
    }
}