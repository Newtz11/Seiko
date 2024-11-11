﻿namespace Design
{
    partial class KTTPaymentSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KTTPaymentSchedule));
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ColMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColTenNhanVien = new DataGridViewTextBoxColumn();
            ColGiaTriHopDong = new DataGridViewTextBoxColumn();
            CoDaThanhToan = new DataGridViewTextBoxColumn();
            ColGiaTriConLai = new DataGridViewTextBoxColumn();
            buttonSearching = new Button();
            textBoxSearch = new TextBox();
            label9 = new Label();
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
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(10, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(1846, 1076);
            panel2.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColMaHopDong, ColTenHopDong, ColTenNhanVien, ColGiaTriHopDong, CoDaThanhToan, ColGiaTriConLai });
            dataGridView1.Location = new Point(29, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1784, 200);
            dataGridView1.TabIndex = 0;
            // 
            // ColMaHopDong
            // 
            ColMaHopDong.HeaderText = "Mã hợp đồng";
            ColMaHopDong.MinimumWidth = 10;
            ColMaHopDong.Name = "ColMaHopDong";
            ColMaHopDong.Width = 300;
            // 
            // ColTenHopDong
            // 
            ColTenHopDong.HeaderText = "Tên hợp đồng";
            ColTenHopDong.MinimumWidth = 10;
            ColTenHopDong.Name = "ColTenHopDong";
            ColTenHopDong.Width = 300;
            // 
            // ColTenNhanVien
            // 
            ColTenNhanVien.HeaderText = "Tên nhân viên";
            ColTenNhanVien.MinimumWidth = 10;
            ColTenNhanVien.Name = "ColTenNhanVien";
            ColTenNhanVien.Width = 300;
            // 
            // ColGiaTriHopDong
            // 
            ColGiaTriHopDong.HeaderText = "Giá trị hợp đồng";
            ColGiaTriHopDong.MinimumWidth = 10;
            ColGiaTriHopDong.Name = "ColGiaTriHopDong";
            ColGiaTriHopDong.Width = 300;
            // 
            // CoDaThanhToan
            // 
            CoDaThanhToan.HeaderText = "Đã thanh toán";
            CoDaThanhToan.MinimumWidth = 10;
            CoDaThanhToan.Name = "CoDaThanhToan";
            CoDaThanhToan.Width = 200;
            // 
            // ColGiaTriConLai
            // 
            ColGiaTriConLai.HeaderText = "Giá trị còn lại";
            ColGiaTriConLai.MinimumWidth = 10;
            ColGiaTriConLai.Name = "ColGiaTriConLai";
            ColGiaTriConLai.Width = 300;
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1568, 209);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 44);
            buttonSearching.TabIndex = 36;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(12, 209);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1446, 44);
            textBoxSearch.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(156, 120);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(333, 40);
            label9.TabIndex = 34;
            label9.Text = "TIẾN ĐỘ THANH TOÁN";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 60);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 18;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // KTTPaymentSchedule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KTTPaymentSchedule";
            Text = "Tiến độ thanh toán";
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
        private Label label9;
        private TextBox textBoxSearch;
        private Button buttonSearching;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColTenNhanVien;
        private DataGridViewTextBoxColumn ColGiaTriHopDong;
        private DataGridViewTextBoxColumn CoDaThanhToan;
        private DataGridViewTextBoxColumn ColGiaTriConLai;
    }
}