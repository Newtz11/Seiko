namespace Design
{
    partial class SuperAdminCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminCreateAccount));
            pictureBoxIconCreateAccount = new PictureBox();
            labelCreateAccount = new Label();
            groupBoxEmail = new GroupBox();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            labelDateTutorial = new Label();
            dateTimePickerDateOfJoining = new DateTimePicker();
            comboBoxRole = new ComboBox();
            buttonSavePassword = new Button();
            labelDateOfJoining = new Label();
            labelRole = new Label();
            textBox2 = new TextBox();
            labelEmail = new Label();
            labelUserName = new Label();
            textBoxFullName = new TextBox();
            textBoxUserName = new TextBox();
            labelFullName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconCreateAccount).BeginInit();
            groupBoxEmail.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxIconCreateAccount
            // 
            pictureBoxIconCreateAccount.Image = Properties.Resources.user__1_;
            pictureBoxIconCreateAccount.Location = new Point(44, 24);
            pictureBoxIconCreateAccount.Name = "pictureBoxIconCreateAccount";
            pictureBoxIconCreateAccount.Size = new Size(70, 70);
            pictureBoxIconCreateAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconCreateAccount.TabIndex = 8;
            pictureBoxIconCreateAccount.TabStop = false;
            // 
            // labelCreateAccount
            // 
            labelCreateAccount.AutoSize = true;
            labelCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreateAccount.Location = new Point(141, 66);
            labelCreateAccount.Name = "labelCreateAccount";
            labelCreateAccount.Size = new Size(169, 28);
            labelCreateAccount.TabIndex = 9;
            labelCreateAccount.Text = "TẠO TÀI KHOẢN";
            labelCreateAccount.Click += labelCreateAccount_Click;
            // 
            // groupBoxEmail
            // 
            groupBoxEmail.Controls.Add(textBoxPhoneNumber);
            groupBoxEmail.Controls.Add(labelPhoneNumber);
            groupBoxEmail.Controls.Add(labelDateTutorial);
            groupBoxEmail.Controls.Add(dateTimePickerDateOfJoining);
            groupBoxEmail.Controls.Add(comboBoxRole);
            groupBoxEmail.Controls.Add(buttonSavePassword);
            groupBoxEmail.Controls.Add(labelDateOfJoining);
            groupBoxEmail.Controls.Add(labelRole);
            groupBoxEmail.Controls.Add(textBox2);
            groupBoxEmail.Controls.Add(labelEmail);
            groupBoxEmail.Controls.Add(labelUserName);
            groupBoxEmail.Controls.Add(textBoxFullName);
            groupBoxEmail.Controls.Add(textBoxUserName);
            groupBoxEmail.Controls.Add(labelFullName);
            groupBoxEmail.Location = new Point(372, 67);
            groupBoxEmail.Name = "groupBoxEmail";
            groupBoxEmail.Size = new Size(522, 855);
            groupBoxEmail.TabIndex = 10;
            groupBoxEmail.TabStop = false;
            groupBoxEmail.Text = "Điền thông tin để tạo tài khoản";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(25, 447);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            textBoxPhoneNumber.Size = new Size(458, 30);
            textBoxPhoneNumber.TabIndex = 26;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhoneNumber.Location = new Point(25, 404);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(138, 28);
            labelPhoneNumber.TabIndex = 25;
            labelPhoneNumber.Text = "Số điện thoại";
            // 
            // labelDateTutorial
            // 
            labelDateTutorial.AutoSize = true;
            labelDateTutorial.Location = new Point(25, 706);
            labelDateTutorial.Name = "labelDateTutorial";
            labelDateTutorial.Size = new Size(129, 20);
            labelDateTutorial.TabIndex = 24;
            labelDateTutorial.Text = "Tháng/Ngày/Năm";
            // 
            // dateTimePickerDateOfJoining
            // 
            dateTimePickerDateOfJoining.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDateOfJoining.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDateOfJoining.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfJoining.Location = new Point(25, 676);
            dateTimePickerDateOfJoining.Name = "dateTimePickerDateOfJoining";
            dateTimePickerDateOfJoining.Size = new Size(458, 27);
            dateTimePickerDateOfJoining.TabIndex = 23;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(25, 559);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(458, 31);
            comboBoxRole.TabIndex = 22;
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSavePassword.BackColor = Color.DodgerBlue;
            buttonSavePassword.FlatStyle = FlatStyle.Popup;
            buttonSavePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePassword.ForeColor = Color.White;
            buttonSavePassword.Location = new Point(174, 783);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(169, 41);
            buttonSavePassword.TabIndex = 21;
            buttonSavePassword.Text = "TẠO TÀI KHOẢN";
            buttonSavePassword.UseVisualStyleBackColor = false;
            // 
            // labelDateOfJoining
            // 
            labelDateOfJoining.AutoSize = true;
            labelDateOfJoining.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateOfJoining.Location = new Point(25, 622);
            labelDateOfJoining.Name = "labelDateOfJoining";
            labelDateOfJoining.Size = new Size(288, 28);
            labelDateOfJoining.TabIndex = 20;
            labelDateOfJoining.Text = "Ngày tham gia doanh nghiệp";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(25, 506);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(88, 28);
            labelRole.TabIndex = 18;
            labelRole.Text = "Chức vụ";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(25, 330);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập Email: ( ví dụ: abc@gmail.com )";
            textBox2.Size = new Size(458, 30);
            textBox2.TabIndex = 17;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(25, 287);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(64, 28);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(25, 168);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(152, 28);
            labelUserName.TabIndex = 14;
            labelUserName.Text = "Tên đăng nhập";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(25, 105);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.PlaceholderText = "Nhập họ và tên";
            textBoxFullName.Size = new Size(458, 30);
            textBoxFullName.TabIndex = 13;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(25, 219);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Nhập tên đăng nhập";
            textBoxUserName.Size = new Size(458, 30);
            textBoxUserName.TabIndex = 12;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullName.Location = new Point(25, 62);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(220, 28);
            labelFullName.TabIndex = 11;
            labelFullName.Text = "Họ và tên người dùng";
            // 
            // SuperAdminCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1266, 951);
            Controls.Add(groupBoxEmail);
            Controls.Add(labelCreateAccount);
            Controls.Add(pictureBoxIconCreateAccount);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SuperAdminCreateAccount";
            Text = "Tạo tài khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconCreateAccount).EndInit();
            groupBoxEmail.ResumeLayout(false);
            groupBoxEmail.PerformLayout();
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
        private Label labelDateOfJoining;
        private Label labelRole;
        private TextBox textBox2;
        private Label labelEmail;
        private Button buttonSavePassword;
        private ComboBox comboBoxRole;
        private Label labelDateTutorial;
        private DateTimePicker dateTimePickerDateOfJoining;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
    }
}