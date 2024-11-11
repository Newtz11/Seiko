namespace Design
{
    partial class SaleCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleCommission));
            pictureBoxIconContractTracking = new PictureBox();
            labelContractTracking = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            ColMaNhanVien = new DataGridViewTextBoxColumn();
            ColTenNhanVien = new DataGridViewTextBoxColumn();
            ColChucVu = new DataGridViewTextBoxColumn();
            ColPhongBan = new DataGridViewTextBoxColumn();
            ColTongSoHoaHong = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            labelContractTracking.Location = new Point(169, 64);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(157, 25);
            labelContractTracking.TabIndex = 16;
            labelContractTracking.Text = "XEM HOA HỒNG";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(102, 165);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1064, 743);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColMaNhanVien, ColTenNhanVien, ColChucVu, ColPhongBan, ColTongSoHoaHong });
            dataGridView1.Location = new Point(31, 117);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(996, 262);
            dataGridView1.TabIndex = 19;
            // 
            // ColMaNhanVien
            // 
            ColMaNhanVien.HeaderText = "Mã nhân viên";
            ColMaNhanVien.MinimumWidth = 10;
            ColMaNhanVien.Name = "ColMaNhanVien";
            ColMaNhanVien.Width = 300;
            // 
            // ColTenNhanVien
            // 
            ColTenNhanVien.HeaderText = "Tên nhân viên";
            ColTenNhanVien.MinimumWidth = 10;
            ColTenNhanVien.Name = "ColTenNhanVien";
            ColTenNhanVien.Width = 400;
            // 
            // ColChucVu
            // 
            ColChucVu.HeaderText = "Chức vụ";
            ColChucVu.MinimumWidth = 10;
            ColChucVu.Name = "ColChucVu";
            ColChucVu.Width = 300;
            // 
            // ColPhongBan
            // 
            ColPhongBan.HeaderText = "Phòng ban";
            ColPhongBan.MinimumWidth = 10;
            ColPhongBan.Name = "ColPhongBan";
            ColPhongBan.Width = 300;
            // 
            // ColTongSoHoaHong
            // 
            ColTongSoHoaHong.HeaderText = "Tổng số hoa hồng";
            ColTongSoHoaHong.MinimumWidth = 10;
            ColTongSoHoaHong.Name = "ColTongSoHoaHong";
            ColTongSoHoaHong.Width = 500;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(906, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(31, 39);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(819, 30);
            textBoxSearch.TabIndex = 17;
            // 
            // SaleCommission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 951);
            Controls.Add(groupBox1);
            Controls.Add(labelContractTracking);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SaleCommission";
            Text = "Xem hoa hồng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractTracking;
        private GroupBox groupBox1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColMaNhanVien;
        private DataGridViewTextBoxColumn ColTenNhanVien;
        private DataGridViewTextBoxColumn ColChucVu;
        private DataGridViewTextBoxColumn ColPhongBan;
        private DataGridViewTextBoxColumn ColTongSoHoaHong;
    }
}