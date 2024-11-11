namespace Design
{
    partial class SaleContractHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleContractHistory));
            pictureBoxIconContractTracking = new PictureBox();
            labelContractHistory = new Label();
            textBoxSearch = new TextBox();
            button1 = new Button();
            buttonSearch = new Button();
            dataGridViewContractTracking = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenNguoiDung = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            noiDungHopDong = new DataGridViewTextBoxColumn();
            ngayHetHang = new DataGridViewTextBoxColumn();
            giaTriHopDong = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(22, 12);
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
            labelContractHistory.Location = new Point(142, 87);
            labelContractHistory.Name = "labelContractHistory";
            labelContractHistory.Size = new Size(184, 25);
            labelContractHistory.TabIndex = 17;
            labelContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(9, 117);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(980, 30);
            textBoxSearch.TabIndex = 17;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1074, 117);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 20;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(2157, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridViewContractTracking
            // 
            dataGridViewContractTracking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewContractTracking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContractTracking.BackgroundColor = Color.White;
            dataGridViewContractTracking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContractTracking.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenNguoiDung, tenKhachHang, noiDungHopDong, ngayHetHang, giaTriHopDong });
            dataGridViewContractTracking.Location = new Point(23, 26);
            dataGridViewContractTracking.Name = "dataGridViewContractTracking";
            dataGridViewContractTracking.RowHeadersWidth = 51;
            dataGridViewContractTracking.Size = new Size(1176, 436);
            dataGridViewContractTracking.TabIndex = 19;
            dataGridViewContractTracking.CellContentClick += dataGridViewContractTracking_CellContentClick;
            // 
            // maHopDong
            // 
            maHopDong.HeaderText = "Mã hợp dồng";
            maHopDong.MinimumWidth = 6;
            maHopDong.Name = "maHopDong";
            // 
            // tenNguoiDung
            // 
            tenNguoiDung.HeaderText = "Tên người dùng";
            tenNguoiDung.MinimumWidth = 6;
            tenNguoiDung.Name = "tenNguoiDung";
            // 
            // tenKhachHang
            // 
            tenKhachHang.HeaderText = "Tên khách hàng (Công ty của người liên hệ đại diện)";
            tenKhachHang.MinimumWidth = 6;
            tenKhachHang.Name = "tenKhachHang";
            // 
            // noiDungHopDong
            // 
            noiDungHopDong.HeaderText = "Nội dung hợp đồng";
            noiDungHopDong.MinimumWidth = 6;
            noiDungHopDong.Name = "noiDungHopDong";
            // 
            // ngayHetHang
            // 
            ngayHetHang.HeaderText = "Ngày hết hạn";
            ngayHetHang.MinimumWidth = 6;
            ngayHetHang.Name = "ngayHetHang";
            // 
            // giaTriHopDong
            // 
            giaTriHopDong.HeaderText = "Giá trị hợp đồng";
            giaTriHopDong.MinimumWidth = 6;
            giaTriHopDong.Name = "giaTriHopDong";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(dataGridViewContractTracking);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Location = new Point(9, 160);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(1224, 691);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // SaleContractHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 951);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(labelContractHistory);
            Controls.Add(textBoxSearch);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "SaleContractHistory";
            Text = "Lịch sử hợp đồng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractHistory;
        private TextBox textBoxSearch;
        private Button button1;
        private Button buttonSearch;
        private DataGridView dataGridViewContractTracking;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenNguoiDung;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn noiDungHopDong;
        private DataGridViewTextBoxColumn ngayHetHang;
        private DataGridViewTextBoxColumn giaTriHopDong;
        private GroupBox groupBox1;
    }
}