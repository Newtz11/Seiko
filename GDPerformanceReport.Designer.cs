namespace Design
{
    partial class GDPerformanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDPerformanceReport));
            panel1 = new Panel();
            groupBoxFeature = new GroupBox();
            buttonPerformanceReport = new Button();
            labelSuperAdmin = new Label();
            buttonUserList = new Button();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            buttonFinacialReports = new Button();
            buttonContractHistory = new Button();
            buttonContractTracking = new Button();
            buttonProjectSchedule = new Button();
            buttonHome = new Button();
            buttonInformation = new Button();
            pictureBoxSuperAdmin = new PictureBox();
            label9 = new Label();
            pictureBoxIconContractTracking = new PictureBox();
            panel2 = new Panel();
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
            panel1.SuspendLayout();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuperAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Controls.Add(groupBoxFeature);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(labelSuperAdmin);
            groupBoxFeature.Controls.Add(buttonUserList);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBox1);
            groupBoxFeature.Controls.Add(buttonFinacialReports);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonProjectSchedule);
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonInformation);
            groupBoxFeature.Controls.Add(pictureBoxSuperAdmin);
            groupBoxFeature.Location = new Point(0, 0);
            groupBoxFeature.Margin = new Padding(5);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Padding = new Padding(5);
            groupBoxFeature.Size = new Size(351, 1578);
            groupBoxFeature.TabIndex = 20;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonPerformanceReport
            // 
            buttonPerformanceReport.BackColor = Color.White;
            buttonPerformanceReport.FlatStyle = FlatStyle.Popup;
            buttonPerformanceReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerformanceReport.Location = new Point(10, 886);
            buttonPerformanceReport.Margin = new Padding(5);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(325, 77);
            buttonPerformanceReport.TabIndex = 14;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            // 
            // labelSuperAdmin
            // 
            labelSuperAdmin.AutoSize = true;
            labelSuperAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuperAdmin.Location = new Point(97, 30);
            labelSuperAdmin.Margin = new Padding(5, 0, 5, 0);
            labelSuperAdmin.Name = "labelSuperAdmin";
            labelSuperAdmin.Size = new Size(166, 45);
            labelSuperAdmin.TabIndex = 13;
            labelSuperAdmin.Text = "Giám Đốc";
            // 
            // buttonUserList
            // 
            buttonUserList.BackColor = Color.Silver;
            buttonUserList.FlatStyle = FlatStyle.Popup;
            buttonUserList.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUserList.ForeColor = SystemColors.ControlText;
            buttonUserList.Location = new Point(10, 341);
            buttonUserList.Margin = new Padding(5);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(325, 77);
            buttonUserList.TabIndex = 12;
            buttonUserList.Text = "DANH SÁCH NGƯỜI DÙNG";
            buttonUserList.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(10, 1470);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(325, 77);
            buttonLogout.TabIndex = 11;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 1345);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonFinacialReports
            // 
            buttonFinacialReports.BackColor = Color.Silver;
            buttonFinacialReports.FlatStyle = FlatStyle.Popup;
            buttonFinacialReports.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinacialReports.Location = new Point(10, 1024);
            buttonFinacialReports.Margin = new Padding(5);
            buttonFinacialReports.Name = "buttonFinacialReports";
            buttonFinacialReports.Size = new Size(325, 77);
            buttonFinacialReports.TabIndex = 8;
            buttonFinacialReports.Text = "BÁO CÁO TÀI CHÍNH";
            buttonFinacialReports.UseVisualStyleBackColor = false;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(10, 1166);
            buttonContractHistory.Margin = new Padding(5);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(325, 77);
            buttonContractHistory.TabIndex = 10;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(10, 610);
            buttonContractTracking.Margin = new Padding(5);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(325, 77);
            buttonContractTracking.TabIndex = 5;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            // 
            // buttonProjectSchedule
            // 
            buttonProjectSchedule.BackColor = Color.Silver;
            buttonProjectSchedule.FlatStyle = FlatStyle.Popup;
            buttonProjectSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectSchedule.Location = new Point(10, 744);
            buttonProjectSchedule.Margin = new Padding(5);
            buttonProjectSchedule.Name = "buttonProjectSchedule";
            buttonProjectSchedule.Size = new Size(325, 77);
            buttonProjectSchedule.TabIndex = 6;
            buttonProjectSchedule.Text = "TIẾN ĐỘ DỰ ÁN ";
            buttonProjectSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(10, 200);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(325, 77);
            buttonHome.TabIndex = 3;
            buttonHome.Text = " TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonInformation
            // 
            buttonInformation.BackColor = Color.Silver;
            buttonInformation.FlatStyle = FlatStyle.Popup;
            buttonInformation.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInformation.ForeColor = SystemColors.ControlText;
            buttonInformation.Location = new Point(10, 483);
            buttonInformation.Margin = new Padding(5);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Size = new Size(325, 77);
            buttonInformation.TabIndex = 4;
            buttonInformation.Text = "THÔNG TIN CÁ NHÂN";
            buttonInformation.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSuperAdmin
            // 
            pictureBoxSuperAdmin.Image = (Image)resources.GetObject("pictureBoxSuperAdmin.Image");
            pictureBoxSuperAdmin.Location = new Point(0, 0);
            pictureBoxSuperAdmin.Margin = new Padding(5);
            pictureBoxSuperAdmin.Name = "pictureBoxSuperAdmin";
            pictureBoxSuperAdmin.Size = new Size(351, 206);
            pictureBoxSuperAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSuperAdmin.TabIndex = 2;
            pictureBoxSuperAdmin.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(492, 120);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(303, 40);
            label9.TabIndex = 40;
            label9.Text = "BÁO CÁO HIỆU SUẤT";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(365, 77);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 39;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(dataGridViewProjectSchedule);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonSearching);
            panel2.Controls.Add(dateTimePickerDateTo);
            panel2.Controls.Add(dateTimePickerDateFrom);
            panel2.Controls.Add(labelDateTo);
            panel2.Controls.Add(labelDateFrom);
            panel2.Controls.Add(textBoxSearch);
            panel2.Location = new Point(375, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(1954, 1308);
            panel2.TabIndex = 52;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(498, 734);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(873, 547);
            dataGridView1.TabIndex = 44;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DodgerBlue;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(1629, 1225);
            buttonUpdate.Margin = new Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(224, 56);
            buttonUpdate.TabIndex = 43;
            buttonUpdate.Text = "CẬP NHẬT";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProjectSchedule
            // 
            dataGridViewProjectSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProjectSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectSchedule.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenHopDong, ngayThanhToan, soTien, loaiThanhToan, noiDungThanhToan });
            dataGridViewProjectSchedule.Location = new Point(46, 298);
            dataGridViewProjectSchedule.Margin = new Padding(5);
            dataGridViewProjectSchedule.Name = "dataGridViewProjectSchedule";
            dataGridViewProjectSchedule.RowHeadersWidth = 51;
            dataGridViewProjectSchedule.Size = new Size(1807, 398);
            dataGridViewProjectSchedule.TabIndex = 42;
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
            label2.Location = new Point(1480, 237);
            label2.Name = "label2";
            label2.Size = new Size(373, 32);
            label2.TabIndex = 41;
            label2.Text = "Chọn thời gian(Tháng, Qúy, Năm)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 237);
            label1.Name = "label1";
            label1.Size = new Size(317, 32);
            label1.TabIndex = 40;
            label1.Text = "Tính theo(Tháng, Qúy, Năm)";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1565, 166);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(288, 56);
            button1.TabIndex = 39;
            button1.Text = "Lập thống kê";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSearching
            // 
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1565, 56);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 58);
            buttonSearching.TabIndex = 38;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDateTo
            // 
            dateTimePickerDateTo.Format = DateTimePickerFormat.Short;
            dateTimePickerDateTo.Location = new Point(744, 166);
            dateTimePickerDateTo.Margin = new Padding(5);
            dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            dateTimePickerDateTo.Size = new Size(308, 39);
            dateTimePickerDateTo.TabIndex = 37;
            // 
            // dateTimePickerDateFrom
            // 
            dateTimePickerDateFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerDateFrom.Location = new Point(252, 166);
            dateTimePickerDateFrom.Margin = new Padding(5);
            dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            dateTimePickerDateFrom.Size = new Size(308, 39);
            dateTimePickerDateFrom.TabIndex = 36;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateTo.Location = new Point(631, 173);
            labelDateTo.Margin = new Padding(5, 0, 5, 0);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(114, 32);
            labelDateTo.TabIndex = 35;
            labelDateTo.Text = "Từ ngày:";
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateFrom.Location = new Point(138, 173);
            labelDateFrom.Margin = new Padding(5, 0, 5, 0);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(114, 32);
            labelDateFrom.TabIndex = 34;
            labelDateFrom.Text = "Từ ngày:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(136, 56);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1329, 50);
            textBoxSearch.TabIndex = 33;
            textBoxSearch.Text = "Tìm kiếm";
            // 
            // GDPerformanceReport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            Name = "GDPerformanceReport";
            Text = "GDPerformanceReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuperAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button buttonUpdate;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button buttonSearching;
        private DateTimePicker dateTimePickerDateTo;
        private DateTimePicker dateTimePickerDateFrom;
        private Label labelDateTo;
        private Label labelDateFrom;
        private TextBox textBoxSearch;
    }
}