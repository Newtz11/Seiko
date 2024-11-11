namespace Design
{
    partial class SAPerformanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAPerformanceReport));
            pictureBoxIconPerformanceReport = new PictureBox();
            labelPerformanceReport = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            buttonUpdate = new Button();
            dataGridViewProjectSchedule = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenHopDong = new DataGridViewTextBoxColumn();
            ngayThanhToan = new DataGridViewTextBoxColumn();
            soTien = new DataGridViewTextBoxColumn();
            loaiThanhToan = new DataGridViewTextBoxColumn();
            noiDungThanhToan = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            buttonSearching = new Button();
            dateTimePickerDateTo = new DateTimePicker();
            dateTimePickerDateFrom = new DateTimePicker();
            labelDateTo = new Label();
            labelDateFrom = new Label();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconPerformanceReport).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).BeginInit();
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
            labelPerformanceReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPerformanceReport.Location = new Point(182, 81);
            labelPerformanceReport.Name = "labelPerformanceReport";
            labelPerformanceReport.Size = new Size(199, 25);
            labelPerformanceReport.TabIndex = 19;
            labelPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(dataGridViewProjectSchedule);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonSearching);
            panel1.Controls.Add(dateTimePickerDateTo);
            panel1.Controls.Add(dateTimePickerDateFrom);
            panel1.Controls.Add(labelDateTo);
            panel1.Controls.Add(labelDateFrom);
            panel1.Controls.Add(textBoxSearch);
            panel1.Location = new Point(16, 165);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 778);
            panel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 485);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(537, 194);
            dataGridView1.TabIndex = 53;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.DodgerBlue;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(988, 644);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(138, 35);
            buttonUpdate.TabIndex = 52;
            buttonUpdate.Text = "CẬP NHẬT";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProjectSchedule
            // 
            dataGridViewProjectSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProjectSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectSchedule.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenHopDong, ngayThanhToan, soTien, loaiThanhToan, noiDungThanhToan });
            dataGridViewProjectSchedule.Location = new Point(40, 169);
            dataGridViewProjectSchedule.Name = "dataGridViewProjectSchedule";
            dataGridViewProjectSchedule.RowHeadersWidth = 51;
            dataGridViewProjectSchedule.Size = new Size(1086, 209);
            dataGridViewProjectSchedule.TabIndex = 51;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(894, 146);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 50;
            label2.Text = "Chọn thời gian(Tháng, Qúy, Năm)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 146);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 49;
            label1.Text = "Tính theo(Tháng, Qúy, Năm)";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(920, 102);
            button1.Name = "button1";
            button1.Size = new Size(177, 35);
            button1.TabIndex = 48;
            button1.Text = "Lập thống kê";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(920, 33);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(177, 36);
            buttonSearching.TabIndex = 47;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDateTo
            // 
            dateTimePickerDateTo.Format = DateTimePickerFormat.Short;
            dateTimePickerDateTo.Location = new Point(441, 102);
            dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            dateTimePickerDateTo.Size = new Size(191, 27);
            dateTimePickerDateTo.TabIndex = 46;
            // 
            // dateTimePickerDateFrom
            // 
            dateTimePickerDateFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerDateFrom.Location = new Point(138, 102);
            dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            dateTimePickerDateFrom.Size = new Size(191, 27);
            dateTimePickerDateFrom.TabIndex = 45;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateTo.Location = new Point(371, 106);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(70, 20);
            labelDateTo.TabIndex = 44;
            labelDateTo.Text = "Từ ngày:";
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateFrom.Location = new Point(68, 106);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(70, 20);
            labelDateFrom.TabIndex = 43;
            labelDateFrom.Text = "Từ ngày:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(67, 33);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(793, 34);
            textBoxSearch.TabIndex = 42;
            textBoxSearch.Text = "Tìm kiếm";
            // 
            // SAPerformanceReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 951);
            Controls.Add(panel1);
            Controls.Add(labelPerformanceReport);
            Controls.Add(pictureBoxIconPerformanceReport);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SAPerformanceReport";
            Text = "Báo cáo hiệu suất";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconPerformanceReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconPerformanceReport;
        private Label labelPerformanceReport;
        private GroupBox groupBoxProjectSchedule;
        private Button buttonSearch;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
        private Label labelDateTo;
        private TextBox textBoxDateTo;
        private Label labelDateFrom;
        private TextBox textBoxDateFrom;
        private TextBox textBoxSearch;
        private DateTimePicker dateTimePickerDateTo;
        private DateTimePicker dateTimePickerDateFrom;
        private Button buttonSearching;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button buttonUpdate;
    }
}