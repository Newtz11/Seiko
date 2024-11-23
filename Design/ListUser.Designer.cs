namespace Design
{
    partial class ListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUser));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBoxIconListUser = new PictureBox();
            labelListUser = new Label();
            groupBoxListUser = new GroupBox();
            dataGridViewListUser = new DataGridView();
            SoThuTu = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            TenNguoiDung = new DataGridViewTextBoxColumn();
            MaNguoiDung = new DataGridViewTextBoxColumn();
            PhongBan = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            comboBoxTinhTrang = new ComboBox();
            comboBoxChucVu = new ComboBox();
            comboBoxPhongBan = new ComboBox();
            buttonXoa = new Button();
            buttonTaoTaiKhoan = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            labelDanhSachNguoiDung = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconListUser).BeginInit();
            groupBoxListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListUser).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconListUser
            // 
            pictureBoxIconListUser.Image = (Image)resources.GetObject("pictureBoxIconListUser.Image");
            pictureBoxIconListUser.Location = new Point(12, 12);
            pictureBoxIconListUser.Name = "pictureBoxIconListUser";
            pictureBoxIconListUser.Size = new Size(100, 100);
            pictureBoxIconListUser.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconListUser.TabIndex = 12;
            pictureBoxIconListUser.TabStop = false;
            // 
            // labelListUser
            // 
            labelListUser.AutoSize = true;
            labelListUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelListUser.Location = new Point(41, 23);
            labelListUser.Name = "labelListUser";
            labelListUser.Size = new Size(377, 38);
            labelListUser.TabIndex = 13;
            labelListUser.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // groupBoxListUser
            // 
            groupBoxListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxListUser.BackColor = Color.LightGray;
            groupBoxListUser.Controls.Add(dataGridViewListUser);
            groupBoxListUser.Controls.Add(comboBoxTinhTrang);
            groupBoxListUser.Controls.Add(comboBoxChucVu);
            groupBoxListUser.Controls.Add(comboBoxPhongBan);
            groupBoxListUser.Controls.Add(buttonXoa);
            groupBoxListUser.Controls.Add(buttonTaoTaiKhoan);
            groupBoxListUser.Controls.Add(buttonSearch);
            groupBoxListUser.Controls.Add(textBoxSearch);
            groupBoxListUser.Controls.Add(labelListUser);
            groupBoxListUser.Location = new Point(8, 138);
            groupBoxListUser.Name = "groupBoxListUser";
            groupBoxListUser.Size = new Size(1280, 803);
            groupBoxListUser.TabIndex = 15;
            groupBoxListUser.TabStop = false;
            // 
            // dataGridViewListUser
            // 
            dataGridViewListUser.AllowUserToAddRows = false;
            dataGridViewListUser.AllowUserToDeleteRows = false;
            dataGridViewListUser.AllowUserToOrderColumns = true;
            dataGridViewListUser.AllowUserToResizeRows = false;
            dataGridViewListUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewListUser.BackgroundColor = Color.White;
            dataGridViewListUser.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewListUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewListUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListUser.ColumnHeadersHeight = 50;
            dataGridViewListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewListUser.Columns.AddRange(new DataGridViewColumn[] { SoThuTu, TenDangNhap, mail, TenNguoiDung, MaNguoiDung, PhongBan, ChucVu, TinhTrang });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewListUser.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewListUser.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewListUser.Location = new Point(39, 213);
            dataGridViewListUser.Name = "dataGridViewListUser";
            dataGridViewListUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewListUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewListUser.RowHeadersVisible = false;
            dataGridViewListUser.RowHeadersWidth = 51;
            dataGridViewListUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewListUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewListUser.RowTemplate.Height = 35;
            dataGridViewListUser.ScrollBars = ScrollBars.Vertical;
            dataGridViewListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListUser.Size = new Size(1200, 550);
            dataGridViewListUser.TabIndex = 29;
            dataGridViewListUser.CellClick += dataGridViewListUser_CellClick;
            dataGridViewListUser.CellContentClick += dataGridViewListUser_CellContentClick;
            // 
            // SoThuTu
            // 
            SoThuTu.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoThuTu.HeaderText = "STT";
            SoThuTu.MinimumWidth = 6;
            SoThuTu.Name = "SoThuTu";
            SoThuTu.Width = 64;
            // 
            // TenDangNhap
            // 
            TenDangNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // mail
            // 
            mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mail.HeaderText = "Email";
            mail.MinimumWidth = 6;
            mail.Name = "mail";
            // 
            // TenNguoiDung
            // 
            TenNguoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNguoiDung.HeaderText = "Tên người dùng";
            TenNguoiDung.MinimumWidth = 6;
            TenNguoiDung.Name = "TenNguoiDung";
            // 
            // MaNguoiDung
            // 
            MaNguoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNguoiDung.HeaderText = "Mã người dùng";
            MaNguoiDung.MinimumWidth = 6;
            MaNguoiDung.Name = "MaNguoiDung";
            // 
            // PhongBan
            // 
            PhongBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhongBan.HeaderText = "Phòng ban";
            PhongBan.MinimumWidth = 6;
            PhongBan.Name = "PhongBan";
            // 
            // ChucVu
            // 
            ChucVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // TinhTrang
            // 
            TinhTrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            // 
            // comboBoxTinhTrang
            // 
            comboBoxTinhTrang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxTinhTrang.FormattingEnabled = true;
            comboBoxTinhTrang.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxTinhTrang.Location = new Point(477, 165);
            comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            comboBoxTinhTrang.Size = new Size(159, 31);
            comboBoxTinhTrang.TabIndex = 28;
            comboBoxTinhTrang.Text = "Tình trạng";
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxChucVu.Location = new Point(259, 165);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(159, 31);
            comboBoxChucVu.TabIndex = 27;
            comboBoxChucVu.Text = "Chức vụ";
            // 
            // comboBoxPhongBan
            // 
            comboBoxPhongBan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxPhongBan.FormattingEnabled = true;
            comboBoxPhongBan.Items.AddRange(new object[] { "Sale", "Kế toán", "Giám đốc", "IT" });
            comboBoxPhongBan.Location = new Point(46, 165);
            comboBoxPhongBan.Name = "comboBoxPhongBan";
            comboBoxPhongBan.Size = new Size(159, 31);
            comboBoxPhongBan.TabIndex = 26;
            comboBoxPhongBan.Text = "Phòng ban";
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.Crimson;
            buttonXoa.FlatStyle = FlatStyle.Popup;
            buttonXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(1122, 165);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(106, 33);
            buttonXoa.TabIndex = 20;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonTaoTaiKhoan
            // 
            buttonTaoTaiKhoan.BackColor = Color.FromArgb(0, 192, 0);
            buttonTaoTaiKhoan.FlatStyle = FlatStyle.Popup;
            buttonTaoTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTaoTaiKhoan.ForeColor = Color.White;
            buttonTaoTaiKhoan.Location = new Point(945, 165);
            buttonTaoTaiKhoan.Name = "buttonTaoTaiKhoan";
            buttonTaoTaiKhoan.Size = new Size(136, 33);
            buttonTaoTaiKhoan.TabIndex = 19;
            buttonTaoTaiKhoan.Text = "Tạo tài khoản";
            buttonTaoTaiKhoan.UseVisualStyleBackColor = false;
            buttonTaoTaiKhoan.Click += buttonTaoTaiKhoan_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1122, 85);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(106, 33);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(46, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm người dùng trong danh sách ";
            textBoxSearch.Size = new Size(1035, 30);
            textBoxSearch.TabIndex = 16;
            // 
            // labelDanhSachNguoiDung
            // 
            labelDanhSachNguoiDung.AutoSize = true;
            labelDanhSachNguoiDung.BackColor = SystemColors.Window;
            labelDanhSachNguoiDung.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelDanhSachNguoiDung.Location = new Point(118, 56);
            labelDanhSachNguoiDung.Name = "labelDanhSachNguoiDung";
            labelDanhSachNguoiDung.Size = new Size(243, 25);
            labelDanhSachNguoiDung.TabIndex = 16;
            labelDanhSachNguoiDung.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // ListUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1300, 953);
            Controls.Add(labelDanhSachNguoiDung);
            Controls.Add(groupBoxListUser);
            Controls.Add(pictureBoxIconListUser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListUser";
            Text = "Danh sách người dùng";
            Load += ListUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconListUser).EndInit();
            groupBoxListUser.ResumeLayout(false);
            groupBoxListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconListUser;
        private Label labelListUser;
        private GroupBox groupBoxListUser;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label labelDanhSachNguoiDung;
        private Button buttonXoa;
        private Button buttonTaoTaiKhoan;
        private ComboBox comboBoxChucVu;
        private ComboBox comboBoxPhongBan;
        private ComboBox comboBoxTinhTrang;
        private DataGridView dataGridViewListUser;
        private DataGridViewTextBoxColumn SoThuTu;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn TenNguoiDung;
        private DataGridViewTextBoxColumn MaNguoiDung;
        private DataGridViewTextBoxColumn PhongBan;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}