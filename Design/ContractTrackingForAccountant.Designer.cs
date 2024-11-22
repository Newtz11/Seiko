﻿namespace Design
{
    partial class ContractTrackingForAccountant
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractTrackingForAccountant));
            comboBoxSale = new ComboBox();
            comboBoxTinhTrang = new ComboBox();
            buttonXoa = new Button();
            buttonThem = new Button();
            labelNgayKetThuc = new Label();
            dateTimePickerEnd = new DateTimePicker();
            labelNgayBatDau = new Label();
            dateTimePickerStart = new DateTimePicker();
            labelContractList = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewContractTracking = new DataGridView();
            groupBoxListUser = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelContractTracking = new Label();
            pictureBoxIconContractTracking = new PictureBox();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            TenCongTyCaNhan = new DataGridViewTextBoxColumn();
            NguoiLienHe = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            GiaTriHopDong = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            PhuTrachThanhToan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).BeginInit();
            groupBoxListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSale
            // 
            comboBoxSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxSale.Location = new Point(232, 201);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(197, 31);
            comboBoxSale.TabIndex = 6;
            comboBoxSale.Text = "Nhân viên phụ trách";
            // 
            // comboBoxTinhTrang
            // 
            comboBoxTinhTrang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxTinhTrang.FormattingEnabled = true;
            comboBoxTinhTrang.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxTinhTrang.Location = new Point(33, 201);
            comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            comboBoxTinhTrang.Size = new Size(159, 31);
            comboBoxTinhTrang.TabIndex = 5;
            comboBoxTinhTrang.Text = "Tình trạng";
            // 
            // buttonXoa
            // 
            buttonXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonXoa.BackColor = Color.Crimson;
            buttonXoa.FlatAppearance.BorderSize = 2;
            buttonXoa.FlatStyle = FlatStyle.Popup;
            buttonXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(2251, 203);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(106, 33);
            buttonXoa.TabIndex = 7;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonThem
            // 
            buttonThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonThem.BackColor = Color.FromArgb(0, 192, 0);
            buttonThem.FlatAppearance.BorderSize = 2;
            buttonThem.FlatStyle = FlatStyle.Popup;
            buttonThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            buttonThem.ForeColor = Color.White;
            buttonThem.Location = new Point(2115, 203);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(106, 33);
            buttonThem.TabIndex = 6;
            buttonThem.Text = "Thêm mới";
            buttonThem.UseVisualStyleBackColor = false;
            // 
            // labelNgayKetThuc
            // 
            labelNgayKetThuc.AutoSize = true;
            labelNgayKetThuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgayKetThuc.Location = new Point(473, 148);
            labelNgayKetThuc.Name = "labelNgayKetThuc";
            labelNgayKetThuc.Size = new Size(126, 25);
            labelNgayKetThuc.TabIndex = 21;
            labelNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(603, 148);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(264, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // labelNgayBatDau
            // 
            labelNgayBatDau.AutoSize = true;
            labelNgayBatDau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgayBatDau.Location = new Point(33, 146);
            labelNgayBatDau.Name = "labelNgayBatDau";
            labelNgayBatDau.Size = new Size(124, 25);
            labelNgayBatDau.TabIndex = 19;
            labelNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(163, 146);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(266, 27);
            dateTimePickerStart.TabIndex = 3;
            // 
            // labelContractList
            // 
            labelContractList.AutoSize = true;
            labelContractList.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelContractList.ForeColor = Color.Black;
            labelContractList.Location = new Point(23, 23);
            labelContractList.Name = "labelContractList";
            labelContractList.Size = new Size(343, 38);
            labelContractList.TabIndex = 17;
            labelContractList.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatAppearance.BorderSize = 2;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(2227, 94);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(33, 94);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1033, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // dataGridViewContractTracking
            // 
            dataGridViewContractTracking.AllowUserToAddRows = false;
            dataGridViewContractTracking.AllowUserToDeleteRows = false;
            dataGridViewContractTracking.AllowUserToOrderColumns = true;
            dataGridViewContractTracking.AllowUserToResizeRows = false;
            dataGridViewContractTracking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewContractTracking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContractTracking.BackgroundColor = Color.White;
            dataGridViewContractTracking.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewContractTracking.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewContractTracking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewContractTracking.ColumnHeadersHeight = 60;
            dataGridViewContractTracking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewContractTracking.Columns.AddRange(new DataGridViewColumn[] { MaHopDong, TenHopDong, TenCongTyCaNhan, NguoiLienHe, NgayBatDau, NgayHetHan, GiaTriHopDong, TinhTrang, PhuTrachThanhToan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewContractTracking.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewContractTracking.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewContractTracking.Location = new Point(23, 265);
            dataGridViewContractTracking.Name = "dataGridViewContractTracking";
            dataGridViewContractTracking.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewContractTracking.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewContractTracking.RowHeadersVisible = false;
            dataGridViewContractTracking.RowHeadersWidth = 51;
            dataGridViewContractTracking.RowTemplate.Height = 35;
            dataGridViewContractTracking.ScrollBars = ScrollBars.Vertical;
            dataGridViewContractTracking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewContractTracking.Size = new Size(1260, 500);
            dataGridViewContractTracking.TabIndex = 8;
            // 
            // groupBoxListUser
            // 
            groupBoxListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxListUser.BackColor = Color.LightGray;
            groupBoxListUser.Controls.Add(button1);
            groupBoxListUser.Controls.Add(button2);
            groupBoxListUser.Controls.Add(button3);
            groupBoxListUser.Controls.Add(comboBoxSale);
            groupBoxListUser.Controls.Add(comboBoxTinhTrang);
            groupBoxListUser.Controls.Add(buttonXoa);
            groupBoxListUser.Controls.Add(buttonThem);
            groupBoxListUser.Controls.Add(labelNgayKetThuc);
            groupBoxListUser.Controls.Add(dateTimePickerEnd);
            groupBoxListUser.Controls.Add(labelNgayBatDau);
            groupBoxListUser.Controls.Add(dateTimePickerStart);
            groupBoxListUser.Controls.Add(labelContractList);
            groupBoxListUser.Controls.Add(buttonSearch);
            groupBoxListUser.Controls.Add(textBoxSearch);
            groupBoxListUser.Controls.Add(dataGridViewContractTracking);
            groupBoxListUser.Location = new Point(12, 139);
            groupBoxListUser.Name = "groupBoxListUser";
            groupBoxListUser.Size = new Size(1300, 802);
            groupBoxListUser.TabIndex = 19;
            groupBoxListUser.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1144, 202);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 8;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1008, 202);
            button2.Name = "button2";
            button2.Size = new Size(106, 33);
            button2.TabIndex = 7;
            button2.Text = "Thêm mới";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1120, 93);
            button3.Name = "button3";
            button3.Size = new Size(130, 30);
            button3.TabIndex = 2;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = false;
            // 
            // labelContractTracking
            // 
            labelContractTracking.AutoSize = true;
            labelContractTracking.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractTracking.Location = new Point(118, 54);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(222, 25);
            labelContractTracking.TabIndex = 18;
            labelContractTracking.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 12);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 17;
            pictureBoxIconContractTracking.TabStop = false;
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
            // TenCongTyCaNhan
            // 
            TenCongTyCaNhan.HeaderText = "Tên Công ty/Cá nhân";
            TenCongTyCaNhan.MinimumWidth = 6;
            TenCongTyCaNhan.Name = "TenCongTyCaNhan";
            // 
            // NguoiLienHe
            // 
            NguoiLienHe.HeaderText = "Người liên hệ";
            NguoiLienHe.MinimumWidth = 6;
            NguoiLienHe.Name = "NguoiLienHe";
            // 
            // NgayBatDau
            // 
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayHetHan
            // 
            NgayHetHan.HeaderText = "Ngày hết hạn";
            NgayHetHan.MinimumWidth = 6;
            NgayHetHan.Name = "NgayHetHan";
            // 
            // GiaTriHopDong
            // 
            GiaTriHopDong.HeaderText = "Giá trị hợp đồng";
            GiaTriHopDong.MinimumWidth = 6;
            GiaTriHopDong.Name = "GiaTriHopDong";
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình trạng thanh toán";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            // 
            // PhuTrachThanhToan
            // 
            PhuTrachThanhToan.HeaderText = "Phụ trách thanh toán";
            PhuTrachThanhToan.MinimumWidth = 6;
            PhuTrachThanhToan.Name = "PhuTrachThanhToan";
            // 
            // ContractTrackingForAccountant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 953);
            Controls.Add(groupBoxListUser);
            Controls.Add(labelContractTracking);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContractTrackingForAccountant";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).EndInit();
            groupBoxListUser.ResumeLayout(false);
            groupBoxListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxSale;
        private ComboBox comboBoxTinhTrang;
        private Button buttonXoa;
        private Button buttonThem;
        private Label labelNgayKetThuc;
        private DateTimePicker dateTimePickerEnd;
        private Label labelNgayBatDau;
        private DateTimePicker dateTimePickerStart;
        private Label labelContractList;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridViewContractTracking;
        private GroupBox groupBoxListUser;
        private Label labelContractTracking;
        private PictureBox pictureBoxIconContractTracking;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn TenCongTyCaNhan;
        private DataGridViewTextBoxColumn NguoiLienHe;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayHetHan;
        private DataGridViewTextBoxColumn GiaTriHopDong;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn PhuTrachThanhToan;
    }
}