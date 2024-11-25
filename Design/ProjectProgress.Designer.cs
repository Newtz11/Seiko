namespace Design
{
    partial class ProjectProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectProgress));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            labelTienDoCongViec = new Label();
            pictureBoxIconContractTracking = new PictureBox();
            groupBoxListUser = new GroupBox();
            buttonReset = new Button();
            dateTimePickerEnd = new DateTimePicker();
            label2 = new Label();
            dateTimePickerStart = new DateTimePicker();
            label1 = new Label();
            buttonSua = new Button();
            dataGridViewProjectProgress = new DataGridView();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenHopDong = new DataGridViewTextBoxColumn();
            NoiDungCongViec = new DataGridViewTextBoxColumn();
            KhoiLuongYeuCau = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            TienDo = new DataGridViewTextBoxColumn();
            NguoiThucHien = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            comboBoxTinhTrang = new ComboBox();
            buttonXoa = new Button();
            buttonTaoTaiKhoan = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            labelProjectProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBoxListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectProgress).BeginInit();
            SuspendLayout();
            // 
            // labelTienDoCongViec
            // 
            labelTienDoCongViec.AutoSize = true;
            labelTienDoCongViec.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTienDoCongViec.Location = new Point(118, 45);
            labelTienDoCongViec.Name = "labelTienDoCongViec";
            labelTienDoCongViec.Size = new Size(186, 25);
            labelTienDoCongViec.TabIndex = 49;
            labelTienDoCongViec.Text = "TIẾN ĐỘ CÔNG VIỆC";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(12, 12);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 46;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // groupBoxListUser
            // 
            groupBoxListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxListUser.BackColor = Color.LightGray;
            groupBoxListUser.Controls.Add(buttonReset);
            groupBoxListUser.Controls.Add(dateTimePickerEnd);
            groupBoxListUser.Controls.Add(label2);
            groupBoxListUser.Controls.Add(dateTimePickerStart);
            groupBoxListUser.Controls.Add(label1);
            groupBoxListUser.Controls.Add(buttonSua);
            groupBoxListUser.Controls.Add(dataGridViewProjectProgress);
            groupBoxListUser.Controls.Add(comboBoxTinhTrang);
            groupBoxListUser.Controls.Add(buttonXoa);
            groupBoxListUser.Controls.Add(buttonTaoTaiKhoan);
            groupBoxListUser.Controls.Add(buttonSearch);
            groupBoxListUser.Controls.Add(textBoxSearch);
            groupBoxListUser.Controls.Add(labelProjectProgress);
            groupBoxListUser.Location = new Point(12, 133);
            groupBoxListUser.Name = "groupBoxListUser";
            groupBoxListUser.Size = new Size(1298, 808);
            groupBoxListUser.TabIndex = 50;
            groupBoxListUser.TabStop = false;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReset.BackColor = Color.Goldenrod;
            buttonReset.FlatStyle = FlatStyle.Popup;
            buttonReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(825, 174);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(106, 33);
            buttonReset.TabIndex = 35;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(159, 175);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(261, 27);
            dateTimePickerEnd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(46, 178);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 34;
            label2.Text = "Ngày kết thúc:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(159, 137);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(261, 27);
            dateTimePickerStart.TabIndex = 2;
            dateTimePickerStart.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(46, 142);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 32;
            label1.Text = "Ngày bắt đầu:";
            label1.Click += label1_Click;
            // 
            // buttonSua
            // 
            buttonSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSua.BackColor = Color.Goldenrod;
            buttonSua.FlatStyle = FlatStyle.Popup;
            buttonSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(1087, 175);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(84, 32);
            buttonSua.TabIndex = 31;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProjectProgress
            // 
            dataGridViewProjectProgress.AllowUserToAddRows = false;
            dataGridViewProjectProgress.AllowUserToDeleteRows = false;
            dataGridViewProjectProgress.AllowUserToOrderColumns = true;
            dataGridViewProjectProgress.AllowUserToResizeRows = false;
            dataGridViewProjectProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectProgress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectProgress.BackgroundColor = Color.White;
            dataGridViewProjectProgress.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewProjectProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProjectProgress.ColumnHeadersHeight = 50;
            dataGridViewProjectProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProjectProgress.Columns.AddRange(new DataGridViewColumn[] { MaHopDong, TenHopDong, NoiDungCongViec, KhoiLuongYeuCau, NgayBatDau, NgayKetThuc, TienDo, NguoiThucHien, TinhTrang });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewProjectProgress.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProjectProgress.GridColor = Color.Black;
            dataGridViewProjectProgress.Location = new Point(15, 231);
            dataGridViewProjectProgress.Name = "dataGridViewProjectProgress";
            dataGridViewProjectProgress.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewProjectProgress.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewProjectProgress.RowHeadersVisible = false;
            dataGridViewProjectProgress.RowHeadersWidth = 51;
            dataGridViewProjectProgress.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewProjectProgress.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewProjectProgress.RowTemplate.Height = 35;
            dataGridViewProjectProgress.ScrollBars = ScrollBars.Vertical;
            dataGridViewProjectProgress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProjectProgress.Size = new Size(1270, 550);
            dataGridViewProjectProgress.TabIndex = 29;
            // 
            // MaHopDong
            // 
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.MinimumWidth = 6;
            MaHopDong.Name = "MaHopDong";
            // 
            // TenHopDong
            // 
            TenHopDong.HeaderText = "Tên hợp đồng";
            TenHopDong.MinimumWidth = 6;
            TenHopDong.Name = "TenHopDong";
            // 
            // NoiDungCongViec
            // 
            NoiDungCongViec.HeaderText = "Nội dung công việc";
            NoiDungCongViec.MinimumWidth = 6;
            NoiDungCongViec.Name = "NoiDungCongViec";
            // 
            // KhoiLuongYeuCau
            // 
            KhoiLuongYeuCau.HeaderText = "Khối lượng yêu cầu";
            KhoiLuongYeuCau.MinimumWidth = 6;
            KhoiLuongYeuCau.Name = "KhoiLuongYeuCau";
            // 
            // NgayBatDau
            // 
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.HeaderText = "Ngày kết thúc";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            // 
            // TienDo
            // 
            TienDo.HeaderText = "Tiến Độ";
            TienDo.MinimumWidth = 6;
            TienDo.Name = "TienDo";
            // 
            // NguoiThucHien
            // 
            NguoiThucHien.HeaderText = "Người thực hiện";
            NguoiThucHien.MinimumWidth = 6;
            NguoiThucHien.Name = "NguoiThucHien";
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            // 
            // comboBoxTinhTrang
            // 
            comboBoxTinhTrang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxTinhTrang.FormattingEnabled = true;
            comboBoxTinhTrang.Items.AddRange(new object[] { "Chưa thực hiện", "Đang thực hiện", "Chờ nghiệm thu", "Đã xong" });
            comboBoxTinhTrang.Location = new Point(442, 171);
            comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            comboBoxTinhTrang.Size = new Size(161, 31);
            comboBoxTinhTrang.TabIndex = 4;
            comboBoxTinhTrang.Text = "Tình Trạng ";
            // 
            // buttonXoa
            // 
            buttonXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonXoa.BackColor = Color.Crimson;
            buttonXoa.FlatStyle = FlatStyle.Popup;
            buttonXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(1195, 175);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(84, 32);
            buttonXoa.TabIndex = 20;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonTaoTaiKhoan
            // 
            buttonTaoTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTaoTaiKhoan.BackColor = Color.FromArgb(0, 192, 0);
            buttonTaoTaiKhoan.FlatStyle = FlatStyle.Popup;
            buttonTaoTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTaoTaiKhoan.ForeColor = Color.White;
            buttonTaoTaiKhoan.Location = new Point(957, 174);
            buttonTaoTaiKhoan.Name = "buttonTaoTaiKhoan";
            buttonTaoTaiKhoan.Size = new Size(104, 32);
            buttonTaoTaiKhoan.TabIndex = 19;
            buttonTaoTaiKhoan.Text = "Thêm mới";
            buttonTaoTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1173, 88);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(106, 33);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(46, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Nhập từ khóa tìm kiếm (Mã hợp đồng, tên hợp đồng, người thực hiện, nội dung thực hiện, ...)";
            textBoxSearch.Size = new Size(1053, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // labelProjectProgress
            // 
            labelProjectProgress.AutoSize = true;
            labelProjectProgress.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelProjectProgress.Location = new Point(41, 23);
            labelProjectProgress.Name = "labelProjectProgress";
            labelProjectProgress.Size = new Size(284, 38);
            labelProjectProgress.TabIndex = 13;
            labelProjectProgress.Text = "TIẾN ĐỘ CÔNG VIỆC";
            // 
            // ProjectProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 953);
            Controls.Add(groupBoxListUser);
            Controls.Add(labelTienDoCongViec);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ProjectProgress";
            Text = "Tiến độ dự án";
            Load += ProjectProgress_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBoxListUser.ResumeLayout(false);
            groupBoxListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectProgress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTienDoCongViec;
        private PictureBox pictureBoxIconContractTracking;
        private GroupBox groupBoxListUser;
        private DataGridView dataGridViewProjectProgress;
        private ComboBox comboBoxTinhTrang;
        private Button buttonXoa;
        private Button buttonTaoTaiKhoan;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelProjectProgress;
        private Label label1;
        private Button buttonSua;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label2;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenHopDong;
        private DataGridViewTextBoxColumn NoiDungCongViec;
        private DataGridViewTextBoxColumn KhoiLuongYeuCau;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn TienDo;
        private DataGridViewTextBoxColumn NguoiThucHien;
        private DataGridViewTextBoxColumn TinhTrang;
        private Button buttonReset;
    }
}