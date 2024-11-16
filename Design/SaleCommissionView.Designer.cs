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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pictureBoxIconContractTracking = new PictureBox();
            labelContractTracking = new Label();
            groupBoxCommissionView = new GroupBox();
            dataGridViewTongHoaHong = new DataGridView();
            TongSoHoaHong = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewCommissionView = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            HoaHong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxCommissionView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTongHoaHong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommissionView).BeginInit();
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
            groupBoxCommissionView.Location = new Point(102, 165);
            groupBoxCommissionView.Margin = new Padding(2);
            groupBoxCommissionView.Name = "groupBoxCommissionView";
            groupBoxCommissionView.Padding = new Padding(2);
            groupBoxCommissionView.Size = new Size(1064, 743);
            groupBoxCommissionView.TabIndex = 17;
            groupBoxCommissionView.TabStop = false;
            // 
            // dataGridViewTongHoaHong
            // 
            dataGridViewTongHoaHong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewTongHoaHong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTongHoaHong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTongHoaHong.Columns.AddRange(new DataGridViewColumn[] { TongSoHoaHong });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewTongHoaHong.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTongHoaHong.Location = new Point(715, 631);
            dataGridViewTongHoaHong.Name = "dataGridViewTongHoaHong";
            dataGridViewTongHoaHong.RowHeadersVisible = false;
            dataGridViewTongHoaHong.RowHeadersWidth = 51;
            dataGridViewTongHoaHong.ScrollBars = ScrollBars.None;
            dataGridViewTongHoaHong.Size = new Size(300, 65);
            dataGridViewTongHoaHong.TabIndex = 20;
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
            buttonSearch.Location = new Point(885, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(40, 40);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(819, 30);
            textBoxSearch.TabIndex = 17;
            // 
            // dataGridViewCommissionView
            // 
            dataGridViewCommissionView.AllowUserToAddRows = false;
            dataGridViewCommissionView.AllowUserToDeleteRows = false;
            dataGridViewCommissionView.AllowUserToOrderColumns = true;
            dataGridViewCommissionView.AllowUserToResizeRows = false;
            dataGridViewCommissionView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCommissionView.BackgroundColor = Color.White;
            dataGridViewCommissionView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCommissionView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.DarkGray;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewCommissionView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCommissionView.ColumnHeadersHeight = 60;
            dataGridViewCommissionView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCommissionView.Columns.AddRange(new DataGridViewColumn[] { maHopDong, TenHopDong, MaNhanVien, TenNhanVien, HoaHong });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewCommissionView.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCommissionView.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewCommissionView.Location = new Point(40, 98);
            dataGridViewCommissionView.Name = "dataGridViewCommissionView";
            dataGridViewCommissionView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewCommissionView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCommissionView.RowHeadersVisible = false;
            dataGridViewCommissionView.RowHeadersWidth = 51;
            dataGridViewCommissionView.RowTemplate.Height = 35;
            dataGridViewCommissionView.ScrollBars = ScrollBars.Vertical;
            dataGridViewCommissionView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCommissionView.Size = new Size(975, 511);
            dataGridViewCommissionView.TabIndex = 21;
            // 
            // maHopDong
            // 
            maHopDong.FillWeight = 110.190605F;
            maHopDong.HeaderText = "Mã hợp dồng";
            maHopDong.MinimumWidth = 6;
            maHopDong.Name = "maHopDong";
            maHopDong.Resizable = DataGridViewTriState.False;
            // 
            // TenHopDong
            // 
            TenHopDong.FillWeight = 113.27359F;
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            TenHopDong.Resizable = DataGridViewTriState.False;
            // 
            // MaNhanVien
            // 
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // HoaHong
            // 
            HoaHong.HeaderText = "Hoa Hồng";
            HoaHong.MinimumWidth = 6;
            HoaHong.Name = "HoaHong";
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewTongHoaHong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommissionView).EndInit();
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
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn HoaHong;
    }
}