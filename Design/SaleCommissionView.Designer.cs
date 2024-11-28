namespace Design
{
    partial class SaleCommissionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleCommissionView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBoxIconContractTracking = new PictureBox();
            labelContractTracking = new Label();
            groupBoxCommissionView = new GroupBox();
            dataGridViewCommissionView = new DataGridView();
            dataGridViewTongHoaHong = new DataGridView();
            TongSoHoaHong = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            maHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            GiaiDoanThanhToan = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            NgayNhanThanhToan = new DataGridViewTextBoxColumn();
            GiaTriThanhToan = new DataGridViewTextBoxColumn();
            MucHoaHong = new DataGridViewTextBoxColumn();
            TienHoaHong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxCommissionView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommissionView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTongHoaHong).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(20, 24);
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
            labelContractTracking.Location = new Point(152, 60);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(157, 25);
            labelContractTracking.TabIndex = 16;
            labelContractTracking.Text = "XEM HOA HỒNG";
            // 
            // groupBoxCommissionView
            // 
            groupBoxCommissionView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCommissionView.BackColor = Color.LightGray;
            groupBoxCommissionView.Controls.Add(dataGridViewCommissionView);
            groupBoxCommissionView.Controls.Add(dataGridViewTongHoaHong);
            groupBoxCommissionView.Controls.Add(buttonSearch);
            groupBoxCommissionView.Controls.Add(textBoxSearch);
            groupBoxCommissionView.Location = new Point(21, 165);
            groupBoxCommissionView.Margin = new Padding(2);
            groupBoxCommissionView.Name = "groupBoxCommissionView";
            groupBoxCommissionView.Padding = new Padding(2);
            groupBoxCommissionView.Size = new Size(1223, 743);
            groupBoxCommissionView.TabIndex = 17;
            groupBoxCommissionView.TabStop = false;
            // 
            // dataGridViewCommissionView
            // 
            dataGridViewCommissionView.AllowUserToAddRows = false;
            dataGridViewCommissionView.AllowUserToDeleteRows = false;
            dataGridViewCommissionView.AllowUserToOrderColumns = true;
            dataGridViewCommissionView.AllowUserToResizeRows = false;
            dataGridViewCommissionView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCommissionView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCommissionView.BackgroundColor = Color.White;
            dataGridViewCommissionView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCommissionView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCommissionView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCommissionView.ColumnHeadersHeight = 60;
            dataGridViewCommissionView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCommissionView.Columns.AddRange(new DataGridViewColumn[] { maHopDong, TenHopDong, GiaiDoanThanhToan, MaNhanVien, TenNhanVien, NgayNhanThanhToan, GiaTriThanhToan, MucHoaHong, TienHoaHong });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCommissionView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCommissionView.Enabled = false;
            dataGridViewCommissionView.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewCommissionView.Location = new Point(40, 98);
            dataGridViewCommissionView.Name = "dataGridViewCommissionView";
            dataGridViewCommissionView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCommissionView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCommissionView.RowHeadersVisible = false;
            dataGridViewCommissionView.RowHeadersWidth = 51;
            dataGridViewCommissionView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCommissionView.RowTemplate.Height = 35;
            dataGridViewCommissionView.ScrollBars = ScrollBars.Vertical;
            dataGridViewCommissionView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCommissionView.Size = new Size(1134, 511);
            dataGridViewCommissionView.TabIndex = 3;
            // 
            // dataGridViewTongHoaHong
            // 
            dataGridViewTongHoaHong.AllowUserToResizeColumns = false;
            dataGridViewTongHoaHong.AllowUserToResizeRows = false;
            dataGridViewTongHoaHong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTongHoaHong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTongHoaHong.ColumnHeadersHeight = 29;
            dataGridViewTongHoaHong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTongHoaHong.Columns.AddRange(new DataGridViewColumn[] { TongSoHoaHong });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewTongHoaHong.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTongHoaHong.Enabled = false;
            dataGridViewTongHoaHong.Location = new Point(874, 648);
            dataGridViewTongHoaHong.Name = "dataGridViewTongHoaHong";
            dataGridViewTongHoaHong.RowHeadersVisible = false;
            dataGridViewTongHoaHong.RowHeadersWidth = 51;
            dataGridViewTongHoaHong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTongHoaHong.ScrollBars = ScrollBars.None;
            dataGridViewTongHoaHong.Size = new Size(300, 60);
            dataGridViewTongHoaHong.TabIndex = 4;
            // 
            // TongSoHoaHong
            // 
            TongSoHoaHong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongSoHoaHong.HeaderText = "Tổng Số Hoa Hồng";
            TongSoHoaHong.MinimumWidth = 6;
            TongSoHoaHong.Name = "TongSoHoaHong";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1044, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(40, 40);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(978, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // maHopDong
            // 
            maHopDong.FillWeight = 116.0638F;
            maHopDong.HeaderText = "Mã hợp dồng";
            maHopDong.MinimumWidth = 30;
            maHopDong.Name = "maHopDong";
            maHopDong.Resizable = DataGridViewTriState.False;
            // 
            // TenHopDong
            // 
            TenHopDong.FillWeight = 112.188828F;
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            TenHopDong.Resizable = DataGridViewTriState.False;
            // 
            // GiaiDoanThanhToan
            // 
            GiaiDoanThanhToan.HeaderText = "Giai đoạn thanh toán";
            GiaiDoanThanhToan.MinimumWidth = 6;
            GiaiDoanThanhToan.Name = "GiaiDoanThanhToan";
            // 
            // MaNhanVien
            // 
            MaNhanVien.FillWeight = 99.04235F;
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            TenNhanVien.FillWeight = 99.04235F;
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // NgayNhanThanhToan
            // 
            NgayNhanThanhToan.FillWeight = 99.04235F;
            NgayNhanThanhToan.HeaderText = "Ngày nhận thanh toán";
            NgayNhanThanhToan.MinimumWidth = 6;
            NgayNhanThanhToan.Name = "NgayNhanThanhToan";
            // 
            // GiaTriThanhToan
            // 
            GiaTriThanhToan.HeaderText = "Giá trị thanh toán";
            GiaTriThanhToan.MinimumWidth = 6;
            GiaTriThanhToan.Name = "GiaTriThanhToan";
            // 
            // MucHoaHong
            // 
            MucHoaHong.FillWeight = 99.04235F;
            MucHoaHong.HeaderText = "Hoa hồng (%)";
            MucHoaHong.MinimumWidth = 6;
            MucHoaHong.Name = "MucHoaHong";
            // 
            // TienHoaHong
            // 
            TienHoaHong.FillWeight = 99.04235F;
            TienHoaHong.HeaderText = "Tiền hoa hồng";
            TienHoaHong.MinimumWidth = 6;
            TienHoaHong.Name = "TienHoaHong";
            // 
            // SaleCommissionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 951);
            Controls.Add(groupBoxCommissionView);
            Controls.Add(labelContractTracking);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SaleCommissionView";
            Text = "Xem hoa hồng";
            Load += SaleCommissionView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxCommissionView.ResumeLayout(false);
            groupBoxCommissionView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommissionView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTongHoaHong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractTracking;
        private GroupBox groupBoxCommissionView;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridViewTongHoaHong;
        private DataGridViewTextBoxColumn TongSoHoaHong;
        private DataGridView dataGridViewCommissionView;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn GiaiDoanThanhToan;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn NgayNhanThanhToan;
        private DataGridViewTextBoxColumn GiaTriThanhToan;
        private DataGridViewTextBoxColumn MucHoaHong;
        private DataGridViewTextBoxColumn TienHoaHong;
    }
}