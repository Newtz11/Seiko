namespace Design
{
    partial class CreatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePassword));
            labelCreatePassword = new Label();
            pictureBoxLogo0 = new PictureBox();
            buttonShowPassword2 = new Button();
            buttonHidePassword2 = new Button();
            buttonShowPassword1 = new Button();
            buttonHidePassword1 = new Button();
            buttonCancel = new Button();
            buttonSavePassword = new Button();
            textBoxConfirmPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            labelConfirmPassword = new Label();
            labelNewPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            SuspendLayout();
            // 
            // labelCreatePassword
            // 
            labelCreatePassword.AutoSize = true;
            labelCreatePassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreatePassword.Location = new Point(125, 67);
            labelCreatePassword.Name = "labelCreatePassword";
            labelCreatePassword.Size = new Size(249, 41);
            labelCreatePassword.TabIndex = 2;
            labelCreatePassword.Text = "TẠO MẬT KHẨU";
            labelCreatePassword.Click += labelCreatePassword_Click;
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Image = Properties.Resources.logo0;
            pictureBoxLogo0.Location = new Point(224, 12);
            pictureBoxLogo0.Name = "pictureBoxLogo0";
            pictureBoxLogo0.Size = new Size(43, 43);
            pictureBoxLogo0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo0.TabIndex = 3;
            pictureBoxLogo0.TabStop = false;
            // 
            // buttonShowPassword2
            // 
            buttonShowPassword2.Image = Properties.Resources.show__1_;
            buttonShowPassword2.Location = new Point(438, 309);
            buttonShowPassword2.Name = "buttonShowPassword2";
            buttonShowPassword2.Size = new Size(33, 30);
            buttonShowPassword2.TabIndex = 26;
            buttonShowPassword2.UseVisualStyleBackColor = true;
            buttonShowPassword2.Click += buttonShowPassword2_Click;
            // 
            // buttonHidePassword2
            // 
            buttonHidePassword2.Image = Properties.Resources.hide__1_;
            buttonHidePassword2.Location = new Point(437, 309);
            buttonHidePassword2.Name = "buttonHidePassword2";
            buttonHidePassword2.Size = new Size(34, 30);
            buttonHidePassword2.TabIndex = 25;
            buttonHidePassword2.UseVisualStyleBackColor = true;
            buttonHidePassword2.Click += buttonHidePassword2_Click;
            // 
            // buttonShowPassword1
            // 
            buttonShowPassword1.Image = Properties.Resources.show__1_;
            buttonShowPassword1.Location = new Point(437, 207);
            buttonShowPassword1.Name = "buttonShowPassword1";
            buttonShowPassword1.Size = new Size(32, 30);
            buttonShowPassword1.TabIndex = 24;
            buttonShowPassword1.UseVisualStyleBackColor = true;
            buttonShowPassword1.Click += buttonShowPassword1_Click;
            // 
            // buttonHidePassword1
            // 
            buttonHidePassword1.Image = Properties.Resources.hide__1_;
            buttonHidePassword1.Location = new Point(437, 207);
            buttonHidePassword1.Name = "buttonHidePassword1";
            buttonHidePassword1.Size = new Size(33, 30);
            buttonHidePassword1.TabIndex = 23;
            buttonHidePassword1.UseVisualStyleBackColor = true;
            buttonHidePassword1.Click += buttonHidePassword1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.BackColor = Color.Crimson;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(386, 415);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(85, 26);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSavePassword.BackColor = Color.DodgerBlue;
            buttonSavePassword.FlatStyle = FlatStyle.Popup;
            buttonSavePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePassword.ForeColor = Color.White;
            buttonSavePassword.Location = new Point(164, 376);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(148, 41);
            buttonSavePassword.TabIndex = 19;
            buttonSavePassword.Text = "LƯU MẬT KHẨU";
            buttonSavePassword.UseVisualStyleBackColor = false;
            buttonSavePassword.Click += buttonSavePassword_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(12, 309);
            textBoxConfirmPassword.MaxLength = 20;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Xác nhận mật khẩu mới (phải trùng với mật khẩu mới )";
            textBoxConfirmPassword.Size = new Size(458, 30);
            textBoxConfirmPassword.TabIndex = 18;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(12, 207);
            textBoxNewPassword.MaxLength = 20;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "Mật khẩu mới";
            textBoxNewPassword.Size = new Size(458, 30);
            textBoxNewPassword.TabIndex = 17;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.Location = new Point(12, 264);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(194, 28);
            labelConfirmPassword.TabIndex = 22;
            labelConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(12, 165);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(145, 28);
            labelNewPassword.TabIndex = 21;
            labelNewPassword.Text = "Mật khẩu mới";
            // 
            // CreatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 453);
            Controls.Add(buttonShowPassword2);
            Controls.Add(buttonHidePassword2);
            Controls.Add(buttonShowPassword1);
            Controls.Add(buttonHidePassword1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSavePassword);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(labelConfirmPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(pictureBoxLogo0);
            Controls.Add(labelCreatePassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seiko";
            Load += CreatePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCreatePassword;
        private PictureBox pictureBoxLogo0;
        private Button buttonShowPassword2;
        private Button buttonHidePassword2;
        private Button buttonShowPassword1;
        private Button buttonHidePassword1;
        private Button buttonCancel;
        private Button buttonSavePassword;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxNewPassword;
        private Label labelConfirmPassword;
        private Label labelNewPassword;
    }
}