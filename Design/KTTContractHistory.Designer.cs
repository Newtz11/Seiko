namespace Design
{
    partial class KTTContractHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KTTContractHistory));
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridViewContractTracking = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenNguoiDung = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            noiDungHopDong = new DataGridViewTextBoxColumn();
            ngayHetHang = new DataGridViewTextBoxColumn();
            giaTriHopDong = new DataGridViewTextBoxColumn();
            buttonSearching = new Button();
            label9 = new Label();
            textBoxSearch = new TextBox();
            pictureBoxIconContractTracking = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonSearching);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridViewContractTracking);
            panel2.Location = new Point(22, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1846, 1076);
            panel2.TabIndex = 36;
            // 
            // dataGridViewContractTracking
            // 
            dataGridViewContractTracking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewContractTracking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContractTracking.BackgroundColor = Color.White;
            dataGridViewContractTracking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContractTracking.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenNguoiDung, tenKhachHang, noiDungHopDong, ngayHetHang, giaTriHopDong });
            dataGridViewContractTracking.Location = new Point(38, 42);
            dataGridViewContractTracking.Margin = new Padding(5);
            dataGridViewContractTracking.Name = "dataGridViewContractTracking";
            dataGridViewContractTracking.RowHeadersWidth = 51;
            dataGridViewContractTracking.Size = new Size(1769, 701);
            dataGridViewContractTracking.TabIndex = 20;
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
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1580, 220);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 44);
            buttonSearching.TabIndex = 35;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(154, 144);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(294, 40);
            label9.TabIndex = 34;
            label9.Text = "LỊCH SỬ HỢP ĐỒNG";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(22, 220);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1445, 44);
            textBoxSearch.TabIndex = 21;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(22, 84);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 18;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // KTTContractHistory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KTTContractHistory";
            Text = "Lịch sử hợp đồng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxIconContractTracking;
        private TextBox textBoxSearch;
        private Label label9;
        private Button buttonSearching;
        private Panel panel2;
        private DataGridView dataGridViewContractTracking;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenNguoiDung;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn noiDungHopDong;
        private DataGridViewTextBoxColumn ngayHetHang;
        private DataGridViewTextBoxColumn giaTriHopDong;
    }
}