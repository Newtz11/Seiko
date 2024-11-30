namespace Design
{
    partial class FinancialReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label9 = new Label();
            pictureBoxIconContractTracking = new PictureBox();
            groupBoxListUser = new GroupBox();
            buttonCapNhat = new Button();
            labelChonGiaTri = new Label();
            radioButtonQuy = new RadioButton();
            radioButtonNam = new RadioButton();
            radioButtonThang = new RadioButton();
            comboBox1 = new ComboBox();
            chartFinancialReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            buttonLapThongKe = new Button();
            dataGridViewFinancial = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            TenHD = new DataGridViewTextBoxColumn();
            NgayThanhToan = new DataGridViewTextBoxColumn();
            DoanhThu = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            labelProjectProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFinancialReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancial).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(118, 87);
            label9.Name = "label9";
            label9.Size = new Size(192, 25);
            label9.TabIndex = 55;
            label9.Text = "BÁO CÁO TÀI CHÍNH";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 12);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 54;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // groupBoxListUser
            // 
            groupBoxListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxListUser.BackColor = Color.LightGray;
            groupBoxListUser.Controls.Add(buttonCapNhat);
            groupBoxListUser.Controls.Add(labelChonGiaTri);
            groupBoxListUser.Controls.Add(radioButtonQuy);
            groupBoxListUser.Controls.Add(radioButtonNam);
            groupBoxListUser.Controls.Add(radioButtonThang);
            groupBoxListUser.Controls.Add(comboBox1);
            groupBoxListUser.Controls.Add(chartFinancialReport);
            groupBoxListUser.Controls.Add(label1);
            groupBoxListUser.Controls.Add(buttonLapThongKe);
            groupBoxListUser.Controls.Add(dataGridViewFinancial);
            groupBoxListUser.Controls.Add(buttonSearch);
            groupBoxListUser.Controls.Add(textBoxSearch);
            groupBoxListUser.Controls.Add(labelProjectProgress);
            groupBoxListUser.Location = new Point(12, 134);
            groupBoxListUser.Name = "groupBoxListUser";
            groupBoxListUser.Size = new Size(1242, 807);
            groupBoxListUser.TabIndex = 56;
            groupBoxListUser.TabStop = false;
            groupBoxListUser.Enter += groupBoxListUser_Enter;
            // 
            // buttonCapNhat
            // 
            buttonCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCapNhat.BackColor = Color.DodgerBlue;
            buttonCapNhat.FlatStyle = FlatStyle.Popup;
            buttonCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCapNhat.ForeColor = Color.White;
            buttonCapNhat.Location = new Point(1055, 759);
            buttonCapNhat.Name = "buttonCapNhat";
            buttonCapNhat.Size = new Size(163, 33);
            buttonCapNhat.TabIndex = 62;
            buttonCapNhat.Text = "Cập nhật";
            buttonCapNhat.UseVisualStyleBackColor = false;
            // 
            // labelChonGiaTri
            // 
            labelChonGiaTri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelChonGiaTri.AutoSize = true;
            labelChonGiaTri.Font = new Font("Segoe UI", 10.8F);
            labelChonGiaTri.Location = new Point(714, 81);
            labelChonGiaTri.Name = "labelChonGiaTri";
            labelChonGiaTri.Size = new Size(108, 25);
            labelChonGiaTri.TabIndex = 61;
            labelChonGiaTri.Text = "Chọn giá trị:";
            // 
            // radioButtonQuy
            // 
            radioButtonQuy.AutoSize = true;
            radioButtonQuy.Location = new Point(362, 86);
            radioButtonQuy.Name = "radioButtonQuy";
            radioButtonQuy.Size = new Size(56, 24);
            radioButtonQuy.TabIndex = 5;
            radioButtonQuy.TabStop = true;
            radioButtonQuy.Text = "Quý";
            radioButtonQuy.UseVisualStyleBackColor = true;
            radioButtonQuy.CheckedChanged += radioButtonQuy_CheckedChanged;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(435, 86);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 6;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Năm";
            radioButtonNam.UseVisualStyleBackColor = true;
            radioButtonNam.CheckedChanged += radioButtonNam_CheckedChanged;
            // 
            // radioButtonThang
            // 
            radioButtonThang.AutoSize = true;
            radioButtonThang.Location = new Point(283, 85);
            radioButtonThang.Name = "radioButtonThang";
            radioButtonThang.Size = new Size(71, 24);
            radioButtonThang.TabIndex = 4;
            radioButtonThang.TabStop = true;
            radioButtonThang.Text = "Tháng";
            radioButtonThang.UseVisualStyleBackColor = true;
            radioButtonThang.CheckedChanged += radioButtonThang_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(829, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 7;
            // 
            // chartFinancialReport
            // 
            chartFinancialReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartFinancialReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFinancialReport.Legends.Add(legend2);
            chartFinancialReport.Location = new Point(21, 401);
            chartFinancialReport.Name = "chartFinancialReport";
            chartFinancialReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            chartFinancialReport.Series.Add(series2);
            chartFinancialReport.Size = new Size(1197, 352);
            chartFinancialReport.TabIndex = 37;
            chartFinancialReport.Text = "chart1";
            chartFinancialReport.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(22, 84);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 35;
            label1.Text = "Tính theo: (Tháng, Quý, Năm)";
            // 
            // buttonLapThongKe
            // 
            buttonLapThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLapThongKe.BackColor = Color.DodgerBlue;
            buttonLapThongKe.FlatStyle = FlatStyle.Popup;
            buttonLapThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLapThongKe.ForeColor = Color.White;
            buttonLapThongKe.Location = new Point(1055, 81);
            buttonLapThongKe.Name = "buttonLapThongKe";
            buttonLapThongKe.Size = new Size(163, 33);
            buttonLapThongKe.TabIndex = 30;
            buttonLapThongKe.Text = "Lập thống kê";
            buttonLapThongKe.UseVisualStyleBackColor = false;
            buttonLapThongKe.Click += buttonLapThongKe_Click;
            // 
            // dataGridViewFinancial
            // 
            dataGridViewFinancial.AllowUserToAddRows = false;
            dataGridViewFinancial.AllowUserToDeleteRows = false;
            dataGridViewFinancial.AllowUserToOrderColumns = true;
            dataGridViewFinancial.AllowUserToResizeRows = false;
            dataGridViewFinancial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFinancial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFinancial.BackgroundColor = Color.White;
            dataGridViewFinancial.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewFinancial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewFinancial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewFinancial.ColumnHeadersHeight = 80;
            dataGridViewFinancial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewFinancial.Columns.AddRange(new DataGridViewColumn[] { MaHD, TenHD, NgayThanhToan, DoanhThu });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewFinancial.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewFinancial.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewFinancial.Location = new Point(21, 145);
            dataGridViewFinancial.Name = "dataGridViewFinancial";
            dataGridViewFinancial.ReadOnly = true;
            dataGridViewFinancial.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewFinancial.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewFinancial.RowHeadersVisible = false;
            dataGridViewFinancial.RowHeadersWidth = 51;
            dataGridViewFinancial.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewFinancial.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewFinancial.RowTemplate.Height = 35;
            dataGridViewFinancial.ScrollBars = ScrollBars.Vertical;
            dataGridViewFinancial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFinancial.Size = new Size(1197, 250);
            dataGridViewFinancial.TabIndex = 8;
            // 
            // MaHD
            // 
            MaHD.HeaderText = "Mã hợp đồng";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            // 
            // TenHD
            // 
            TenHD.HeaderText = "Tên hợp đồng";
            TenHD.MinimumWidth = 6;
            TenHD.Name = "TenHD";
            TenHD.ReadOnly = true;
            // 
            // NgayThanhToan
            // 
            NgayThanhToan.HeaderText = "Ngày thanh toán";
            NgayThanhToan.MinimumWidth = 6;
            NgayThanhToan.Name = "NgayThanhToan";
            NgayThanhToan.ReadOnly = true;
            // 
            // DoanhThu
            // 
            DoanhThu.HeaderText = "Doanh thu";
            DoanhThu.MinimumWidth = 6;
            DoanhThu.Name = "DoanhThu";
            DoanhThu.ReadOnly = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1055, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(163, 30);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(21, 23);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm người dùng trong danh sách ";
            textBoxSearch.Size = new Size(965, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // labelProjectProgress
            // 
            labelProjectProgress.AutoSize = true;
            labelProjectProgress.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelProjectProgress.Location = new Point(41, 23);
            labelProjectProgress.Name = "labelProjectProgress";
            labelProjectProgress.Size = new Size(0, 38);
            labelProjectProgress.TabIndex = 13;
            // 
            // FinancialReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 953);
            Controls.Add(groupBoxListUser);
            Controls.Add(label9);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FinancialReport";
            Text = "Báo cáo tài chính";
            Load += FinancialReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxListUser.ResumeLayout(false);
            groupBoxListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFinancialReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxFeature;
        private Button buttonPerformanceReport;
        private Label labelSuperAdmin;
        private Button buttonUserList;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Button buttonFinacialReports;
        private Button buttonContractHistory;
        private Button buttonContractTracking;
        private Button buttonProjectSchedule;
        private Button buttonHome;
        private Button buttonInformation;
        private PictureBox pictureBoxSuperAdmin;
        private Label label9;
        private PictureBox pictureBoxIconContractTracking;
        private GroupBox groupBoxListUser;
        private DataGridView dataGridViewFinancial;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelProjectProgress;
        private Button buttonLapThongKe;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn TenNguoiDung;
        private DataGridViewTextBoxColumn MaNguoiDung;
        private DataGridViewTextBoxColumn PhongBan;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFinancialReport;
        private ComboBox comboBox1;
        private Label labelChonGiaTri;
        private RadioButton radioButtonQuy;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonThang;
        private Button buttonCapNhat;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn TenHD;
        private DataGridViewTextBoxColumn NgayThanhToan;
        private DataGridViewTextBoxColumn DoanhThu;
    }
}