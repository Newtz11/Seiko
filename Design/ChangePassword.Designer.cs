namespace Design
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            pictureBoxLogo0 = new PictureBox();
            labelChangePassword = new Label();
            buttonShowPassword3 = new Button();
            buttonShowPassword2 = new Button();
            buttonHidePassword3 = new Button();
            buttonHidePassword2 = new Button();
            buttonBack = new Button();
            buttonSavePassword = new Button();
            textBoxConfirmPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxNewPassword = new TextBox();
            labelNewPassword = new Label();
            buttonShowPassword1 = new Button();
            buttonHidePassword1 = new Button();
            textBoxChangePassword = new TextBox();
            labelPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Anchor = AnchorStyles.Top;
            pictureBoxLogo0.Image = Properties.Resources.logo0;
            pictureBoxLogo0.Location = new Point(219, 12);
            pictureBoxLogo0.Name = "pictureBoxLogo0";
            pictureBoxLogo0.Size = new Size(43, 43);
            pictureBoxLogo0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo0.TabIndex = 4;
            pictureBoxLogo0.TabStop = false;
            // 
            // labelChangePassword
            // 
            labelChangePassword.Anchor = AnchorStyles.Top;
            labelChangePassword.AutoSize = true;
            labelChangePassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChangePassword.Location = new Point(131, 69);
            labelChangePassword.Name = "labelChangePassword";
            labelChangePassword.Size = new Size(242, 41);
            labelChangePassword.TabIndex = 5;
            labelChangePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // buttonShowPassword3
            // 
            buttonShowPassword3.Image = Properties.Resources.show__1_;
            buttonShowPassword3.Location = new Point(438, 403);
            buttonShowPassword3.Name = "buttonShowPassword3";
            buttonShowPassword3.Size = new Size(32, 30);
            buttonShowPassword3.TabIndex = 39;
            buttonShowPassword3.UseVisualStyleBackColor = true;
            buttonShowPassword3.Click += buttonShowPassword3_Click;
            // 
            // buttonShowPassword2
            // 
            buttonShowPassword2.Image = Properties.Resources.show__1_;
            buttonShowPassword2.Location = new Point(438, 297);
            buttonShowPassword2.Name = "buttonShowPassword2";
            buttonShowPassword2.Size = new Size(32, 30);
            buttonShowPassword2.TabIndex = 38;
            buttonShowPassword2.UseVisualStyleBackColor = true;
            buttonShowPassword2.Click += buttonShowPassword2_Click;
            // 
            // buttonHidePassword3
            // 
            buttonHidePassword3.Image = Properties.Resources.hide__1_;
            buttonHidePassword3.Location = new Point(437, 403);
            buttonHidePassword3.Name = "buttonHidePassword3";
            buttonHidePassword3.Size = new Size(33, 30);
            buttonHidePassword3.TabIndex = 37;
            buttonHidePassword3.UseVisualStyleBackColor = true;
            buttonHidePassword3.Click += buttonHidePassword3_Click;
            // 
            // buttonHidePassword2
            // 
            buttonHidePassword2.Image = Properties.Resources.hide__1_;
            buttonHidePassword2.Location = new Point(437, 297);
            buttonHidePassword2.Name = "buttonHidePassword2";
            buttonHidePassword2.Size = new Size(33, 30);
            buttonHidePassword2.TabIndex = 36;
            buttonHidePassword2.UseVisualStyleBackColor = true;
            buttonHidePassword2.Click += buttonHidePassword2_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBack.BackColor = Color.Crimson;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(385, 503);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(85, 26);
            buttonBack.TabIndex = 35;
            buttonBack.Text = "Quay lại";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSavePassword.BackColor = Color.DodgerBlue;
            buttonSavePassword.FlatStyle = FlatStyle.Popup;
            buttonSavePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePassword.ForeColor = Color.White;
            buttonSavePassword.Location = new Point(163, 453);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(148, 41);
            buttonSavePassword.TabIndex = 34;
            buttonSavePassword.Text = "LƯU MẬT KHẨU";
            buttonSavePassword.UseVisualStyleBackColor = false;
            buttonSavePassword.Click += buttonSavePassword_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(12, 403);
            textBoxConfirmPassword.MaxLength = 20;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Xác nhận mật khẩu mới (phải trùng với mật khẩu mới )";
            textBoxConfirmPassword.Size = new Size(458, 30);
            textBoxConfirmPassword.TabIndex = 28;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.Location = new Point(12, 361);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(194, 28);
            labelConfirmPassword.TabIndex = 33;
            labelConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(12, 297);
            textBoxNewPassword.MaxLength = 20;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "Nhập mật khẩu mới";
            textBoxNewPassword.Size = new Size(458, 30);
            textBoxNewPassword.TabIndex = 27;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(12, 256);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(145, 28);
            labelNewPassword.TabIndex = 32;
            labelNewPassword.Text = "Mật khẩu mới";
            // 
            // buttonShowPassword1
            // 
            buttonShowPassword1.Image = Properties.Resources.show__1_;
            buttonShowPassword1.Location = new Point(437, 199);
            buttonShowPassword1.Name = "buttonShowPassword1";
            buttonShowPassword1.Size = new Size(32, 30);
            buttonShowPassword1.TabIndex = 31;
            buttonShowPassword1.UseVisualStyleBackColor = true;
            buttonShowPassword1.Click += buttonShowPassword1_Click;
            // 
            // buttonHidePassword1
            // 
            buttonHidePassword1.Image = Properties.Resources.hide__1_;
            buttonHidePassword1.Location = new Point(437, 199);
            buttonHidePassword1.Name = "buttonHidePassword1";
            buttonHidePassword1.Size = new Size(33, 30);
            buttonHidePassword1.TabIndex = 30;
            buttonHidePassword1.UseVisualStyleBackColor = true;
            buttonHidePassword1.Click += buttonHidePassword1_Click;
            // 
            // textBoxChangePassword
            // 
            textBoxChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxChangePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxChangePassword.Location = new Point(12, 199);
            textBoxChangePassword.MaxLength = 20;
            textBoxChangePassword.Name = "textBoxChangePassword";
            textBoxChangePassword.PlaceholderText = "Nhập mật khẩu hiện tại";
            textBoxChangePassword.Size = new Size(458, 30);
            textBoxChangePassword.TabIndex = 26;
            textBoxChangePassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(12, 159);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(102, 28);
            labelPassword.TabIndex = 29;
            labelPassword.Text = "Mật khẩu";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 553);
            Controls.Add(buttonShowPassword3);
            Controls.Add(buttonShowPassword2);
            Controls.Add(buttonHidePassword3);
            Controls.Add(buttonHidePassword2);
            Controls.Add(buttonBack);
            Controls.Add(buttonSavePassword);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(labelConfirmPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(buttonShowPassword1);
            Controls.Add(buttonHidePassword1);
            Controls.Add(textBoxChangePassword);
            Controls.Add(labelPassword);
            Controls.Add(labelChangePassword);
            Controls.Add(pictureBoxLogo0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += ChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxLogo0;
        private Label labelChangePassword;
        private Button buttonShowPassword3;
        private Button buttonShowPassword2;
        private Button buttonHidePassword3;
        private Button buttonHidePassword2;
        private Button buttonBack;
        private Button buttonSavePassword;
        private TextBox textBoxConfirmPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxNewPassword;
        private Label labelNewPassword;
        private Button buttonShowPassword1;
        private Button buttonHidePassword1;
        private TextBox textBoxChangePassword;
        private Label labelPassword;
    }
}