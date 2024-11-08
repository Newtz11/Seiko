namespace Design
{
    partial class TPSPerformanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TPSPerformanceReport));
            panel1 = new Panel();
            groupBoxFeature = new GroupBox();
            buttonHome = new Button();
            buttonProjectAssignment = new Button();
            buttonPerformanceReport = new Button();
            buttonContractHistory = new Button();
            buttonProjectSchedule = new Button();
            buttonContractApproval = new Button();
            buttonLogout = new Button();
            pictureBoxSecurity = new PictureBox();
            buttonContractTracking = new Button();
            buttonInfoUser = new Button();
            pictureBoxLogoHeadOfSales = new PictureBox();
            pictureBoxIconContractTracking = new PictureBox();
            labelPerformanceReport = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            buttonSearching = new Button();
            dateTimePickerDateTo = new DateTimePicker();
            dateTimePickerDateFrom = new DateTimePicker();
            labelDateTo = new Label();
            labelDateFrom = new Label();
            textBoxSearch = new TextBox();
            dataGridViewProjectSchedule = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenHopDong = new DataGridViewTextBoxColumn();
            ngayThanhToan = new DataGridViewTextBoxColumn();
            soTien = new DataGridViewTextBoxColumn();
            loaiThanhToan = new DataGridViewTextBoxColumn();
            noiDungThanhToan = new DataGridViewTextBoxColumn();
            buttonUpdate = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelPerformanceReport);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // groupBoxFeature
            // 
            groupBoxFeature.BackColor = Color.Gainsboro;
            groupBoxFeature.Controls.Add(buttonHome);
            groupBoxFeature.Controls.Add(buttonProjectAssignment);
            groupBoxFeature.Controls.Add(buttonPerformanceReport);
            groupBoxFeature.Controls.Add(buttonContractHistory);
            groupBoxFeature.Controls.Add(buttonProjectSchedule);
            groupBoxFeature.Controls.Add(buttonContractApproval);
            groupBoxFeature.Controls.Add(buttonLogout);
            groupBoxFeature.Controls.Add(pictureBoxSecurity);
            groupBoxFeature.Controls.Add(buttonContractTracking);
            groupBoxFeature.Controls.Add(buttonInfoUser);
            groupBoxFeature.Controls.Add(pictureBoxLogoHeadOfSales);
            groupBoxFeature.Location = new Point(3, 2);
            groupBoxFeature.Margin = new Padding(5);
            groupBoxFeature.Name = "groupBoxFeature";
            groupBoxFeature.Padding = new Padding(5);
            groupBoxFeature.Size = new Size(351, 1578);
            groupBoxFeature.TabIndex = 25;
            groupBoxFeature.TabStop = false;
            groupBoxFeature.Text = "groupBox1";
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Silver;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = SystemColors.ControlText;
            buttonHome.Location = new Point(10, 169);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(325, 77);
            buttonHome.TabIndex = 18;
            buttonHome.Text = "TRANG CHỦ";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonProjectAssignment
            // 
            buttonProjectAssignment.BackColor = Color.Silver;
            buttonProjectAssignment.FlatStyle = FlatStyle.Popup;
            buttonProjectAssignment.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectAssignment.Location = new Point(10, 731);
            buttonProjectAssignment.Margin = new Padding(5);
            buttonProjectAssignment.Name = "buttonProjectAssignment";
            buttonProjectAssignment.Size = new Size(325, 77);
            buttonProjectAssignment.TabIndex = 17;
            buttonProjectAssignment.Text = "GIAO DỰ ÁN";
            buttonProjectAssignment.UseVisualStyleBackColor = false;
            // 
            // buttonPerformanceReport
            // 
            buttonPerformanceReport.BackColor = Color.White;
            buttonPerformanceReport.FlatStyle = FlatStyle.Popup;
            buttonPerformanceReport.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerformanceReport.Location = new Point(10, 1008);
            buttonPerformanceReport.Margin = new Padding(5);
            buttonPerformanceReport.Name = "buttonPerformanceReport";
            buttonPerformanceReport.Size = new Size(325, 77);
            buttonPerformanceReport.TabIndex = 13;
            buttonPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
            buttonPerformanceReport.UseVisualStyleBackColor = false;
            // 
            // buttonContractHistory
            // 
            buttonContractHistory.BackColor = Color.Silver;
            buttonContractHistory.FlatStyle = FlatStyle.Popup;
            buttonContractHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractHistory.Location = new Point(10, 1149);
            buttonContractHistory.Margin = new Padding(5);
            buttonContractHistory.Name = "buttonContractHistory";
            buttonContractHistory.Size = new Size(325, 77);
            buttonContractHistory.TabIndex = 15;
            buttonContractHistory.Text = "LỊCH SỬ HỢP ĐỒNG";
            buttonContractHistory.UseVisualStyleBackColor = false;
            // 
            // buttonProjectSchedule
            // 
            buttonProjectSchedule.BackColor = Color.Silver;
            buttonProjectSchedule.FlatStyle = FlatStyle.Popup;
            buttonProjectSchedule.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjectSchedule.Location = new Point(10, 867);
            buttonProjectSchedule.Margin = new Padding(5);
            buttonProjectSchedule.Name = "buttonProjectSchedule";
            buttonProjectSchedule.Size = new Size(325, 77);
            buttonProjectSchedule.TabIndex = 14;
            buttonProjectSchedule.Text = "TIẾN ĐỘ DỰ ÁN";
            buttonProjectSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonContractApproval
            // 
            buttonContractApproval.BackColor = Color.Silver;
            buttonContractApproval.FlatStyle = FlatStyle.Popup;
            buttonContractApproval.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractApproval.ForeColor = SystemColors.ControlText;
            buttonContractApproval.Location = new Point(10, 598);
            buttonContractApproval.Margin = new Padding(5);
            buttonContractApproval.Name = "buttonContractApproval";
            buttonContractApproval.Size = new Size(325, 77);
            buttonContractApproval.TabIndex = 12;
            buttonContractApproval.Text = "PHÊ DUYỆT HỢP ĐỒNG";
            buttonContractApproval.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Silver;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(10, 1429);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(325, 77);
            buttonLogout.TabIndex = 11;
            buttonLogout.Text = "ĐĂNG XUẤT";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSecurity
            // 
            pictureBoxSecurity.Image = (Image)resources.GetObject("pictureBoxSecurity.Image");
            pictureBoxSecurity.Location = new Point(158, 1332);
            pictureBoxSecurity.Margin = new Padding(5);
            pictureBoxSecurity.Name = "pictureBoxSecurity";
            pictureBoxSecurity.Size = new Size(30, 33);
            pictureBoxSecurity.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecurity.TabIndex = 6;
            pictureBoxSecurity.TabStop = false;
            // 
            // buttonContractTracking
            // 
            buttonContractTracking.BackColor = Color.Silver;
            buttonContractTracking.FlatStyle = FlatStyle.Popup;
            buttonContractTracking.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContractTracking.Location = new Point(10, 461);
            buttonContractTracking.Margin = new Padding(5);
            buttonContractTracking.Name = "buttonContractTracking";
            buttonContractTracking.Size = new Size(325, 77);
            buttonContractTracking.TabIndex = 5;
            buttonContractTracking.Text = "THEO DÕI HỢP ĐỒNG";
            buttonContractTracking.UseVisualStyleBackColor = false;
            // 
            // buttonInfoUser
            // 
            buttonInfoUser.BackColor = Color.Silver;
            buttonInfoUser.FlatStyle = FlatStyle.Popup;
            buttonInfoUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInfoUser.ForeColor = SystemColors.ControlText;
            buttonInfoUser.Location = new Point(10, 307);
            buttonInfoUser.Margin = new Padding(5);
            buttonInfoUser.Name = "buttonInfoUser";
            buttonInfoUser.Size = new Size(325, 77);
            buttonInfoUser.TabIndex = 4;
            buttonInfoUser.Text = "THÔNG TIN CÁ NHÂN";
            buttonInfoUser.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogoHeadOfSales
            // 
            pictureBoxLogoHeadOfSales.Image = (Image)resources.GetObject("pictureBoxLogoHeadOfSales.Image");
            pictureBoxLogoHeadOfSales.Location = new Point(0, 0);
            pictureBoxLogoHeadOfSales.Margin = new Padding(5);
            pictureBoxLogoHeadOfSales.Name = "pictureBoxLogoHeadOfSales";
            pictureBoxLogoHeadOfSales.Size = new Size(351, 97);
            pictureBoxLogoHeadOfSales.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoHeadOfSales.TabIndex = 2;
            pictureBoxLogoHeadOfSales.TabStop = false;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(375, 52);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 49;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelPerformanceReport
            // 
            labelPerformanceReport.AutoSize = true;
            labelPerformanceReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPerformanceReport.Location = new Point(485, 89);
            labelPerformanceReport.Margin = new Padding(5, 0, 5, 0);
            labelPerformanceReport.Name = "labelPerformanceReport";
            labelPerformanceReport.Size = new Size(311, 40);
            labelPerformanceReport.TabIndex = 50;
            labelPerformanceReport.Text = "BÁO CÁO HIỆU SUẤT ";
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
            panel2.TabIndex = 51;
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
            // TPSPerformanceReport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(groupBoxFeature);
            Controls.Add(panel1);
            Name = "TPSPerformanceReport";
            Text = "TPSPerformanceReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxFeature.ResumeLayout(false);
            groupBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoHeadOfSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxFeature;
        private Button buttonHome;
        private Button buttonProjectAssignment;
        private Button buttonPerformanceReport;
        private Button buttonContractHistory;
        private Button buttonProjectSchedule;
        private Button buttonContractApproval;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonContractTracking;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoHeadOfSales;
        private PictureBox pictureBoxIconContractTracking;
        private Label labelPerformanceReport;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button buttonSearching;
        private DateTimePicker dateTimePickerDateTo;
        private DateTimePicker dateTimePickerDateFrom;
        private Label labelDateTo;
        private Label labelDateFrom;
        private TextBox textBoxSearch;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
        private Button buttonUpdate;
        private DataGridView dataGridView1;
    }
}