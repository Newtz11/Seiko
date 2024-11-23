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
            dataGridViewContractHistory = new DataGridView();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            TenCongTyCaNhan = new DataGridViewTextBoxColumn();
            NguoiLienHe = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            GiaTriHopDong = new DataGridViewTextBoxColumn();
            AccountSale = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            comboBoxSale = new ComboBox();
            labelNgayKetThuc = new Label();
            dateTimePickerEnd = new DateTimePicker();
            labelNgayBatDau = new Label();
            dateTimePickerStart = new DateTimePicker();
            button1 = new Button();
            labelContractList = new Label();
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
            groupBoxContractHistory.Controls.Add(dataGridViewContractHistory);
            groupBoxContractHistory.Controls.Add(comboBoxSale);
            groupBoxContractHistory.Controls.Add(labelNgayKetThuc);
            groupBoxContractHistory.Controls.Add(dateTimePickerEnd);
            groupBoxContractHistory.Controls.Add(labelNgayBatDau);
            groupBoxContractHistory.Controls.Add(dateTimePickerStart);
            groupBoxContractHistory.Controls.Add(button1);
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
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewContractHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewContractHistory.ColumnHeadersHeight = 60;
            dataGridViewContractHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewContractHistory.Columns.AddRange(new DataGridViewColumn[] { MaHopDong, TenHopDong, TenCongTyCaNhan, NguoiLienHe, NgayBatDau, NgayHetHan, GiaTriHopDong, AccountSale, TinhTrang });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewContractHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewContractHistory.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewContractHistory.Location = new Point(25, 200);
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
            dataGridViewContractHistory.Size = new Size(1337, 578);
            dataGridViewContractHistory.TabIndex = 7;
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
            // AccountSale
            // 
            AccountSale.HeaderText = "Account/Sale";
            AccountSale.MinimumWidth = 6;
            AccountSale.Name = "AccountSale";
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            // 
            // comboBoxSale
            // 
            comboBoxSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Location = new Point(911, 143);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(197, 31);
            comboBoxSale.TabIndex = 6;
            comboBoxSale.Text = "Nhân viên phụ trách";
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
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1186, 89);
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
        private Button button1;
        private ComboBox comboBoxSale;
        private Label labelNgayKetThuc;
        private DateTimePicker dateTimePickerEnd;
        private Label labelNgayBatDau;
        private DateTimePicker dateTimePickerStart;
        private DataGridView dataGridViewContractHistory;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn TenCongTyCaNhan;
        private DataGridViewTextBoxColumn NguoiLienHe;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayHetHan;
        private DataGridViewTextBoxColumn GiaTriHopDong;
        private DataGridViewTextBoxColumn AccountSale;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}