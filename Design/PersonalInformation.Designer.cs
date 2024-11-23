namespace Design
{
    partial class PersonalInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInformation));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            groupBoxThongTinCaNhan = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            buttonDoiMatKhau = new Button();
            buttonChinhSua = new Button();
            textBoxMatKhau = new TextBox();
            textBoxTenDangNhap = new TextBox();
            buttonThayAnhDaiDien = new Button();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            buttonLuu = new Button();
            dataGridViewThongTinCaNhan = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dataGridViewThongTinCongViec = new DataGridView();
            ChucVu = new DataGridViewTextBoxColumn();
            PhongBan = new DataGridViewTextBoxColumn();
            NgayVaoLam = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBoxThongTinCaNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongTinCaNhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongTinCongViec).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(118, 50);
            label9.Name = "label9";
            label9.Size = new Size(203, 25);
            label9.TabIndex = 56;
            label9.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // groupBoxThongTinCaNhan
            // 
            groupBoxThongTinCaNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxThongTinCaNhan.BackColor = Color.LightGray;
            groupBoxThongTinCaNhan.Controls.Add(label8);
            groupBoxThongTinCaNhan.Controls.Add(label7);
            groupBoxThongTinCaNhan.Controls.Add(pictureBox3);
            groupBoxThongTinCaNhan.Controls.Add(buttonDoiMatKhau);
            groupBoxThongTinCaNhan.Controls.Add(buttonChinhSua);
            groupBoxThongTinCaNhan.Controls.Add(textBoxMatKhau);
            groupBoxThongTinCaNhan.Controls.Add(textBoxTenDangNhap);
            groupBoxThongTinCaNhan.Controls.Add(buttonThayAnhDaiDien);
            groupBoxThongTinCaNhan.Controls.Add(label4);
            groupBoxThongTinCaNhan.Controls.Add(label6);
            groupBoxThongTinCaNhan.Controls.Add(label5);
            groupBoxThongTinCaNhan.Controls.Add(buttonLuu);
            groupBoxThongTinCaNhan.Controls.Add(dataGridViewThongTinCaNhan);
            groupBoxThongTinCaNhan.Controls.Add(dataGridViewThongTinCongViec);
            groupBoxThongTinCaNhan.Location = new Point(127, 141);
            groupBoxThongTinCaNhan.Name = "groupBoxThongTinCaNhan";
            groupBoxThongTinCaNhan.Size = new Size(1000, 800);
            groupBoxThongTinCaNhan.TabIndex = 57;
            groupBoxThongTinCaNhan.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(27, 627);
            label8.Name = "label8";
            label8.Size = new Size(186, 25);
            label8.TabIndex = 80;
            label8.Text = "Thông tin công việc:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(27, 439);
            label7.Name = "label7";
            label7.Size = new Size(172, 25);
            label7.TabIndex = 79;
            label7.Text = "Thông tin cá nhân:";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = Properties.Resources.avatar;
            pictureBox3.Location = new Point(434, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // buttonDoiMatKhau
            // 
            buttonDoiMatKhau.Anchor = AnchorStyles.Left;
            buttonDoiMatKhau.BackColor = Color.DodgerBlue;
            buttonDoiMatKhau.FlatStyle = FlatStyle.Popup;
            buttonDoiMatKhau.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            buttonDoiMatKhau.ForeColor = Color.White;
            buttonDoiMatKhau.Location = new Point(533, 377);
            buttonDoiMatKhau.Name = "buttonDoiMatKhau";
            buttonDoiMatKhau.Size = new Size(133, 29);
            buttonDoiMatKhau.TabIndex = 3;
            buttonDoiMatKhau.Text = "Đổi mật khẩu";
            buttonDoiMatKhau.UseVisualStyleBackColor = false;
            buttonDoiMatKhau.Click += buttonDoiMatKhau_Click;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonChinhSua.BackColor = Color.Goldenrod;
            buttonChinhSua.FlatStyle = FlatStyle.Popup;
            buttonChinhSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChinhSua.ForeColor = Color.White;
            buttonChinhSua.Location = new Point(706, 26);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(116, 31);
            buttonChinhSua.TabIndex = 69;
            buttonChinhSua.Text = "CHỈNH SỬA";
            buttonChinhSua.UseVisualStyleBackColor = false;
            buttonChinhSua.Click += buttonChinhSua_Click_1;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Anchor = AnchorStyles.Left;
            textBoxMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMatKhau.Location = new Point(305, 377);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(207, 30);
            textBoxMatKhau.TabIndex = 2;
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Anchor = AnchorStyles.Left;
            textBoxTenDangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTenDangNhap.Location = new Point(305, 330);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(207, 30);
            textBoxTenDangNhap.TabIndex = 1;
            // 
            // buttonThayAnhDaiDien
            // 
            buttonThayAnhDaiDien.Anchor = AnchorStyles.Top;
            buttonThayAnhDaiDien.BackColor = Color.DodgerBlue;
            buttonThayAnhDaiDien.FlatStyle = FlatStyle.Popup;
            buttonThayAnhDaiDien.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            buttonThayAnhDaiDien.ForeColor = Color.White;
            buttonThayAnhDaiDien.Location = new Point(408, 190);
            buttonThayAnhDaiDien.Name = "buttonThayAnhDaiDien";
            buttonThayAnhDaiDien.Size = new Size(199, 35);
            buttonThayAnhDaiDien.TabIndex = 72;
            buttonThayAnhDaiDien.Text = "THAY ĐỔI ẢNH ĐẠI DIỆN ";
            buttonThayAnhDaiDien.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(154, 380);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 75;
            label4.Text = "Mật khẩu:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(27, 278);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 73;
            label6.Text = "Thông tin tài khoản:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(154, 337);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 74;
            label5.Text = "Tên đăng nhập: ";
            // 
            // buttonLuu
            // 
            buttonLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLuu.BackColor = Color.DodgerBlue;
            buttonLuu.FlatStyle = FlatStyle.Popup;
            buttonLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLuu.ForeColor = Color.White;
            buttonLuu.Location = new Point(854, 26);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(116, 31);
            buttonLuu.TabIndex = 70;
            buttonLuu.Text = "LƯU";
            buttonLuu.UseVisualStyleBackColor = false;
            // 
            // dataGridViewThongTinCaNhan
            // 
            dataGridViewThongTinCaNhan.AllowUserToAddRows = false;
            dataGridViewThongTinCaNhan.AllowUserToDeleteRows = false;
            dataGridViewThongTinCaNhan.AllowUserToResizeColumns = false;
            dataGridViewThongTinCaNhan.AllowUserToResizeRows = false;
            dataGridViewThongTinCaNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewThongTinCaNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewThongTinCaNhan.BackgroundColor = Color.White;
            dataGridViewThongTinCaNhan.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewThongTinCaNhan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewThongTinCaNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewThongTinCaNhan.ColumnHeadersHeight = 50;
            dataGridViewThongTinCaNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewThongTinCaNhan.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, NgaySinh, GioiTinh, SDT, DiaChi, email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewThongTinCaNhan.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewThongTinCaNhan.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewThongTinCaNhan.Location = new Point(154, 478);
            dataGridViewThongTinCaNhan.Name = "dataGridViewThongTinCaNhan";
            dataGridViewThongTinCaNhan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewThongTinCaNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewThongTinCaNhan.RowHeadersVisible = false;
            dataGridViewThongTinCaNhan.RowHeadersWidth = 51;
            dataGridViewThongTinCaNhan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewThongTinCaNhan.RowTemplate.Height = 35;
            dataGridViewThongTinCaNhan.ScrollBars = ScrollBars.None;
            dataGridViewThongTinCaNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewThongTinCaNhan.Size = new Size(809, 88);
            dataGridViewThongTinCaNhan.TabIndex = 4;
            // 
            // MaNhanVien
            // 
            MaNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.Width = 132;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // dataGridViewThongTinCongViec
            // 
            dataGridViewThongTinCongViec.AllowUserToAddRows = false;
            dataGridViewThongTinCongViec.AllowUserToDeleteRows = false;
            dataGridViewThongTinCongViec.AllowUserToResizeColumns = false;
            dataGridViewThongTinCongViec.AllowUserToResizeRows = false;
            dataGridViewThongTinCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewThongTinCongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewThongTinCongViec.BackgroundColor = Color.White;
            dataGridViewThongTinCongViec.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewThongTinCongViec.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkGray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewThongTinCongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewThongTinCongViec.ColumnHeadersHeight = 50;
            dataGridViewThongTinCongViec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewThongTinCongViec.Columns.AddRange(new DataGridViewColumn[] { ChucVu, PhongBan, NgayVaoLam, TrangThai });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewThongTinCongViec.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewThongTinCongViec.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewThongTinCongViec.Location = new Point(154, 669);
            dataGridViewThongTinCongViec.Name = "dataGridViewThongTinCongViec";
            dataGridViewThongTinCongViec.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewThongTinCongViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewThongTinCongViec.RowHeadersVisible = false;
            dataGridViewThongTinCongViec.RowHeadersWidth = 51;
            dataGridViewThongTinCongViec.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewThongTinCongViec.RowTemplate.Height = 35;
            dataGridViewThongTinCongViec.ScrollBars = ScrollBars.None;
            dataGridViewThongTinCongViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewThongTinCongViec.Size = new Size(809, 81);
            dataGridViewThongTinCongViec.TabIndex = 5;
            // 
            // ChucVu
            // 
            ChucVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // PhongBan
            // 
            PhongBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhongBan.HeaderText = "Phòng Ban";
            PhongBan.MinimumWidth = 6;
            PhongBan.Name = "PhongBan";
            // 
            // NgayVaoLam
            // 
            NgayVaoLam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayVaoLam.HeaderText = "Ngày vào làm";
            NgayVaoLam.MinimumWidth = 6;
            NgayVaoLam.Name = "NgayVaoLam";
            // 
            // TrangThai
            // 
            TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // PersonalInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 953);
            Controls.Add(groupBoxThongTinCaNhan);
            Controls.Add(pictureBox4);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PersonalInformation";
            Text = "Thông tin cá nhân";
            Load += PersonalInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBoxThongTinCaNhan.ResumeLayout(false);
            groupBoxThongTinCaNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongTinCaNhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongTinCongViec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private Label label9;
        private GroupBox groupBoxThongTinCaNhan;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox3;
        private Button buttonDoiMatKhau;
        private Button buttonChinhSua;
        private TextBox textBoxMatKhau;
        private TextBox textBoxTenDangNhap;
        private Button buttonThayAnhDaiDien;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button buttonLuu;
        private DataGridView dataGridViewThongTinCaNhan;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn email;
        private DataGridView dataGridViewThongTinCongViec;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn PhongBan;
        private DataGridViewTextBoxColumn NgayVaoLam;
        private DataGridViewTextBoxColumn TrangThai;
    }
}