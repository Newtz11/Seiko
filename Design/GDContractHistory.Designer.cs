namespace Design
{
    partial class GDContractHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDContractHistory));
            panel1 = new Panel();
            labelContractTracking = new Label();
            buttonSearching = new Button();
            pictureBoxIconContractTracking = new PictureBox();
            panel2 = new Panel();
            dataGridViewProjectSchedule = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenHopDong = new DataGridViewTextBoxColumn();
            ngayThanhToan = new DataGridViewTextBoxColumn();
            soTien = new DataGridViewTextBoxColumn();
            loaiThanhToan = new DataGridViewTextBoxColumn();
            noiDungThanhToan = new DataGridViewTextBoxColumn();
            textBoxSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelContractTracking);
            panel1.Controls.Add(buttonSearching);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxSearch);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // labelContractTracking
            // 
            labelContractTracking.AutoSize = true;
            labelContractTracking.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractTracking.Location = new Point(150, 118);
            labelContractTracking.Margin = new Padding(5, 0, 5, 0);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(294, 40);
            labelContractTracking.TabIndex = 23;
            labelContractTracking.Text = "LỊCH SỬ HỢP ĐỒNG";
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1580, 193);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 44);
            buttonSearching.TabIndex = 31;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(40, 58);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 22;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridViewProjectSchedule);
            panel2.Location = new Point(22, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(1846, 1076);
            panel2.TabIndex = 21;
            // 
            // dataGridViewProjectSchedule
            // 
            dataGridViewProjectSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProjectSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectSchedule.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenHopDong, ngayThanhToan, soTien, loaiThanhToan, noiDungThanhToan });
            dataGridViewProjectSchedule.Location = new Point(31, 66);
            dataGridViewProjectSchedule.Margin = new Padding(5);
            dataGridViewProjectSchedule.Name = "dataGridViewProjectSchedule";
            dataGridViewProjectSchedule.RowHeadersWidth = 51;
            dataGridViewProjectSchedule.Size = new Size(1783, 398);
            dataGridViewProjectSchedule.TabIndex = 67;
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
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(22, 193);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1422, 44);
            textBoxSearch.TabIndex = 20;
            // 
            // GDContractHistory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GDContractHistory";
            Text = "Lịch sử hợp đồng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxIconContractTracking;
        private Label labelContractTracking;
        private TextBox textBoxSearch;
        private Panel panel2;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
        private Button buttonSearching;
    }
}