namespace Design
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            label9 = new Label();
            pictureBoxIconContractTracking = new PictureBox();
            labelHead = new Label();
            groupBoxTienDoThanhToan = new GroupBox();
            buttonHuy = new Button();
            buttonLuu = new Button();
            comboBoxTrangThaiThanhToan = new ComboBox();
            dateTimePickerNgayNhanThanhToan = new DateTimePicker();
            dateTimePickerNgayThanhToan = new DateTimePicker();
            textBoxGhiChu = new TextBox();
            textBoxPhanTramThanhToan = new TextBox();
            textBoxGiaTriThanhToan = new TextBox();
            textBoxGiaiDoan = new TextBox();
            textBoxTenHopDong = new TextBox();
            textBoxMaHopDong = new TextBox();
            labelTrangThai = new Label();
            labelGhiChu = new Label();
            labelPhanTramThanhToan = new Label();
            labelGiaiDoan = new Label();
            labelGiaTriThanhToan = new Label();
            labelNgayNhanThanhToan = new Label();
            labelNgayThanhToan = new Label();
            labelTenHopDong = new Label();
            labelMaHopDong = new Label();
            dateTimePickerEnd = new DateTimePicker();
            labelNgayNhanTT = new Label();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxTienDoThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(118, 55);
            label9.Name = "label9";
            label9.Size = new Size(342, 25);
            label9.TabIndex = 61;
            label9.Text = "CHỈNH SỬA GIAI ĐOẠN THANH TOÁN";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 12);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIconContractTracking.TabIndex = 60;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelHead
            // 
            labelHead.AutoSize = true;
            labelHead.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHead.Location = new Point(6, 10);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(236, 25);
            labelHead.TabIndex = 60;
            labelHead.Text = "GIAI ĐOẠN THANH TOÁN";
            // 
            // groupBoxTienDoThanhToan
            // 
            groupBoxTienDoThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTienDoThanhToan.BackColor = Color.LightGray;
            groupBoxTienDoThanhToan.Controls.Add(buttonHuy);
            groupBoxTienDoThanhToan.Controls.Add(buttonLuu);
            groupBoxTienDoThanhToan.Controls.Add(comboBoxTrangThaiThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(dateTimePickerNgayNhanThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(dateTimePickerNgayThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(textBoxGhiChu);
            groupBoxTienDoThanhToan.Controls.Add(textBoxPhanTramThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(textBoxGiaTriThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(textBoxGiaiDoan);
            groupBoxTienDoThanhToan.Controls.Add(textBoxTenHopDong);
            groupBoxTienDoThanhToan.Controls.Add(textBoxMaHopDong);
            groupBoxTienDoThanhToan.Controls.Add(labelTrangThai);
            groupBoxTienDoThanhToan.Controls.Add(labelGhiChu);
            groupBoxTienDoThanhToan.Controls.Add(labelPhanTramThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(labelGiaiDoan);
            groupBoxTienDoThanhToan.Controls.Add(labelGiaTriThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(labelNgayNhanThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(labelNgayThanhToan);
            groupBoxTienDoThanhToan.Controls.Add(labelTenHopDong);
            groupBoxTienDoThanhToan.Controls.Add(labelMaHopDong);
            groupBoxTienDoThanhToan.Controls.Add(dateTimePickerEnd);
            groupBoxTienDoThanhToan.Controls.Add(labelNgayNhanTT);
            groupBoxTienDoThanhToan.Controls.Add(labelHead);
            groupBoxTienDoThanhToan.Controls.Add(buttonThem);
            groupBoxTienDoThanhToan.Controls.Add(buttonXoa);
            groupBoxTienDoThanhToan.Controls.Add(buttonSua);
            groupBoxTienDoThanhToan.Controls.Add(buttonSearch);
            groupBoxTienDoThanhToan.Location = new Point(12, 129);
            groupBoxTienDoThanhToan.Name = "groupBoxTienDoThanhToan";
            groupBoxTienDoThanhToan.Size = new Size(1158, 612);
            groupBoxTienDoThanhToan.TabIndex = 62;
            groupBoxTienDoThanhToan.TabStop = false;
            // 
            // buttonHuy
            // 
            buttonHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonHuy.BackColor = Color.Crimson;
            buttonHuy.FlatStyle = FlatStyle.Popup;
            buttonHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHuy.ForeColor = Color.White;
            buttonHuy.Location = new Point(1010, 557);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(130, 40);
            buttonHuy.TabIndex = 99;
            buttonHuy.Text = "HỦY BỎ";
            buttonHuy.UseVisualStyleBackColor = false;
            // 
            // buttonLuu
            // 
            buttonLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLuu.BackColor = Color.DodgerBlue;
            buttonLuu.FlatStyle = FlatStyle.Popup;
            buttonLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLuu.ForeColor = Color.White;
            buttonLuu.Location = new Point(847, 557);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(130, 40);
            buttonLuu.TabIndex = 98;
            buttonLuu.Text = "LƯU";
            buttonLuu.UseVisualStyleBackColor = false;
            // 
            // comboBoxTrangThaiThanhToan
            // 
            comboBoxTrangThaiThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxTrangThaiThanhToan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxTrangThaiThanhToan.FormattingEnabled = true;
            comboBoxTrangThaiThanhToan.Items.AddRange(new object[] { "Chưa thanh toán", "Đã thanh toán" });
            comboBoxTrangThaiThanhToan.Location = new Point(847, 405);
            comboBoxTrangThaiThanhToan.Name = "comboBoxTrangThaiThanhToan";
            comboBoxTrangThaiThanhToan.Size = new Size(293, 31);
            comboBoxTrangThaiThanhToan.TabIndex = 97;
            // 
            // dateTimePickerNgayNhanThanhToan
            // 
            dateTimePickerNgayNhanThanhToan.CustomFormat = "dddd, dd/MM/yyyy";
            dateTimePickerNgayNhanThanhToan.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayNhanThanhToan.Location = new Point(221, 307);
            dateTimePickerNgayNhanThanhToan.Name = "dateTimePickerNgayNhanThanhToan";
            dateTimePickerNgayNhanThanhToan.Size = new Size(297, 27);
            dateTimePickerNgayNhanThanhToan.TabIndex = 96;
            // 
            // dateTimePickerNgayThanhToan
            // 
            dateTimePickerNgayThanhToan.CustomFormat = "dddd, dd/MM/yyyy";
            dateTimePickerNgayThanhToan.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayThanhToan.Location = new Point(221, 220);
            dateTimePickerNgayThanhToan.Name = "dateTimePickerNgayThanhToan";
            dateTimePickerNgayThanhToan.Size = new Size(297, 27);
            dateTimePickerNgayThanhToan.TabIndex = 95;
            // 
            // textBoxGhiChu
            // 
            textBoxGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxGhiChu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxGhiChu.Location = new Point(847, 218);
            textBoxGhiChu.MaxLength = 100;
            textBoxGhiChu.Multiline = true;
            textBoxGhiChu.Name = "textBoxGhiChu";
            textBoxGhiChu.Size = new Size(293, 116);
            textBoxGhiChu.TabIndex = 94;
            // 
            // textBoxPhanTramThanhToan
            // 
            textBoxPhanTramThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhanTramThanhToan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxPhanTramThanhToan.Location = new Point(847, 139);
            textBoxPhanTramThanhToan.Name = "textBoxPhanTramThanhToan";
            textBoxPhanTramThanhToan.Size = new Size(293, 30);
            textBoxPhanTramThanhToan.TabIndex = 93;
            // 
            // textBoxGiaTriThanhToan
            // 
            textBoxGiaTriThanhToan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxGiaTriThanhToan.Location = new Point(221, 404);
            textBoxGiaTriThanhToan.Name = "textBoxGiaTriThanhToan";
            textBoxGiaTriThanhToan.Size = new Size(297, 30);
            textBoxGiaTriThanhToan.TabIndex = 92;
            // 
            // textBoxGiaiDoan
            // 
            textBoxGiaiDoan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxGiaiDoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxGiaiDoan.Location = new Point(847, 58);
            textBoxGiaiDoan.Name = "textBoxGiaiDoan";
            textBoxGiaiDoan.Size = new Size(293, 30);
            textBoxGiaiDoan.TabIndex = 91;
            // 
            // textBoxTenHopDong
            // 
            textBoxTenHopDong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxTenHopDong.Location = new Point(221, 133);
            textBoxTenHopDong.MaxLength = 50;
            textBoxTenHopDong.Name = "textBoxTenHopDong";
            textBoxTenHopDong.Size = new Size(297, 30);
            textBoxTenHopDong.TabIndex = 90;
            // 
            // textBoxMaHopDong
            // 
            textBoxMaHopDong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaHopDong.Location = new Point(221, 58);
            textBoxMaHopDong.MaxLength = 5;
            textBoxMaHopDong.Name = "textBoxMaHopDong";
            textBoxMaHopDong.Size = new Size(297, 30);
            textBoxMaHopDong.TabIndex = 89;
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTrangThai.Location = new Point(602, 405);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(104, 25);
            labelTrangThai.TabIndex = 88;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // labelGhiChu
            // 
            labelGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGhiChu.AutoSize = true;
            labelGhiChu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelGhiChu.Location = new Point(602, 223);
            labelGhiChu.Name = "labelGhiChu";
            labelGhiChu.Size = new Size(82, 25);
            labelGhiChu.TabIndex = 87;
            labelGhiChu.Text = "Ghi chú:";
            // 
            // labelPhanTramThanhToan
            // 
            labelPhanTramThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPhanTramThanhToan.AutoSize = true;
            labelPhanTramThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelPhanTramThanhToan.Location = new Point(602, 139);
            labelPhanTramThanhToan.Name = "labelPhanTramThanhToan";
            labelPhanTramThanhToan.Size = new Size(239, 25);
            labelPhanTramThanhToan.TabIndex = 86;
            labelPhanTramThanhToan.Text = "Phần trăm thanh toán (%):";
            // 
            // labelGiaiDoan
            // 
            labelGiaiDoan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGiaiDoan.AutoSize = true;
            labelGiaiDoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelGiaiDoan.Location = new Point(602, 59);
            labelGiaiDoan.Name = "labelGiaiDoan";
            labelGiaiDoan.Size = new Size(98, 25);
            labelGiaiDoan.TabIndex = 85;
            labelGiaiDoan.Text = "Giai đoạn:";
            // 
            // labelGiaTriThanhToan
            // 
            labelGiaTriThanhToan.AutoSize = true;
            labelGiaTriThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelGiaTriThanhToan.Location = new Point(6, 405);
            labelGiaTriThanhToan.Name = "labelGiaTriThanhToan";
            labelGiaTriThanhToan.Size = new Size(168, 25);
            labelGiaTriThanhToan.TabIndex = 84;
            labelGiaTriThanhToan.Text = "Giá trị thanh toán:";
            // 
            // labelNgayNhanThanhToan
            // 
            labelNgayNhanThanhToan.AutoSize = true;
            labelNgayNhanThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelNgayNhanThanhToan.Location = new Point(6, 309);
            labelNgayNhanThanhToan.Name = "labelNgayNhanThanhToan";
            labelNgayNhanThanhToan.Size = new Size(209, 25);
            labelNgayNhanThanhToan.TabIndex = 83;
            labelNgayNhanThanhToan.Text = "Ngày nhận thanh toán:";
            labelNgayNhanThanhToan.Click += label3_Click;
            // 
            // labelNgayThanhToan
            // 
            labelNgayThanhToan.AutoSize = true;
            labelNgayThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelNgayThanhToan.Location = new Point(6, 222);
            labelNgayThanhToan.Name = "labelNgayThanhToan";
            labelNgayThanhToan.Size = new Size(161, 25);
            labelNgayThanhToan.TabIndex = 82;
            labelNgayThanhToan.Text = "Ngày thanh toán:";
            // 
            // labelTenHopDong
            // 
            labelTenHopDong.AutoSize = true;
            labelTenHopDong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTenHopDong.Location = new Point(6, 138);
            labelTenHopDong.Name = "labelTenHopDong";
            labelTenHopDong.Size = new Size(134, 25);
            labelTenHopDong.TabIndex = 81;
            labelTenHopDong.Text = "Tên hợp đồng:";
            // 
            // labelMaHopDong
            // 
            labelMaHopDong.AutoSize = true;
            labelMaHopDong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelMaHopDong.Location = new Point(6, 58);
            labelMaHopDong.Name = "labelMaHopDong";
            labelMaHopDong.Size = new Size(131, 25);
            labelMaHopDong.TabIndex = 80;
            labelMaHopDong.Text = "Mã hợp đồng:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerEnd.Location = new Point(1776, 100);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(262, 27);
            dateTimePickerEnd.TabIndex = 77;
            // 
            // labelNgayNhanTT
            // 
            labelNgayNhanTT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNgayNhanTT.AutoSize = true;
            labelNgayNhanTT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgayNhanTT.Location = new Point(1577, 99);
            labelNgayNhanTT.Name = "labelNgayNhanTT";
            labelNgayNhanTT.Size = new Size(193, 25);
            labelNgayNhanTT.TabIndex = 79;
            labelNgayNhanTT.Text = "Ngày nhận thanh toán:";
            // 
            // buttonThem
            // 
            buttonThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonThem.BackColor = Color.FromArgb(0, 192, 0);
            buttonThem.FlatStyle = FlatStyle.Popup;
            buttonThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThem.ForeColor = Color.White;
            buttonThem.Location = new Point(1750, 149);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(130, 33);
            buttonThem.TabIndex = 61;
            buttonThem.Text = "Thêm mới";
            buttonThem.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            buttonXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonXoa.BackColor = Color.Crimson;
            buttonXoa.FlatStyle = FlatStyle.Popup;
            buttonXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(2081, 149);
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
            buttonSua.Location = new Point(1917, 149);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(130, 33);
            buttonSua.TabIndex = 22;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(2040, 47);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 30);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(groupBoxTienDoThanhToan);
            Controls.Add(label9);
            Controls.Add(pictureBoxIconContractTracking);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form";
            Text = "Seiko";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxTienDoThanhToan.ResumeLayout(false);
            groupBoxTienDoThanhToan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private PictureBox pictureBoxIconContractTracking;
        private Label labelHead;
        private GroupBox groupBoxTienDoThanhToan;
        private Label labelMaHopDong;
        private DateTimePicker dateTimePickerEnd;
        private Label labelNgayNhanTT;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonSearch;
        private Label labelNgayThanhToan;
        private Label labelTenHopDong;
        private Label labelTrangThai;
        private Label labelGhiChu;
        private Label labelPhanTramThanhToan;
        private Label labelGiaiDoan;
        private Label labelGiaTriThanhToan;
        private Label labelNgayNhanThanhToan;
        private TextBox textBoxMaHopDong;
        private DateTimePicker dateTimePickerNgayNhanThanhToan;
        private DateTimePicker dateTimePickerNgayThanhToan;
        private TextBox textBoxGhiChu;
        private TextBox textBoxPhanTramThanhToan;
        private TextBox textBoxGiaTriThanhToan;
        private TextBox textBoxGiaiDoan;
        private TextBox textBoxTenHopDong;
        private ComboBox comboBoxTrangThaiThanhToan;
        private Button buttonHuy;
        private Button buttonLuu;
    }
}