namespace Design
{
    partial class AccountantManagerPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantManagerPaymentHistory));
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            CoMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColNgayThanhToan = new DataGridViewTextBoxColumn();
            CoSoTien = new DataGridViewTextBoxColumn();
            CoLoaiHinhThanhToan = new DataGridViewTextBoxColumn();
            ColNoiDungThanhToan = new DataGridViewTextBoxColumn();
            buttonSearching = new Button();
            label9 = new Label();
            textBoxSearch = new TextBox();
            pictureBoxIconContractTracking = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 686);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(17, 206);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 367);
            panel2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CoMaHopDong, ColTenHopDong, ColNgayThanhToan, CoSoTien, CoLoaiHinhThanhToan, ColNoiDungThanhToan });
            dataGridView1.Location = new Point(23, 31);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(888, 0);
            dataGridView1.TabIndex = 20;
            // 
            // CoMaHopDong
            // 
            CoMaHopDong.HeaderText = "Mã hợp đồng";
            CoMaHopDong.MinimumWidth = 10;
            CoMaHopDong.Name = "CoMaHopDong";
            CoMaHopDong.Width = 300;
            // 
            // ColTenHopDong
            // 
            ColTenHopDong.HeaderText = "Tên hợp đồng";
            ColTenHopDong.MinimumWidth = 10;
            ColTenHopDong.Name = "ColTenHopDong";
            ColTenHopDong.Width = 300;
            // 
            // ColNgayThanhToan
            // 
            ColNgayThanhToan.HeaderText = "Ngày thanh toán";
            ColNgayThanhToan.MinimumWidth = 10;
            ColNgayThanhToan.Name = "ColNgayThanhToan";
            ColNgayThanhToan.Width = 300;
            // 
            // CoSoTien
            // 
            CoSoTien.HeaderText = "Số tiền";
            CoSoTien.MinimumWidth = 10;
            CoSoTien.Name = "CoSoTien";
            CoSoTien.Width = 300;
            // 
            // CoLoaiHinhThanhToan
            // 
            CoLoaiHinhThanhToan.HeaderText = "Loại hình thanh toán (banking or cash)";
            CoLoaiHinhThanhToan.MinimumWidth = 10;
            CoLoaiHinhThanhToan.Name = "CoLoaiHinhThanhToan";
            CoLoaiHinhThanhToan.Width = 300;
            // 
            // ColNoiDungThanhToan
            // 
            ColNoiDungThanhToan.HeaderText = "Nội dung thanh toán";
            ColNoiDungThanhToan.MinimumWidth = 10;
            ColNoiDungThanhToan.Name = "ColNoiDungThanhToan";
            ColNoiDungThanhToan.Width = 350;
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(775, 148);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(177, 28);
            buttonSearching.TabIndex = 38;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(98, 89);
            label9.Name = "label9";
            label9.Size = new Size(208, 25);
            label9.TabIndex = 37;
            label9.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(17, 148);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(637, 30);
            textBoxSearch.TabIndex = 36;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(17, 51);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 19;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // AccountantManagerPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 689);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AccountantManagerPaymentHistory";
            Text = "Lịch sử thanh toán";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxIconContractTracking;
        private Button buttonSearching;
        private Label label9;
        private TextBox textBoxSearch;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CoMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColNgayThanhToan;
        private DataGridViewTextBoxColumn CoSoTien;
        private DataGridViewTextBoxColumn CoLoaiHinhThanhToan;
        private DataGridViewTextBoxColumn ColNoiDungThanhToan;
    }
}