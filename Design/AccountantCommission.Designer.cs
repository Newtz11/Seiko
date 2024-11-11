namespace Design
{
    partial class AccountantCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantCommission));
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ColMaNhanVien = new DataGridViewTextBoxColumn();
            ColTenNhanVien = new DataGridViewTextBoxColumn();
            ColChucVu = new DataGridViewTextBoxColumn();
            ColPhongBan = new DataGridViewTextBoxColumn();
            ColTongSoHoaHong = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxSearch = new TextBox();
            labelCommission = new Label();
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
            panel1.Controls.Add(labelCommission);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Location = new Point(14, 8);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 545);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBoxSearch);
            panel2.Location = new Point(33, 157);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 372);
            panel2.TabIndex = 28;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.DodgerBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(737, 561);
            button3.Name = "button3";
            button3.Size = new Size(159, 30);
            button3.TabIndex = 25;
            button3.Text = "CẬP NHẬT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.DodgerBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(737, 82);
            button2.Name = "button2";
            button2.Size = new Size(159, 30);
            button2.TabIndex = 24;
            button2.Text = "CHỈNH SỬA";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColMaNhanVien, ColTenNhanVien, ColChucVu, ColPhongBan, ColTongSoHoaHong });
            dataGridView1.Location = new Point(28, 143);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(868, 0);
            dataGridView1.TabIndex = 23;
            // 
            // ColMaNhanVien
            // 
            ColMaNhanVien.HeaderText = "Mã nhân viên";
            ColMaNhanVien.MinimumWidth = 10;
            ColMaNhanVien.Name = "ColMaNhanVien";
            ColMaNhanVien.Width = 300;
            // 
            // ColTenNhanVien
            // 
            ColTenNhanVien.HeaderText = "Tên nhân viên";
            ColTenNhanVien.MinimumWidth = 10;
            ColTenNhanVien.Name = "ColTenNhanVien";
            ColTenNhanVien.Width = 400;
            // 
            // ColChucVu
            // 
            ColChucVu.HeaderText = "Chức vụ";
            ColChucVu.MinimumWidth = 10;
            ColChucVu.Name = "ColChucVu";
            ColChucVu.Width = 300;
            // 
            // ColPhongBan
            // 
            ColPhongBan.HeaderText = "Phòng ban";
            ColPhongBan.MinimumWidth = 10;
            ColPhongBan.Name = "ColPhongBan";
            ColPhongBan.Width = 300;
            // 
            // ColTongSoHoaHong
            // 
            ColTongSoHoaHong.HeaderText = "Tổng số hoa hồng";
            ColTongSoHoaHong.MinimumWidth = 10;
            ColTongSoHoaHong.Name = "ColTongSoHoaHong";
            ColTongSoHoaHong.Width = 500;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(737, 35);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 22;
            button1.Text = "TÌM KIẾM";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(28, 35);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm";
            textBoxSearch.Size = new Size(572, 30);
            textBoxSearch.TabIndex = 20;
            // 
            // labelCommission
            // 
            labelCommission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCommission.AutoSize = true;
            labelCommission.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCommission.Location = new Point(122, 92);
            labelCommission.Name = "labelCommission";
            labelCommission.Size = new Size(163, 25);
            labelCommission.TabIndex = 27;
            labelCommission.Text = "TÍNH HOA HỒNG";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(16, 17);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 26;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // AccountantCommission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 689);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AccountantCommission";
            Text = "Tính hoa hồng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelCommission;
        private GroupBox groupBoxFeature;
        private Panel mainpanel;
        private Button buttonCommissionCalculation;
        private Button buttonContractHistory;
        private Button buttonLogout;
        private PictureBox pictureBoxSecurity;
        private Button buttonCreateContract;
        private Button buttonPaymentHistory;
        private Button buttonHome;
        private Button buttonInfoUser;
        private PictureBox pictureBoxLogoAccountant;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxSearch;
        private Button button1;
        private DataGridView dataGridViewProjectSchedule;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn ngayThanhToan;
        private DataGridViewTextBoxColumn soTien;
        private DataGridViewTextBoxColumn loaiThanhToan;
        private DataGridViewTextBoxColumn noiDungThanhToan;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColMaNhanVien;
        private DataGridViewTextBoxColumn ColTenNhanVien;
        private DataGridViewTextBoxColumn ColChucVu;
        private DataGridViewTextBoxColumn ColPhongBan;
        private DataGridViewTextBoxColumn ColTongSoHoaHong;
    }
}