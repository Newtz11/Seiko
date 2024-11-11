namespace Design
{
    partial class AccountantContractHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantContractHistory));
            pictureBoxIconContractTracking = new PictureBox();
            labelContractHistory = new Label();
            textBoxSearch = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            dataGridViewProjectSchedule = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenHopDong = new DataGridViewTextBoxColumn();
            ngayThanhToan = new DataGridViewTextBoxColumn();
            soTien = new DataGridViewTextBoxColumn();
            loaiThanhToan = new DataGridViewTextBoxColumn();
            noiDungThanhToan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(29, 51);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 17;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelContractHistory
            // 
            labelContractHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelContractHistory.AutoSize = true;
            labelContractHistory.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractHistory.Location = new Point(170, 111);
            labelContractHistory.Margin = new Padding(5, 0, 5, 0);
            labelContractHistory.Name = "labelContractHistory";
            labelContractHistory.Size = new Size(294, 40);
            labelContractHistory.TabIndex = 18;
            labelContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(29, 198);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(1475, 44);
            textBoxSearch.TabIndex = 19;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1756, 194);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(258, 48);
            button1.TabIndex = 21;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dataGridViewProjectSchedule);
            panel1.Location = new Point(29, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(1985, 1146);
            panel1.TabIndex = 22;
            // 
            // dataGridViewProjectSchedule
            // 
            dataGridViewProjectSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProjectSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectSchedule.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenHopDong, ngayThanhToan, soTien, loaiThanhToan, noiDungThanhToan });
            dataGridViewProjectSchedule.Location = new Point(36, 95);
            dataGridViewProjectSchedule.Margin = new Padding(5);
            dataGridViewProjectSchedule.Name = "dataGridViewProjectSchedule";
            dataGridViewProjectSchedule.RowHeadersWidth = 51;
            dataGridViewProjectSchedule.Size = new Size(1903, 398);
            dataGridViewProjectSchedule.TabIndex = 68;
            // 
            // maHopDong
            // 
            maHopDong.HeaderText = "Mã hợp đồng";
            maHopDong.MinimumWidth = 6;
            maHopDong.Name = "maHopDong";
            // 
            // tenHopDong
            // 
            tenHopDong.HeaderText = "Tên hợp đồng";
            tenHopDong.MinimumWidth = 6;
            tenHopDong.Name = "tenHopDong";
            // 
            // ngayThanhToan
            // 
            ngayThanhToan.HeaderText = "Ngày thanh toán";
            ngayThanhToan.MinimumWidth = 6;
            ngayThanhToan.Name = "ngayThanhToan";
            // 
            // soTien
            // 
            soTien.HeaderText = "Số tiền";
            soTien.MinimumWidth = 6;
            soTien.Name = "soTien";
            // 
            // loaiThanhToan
            // 
            loaiThanhToan.HeaderText = "Loại hình thanh toán ";
            loaiThanhToan.MinimumWidth = 6;
            loaiThanhToan.Name = "loaiThanhToan";
            // 
            // noiDungThanhToan
            // 
            noiDungThanhToan.HeaderText = "Nội dung thanh toán";
            noiDungThanhToan.MinimumWidth = 6;
            noiDungThanhToan.Name = "noiDungThanhToan";
            // 
            // AccountantContractHistory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBoxSearch);
            Controls.Add(labelContractHistory);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountantContractHistory";
            Text = "Lịch sử hợp đồng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractHistory;
        private TextBox textBoxSearch;
        private Button button1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewContractTracking;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenNguoiDung;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn noiDungHopDong;
        private DataGridViewTextBoxColumn ngayHetHang;
        private DataGridViewTextBoxColumn giaTriHopDong;
        private Button buttonSearch;
        private Panel panel1;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
    }
}