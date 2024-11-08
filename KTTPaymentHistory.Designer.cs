namespace Design
{
    partial class KTTPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KTTPaymentHistory));
            panel1 = new Panel();
            groupBoxFeature = new GroupBox();
            pictureBoxLogoHeadOfAccounting = new PictureBox();
            buttonHome = new Button();
            buttonContractTracking = new Button();
            buttonPaymentSchedule = new Button();
            buttonContractHistory = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonPaymentHistory = new Button();
            buttonInfoUser = new Button();
            pictureBoxIconContractTracking = new PictureBox();
            buttonSearching = new Button();
            label9 = new Label();
            textBoxSearch = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            CoMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColNgayThanhToan = new DataGridViewTextBoxColumn();
            CoSoTien = new DataGridViewTextBoxColumn();
            CoLoaiHinhThanhToan = new DataGridViewTextBoxColumn();
            ColNoiDungThanhToan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfAccounting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonSearching);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Controls.Add(groupBoxFeature);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(pictureBoxLogoHeadOfAccounting);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonPaymentSchedule);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonPaymentHistory);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Margin = new Padding(5);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Padding = new Padding(5);
            groupBoxFeature.Size = new Size(351, 1578);
            groupBoxFeature.TabIndex = 14;
            groupBoxFeature.TabStop = false;
            // 
            // pictureBoxLogoHeadOfAccounting
            // 
            pictureBoxLogoHeadOfAccounting.Image = (Image)resources.GetObject("pictureBoxLogoHeadOfAccounting.Image");
            pictureBoxLogoHeadOfAccounting.Location = new Point(0, 0);
            pictureBoxLogoHeadOfAccounting.Margin = new Padding(5);
            pictureBoxLogoHeadOfAccounting.Name = "pictureBoxLogoHeadOfAccounting";
            pictureBoxLogoHeadOfAccounting.Size = new Size(351, 110);
            pictureBoxLogoHeadOfAccounting.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoHeadOfAccounting.TabIndex = 11;
            pictureBoxLogoHeadOfAccounting.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = SystemColors.ControlText;
            buttonHome.Location = new Point(10, 202);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(325, 77);
            buttonHome.TabIndex = 19;
            buttonHome.Text = "TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(10, 491);
            buttonContractTracking.Margin = new Padding(5);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(325, 77);
            buttonContractTracking.TabIndex = 18;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            // 
            // buttonPaymentSchedule
            // 
            buttonPaymentSchedule.BackColor = Color.Silver;
            buttonPaymentSchedule.FlatStyle = FlatStyle.Popup;
            buttonPaymentSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPaymentSchedule.ForeColor = SystemColors.ControlText;
            buttonPaymentSchedule.Location = new Point(10, 650);
            buttonPaymentSchedule.Margin = new Padding(5);
            buttonPaymentSchedule.Name = "buttonPaymentSchedule";
            buttonPaymentSchedule.Size = new Size(325, 77);
            buttonPaymentSchedule.TabIndex = 17;
            buttonPaymentSchedule.Text = "TIẾN ĐỘ THANH TOÁN";
            buttonPaymentSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(10, 973);
            buttonContractHistory.Margin = new Padding(5);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(325, 77);
            buttonContractHistory.TabIndex = 15;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(10, 1366);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(325, 77);
            buttonLogout.TabIndex = 11;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSecurity
            // 
            pictureBoxSecurity.Image = (Image)resources.GetObject("pictureBoxSecurity.Image");
            pictureBoxSecurity.Location = new Point(162, 1208);
            pictureBoxSecurity.Margin = new Padding(5);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            // 
            // buttonPaymentHistory
            // 
            buttonPaymentHistory.BackColor = Color.White;
            buttonPaymentHistory.FlatStyle = FlatStyle.Popup;
            buttonPaymentHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPaymentHistory.Location = new Point(10, 811);
            buttonPaymentHistory.Margin = new Padding(5);
            buttonPaymentHistory.Name = "buttonPaymentHistory";
            buttonPaymentHistory.Size = new Size(325, 77);
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
            buttonInfoUser.Location = new Point(10, 344);
            buttonInfoUser.Margin = new Padding(5);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(325, 77);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(365, 77);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 19;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // buttonSearching
            // 
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1859, 220);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 44);
            buttonSearching.TabIndex = 38;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(492, 120);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(329, 40);
            label9.TabIndex = 37;
            label9.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(492, 220);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1294, 44);
            textBoxSearch.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(384, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(1985, 1109);
            panel2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CoMaHopDong, ColTenHopDong, ColNgayThanhToan, CoSoTien, CoLoaiHinhThanhToan, ColNoiDungThanhToan });
            dataGridView1.Location = new Point(38, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1907, 300);
            dataGridView1.TabIndex = 20;
            // 
            // CoMaHopDong
            // 
            CoMaHopDong.HeaderText = "Mã hợp đồng";
            CoMaHopDong.MinimumWidth = 10;
            CoMaHopDong.Name = "CoMaHopDong";
            CoMaHopDong.Width = 300;
            // 
            // ColTenHopDong
            // 
            ColTenHopDong.HeaderText = "Tên hợp đồng";
            ColTenHopDong.MinimumWidth = 10;
            ColTenHopDong.Name = "ColTenHopDong";
            ColTenHopDong.Width = 300;
            // 
            // ColNgayThanhToan
            // 
            ColNgayThanhToan.HeaderText = "Ngày thanh toán";
            ColNgayThanhToan.MinimumWidth = 10;
            ColNgayThanhToan.Name = "ColNgayThanhToan";
            ColNgayThanhToan.Width = 300;
            // 
            // CoSoTien
            // 
            CoSoTien.HeaderText = "Số tiền";
            CoSoTien.MinimumWidth = 10;
            CoSoTien.Name = "CoSoTien";
            CoSoTien.Width = 300;
            // 
            // CoLoaiHinhThanhToan
            // 
            CoLoaiHinhThanhToan.HeaderText = "Loại hình thanh toán (banking or cash)";
            CoLoaiHinhThanhToan.MinimumWidth = 10;
            CoLoaiHinhThanhToan.Name = "CoLoaiHinhThanhToan";
            CoLoaiHinhThanhToan.Width = 300;
            // 
            // ColNoiDungThanhToan
            // 
            ColNoiDungThanhToan.HeaderText = "Nội dung thanh toán";
            ColNoiDungThanhToan.MinimumWidth = 10;
            ColNoiDungThanhToan.Name = "ColNoiDungThanhToan";
            ColNoiDungThanhToan.Width = 350;
            // 
            // KTTPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            Name = "KTTPaymentHistory";
            Text = "KTTPaymentHistory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfAccounting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxFeature;
        private PictureBox pictureBoxLogoHeadOfAccounting;
        private Button buttonHome;
        private Button buttonContractTracking;
        private Button buttonPaymentSchedule;
        private Button buttonContractHistory;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonPaymentHistory;
        private Button buttonInfoUser;
        private PictureBox pictureBoxIconContractTracking;
        private Button buttonSearching;
        private Label label9;
        private TextBox textBoxSearch;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CoMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColNgayThanhToan;
        private DataGridViewTextBoxColumn CoSoTien;
        private DataGridViewTextBoxColumn CoLoaiHinhThanhToan;
        private DataGridViewTextBoxColumn ColNoiDungThanhToan;
    }
}