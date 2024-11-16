namespace Design
{
    partial class AccountantPaymentCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantPaymentCommission));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pictureBoxIconContractTracking = new PictureBox();
            groupBoxTinhHoaHong = new GroupBox();
            buttonLuu = new Button();
            buttonSua = new Button();
            dataGridViewPaymentCommission = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            PhongBan = new DataGridViewTextBoxColumn();
            TongSoHoaHong = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxTinhHoaHong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentCommission).BeginInit();
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
            // groupBoxTinhHoaHong
            // 
            groupBoxTinhHoaHong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTinhHoaHong.BackColor = Color.LightGray;
            groupBoxTinhHoaHong.Controls.Add(buttonLuu);
            groupBoxTinhHoaHong.Controls.Add(buttonSua);
            groupBoxTinhHoaHong.Controls.Add(dataGridViewPaymentCommission);
            groupBoxTinhHoaHong.Controls.Add(buttonSearch);
            groupBoxTinhHoaHong.Controls.Add(textBoxSearch);
            groupBoxTinhHoaHong.Location = new Point(43, 129);
            groupBoxTinhHoaHong.Name = "groupBoxTinhHoaHong";
            groupBoxTinhHoaHong.Size = new Size(1181, 812);
            groupBoxTinhHoaHong.TabIndex = 31;
            groupBoxTinhHoaHong.TabStop = false;
            // 
            // buttonLuu
            // 
            buttonLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLuu.BackColor = Color.DodgerBlue;
            buttonLuu.FlatStyle = FlatStyle.Popup;
            buttonLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLuu.ForeColor = Color.White;
            buttonLuu.Location = new Point(1028, 100);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(130, 45);
            buttonLuu.TabIndex = 23;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = false;
            // 
            // buttonSua
            // 
            buttonSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSua.BackColor = Color.Goldenrod;
            buttonSua.FlatStyle = FlatStyle.Popup;
            buttonSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(864, 100);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(130, 45);
            buttonSua.TabIndex = 22;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPaymentCommission
            // 
            dataGridViewPaymentCommission.AllowUserToAddRows = false;
            dataGridViewPaymentCommission.AllowUserToDeleteRows = false;
            dataGridViewPaymentCommission.AllowUserToOrderColumns = true;
            dataGridViewPaymentCommission.AllowUserToResizeColumns = false;
            dataGridViewPaymentCommission.AllowUserToResizeRows = false;
            dataGridViewPaymentCommission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPaymentCommission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPaymentCommission.BackgroundColor = Color.White;
            dataGridViewPaymentCommission.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewPaymentCommission.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewPaymentCommission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPaymentCommission.ColumnHeadersHeight = 50;
            dataGridViewPaymentCommission.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, ChucVu, PhongBan, TongSoHoaHong });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewPaymentCommission.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewPaymentCommission.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewPaymentCommission.Location = new Point(24, 169);
            dataGridViewPaymentCommission.Name = "dataGridViewPaymentCommission";
            dataGridViewPaymentCommission.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewPaymentCommission.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewPaymentCommission.RowHeadersVisible = false;
            dataGridViewPaymentCommission.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewPaymentCommission.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewPaymentCommission.RowTemplate.Height = 35;
            dataGridViewPaymentCommission.ScrollBars = ScrollBars.Vertical;
            dataGridViewPaymentCommission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPaymentCommission.Size = new Size(1134, 313);
            dataGridViewPaymentCommission.TabIndex = 3;
            // 
            // MaNhanVien
            // 
            MaNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhanVien.FillWeight = 320.85556F;
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 100;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.Resizable = DataGridViewTriState.True;
            // 
            // TenNhanVien
            // 
            TenNhanVien.FillWeight = 0.16366078F;
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 300;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // ChucVu
            // 
            ChucVu.FillWeight = 0.350126535F;
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 200;
            ChucVu.Name = "ChucVu";
            // 
            // PhongBan
            // 
            PhongBan.FillWeight = 0.742286861F;
            PhongBan.HeaderText = "Phòng ban";
            PhongBan.MinimumWidth = 200;
            PhongBan.Name = "PhongBan";
            // 
            // TongSoHoaHong
            // 
            TongSoHoaHong.FillWeight = 234.425842F;
            TongSoHoaHong.HeaderText = "Tổng số hoa hồng";
            TongSoHoaHong.MinimumWidth = 200;
            TongSoHoaHong.Name = "TongSoHoaHong";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(987, 47);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 30);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(24, 47);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm thông tin";
            textBoxSearch.Size = new Size(928, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(131, 87);
            label9.Name = "label9";
            label9.Size = new Size(163, 25);
            label9.TabIndex = 59;
            label9.Text = "TÍNH HOA HỒNG";
            // 
            // AccountantPaymentCommission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 953);
            Controls.Add(label9);
            Controls.Add(groupBoxTinhHoaHong);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AccountantPaymentCommission";
            Text = "Tính hoa hồng";
            Load += AccountantPaymentCommission_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxTinhHoaHong.ResumeLayout(false);
            groupBoxTinhHoaHong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentCommission).EndInit();
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
        private GroupBox groupBoxTinhHoaHong;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label label9;
        private DataGridView dataGridViewPaymentCommission;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn PhongBan;
        private DataGridViewTextBoxColumn TongSoHoaHong;
        private Button buttonLuu;
        private Button buttonSua;
    }
}