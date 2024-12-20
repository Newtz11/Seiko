﻿namespace Design
{
    partial class CreateAccount
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            pictureBoxIconCreateAccount = new PictureBox();
            labelCreateAccount = new Label();
            groupBoxEmail = new GroupBox();
            buttonHuyBo = new Button();
            textBoxDiaChi = new TextBox();
            labelDiaChi = new Label();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            labelGioiTinh = new Label();
            label1 = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            labelNgaySinh = new Label();
            comboBoxPhongBan = new ComboBox();
            labelPhongBan = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            comboBoxChucVu = new ComboBox();
            buttonTaoTaiKhoan = new Button();
            labelRole = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelUserName = new Label();
            textBoxFullName = new TextBox();
            textBoxUserName = new TextBox();
            labelFullName = new Label();
            errorProviderTenDangNhap = new ErrorProvider(components);
            errorProviderHoTenNguoiDung = new ErrorProvider(components);
            errorProviderDiaChi = new ErrorProvider(components);
            errorProviderPhongBan = new ErrorProvider(components);
            errorProviderChucVu = new ErrorProvider(components);
            errorProviderEmail = new ErrorProvider(components);
            errorProviderSDT = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconCreateAccount).BeginInit();
            groupBoxEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderTenDangNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderHoTenNguoiDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDiaChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPhongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderChucVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSDT).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconCreateAccount
            // 
            pictureBoxIconCreateAccount.Anchor = AnchorStyles.Top;
            pictureBoxIconCreateAccount.Image = Properties.Resources.user__1_;
            pictureBoxIconCreateAccount.Location = new Point(453, 12);
            pictureBoxIconCreateAccount.Name = "pictureBoxIconCreateAccount";
            pictureBoxIconCreateAccount.Size = new Size(100, 100);
            pictureBoxIconCreateAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIconCreateAccount.TabIndex = 8;
            pictureBoxIconCreateAccount.TabStop = false;
            // 
            // labelCreateAccount
            // 
            labelCreateAccount.Anchor = AnchorStyles.Top;
            labelCreateAccount.AutoSize = true;
            labelCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelCreateAccount.Location = new Point(416, 115);
            labelCreateAccount.Name = "labelCreateAccount";
            labelCreateAccount.Size = new Size(169, 28);
            labelCreateAccount.TabIndex = 30;
            labelCreateAccount.Text = "TẠO TÀI KHOẢN";
            labelCreateAccount.Click += labelCreateAccount_Click;
            // 
            // groupBoxEmail
            // 
            groupBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEmail.BackColor = Color.LightGray;
            groupBoxEmail.Controls.Add(buttonHuyBo);
            groupBoxEmail.Controls.Add(textBoxDiaChi);
            groupBoxEmail.Controls.Add(labelDiaChi);
            groupBoxEmail.Controls.Add(radioButtonNu);
            groupBoxEmail.Controls.Add(radioButtonNam);
            groupBoxEmail.Controls.Add(labelGioiTinh);
            groupBoxEmail.Controls.Add(label1);
            groupBoxEmail.Controls.Add(dateTimePickerNgaySinh);
            groupBoxEmail.Controls.Add(labelNgaySinh);
            groupBoxEmail.Controls.Add(comboBoxPhongBan);
            groupBoxEmail.Controls.Add(labelPhongBan);
            groupBoxEmail.Controls.Add(textBoxPhoneNumber);
            groupBoxEmail.Controls.Add(labelPhoneNumber);
            groupBoxEmail.Controls.Add(comboBoxChucVu);
            groupBoxEmail.Controls.Add(buttonTaoTaiKhoan);
            groupBoxEmail.Controls.Add(labelRole);
            groupBoxEmail.Controls.Add(textBoxEmail);
            groupBoxEmail.Controls.Add(labelEmail);
            groupBoxEmail.Controls.Add(labelUserName);
            groupBoxEmail.Controls.Add(textBoxFullName);
            groupBoxEmail.Controls.Add(textBoxUserName);
            groupBoxEmail.Controls.Add(labelFullName);
            groupBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBoxEmail.Location = new Point(13, 155);
            groupBoxEmail.Name = "groupBoxEmail";
            groupBoxEmail.Size = new Size(1007, 750);
            groupBoxEmail.TabIndex = 31;
            groupBoxEmail.TabStop = false;
            groupBoxEmail.Text = "Điền thông tin để tạo tài khoản";
            // 
            // buttonHuyBo
            // 
            buttonHuyBo.Anchor = AnchorStyles.Right;
            buttonHuyBo.BackColor = Color.Crimson;
            buttonHuyBo.FlatStyle = FlatStyle.Popup;
            buttonHuyBo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHuyBo.ForeColor = Color.White;
            buttonHuyBo.Location = new Point(756, 678);
            buttonHuyBo.Name = "buttonHuyBo";
            buttonHuyBo.Size = new Size(200, 50);
            buttonHuyBo.TabIndex = 37;
            buttonHuyBo.Text = "HỦY BỎ";
            buttonHuyBo.UseVisualStyleBackColor = false;
            buttonHuyBo.Click += buttonHuyBo_Click;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDiaChi.Location = new Point(48, 585);
            textBoxDiaChi.MaxLength = 50;
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.PlaceholderText = "Nhập địa chỉ";
            textBoxDiaChi.Size = new Size(415, 30);
            textBoxDiaChi.TabIndex = 6;
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiaChi.Location = new Point(48, 542);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(78, 28);
            labelDiaChi.TabIndex = 36;
            labelDiaChi.Text = "Địa chỉ";
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(180, 474);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 5;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(58, 474);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 4;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGioiTinh.Location = new Point(48, 425);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(95, 28);
            labelGioiTinh.TabIndex = 32;
            labelGioiTinh.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 366);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 30;
            label1.Text = "Ngày/Tháng/Năm";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(48, 336);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(182, 27);
            dateTimePickerNgaySinh.TabIndex = 3;
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNgaySinh.Location = new Point(48, 282);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(107, 28);
            labelNgaySinh.TabIndex = 29;
            labelNgaySinh.Text = "Ngày sinh";
            // 
            // comboBoxPhongBan
            // 
            comboBoxPhongBan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhongBan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPhongBan.FormattingEnabled = true;
            comboBoxPhongBan.ItemHeight = 23;
            comboBoxPhongBan.Location = new Point(541, 103);
            comboBoxPhongBan.Name = "comboBoxPhongBan";
            comboBoxPhongBan.Size = new Size(415, 31);
            comboBoxPhongBan.TabIndex = 7;
            comboBoxPhongBan.SelectedIndexChanged += comboBoxPhongBan_SelectedIndexChanged;
            // 
            // labelPhongBan
            // 
            labelPhongBan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPhongBan.AutoSize = true;
            labelPhongBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhongBan.Location = new Point(541, 60);
            labelPhongBan.Name = "labelPhongBan";
            labelPhongBan.Size = new Size(114, 28);
            labelPhongBan.TabIndex = 27;
            labelPhongBan.Text = "Phòng Ban";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(550, 468);
            textBoxPhoneNumber.MaxLength = 10;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            textBoxPhoneNumber.Size = new Size(415, 30);
            textBoxPhoneNumber.TabIndex = 11;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhoneNumber.Location = new Point(541, 425);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(138, 28);
            labelPhoneNumber.TabIndex = 25;
            labelPhoneNumber.Text = "Số điện thoại";
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChucVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.ItemHeight = 23;
            comboBoxChucVu.Location = new Point(541, 216);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(415, 31);
            comboBoxChucVu.TabIndex = 8;
            // 
            // buttonTaoTaiKhoan
            // 
            buttonTaoTaiKhoan.Anchor = AnchorStyles.Top;
            buttonTaoTaiKhoan.BackColor = Color.DodgerBlue;
            buttonTaoTaiKhoan.FlatStyle = FlatStyle.Popup;
            buttonTaoTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTaoTaiKhoan.ForeColor = Color.White;
            buttonTaoTaiKhoan.Location = new Point(385, 678);
            buttonTaoTaiKhoan.Name = "buttonTaoTaiKhoan";
            buttonTaoTaiKhoan.Size = new Size(200, 50);
            buttonTaoTaiKhoan.TabIndex = 12;
            buttonTaoTaiKhoan.Text = "TẠO TÀI KHOẢN";
            buttonTaoTaiKhoan.UseVisualStyleBackColor = false;
            buttonTaoTaiKhoan.Click += buttonTaoTaiKhoan_Click;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(541, 166);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(88, 28);
            labelRole.TabIndex = 18;
            labelRole.Text = "Chức vụ";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(541, 325);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Nhập Email: ( ví dụ: abc@gmail.com )";
            textBoxEmail.Size = new Size(415, 30);
            textBoxEmail.TabIndex = 10;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(541, 282);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(64, 28);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(48, 60);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(152, 28);
            labelUserName.TabIndex = 14;
            labelUserName.Text = "Tên đăng nhập";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(48, 217);
            textBoxFullName.MaxLength = 50;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.PlaceholderText = "Nhập họ và tên";
            textBoxFullName.Size = new Size(415, 30);
            textBoxFullName.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(48, 103);
            textBoxUserName.MaxLength = 50;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Nhập tên đăng nhập";
            textBoxUserName.Size = new Size(415, 30);
            textBoxUserName.TabIndex = 1;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullName.Location = new Point(48, 166);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(220, 28);
            labelFullName.TabIndex = 11;
            labelFullName.Text = "Họ và tên người dùng";
            // 
            // errorProviderTenDangNhap
            // 
            errorProviderTenDangNhap.ContainerControl = this;
            // 
            // errorProviderHoTenNguoiDung
            // 
            errorProviderHoTenNguoiDung.ContainerControl = this;
            // 
            // errorProviderDiaChi
            // 
            errorProviderDiaChi.ContainerControl = this;
            // 
            // errorProviderPhongBan
            // 
            errorProviderPhongBan.ContainerControl = this;
            // 
            // errorProviderChucVu
            // 
            errorProviderChucVu.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderSDT
            // 
            errorProviderSDT.ContainerControl = this;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 933);
            Controls.Add(groupBoxEmail);
            Controls.Add(labelCreateAccount);
            Controls.Add(pictureBoxIconCreateAccount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += CreateAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconCreateAccount).EndInit();
            groupBoxEmail.ResumeLayout(false);
            groupBoxEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderTenDangNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderHoTenNguoiDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDiaChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPhongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderChucVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSDT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconCreateAccount;
        private Label labelCreateAccount;
        private GroupBox groupBoxEmail;
        private Label labelFullName;
        private Label labelUserName;
        private TextBox textBoxFullName;
        private TextBox textBoxUserName;
        private Label labelRole;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonTaoTaiKhoan;
        private ComboBox comboBoxChucVu;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private ComboBox comboBoxPhongBan;
        private Label labelPhongBan;
        private Label label1;
        private DateTimePicker dateTimePickerNgaySinh;
        private Label labelNgaySinh;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private Label labelGioiTinh;
        private TextBox textBoxDiaChi;
        private Label labelDiaChi;
        private Button buttonHuyBo;
        private ErrorProvider errorProviderTenDangNhap;
        private ErrorProvider errorProviderHoTenNguoiDung;
        private ErrorProvider errorProviderDiaChi;
        private ErrorProvider errorProviderPhongBan;
        private ErrorProvider errorProviderChucVu;
        private ErrorProvider errorProviderEmail;
        private ErrorProvider errorProviderSDT;
    }
}