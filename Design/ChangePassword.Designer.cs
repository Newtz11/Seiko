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
            groupBoxChangePassword = new GroupBox();
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
            pictureBoxLogo0 = new PictureBox();
            labelChangePassword = new Label();
            groupBoxChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            SuspendLayout();
            // 
            // groupBoxChangePassword
            // 
            groupBoxChangePassword.Controls.Add(buttonShowPassword3);
            groupBoxChangePassword.Controls.Add(buttonShowPassword2);
            groupBoxChangePassword.Controls.Add(buttonHidePassword3);
            groupBoxChangePassword.Controls.Add(buttonHidePassword2);
            groupBoxChangePassword.Controls.Add(buttonBack);
            groupBoxChangePassword.Controls.Add(buttonSavePassword);
            groupBoxChangePassword.Controls.Add(textBoxConfirmPassword);
            groupBoxChangePassword.Controls.Add(labelConfirmPassword);
            groupBoxChangePassword.Controls.Add(textBoxNewPassword);
            groupBoxChangePassword.Controls.Add(labelNewPassword);
            groupBoxChangePassword.Controls.Add(buttonShowPassword1);
            groupBoxChangePassword.Controls.Add(buttonHidePassword1);
            groupBoxChangePassword.Controls.Add(textBoxChangePassword);
            groupBoxChangePassword.Controls.Add(labelPassword);
            groupBoxChangePassword.Location = new Point(-156, 221);
            groupBoxChangePassword.Margin = new Padding(5);
            groupBoxChangePassword.Name = "groupBoxChangePassword";
            groupBoxChangePassword.Padding = new Padding(5);
            groupBoxChangePassword.Size = new Size(949, 664);
            groupBoxChangePassword.TabIndex = 0;
            groupBoxChangePassword.TabStop = false;
            groupBoxChangePassword.Text = "groupBox1";
            groupBoxChangePassword.Enter += groupBox1_Enter;
            // 
            // buttonShowPassword3
            // 
            buttonShowPassword3.Image = Properties.Resources.show__1_;
            buttonShowPassword3.Location = new Point(868, 443);
            buttonShowPassword3.Margin = new Padding(5);
            buttonShowPassword3.Name = "buttonShowPassword3";
            buttonShowPassword3.Size = new Size(52, 48);
            buttonShowPassword3.TabIndex = 25;
            buttonShowPassword3.UseVisualStyleBackColor = true;
            // 
            // buttonShowPassword2
            // 
            buttonShowPassword2.Image = Properties.Resources.show__1_;
            buttonShowPassword2.Location = new Point(868, 274);
            buttonShowPassword2.Margin = new Padding(5);
            buttonShowPassword2.Name = "buttonShowPassword2";
            buttonShowPassword2.Size = new Size(52, 48);
            buttonShowPassword2.TabIndex = 24;
            buttonShowPassword2.UseVisualStyleBackColor = true;
            // 
            // buttonHidePassword3
            // 
            buttonHidePassword3.Image = Properties.Resources.hide__1_;
            buttonHidePassword3.Location = new Point(866, 443);
            buttonHidePassword3.Margin = new Padding(5);
            buttonHidePassword3.Name = "buttonHidePassword3";
            buttonHidePassword3.Size = new Size(54, 48);
            buttonHidePassword3.TabIndex = 23;
            buttonHidePassword3.UseVisualStyleBackColor = true;
            // 
            // buttonHidePassword2
            // 
            buttonHidePassword2.Image = Properties.Resources.hide__1_;
            buttonHidePassword2.Location = new Point(866, 274);
            buttonHidePassword2.Margin = new Padding(5);
            buttonHidePassword2.Name = "buttonHidePassword2";
            buttonHidePassword2.Size = new Size(54, 48);
            buttonHidePassword2.TabIndex = 22;
            buttonHidePassword2.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBack.BackColor = Color.Crimson;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(782, 603);
            buttonBack.Margin = new Padding(5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(138, 42);
            buttonBack.TabIndex = 21;
            buttonBack.Text = "Quay lại";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSavePassword.BackColor = Color.DodgerBlue;
            buttonSavePassword.FlatStyle = FlatStyle.Popup;
            buttonSavePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePassword.ForeColor = Color.White;
            buttonSavePassword.Location = new Point(421, 523);
            buttonSavePassword.Margin = new Padding(5);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(240, 66);
            buttonSavePassword.TabIndex = 20;
            buttonSavePassword.Text = "LƯU MẬT KHẨU";
            buttonSavePassword.UseVisualStyleBackColor = false;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(176, 443);
            textBoxConfirmPassword.Margin = new Padding(5);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Xác nhận mật khẩu mới (phải trùng với mật khẩu mới )";
            textBoxConfirmPassword.ReadOnly = true;
            textBoxConfirmPassword.Size = new Size(742, 44);
            textBoxConfirmPassword.TabIndex = 19;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.Location = new Point(176, 376);
            labelConfirmPassword.Margin = new Padding(5, 0, 5, 0);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(305, 45);
            labelConfirmPassword.TabIndex = 18;
            labelConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(176, 274);
            textBoxNewPassword.Margin = new Padding(5);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "Nhập mật khẩu mới";
            textBoxNewPassword.Size = new Size(742, 44);
            textBoxNewPassword.TabIndex = 17;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(176, 208);
            labelNewPassword.Margin = new Padding(5, 0, 5, 0);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(229, 45);
            labelNewPassword.TabIndex = 16;
            labelNewPassword.Text = "Mật khẩu mới";
            // 
            // buttonShowPassword1
            // 
            buttonShowPassword1.Image = Properties.Resources.show__1_;
            buttonShowPassword1.Location = new Point(868, 117);
            buttonShowPassword1.Margin = new Padding(5);
            buttonShowPassword1.Name = "buttonShowPassword1";
            buttonShowPassword1.Size = new Size(52, 48);
            buttonShowPassword1.TabIndex = 15;
            buttonShowPassword1.UseVisualStyleBackColor = true;
            buttonShowPassword1.Click += buttonShowPassword1_Click;
            // 
            // buttonHidePassword1
            // 
            buttonHidePassword1.Image = Properties.Resources.hide__1_;
            buttonHidePassword1.Location = new Point(866, 117);
            buttonHidePassword1.Margin = new Padding(5);
            buttonHidePassword1.Name = "buttonHidePassword1";
            buttonHidePassword1.Size = new Size(54, 48);
            buttonHidePassword1.TabIndex = 14;
            buttonHidePassword1.UseVisualStyleBackColor = true;
            // 
            // textBoxChangePassword
            // 
            textBoxChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxChangePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxChangePassword.Location = new Point(176, 117);
            textBoxChangePassword.Margin = new Padding(5);
            textBoxChangePassword.Name = "textBoxChangePassword";
            textBoxChangePassword.PlaceholderText = "Nhập mật khẩu hiện tại";
            textBoxChangePassword.Size = new Size(742, 44);
            textBoxChangePassword.TabIndex = 7;
            textBoxChangePassword.TextChanged += textBoxChangePassword_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(176, 53);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(162, 45);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Mật khẩu";
            labelPassword.Click += labelNewPassword_Click;
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Image = Properties.Resources.logo0;
            pictureBoxLogo0.Location = new Point(356, 19);
            pictureBoxLogo0.Margin = new Padding(5);
            pictureBoxLogo0.Name = "pictureBoxLogo0";
            pictureBoxLogo0.Size = new Size(43, 43);
            pictureBoxLogo0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo0.TabIndex = 4;
            pictureBoxLogo0.TabStop = false;
            // 
            // labelChangePassword
            // 
            labelChangePassword.AutoSize = true;
            labelChangePassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChangePassword.Location = new Point(213, 110);
            labelChangePassword.Margin = new Padding(5, 0, 5, 0);
            labelChangePassword.Name = "labelChangePassword";
            labelChangePassword.Size = new Size(385, 65);
            labelChangePassword.TabIndex = 5;
            labelChangePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 885);
            Controls.Add(labelChangePassword);
            Controls.Add(pictureBoxLogo0);
            Controls.Add(groupBoxChangePassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "ChangePassword";
            Text = "Đổi mật khẩu";
            groupBoxChangePassword.ResumeLayout(false);
            groupBoxChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxChangePassword;
        private PictureBox pictureBoxLogo0;
        private Label labelChangePassword;
        private Label labelPassword;
        private TextBox textBoxChangePassword;
        private Button buttonHidePassword1;
        private Button buttonShowPassword1;
        private TextBox textBoxConfirmPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxNewPassword;
        private Label labelNewPassword;
        private Button buttonSavePassword;
        private Button buttonBack;
        private Button buttonShowPassword3;
        private Button buttonShowPassword2;
        private Button buttonHidePassword3;
        private Button buttonHidePassword2;
    }
}