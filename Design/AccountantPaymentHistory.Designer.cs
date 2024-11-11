namespace Design
{
    partial class AccountantPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantPaymentHistory));
            pictureBoxIconContractTracking = new PictureBox();
            labelContractTracking = new Label();
            textBoxSearch = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            dataGridView7 = new DataGridView();
            CoMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColNgayThanhToan = new DataGridViewTextBoxColumn();
            CoSoTien = new DataGridViewTextBoxColumn();
            CoLoaiHinhThanhToan = new DataGridViewTextBoxColumn();
            ColNoiDungThanhToan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(37, 60);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 16;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelContractTracking
            // 
            labelContractTracking.AutoSize = true;
            labelContractTracking.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractTracking.Location = new Point(164, 120);
            labelContractTracking.Margin = new Padding(5, 0, 5, 0);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(329, 40);
            labelContractTracking.TabIndex = 17;
            labelContractTracking.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(37, 202);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(1475, 44);
            textBoxSearch.TabIndex = 18;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1697, 188);
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
            panel1.Controls.Add(dataGridView7);
            panel1.Location = new Point(37, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(1918, 1076);
            panel1.TabIndex = 22;
            // 
            // dataGridView7
            // 
            dataGridView7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView7.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Columns.AddRange(new DataGridViewColumn[] { CoMaHopDong, ColTenHopDong, ColNgayThanhToan, CoSoTien, CoLoaiHinhThanhToan, ColNoiDungThanhToan });
            dataGridView7.Location = new Point(39, 64);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 82;
            dataGridView7.Size = new Size(1839, 300);
            dataGridView7.TabIndex = 27;
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
            // AccountantPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBoxSearch);
            Controls.Add(labelContractTracking);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountantPaymentHistory";
            Text = "Lịch sử thanh toán";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractTracking;
        private TextBox textBoxSearch;
        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn CoMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColNgayThanhToan;
        private DataGridViewTextBoxColumn CoSoTien;
        private DataGridViewTextBoxColumn CoLoaiHinhThanhToan;
        private DataGridViewTextBoxColumn ColNoiDungThanhToan;
    }
}