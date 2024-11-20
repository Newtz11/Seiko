﻿namespace Design
{
    partial class PerformanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pictureBoxIconPerformanceReport = new PictureBox();
            labelPerformanceReport = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxPerformance = new GroupBox();
            buttonCapNhat = new Button();
            chartPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBoxChonGiaTri = new ComboBox();
            labelChonGiaTri = new Label();
            radioButtonNam = new RadioButton();
            radioButtonQuy = new RadioButton();
            radioButtonThang = new RadioButton();
            label1 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            labelEnd = new Label();
            labelStart = new Label();
            buttonSearch = new Button();
            dataGridViewPerformance = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            DaHoanThanh = new DataGridViewTextBoxColumn();
            DangThucHien = new DataGridViewTextBoxColumn();
            ChuaHoanThanh = new DataGridViewTextBoxColumn();
            buttonLapThongKe = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconPerformanceReport).BeginInit();
            groupBoxPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPerformance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconPerformanceReport
            // 
            pictureBoxIconPerformanceReport.Image = (Image)resources.GetObject("pictureBoxIconPerformanceReport.Image");
            pictureBoxIconPerformanceReport.Location = new Point(16, 23);
            pictureBoxIconPerformanceReport.Name = "pictureBoxIconPerformanceReport";
            pictureBoxIconPerformanceReport.Size = new Size(100, 100);
            pictureBoxIconPerformanceReport.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconPerformanceReport.TabIndex = 18;
            pictureBoxIconPerformanceReport.TabStop = false;
            // 
            // labelPerformanceReport
            // 
            labelPerformanceReport.AutoSize = true;
            labelPerformanceReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelPerformanceReport.Location = new Point(122, 63);
            labelPerformanceReport.Name = "labelPerformanceReport";
            labelPerformanceReport.Size = new Size(199, 25);
            labelPerformanceReport.TabIndex = 19;
            labelPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            // 
            // groupBoxPerformance
            // 
            groupBoxPerformance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPerformance.BackColor = Color.LightGray;
            groupBoxPerformance.Controls.Add(buttonCapNhat);
            groupBoxPerformance.Controls.Add(chartPerformance);
            groupBoxPerformance.Controls.Add(comboBoxChonGiaTri);
            groupBoxPerformance.Controls.Add(labelChonGiaTri);
            groupBoxPerformance.Controls.Add(radioButtonNam);
            groupBoxPerformance.Controls.Add(radioButtonQuy);
            groupBoxPerformance.Controls.Add(radioButtonThang);
            groupBoxPerformance.Controls.Add(label1);
            groupBoxPerformance.Controls.Add(dateTimePickerEnd);
            groupBoxPerformance.Controls.Add(dateTimePickerStart);
            groupBoxPerformance.Controls.Add(labelEnd);
            groupBoxPerformance.Controls.Add(labelStart);
            groupBoxPerformance.Controls.Add(buttonSearch);
            groupBoxPerformance.Controls.Add(dataGridViewPerformance);
            groupBoxPerformance.Controls.Add(buttonLapThongKe);
            groupBoxPerformance.Controls.Add(textBoxSearch);
            groupBoxPerformance.Location = new Point(63, 143);
            groupBoxPerformance.Name = "groupBoxPerformance";
            groupBoxPerformance.Size = new Size(1280, 807);
            groupBoxPerformance.TabIndex = 51;
            groupBoxPerformance.TabStop = false;
            groupBoxPerformance.Enter += groupBoxListUser_Enter;
            // 
            // buttonCapNhat
            // 
            buttonCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCapNhat.BackColor = Color.DodgerBlue;
            buttonCapNhat.FlatStyle = FlatStyle.Popup;
            buttonCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCapNhat.ForeColor = Color.White;
            buttonCapNhat.Location = new Point(1087, 765);
            buttonCapNhat.Name = "buttonCapNhat";
            buttonCapNhat.Size = new Size(136, 33);
            buttonCapNhat.TabIndex = 9;
            buttonCapNhat.Text = "Cập nhật";
            buttonCapNhat.UseVisualStyleBackColor = false;
            // 
            // chartPerformance
            // 
            chartPerformance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartPerformance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPerformance.Legends.Add(legend2);
            chartPerformance.Location = new Point(49, 387);
            chartPerformance.Name = "chartPerformance";
            chartPerformance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPerformance.Series.Add(series2);
            chartPerformance.Size = new Size(1174, 375);
            chartPerformance.TabIndex = 84;
            chartPerformance.Text = "chart1";
            chartPerformance.Visible = false;
            // 
            // comboBoxChonGiaTri
            // 
            comboBoxChonGiaTri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxChonGiaTri.FormattingEnabled = true;
            comboBoxChonGiaTri.Location = new Point(790, 115);
            comboBoxChonGiaTri.Name = "comboBoxChonGiaTri";
            comboBoxChonGiaTri.Size = new Size(262, 28);
            comboBoxChonGiaTri.TabIndex = 7;
            // 
            // labelChonGiaTri
            // 
            labelChonGiaTri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelChonGiaTri.AutoSize = true;
            labelChonGiaTri.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelChonGiaTri.Location = new Point(676, 118);
            labelChonGiaTri.Name = "labelChonGiaTri";
            labelChonGiaTri.Size = new Size(108, 25);
            labelChonGiaTri.TabIndex = 82;
            labelChonGiaTri.Text = "Chọn giá trị:";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(428, 120);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 6;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Năm";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuy
            // 
            radioButtonQuy.AutoSize = true;
            radioButtonQuy.Location = new Point(366, 121);
            radioButtonQuy.Name = "radioButtonQuy";
            radioButtonQuy.Size = new Size(56, 24);
            radioButtonQuy.TabIndex = 5;
            radioButtonQuy.TabStop = true;
            radioButtonQuy.Text = "Quý";
            radioButtonQuy.UseVisualStyleBackColor = true;
            // 
            // radioButtonThang
            // 
            radioButtonThang.AutoSize = true;
            radioButtonThang.Location = new Point(289, 121);
            radioButtonThang.Name = "radioButtonThang";
            radioButtonThang.Size = new Size(71, 24);
            radioButtonThang.TabIndex = 4;
            radioButtonThang.TabStop = true;
            radioButtonThang.Text = "Tháng";
            radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 119);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 78;
            label1.Text = "Tính theo(Tháng/Quý/Năm):";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerEnd.Location = new Point(790, 68);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(262, 27);
            dateTimePickerEnd.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(130, 68);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(262, 27);
            dateTimePickerStart.TabIndex = 2;
            // 
            // labelEnd
            // 
            labelEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEnd.AutoSize = true;
            labelEnd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelEnd.Location = new Point(700, 70);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(84, 25);
            labelEnd.TabIndex = 75;
            labelEnd.Text = "Tới ngày:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStart.Location = new Point(44, 69);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(80, 25);
            labelStart.TabIndex = 74;
            labelStart.Text = "Từ ngày:";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1087, 23);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(136, 33);
            buttonSearch.TabIndex = 30;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewPerformance
            // 
            dataGridViewPerformance.AllowUserToAddRows = false;
            dataGridViewPerformance.AllowUserToDeleteRows = false;
            dataGridViewPerformance.AllowUserToOrderColumns = true;
            dataGridViewPerformance.AllowUserToResizeColumns = false;
            dataGridViewPerformance.AllowUserToResizeRows = false;
            dataGridViewPerformance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPerformance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPerformance.BackgroundColor = Color.White;
            dataGridViewPerformance.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewPerformance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPerformance.ColumnHeadersHeight = 50;
            dataGridViewPerformance.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, DaHoanThanh, DangThucHien, ChuaHoanThanh });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewPerformance.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewPerformance.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewPerformance.Location = new Point(49, 161);
            dataGridViewPerformance.Name = "dataGridViewPerformance";
            dataGridViewPerformance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewPerformance.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewPerformance.RowHeadersVisible = false;
            dataGridViewPerformance.RowHeadersWidth = 50;
            dataGridViewPerformance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewPerformance.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewPerformance.RowTemplate.Height = 35;
            dataGridViewPerformance.ScrollBars = ScrollBars.Vertical;
            dataGridViewPerformance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPerformance.Size = new Size(1174, 220);
            dataGridViewPerformance.TabIndex = 8;
            // 
            // MaNhanVien
            // 
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // DaHoanThanh
            // 
            DaHoanThanh.HeaderText = "Đã hoàn thành (%)";
            DaHoanThanh.MinimumWidth = 6;
            DaHoanThanh.Name = "DaHoanThanh";
            // 
            // DangThucHien
            // 
            DangThucHien.HeaderText = "Đang thực hiện (%)";
            DangThucHien.MinimumWidth = 6;
            DangThucHien.Name = "DangThucHien";
            // 
            // ChuaHoanThanh
            // 
            ChuaHoanThanh.HeaderText = "Chưa hoàn thành (%)";
            ChuaHoanThanh.MinimumWidth = 6;
            ChuaHoanThanh.Name = "ChuaHoanThanh";
            // 
            // buttonLapThongKe
            // 
            buttonLapThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLapThongKe.BackColor = Color.DodgerBlue;
            buttonLapThongKe.FlatStyle = FlatStyle.Popup;
            buttonLapThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLapThongKe.ForeColor = Color.White;
            buttonLapThongKe.Location = new Point(1087, 90);
            buttonLapThongKe.Name = "buttonLapThongKe";
            buttonLapThongKe.Size = new Size(136, 33);
            buttonLapThongKe.TabIndex = 19;
            buttonLapThongKe.Text = "Lập thống kê";
            buttonLapThongKe.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(49, 26);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm thông tin";
            textBoxSearch.Size = new Size(1000, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // PerformanceReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 953);
            Controls.Add(groupBoxPerformance);
            Controls.Add(labelPerformanceReport);
            Controls.Add(pictureBoxIconPerformanceReport);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PerformanceReport";
            Text = "Báo cáo hiệu suất";
            Load += PerformanceReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconPerformanceReport).EndInit();
            groupBoxPerformance.ResumeLayout(false);
            groupBoxPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPerformance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconPerformanceReport;
        private Label labelPerformanceReport;
        private GroupBox groupBoxProjectSchedule;
        private Button buttonSearch;
        private TextBox textBoxDateTo;
        private TextBox textBoxDateFrom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private GroupBox groupBoxPerformance;
        private DataGridView dataGridViewPerformance;
        private Button buttonLapThongKe;
        private TextBox textBoxSearch;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label labelEnd;
        private Label labelStart;
        private ComboBox comboBoxChonGiaTri;
        private Label labelChonGiaTri;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonQuy;
        private RadioButton radioButtonThang;
        private Label label1;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn DaHoanThanh;
        private DataGridViewTextBoxColumn DangThucHien;
        private DataGridViewTextBoxColumn ChuaHoanThanh;
        private Button buttonCapNhat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformance;
    }
}