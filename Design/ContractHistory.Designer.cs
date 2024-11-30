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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBoxIconContractTracking = new PictureBox();
            labelContractHistory = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            groupBoxContractHistory = new GroupBox();
            buttonReset = new Button();
            dataGridViewContractHistory = new DataGridView();
            buttonTimKiem = new Button();
            labelContractList = new Label();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            TenCongTyCaNhan = new DataGridViewTextBoxColumn();
            NguoiLienHe = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            GiaTriHopDong = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxContractHistory.SuspendLayout();
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
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 89);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(1110, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(2310, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // groupBoxContractHistory
            // 
            groupBoxContractHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxContractHistory.BackColor = Color.LightGray;
            groupBoxContractHistory.Controls.Add(buttonReset);
            groupBoxContractHistory.Controls.Add(dataGridViewContractHistory);
            groupBoxContractHistory.Controls.Add(buttonTimKiem);
            groupBoxContractHistory.Controls.Add(labelContractList);
            groupBoxContractHistory.Controls.Add(buttonSearch);
            groupBoxContractHistory.Controls.Add(textBoxSearch);
            groupBoxContractHistory.Location = new Point(12, 143);
            groupBoxContractHistory.Margin = new Padding(2);
            groupBoxContractHistory.Name = "groupBoxContractHistory";
            groupBoxContractHistory.Padding = new Padding(2);
            groupBoxContractHistory.Size = new Size(1377, 799);
            groupBoxContractHistory.TabIndex = 18;
            groupBoxContractHistory.TabStop = false;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReset.BackColor = Color.DodgerBlue;
            buttonReset.FlatStyle = FlatStyle.Popup;
            buttonReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(1210, 134);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(130, 31);
            buttonReset.TabIndex = 32;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // dataGridViewContractHistory
            // 
            dataGridViewContractHistory.AllowUserToAddRows = false;
            dataGridViewContractHistory.AllowUserToDeleteRows = false;
            dataGridViewContractHistory.AllowUserToOrderColumns = true;
            dataGridViewContractHistory.AllowUserToResizeRows = false;
            dataGridViewContractHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewContractHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContractHistory.BackgroundColor = Color.White;
            dataGridViewContractHistory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewContractHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewContractHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewContractHistory.ColumnHeadersHeight = 60;
            dataGridViewContractHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewContractHistory.Columns.AddRange(new DataGridViewColumn[] { MaHopDong, TenHopDong, TenCongTyCaNhan, NguoiLienHe, NgayBatDau, NgayHetHan, GiaTriHopDong, TinhTrang, TenNhanVien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewContractHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewContractHistory.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewContractHistory.Location = new Point(21, 183);
            dataGridViewContractHistory.Name = "dataGridViewContractHistory";
            dataGridViewContractHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewContractHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewContractHistory.RowHeadersVisible = false;
            dataGridViewContractHistory.RowHeadersWidth = 51;
            dataGridViewContractHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewContractHistory.RowTemplate.Height = 35;
            dataGridViewContractHistory.ScrollBars = ScrollBars.Vertical;
            dataGridViewContractHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewContractHistory.Size = new Size(1337, 597);
            dataGridViewContractHistory.TabIndex = 7;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTimKiem.BackColor = Color.DodgerBlue;
            buttonTimKiem.FlatAppearance.BorderSize = 2;
            buttonTimKiem.FlatStyle = FlatStyle.Popup;
            buttonTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimKiem.ForeColor = Color.White;
            buttonTimKiem.Location = new Point(1210, 88);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(130, 30);
            buttonTimKiem.TabIndex = 2;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
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
            // MaHopDong
            // 
            MaHopDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.MinimumWidth = 6;
            MaHopDong.Name = "MaHopDong";
            MaHopDong.Width = 131;
            // 
            // TenHopDong
            // 
            TenHopDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            // 
            // TenCongTyCaNhan
            // 
            TenCongTyCaNhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenCongTyCaNhan.HeaderText = "Tên Công ty/Cá nhân";
            TenCongTyCaNhan.MinimumWidth = 6;
            TenCongTyCaNhan.Name = "TenCongTyCaNhan";
            TenCongTyCaNhan.Width = 184;
            // 
            // NguoiLienHe
            // 
            NguoiLienHe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NguoiLienHe.HeaderText = "Người liên hệ";
            NguoiLienHe.MinimumWidth = 6;
            NguoiLienHe.Name = "NguoiLienHe";
            // 
            // NgayBatDau
            // 
            NgayBatDau.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            NgayBatDau.Width = 132;
            // 
            // NgayHetHan
            // 
            NgayHetHan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayHetHan.HeaderText = "Ngày hết hạn";
            NgayHetHan.MinimumWidth = 6;
            NgayHetHan.Name = "NgayHetHan";
            NgayHetHan.Width = 132;
            // 
            // GiaTriHopDong
            // 
            GiaTriHopDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GiaTriHopDong.HeaderText = "Giá trị hợp đồng";
            GiaTriHopDong.MinimumWidth = 6;
            GiaTriHopDong.Name = "GiaTriHopDong";
            GiaTriHopDong.Width = 152;
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            // 
            // TenNhanVien
            // 
            TenNhanVien.HeaderText = "Account/Sale";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // ContractHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 953);
            Controls.Add(groupBoxContractHistory);
            Controls.Add(labelContractHistory);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ContractHistory";
            Text = "Lịch sử hợp đồng";
            Load += ContractHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxContractHistory.ResumeLayout(false);
            groupBoxContractHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractHistory;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private GroupBox groupBoxContractHistory;
        private Label labelContractList;
        private Button buttonTimKiem;
        private DataGridView dataGridViewContractHistory;
        private Button buttonReset;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn TenCongTyCaNhan;
        private DataGridViewTextBoxColumn NguoiLienHe;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayHetHan;
        private DataGridViewTextBoxColumn GiaTriHopDong;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn TenNhanVien;
    }
}