namespace Design
{
    partial class SaleManagerContractApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManagerContractApproval));
            panel1 = new Panel();
            buttonKhongDuyet = new Button();
            buttonDuyet = new Button();
            checkBox1 = new CheckBox();
            dataGridViewContractTracking = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenNguoiDung = new DataGridViewTextBoxColumn();
            tenKhachHang = new DataGridViewTextBoxColumn();
            noiDungHopDong = new DataGridViewTextBoxColumn();
            ngayHetHang = new DataGridViewTextBoxColumn();
            giaTriHopDong = new DataGridViewTextBoxColumn();
            ColDuyetHopDong = new DataGridViewTextBoxColumn();
            label9 = new Label();
            buttonSearching = new Button();
            textBoxSearch = new TextBox();
            pictureBoxIconContractTracking = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonKhongDuyet);
            panel1.Controls.Add(buttonDuyet);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(dataGridViewContractTracking);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buttonSearching);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 686);
            panel1.TabIndex = 0;
            // 
            // buttonKhongDuyet
            // 
            buttonKhongDuyet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonKhongDuyet.BackColor = Color.Crimson;
            buttonKhongDuyet.FlatStyle = FlatStyle.Popup;
            buttonKhongDuyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKhongDuyet.ForeColor = Color.White;
            buttonKhongDuyet.Location = new Point(853, 887);
            buttonKhongDuyet.Name = "buttonKhongDuyet";
            buttonKhongDuyet.Size = new Size(123, 28);
            buttonKhongDuyet.TabIndex = 45;
            buttonKhongDuyet.Text = "Không duyệt";
            buttonKhongDuyet.UseVisualStyleBackColor = false;
            // 
            // buttonDuyet
            // 
            buttonDuyet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDuyet.BackColor = Color.DodgerBlue;
            buttonDuyet.FlatStyle = FlatStyle.Popup;
            buttonDuyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDuyet.ForeColor = Color.White;
            buttonDuyet.Location = new Point(853, 834);
            buttonDuyet.Name = "buttonDuyet";
            buttonDuyet.Size = new Size(123, 28);
            buttonDuyet.TabIndex = 44;
            buttonDuyet.Text = "Duyệt";
            buttonDuyet.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1169, 285);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 43;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewContractTracking
            // 
            dataGridViewContractTracking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewContractTracking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContractTracking.BackgroundColor = Color.White;
            dataGridViewContractTracking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContractTracking.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenNguoiDung, tenKhachHang, noiDungHopDong, ngayHetHang, giaTriHopDong, ColDuyetHopDong });
            dataGridViewContractTracking.Location = new Point(26, 217);
            dataGridViewContractTracking.Name = "dataGridViewContractTracking";
            dataGridViewContractTracking.RowHeadersWidth = 51;
            dataGridViewContractTracking.Size = new Size(950, 173);
            dataGridViewContractTracking.TabIndex = 42;
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
            // ColDuyetHopDong
            // 
            ColDuyetHopDong.HeaderText = "Duyệt hợp đồng";
            ColDuyetHopDong.MinimumWidth = 10;
            ColDuyetHopDong.Name = "ColDuyetHopDong";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(110, 100);
            label9.Name = "label9";
            label9.Size = new Size(213, 25);
            label9.TabIndex = 41;
            label9.Text = "PHÊ DUYỆT HỢP ĐỒNG";
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(756, 148);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(177, 28);
            buttonSearching.TabIndex = 40;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(26, 148);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(627, 30);
            textBoxSearch.TabIndex = 39;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(26, 62);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 38;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // SaleManagerContractApproval
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 689);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "SaleManagerContractApproval";
            Text = "Phê duyệt hợp đồng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractTracking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button buttonSearching;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxIconContractTracking;
        private DataGridView dataGridViewContractTracking;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenNguoiDung;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn noiDungHopDong;
        private DataGridViewTextBoxColumn ngayHetHang;
        private DataGridViewTextBoxColumn giaTriHopDong;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn ColDuyetHopDong;
        private Button buttonDuyet;
        private Button buttonKhongDuyet;
    }
}