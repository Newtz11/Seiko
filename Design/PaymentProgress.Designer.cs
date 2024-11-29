namespace Design
{
    partial class PaymentProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentProgress));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pictureBoxIconContractTracking = new PictureBox();
            groupBoxTienDoThanhToan = new GroupBox();
            buttonReset = new Button();
            comboBoxTrangThai = new ComboBox();
            labelTrangThai = new Label();
            dateTimePickerNgayNhanThanhToan = new DateTimePicker();
            dateTimePickerNgayThanhToan = new DateTimePicker();
            labelNgayNhanTT = new Label();
            labelNgayTT = new Label();
            buttonThem = new Button();
            label1 = new Label();
            buttonXoa = new Button();
            buttonSua = new Button();
            dataGridViewPaymentProgress = new DataGridView();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            GiaiDoan = new DataGridViewTextBoxColumn();
            NgayThanhToan = new DataGridViewTextBoxColumn();
            PhanTramTT = new DataGridViewTextBoxColumn();
            GiaTriThanhToan = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            NgayNhanThanhToan = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxTienDoThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentProgress).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 12);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIconContractTracking.TabIndex = 29;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // groupBoxTienDoThanhToan
            // 
            groupBoxTienDoThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTienDoThanhToan.BackColor = Color.LightGray;
            groupBoxTienDoThanhToan.Controls.Add(buttonReset);
            groupBoxTienDoThanhToan.Controls.Add(comboBoxTrangThai);
            groupBoxTienDoThanhToan.Controls.Add(labelTrangThai);
            groupBoxTienDoThanhToan.Controls.Add(dateTimePickerNgayNhanThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(dateTimePickerNgayThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(labelNgayNhanTT);
            groupBoxTienDoThanhToan.Controls.Add(labelNgayTT);
            groupBoxTienDoThanhToan.Controls.Add(buttonThem);
            groupBoxTienDoThanhToan.Controls.Add(label1);
            groupBoxTienDoThanhToan.Controls.Add(buttonXoa);
            groupBoxTienDoThanhToan.Controls.Add(buttonSua);
            groupBoxTienDoThanhToan.Controls.Add(dataGridViewPaymentProgress);
            groupBoxTienDoThanhToan.Controls.Add(buttonSearch);
            groupBoxTienDoThanhToan.Controls.Add(textBoxSearch);
            groupBoxTienDoThanhToan.Location = new Point(12, 129);
            groupBoxTienDoThanhToan.Name = "groupBoxTienDoThanhToan";
            groupBoxTienDoThanhToan.Size = new Size(1276, 812);
            groupBoxTienDoThanhToan.TabIndex = 31;
            groupBoxTienDoThanhToan.TabStop = false;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReset.BackColor = Color.DodgerBlue;
            buttonReset.FlatStyle = FlatStyle.Popup;
            buttonReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(623, 149);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(130, 33);
            buttonReset.TabIndex = 82;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            comboBoxTrangThai.Location = new Point(119, 150);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(223, 31);
            comboBoxTrangThai.TabIndex = 81;
            comboBoxTrangThai.Text = "Trạng thái";
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTrangThai.Location = new Point(20, 149);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(93, 25);
            labelTrangThai.TabIndex = 80;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // dateTimePickerNgayNhanThanhToan
            // 
            dateTimePickerNgayNhanThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerNgayNhanThanhToan.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayNhanThanhToan.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayNhanThanhToan.Location = new Point(884, 99);
            dateTimePickerNgayNhanThanhToan.Name = "dateTimePickerNgayNhanThanhToan";
            dateTimePickerNgayNhanThanhToan.Size = new Size(163, 27);
            dateTimePickerNgayNhanThanhToan.TabIndex = 77;
            // 
            // dateTimePickerNgayThanhToan
            // 
            dateTimePickerNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayThanhToan.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayThanhToan.Location = new Point(179, 97);
            dateTimePickerNgayThanhToan.Name = "dateTimePickerNgayThanhToan";
            dateTimePickerNgayThanhToan.Size = new Size(163, 27);
            dateTimePickerNgayThanhToan.TabIndex = 76;
            // 
            // labelNgayNhanTT
            // 
            labelNgayNhanTT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNgayNhanTT.AutoSize = true;
            labelNgayNhanTT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgayNhanTT.Location = new Point(685, 99);
            labelNgayNhanTT.Name = "labelNgayNhanTT";
            labelNgayNhanTT.Size = new Size(193, 25);
            labelNgayNhanTT.TabIndex = 79;
            labelNgayNhanTT.Text = "Ngày nhận thanh toán:";
            // 
            // labelNgayTT
            // 
            labelNgayTT.AutoSize = true;
            labelNgayTT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNgayTT.Location = new Point(24, 99);
            labelNgayTT.Name = "labelNgayTT";
            labelNgayTT.Size = new Size(149, 25);
            labelNgayTT.TabIndex = 78;
            labelNgayTT.Text = "Ngày thanh toán:";
            // 
            // buttonThem
            // 
            buttonThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonThem.BackColor = Color.FromArgb(0, 192, 0);
            buttonThem.FlatStyle = FlatStyle.Popup;
            buttonThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThem.ForeColor = Color.White;
            buttonThem.Location = new Point(792, 149);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(130, 33);
            buttonThem.TabIndex = 61;
            buttonThem.Text = "Thêm mới";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 60;
            label1.Text = "GIAI ĐOẠN THANH TOÁN";
            // 
            // buttonXoa
            // 
            buttonXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonXoa.BackColor = Color.Crimson;
            buttonXoa.FlatStyle = FlatStyle.Popup;
            buttonXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(1123, 149);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(130, 33);
            buttonXoa.TabIndex = 23;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonSua
            // 
            buttonSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSua.BackColor = Color.Goldenrod;
            buttonSua.FlatStyle = FlatStyle.Popup;
            buttonSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(959, 149);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(130, 33);
            buttonSua.TabIndex = 22;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // dataGridViewPaymentProgress
            // 
            dataGridViewPaymentProgress.AllowUserToAddRows = false;
            dataGridViewPaymentProgress.AllowUserToDeleteRows = false;
            dataGridViewPaymentProgress.AllowUserToOrderColumns = true;
            dataGridViewPaymentProgress.AllowUserToResizeRows = false;
            dataGridViewPaymentProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPaymentProgress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPaymentProgress.BackgroundColor = Color.White;
            dataGridViewPaymentProgress.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewPaymentProgress.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewPaymentProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPaymentProgress.ColumnHeadersHeight = 50;
            dataGridViewPaymentProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPaymentProgress.Columns.AddRange(new DataGridViewColumn[] { MaHopDong, TenHopDong, GiaiDoan, NgayThanhToan, PhanTramTT, GiaTriThanhToan, TrangThai, NgayNhanThanhToan, GhiChu });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewPaymentProgress.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewPaymentProgress.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewPaymentProgress.Location = new Point(20, 209);
            dataGridViewPaymentProgress.Name = "dataGridViewPaymentProgress";
            dataGridViewPaymentProgress.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewPaymentProgress.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewPaymentProgress.RowHeadersVisible = false;
            dataGridViewPaymentProgress.RowHeadersWidth = 51;
            dataGridViewPaymentProgress.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewPaymentProgress.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewPaymentProgress.RowTemplate.Height = 35;
            dataGridViewPaymentProgress.ScrollBars = ScrollBars.Vertical;
            dataGridViewPaymentProgress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPaymentProgress.Size = new Size(1233, 584);
            dataGridViewPaymentProgress.TabIndex = 3;
            // 
            // MaHopDong
            // 
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.MinimumWidth = 6;
            MaHopDong.Name = "MaHopDong";
            // 
            // TenHopDong
            // 
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            // 
            // GiaiDoan
            // 
            GiaiDoan.HeaderText = "Giai đoạn";
            GiaiDoan.MinimumWidth = 6;
            GiaiDoan.Name = "GiaiDoan";
            // 
            // NgayThanhToan
            // 
            NgayThanhToan.HeaderText = "Ngày thanh toán";
            NgayThanhToan.MinimumWidth = 6;
            NgayThanhToan.Name = "NgayThanhToan";
            // 
            // PhanTramTT
            // 
            PhanTramTT.HeaderText = "Phần trăm thanh toán(%)";
            PhanTramTT.MinimumWidth = 6;
            PhanTramTT.Name = "PhanTramTT";
            // 
            // GiaTriThanhToan
            // 
            GiaTriThanhToan.HeaderText = "Giá trị thanh toán";
            GiaTriThanhToan.MinimumWidth = 6;
            GiaTriThanhToan.Name = "GiaTriThanhToan";
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // NgayNhanThanhToan
            // 
            NgayNhanThanhToan.HeaderText = "Ngày nhận thanh toán";
            NgayNhanThanhToan.MinimumWidth = 6;
            NgayNhanThanhToan.Name = "NgayNhanThanhToan";
            // 
            // GhiChu
            // 
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1082, 47);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 30);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(24, 47);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm thông tin";
            textBoxSearch.Size = new Size(1023, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(118, 55);
            label9.Name = "label9";
            label9.Size = new Size(236, 25);
            label9.TabIndex = 59;
            label9.Text = "GIAI ĐOẠN THANH TOÁN";
            // 
            // PaymentProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 953);
            Controls.Add(label9);
            Controls.Add(groupBoxTienDoThanhToan);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PaymentProgress";
            Text = "Tính hoa hồng";
            Load += PaymentProgress_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxTienDoThanhToan.ResumeLayout(false);
            groupBoxTienDoThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentProgress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxFeature;
        private Panel mainpanel;
        private Button buttonCommissionCalculation;
        private Button buttonContractHistory;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonCreateContract;
        private Button buttonPaymentHistory;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoAccountant;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
        private PictureBox pictureBoxIconContractTracking;
        private GroupBox groupBoxTienDoThanhToan;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label label9;
        private DataGridView dataGridViewPaymentProgress;
        private Button buttonXoa;
        private Button buttonSua;
        private Label label1;
        private Button buttonThem;
        private DateTimePicker dateTimePickerNgayNhanThanhToan;
        private DateTimePicker dateTimePickerNgayThanhToan;
        private Label labelNgayNhanTT;
        private Label labelNgayTT;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn GiaiDoan;
        private DataGridViewTextBoxColumn NgayThanhToan;
        private DataGridViewTextBoxColumn PhanTramTT;
        private DataGridViewTextBoxColumn GiaTriThanhToan;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn NgayNhanThanhToan;
        private DataGridViewTextBoxColumn GhiChu;
        private ComboBox comboBoxTrangThai;
        private Label labelTrangThai;
        private Button buttonReset;
    }
}