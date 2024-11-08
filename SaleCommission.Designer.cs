namespace Design
{
    partial class SaleCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleCommission));
            groupBoxFeature = new GroupBox();
            buttonHome = new Button();
            buttonContractHistory = new Button();
            buttonCommission = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonCreateContract = new Button();
            buttonContractTracking = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoSale = new PictureBox();
            pictureBoxIconContractTracking = new PictureBox();
            labelContractTracking = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            ColMaNhanVien = new DataGridViewTextBoxColumn();
            ColTenNhanVien = new DataGridViewTextBoxColumn();
            ColChucVu = new DataGridViewTextBoxColumn();
            ColPhongBan = new DataGridViewTextBoxColumn();
            ColTongSoHoaHong = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonCommission);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonCreateContract);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoSale);
            groupBoxFeature.Location = new Point(4, 4);
            groupBoxFeature.Margin = new Padding(5);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Padding = new Padding(5);
            groupBoxFeature.Size = new Size(351, 1578);
            groupBoxFeature.TabIndex = 10;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = SystemColors.ControlText;
            buttonHome.Location = new Point(10, 184);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(325, 77);
            buttonHome.TabIndex = 17;
            buttonHome.Text = "TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(10, 989);
            buttonContractHistory.Margin = new Padding(5);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(325, 77);
            buttonContractHistory.TabIndex = 15;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            // 
            // buttonCommission
            // 
            buttonCommission.BackColor = Color.White;
            buttonCommission.FlatStyle = FlatStyle.Popup;
            buttonCommission.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCommission.ForeColor = SystemColors.ControlText;
            buttonCommission.Location = new Point(10, 823);
            buttonCommission.Margin = new Padding(5);
            buttonCommission.Name = "buttonCommission";
            buttonCommission.Size = new Size(325, 77);
            buttonCommission.TabIndex = 12;
            buttonCommission.Text = "XEM HOA HỒNG";
            buttonCommission.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(10, 1429);
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
            pictureBoxSecurity.Location = new Point(159, 1229);
            pictureBoxSecurity.Margin = new Padding(5);
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
            buttonCreateContract.Location = new Point(10, 494);
            buttonCreateContract.Margin = new Padding(5);
            buttonCreateContract.Name = "buttonCreateContract";
            buttonCreateContract.Size = new Size(325, 77);
            buttonCreateContract.TabIndex = 5;
            buttonCreateContract.Text = "TẠO HỢP ĐỒNG";
            buttonCreateContract.UseVisualStyleBackColor = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(10, 648);
            buttonContractTracking.Margin = new Padding(5);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(325, 77);
            buttonContractTracking.TabIndex = 6;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            // 
            // buttonInfoUser
            // 
            buttonInfoUser.BackColor = Color.Silver;
            buttonInfoUser.FlatStyle = FlatStyle.Popup;
            buttonInfoUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInfoUser.ForeColor = SystemColors.ControlText;
            buttonInfoUser.Location = new Point(10, 336);
            buttonInfoUser.Margin = new Padding(5);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(325, 77);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogoSale
            // 
            pictureBoxLogoSale.Image = (Image)resources.GetObject("pictureBoxLogoSale.Image");
            pictureBoxLogoSale.Location = new Point(10, 0);
            pictureBoxLogoSale.Margin = new Padding(5);
            pictureBoxLogoSale.Name = "pictureBoxLogoSale";
            pictureBoxLogoSale.Size = new Size(341, 122);
            pictureBoxLogoSale.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogoSale.TabIndex = 2;
            pictureBoxLogoSale.TabStop = false;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(365, 77);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 15;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelContractTracking
            // 
            labelContractTracking.AutoSize = true;
            labelContractTracking.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractTracking.Location = new Point(492, 120);
            labelContractTracking.Margin = new Padding(5, 0, 5, 0);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(247, 40);
            labelContractTracking.TabIndex = 16;
            labelContractTracking.Text = "XEM HOA HỒNG";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(383, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1988, 1306);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColMaNhanVien, ColTenNhanVien, ColChucVu, ColPhongBan, ColTongSoHoaHong });
            dataGridView1.Location = new Point(51, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1877, 219);
            dataGridView1.TabIndex = 19;
            // 
            // ColMaNhanVien
            // 
            ColMaNhanVien.HeaderText = "Mã nhân viên";
            ColMaNhanVien.MinimumWidth = 10;
            ColMaNhanVien.Name = "ColMaNhanVien";
            ColMaNhanVien.Width = 300;
            // 
            // ColTenNhanVien
            // 
            ColTenNhanVien.HeaderText = "Tên nhân viên";
            ColTenNhanVien.MinimumWidth = 10;
            ColTenNhanVien.Name = "ColTenNhanVien";
            ColTenNhanVien.Width = 400;
            // 
            // ColChucVu
            // 
            ColChucVu.HeaderText = "Chức vụ";
            ColChucVu.MinimumWidth = 10;
            ColChucVu.Name = "ColChucVu";
            ColChucVu.Width = 300;
            // 
            // ColPhongBan
            // 
            ColPhongBan.HeaderText = "Phòng ban";
            ColPhongBan.MinimumWidth = 10;
            ColPhongBan.Name = "ColPhongBan";
            ColPhongBan.Width = 300;
            // 
            // ColTongSoHoaHong
            // 
            ColTongSoHoaHong.HeaderText = "Tổng số hoa hồng";
            ColTongSoHoaHong.MinimumWidth = 10;
            ColTongSoHoaHong.Name = "ColTongSoHoaHong";
            ColTongSoHoaHong.Width = 500;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1731, 62);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(211, 48);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(51, 62);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(1587, 44);
            textBoxSearch.TabIndex = 17;
            // 
            // SaleCommission
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(groupBox1);
            Controls.Add(labelContractTracking);
            Controls.Add(pictureBoxIconContractTracking);
            Controls.Add(groupBoxFeature);
            Name = "SaleCommission";
            Text = "SaleCommission";
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFeature;
        private Button buttonHome;
        private Button buttonContractHistory;
        private Button buttonCommission;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonCreateContract;
        private Button buttonContractTracking;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoSale;
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractTracking;
        private GroupBox groupBox1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColMaNhanVien;
        private DataGridViewTextBoxColumn ColTenNhanVien;
        private DataGridViewTextBoxColumn ColChucVu;
        private DataGridViewTextBoxColumn ColPhongBan;
        private DataGridViewTextBoxColumn ColTongSoHoaHong;
    }
}