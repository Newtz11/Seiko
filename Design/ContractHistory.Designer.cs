namespace Design
{
    partial class ContractHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractHistory));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBoxIconContractTracking = new PictureBox();
            labelContractHistory = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            groupBox1 = new GroupBox();
            dataGridViewContractHistory = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            tenCongTy = new DataGridViewTextBoxColumn();
            NguoiLienHe = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            ngayHetHang = new DataGridViewTextBoxColumn();
            giaTriHopDong = new DataGridViewTextBoxColumn();
            AccountSale = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            comboBoxSale = new ComboBox();
            comboBoxTinhTrang = new ComboBox();
            labelNgayKetThuc = new Label();
            dateTimePickerEnd = new DateTimePicker();
            labelNgayBatDau = new Label();
            dateTimePickerStart = new DateTimePicker();
            button1 = new Button();
            labelContractList = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractHistory).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 12);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 16;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelContractHistory
            // 
            labelContractHistory.AutoSize = true;
            labelContractHistory.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractHistory.Location = new Point(118, 58);
            labelContractHistory.Name = "labelContractHistory";
            labelContractHistory.Size = new Size(184, 25);
            labelContractHistory.TabIndex = 17;
            labelContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 89);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(1033, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(2233, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(dataGridViewContractHistory);
            groupBox1.Controls.Add(comboBoxSale);
            groupBox1.Controls.Add(comboBoxTinhTrang);
            groupBox1.Controls.Add(labelNgayKetThuc);
            groupBox1.Controls.Add(dateTimePickerEnd);
            groupBox1.Controls.Add(labelNgayBatDau);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(labelContractList);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(50, 143);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1300, 799);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // dataGridViewContractHistory
            // 
            dataGridViewContractHistory.AllowUserToAddRows = false;
            dataGridViewContractHistory.AllowUserToDeleteRows = false;
            dataGridViewContractHistory.AllowUserToOrderColumns = true;
            dataGridViewContractHistory.AllowUserToResizeRows = false;
            dataGridViewContractHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridViewContractHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewContractHistory.BackgroundColor = Color.White;
            dataGridViewContractHistory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewContractHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkGray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewContractHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewContractHistory.ColumnHeadersHeight = 60;
            dataGridViewContractHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewContractHistory.Columns.AddRange(new DataGridViewColumn[] { maHopDong, TenHopDong, tenCongTy, NguoiLienHe, NgayBatDau, ngayHetHang, giaTriHopDong, AccountSale, TinhTrang });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewContractHistory.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewContractHistory.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewContractHistory.Location = new Point(25, 259);
            dataGridViewContractHistory.Name = "dataGridViewContractHistory";
            dataGridViewContractHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewContractHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewContractHistory.RowHeadersVisible = false;
            dataGridViewContractHistory.RowHeadersWidth = 51;
            dataGridViewContractHistory.RowTemplate.Height = 35;
            dataGridViewContractHistory.ScrollBars = ScrollBars.Vertical;
            dataGridViewContractHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewContractHistory.Size = new Size(1260, 499);
            dataGridViewContractHistory.TabIndex = 7;
            // 
            // maHopDong
            // 
            maHopDong.FillWeight = 110.190605F;
            maHopDong.HeaderText = "Mã hợp dồng";
            maHopDong.MinimumWidth = 6;
            maHopDong.Name = "maHopDong";
            maHopDong.Resizable = DataGridViewTriState.False;
            maHopDong.Width = 131;
            // 
            // TenHopDong
            // 
            TenHopDong.FillWeight = 113.27359F;
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            TenHopDong.Resizable = DataGridViewTriState.False;
            TenHopDong.Width = 134;
            // 
            // tenCongTy
            // 
            tenCongTy.FillWeight = 140.829F;
            tenCongTy.HeaderText = "Tên Công ty/Cá nhân";
            tenCongTy.MinimumWidth = 6;
            tenCongTy.Name = "tenCongTy";
            tenCongTy.Resizable = DataGridViewTriState.False;
            tenCongTy.Width = 184;
            // 
            // NguoiLienHe
            // 
            NguoiLienHe.FillWeight = 92.85412F;
            NguoiLienHe.HeaderText = "Người liên hệ";
            NguoiLienHe.MinimumWidth = 6;
            NguoiLienHe.Name = "NguoiLienHe";
            NguoiLienHe.Resizable = DataGridViewTriState.False;
            NguoiLienHe.Width = 132;
            // 
            // NgayBatDau
            // 
            NgayBatDau.FillWeight = 87.81649F;
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            NgayBatDau.Resizable = DataGridViewTriState.False;
            NgayBatDau.Width = 132;
            // 
            // ngayHetHang
            // 
            ngayHetHang.FillWeight = 86.0413361F;
            ngayHetHang.HeaderText = "Ngày hết hạn";
            ngayHetHang.MinimumWidth = 6;
            ngayHetHang.Name = "ngayHetHang";
            ngayHetHang.Resizable = DataGridViewTriState.False;
            ngayHetHang.Width = 132;
            // 
            // giaTriHopDong
            // 
            giaTriHopDong.FillWeight = 96.2567F;
            giaTriHopDong.HeaderText = "Giá trị hợp đồng";
            giaTriHopDong.MinimumWidth = 6;
            giaTriHopDong.Name = "giaTriHopDong";
            giaTriHopDong.Resizable = DataGridViewTriState.False;
            giaTriHopDong.Width = 152;
            // 
            // AccountSale
            // 
            AccountSale.FillWeight = 114.6868F;
            AccountSale.HeaderText = "Account/Sale";
            AccountSale.MinimumWidth = 6;
            AccountSale.Name = "AccountSale";
            AccountSale.Resizable = DataGridViewTriState.False;
            AccountSale.Width = 131;
            // 
            // TinhTrang
            // 
            TinhTrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TinhTrang.FillWeight = 58.0513535F;
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.Resizable = DataGridViewTriState.False;
            // 
            // comboBoxSale
            // 
            comboBoxSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxSale.Location = new Point(233, 201);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(197, 31);
            comboBoxSale.TabIndex = 6;
            comboBoxSale.Text = "Nhân viên phụ trách";
            // 
            // comboBoxTinhTrang
            // 
            comboBoxTinhTrang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxTinhTrang.FormattingEnabled = true;
            comboBoxTinhTrang.ItemHeight = 23;
            comboBoxTinhTrang.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxTinhTrang.Location = new Point(25, 201);
            comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            comboBoxTinhTrang.Size = new Size(159, 31);
            comboBoxTinhTrang.TabIndex = 5;
            comboBoxTinhTrang.Text = "Tình trạng";
            // 
            // labelNgayKetThuc
            // 
            labelNgayKetThuc.AutoSize = true;
            labelNgayKetThuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgayKetThuc.Location = new Point(471, 147);
            labelNgayKetThuc.Name = "labelNgayKetThuc";
            labelNgayKetThuc.Size = new Size(126, 25);
            labelNgayKetThuc.TabIndex = 31;
            labelNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(601, 147);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(264, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgayBatDau.Location = new Point(25, 146);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(124, 25);
            labelNgayBatDau.TabIndex = 29;
            labelNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(155, 145);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(275, 27);
            dateTimePickerStart.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1109, 89);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelContractList
            // 
            labelContractList.AutoSize = true;
            labelContractList.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelContractList.ForeColor = Color.Black;
            labelContractList.Location = new Point(25, 22);
            labelContractList.Name = "labelContractList";
            labelContractList.Size = new Size(284, 38);
            labelContractList.TabIndex = 20;
            labelContractList.Text = "LỊCH SỬ HỢP ĐỒNG";
            // 
            // ContractHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 953);
            Controls.Add(groupBox1);
            Controls.Add(labelContractHistory);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ContractHistory";
            Text = "Lịch sử hợp đồng";
            Load += ContractHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractHistory;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private GroupBox groupBox1;
        private Label labelContractList;
        private Button button1;
        private ComboBox comboBoxSale;
        private ComboBox comboBoxTinhTrang;
        private Label labelNgayKetThuc;
        private DateTimePicker dateTimePickerEnd;
        private Label labelNgayBatDau;
        private DateTimePicker dateTimePickerStart;
        private DataGridView dataGridViewContractHistory;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn tenCongTy;
        private DataGridViewTextBoxColumn NguoiLienHe;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn ngayHetHang;
        private DataGridViewTextBoxColumn giaTriHopDong;
        private DataGridViewTextBoxColumn AccountSale;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}