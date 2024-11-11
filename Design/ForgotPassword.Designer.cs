namespace Design
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            pictureBoxLogo0 = new PictureBox();
            labelForgotPassword = new Label();
            groupBoxForgotPassword = new GroupBox();
            button1 = new Button();
            buttonBack = new Button();
            buttonSavePassword = new Button();
            textBoxOTP = new TextBox();
            textBoxEmail = new TextBox();
            labelOTP = new Label();
            labelEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            groupBoxForgotPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Image = Properties.Resources.logo0;
            pictureBoxLogo0.Location = new Point(362, 19);
            pictureBoxLogo0.Margin = new Padding(5, 5, 5, 5);
            pictureBoxLogo0.Name = "pictureBoxLogo0";
            pictureBoxLogo0.Size = new Size(43, 43);
            pictureBoxLogo0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo0.TabIndex = 4;
            pictureBoxLogo0.TabStop = false;
            // 
            // labelForgotPassword
            // 
            labelForgotPassword.AutoSize = true;
            labelForgotPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelForgotPassword.Location = new Point(174, 115);
            labelForgotPassword.Margin = new Padding(5, 0, 5, 0);
            labelForgotPassword.Name = "labelForgotPassword";
            labelForgotPassword.Size = new Size(434, 65);
            labelForgotPassword.TabIndex = 5;
            labelForgotPassword.Text = "QUÊN MẬT KHẨU";
            labelForgotPassword.Click += labelCreatePassword_Click;
            // 
            // groupBoxForgotPassword
            // 
            groupBoxForgotPassword.Controls.Add(button1);
            groupBoxForgotPassword.Controls.Add(buttonBack);
            groupBoxForgotPassword.Controls.Add(buttonSavePassword);
            groupBoxForgotPassword.Controls.Add(textBoxOTP);
            groupBoxForgotPassword.Controls.Add(textBoxEmail);
            groupBoxForgotPassword.Controls.Add(labelOTP);
            groupBoxForgotPassword.Controls.Add(labelEmail);
            groupBoxForgotPassword.Location = new Point(-138, 205);
            groupBoxForgotPassword.Margin = new Padding(5, 5, 5, 5);
            groupBoxForgotPassword.Name = "groupBoxForgotPassword";
            groupBoxForgotPassword.Padding = new Padding(5, 5, 5, 5);
            groupBoxForgotPassword.Size = new Size(923, 518);
            groupBoxForgotPassword.TabIndex = 6;
            groupBoxForgotPassword.TabStop = false;
            groupBoxForgotPassword.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(704, 294);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(198, 48);
            button1.TabIndex = 14;
            button1.Text = "Gửi OTP";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBack.BackColor = Color.Crimson;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(775, 467);
            buttonBack.Margin = new Padding(5, 5, 5, 5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(138, 42);
            buttonBack.TabIndex = 13;
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
            buttonSavePassword.Location = new Point(418, 411);
            buttonSavePassword.Margin = new Padding(5, 5, 5, 5);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(240, 66);
            buttonSavePassword.TabIndex = 12;
            buttonSavePassword.Text = "XÁC THỰC";
            buttonSavePassword.UseVisualStyleBackColor = false;
            // 
            // textBoxOTP
            // 
            textBoxOTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOTP.Location = new Point(158, 294);
            textBoxOTP.Margin = new Padding(5, 5, 5, 5);
            textBoxOTP.Name = "textBoxOTP";
            textBoxOTP.PlaceholderText = "Nhập mã OTP mà bạn nhận được";
            textBoxOTP.Size = new Size(518, 44);
            textBoxOTP.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(158, 134);
            textBoxEmail.Margin = new Padding(5, 5, 5, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email: ( ví dụ: abc@gmail.com )";
            textBoxEmail.Size = new Size(742, 44);
            textBoxEmail.TabIndex = 7;
            // 
            // labelOTP
            // 
            labelOTP.AutoSize = true;
            labelOTP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOTP.Location = new Point(176, 218);
            labelOTP.Margin = new Padding(5, 0, 5, 0);
            labelOTP.Name = "labelOTP";
            labelOTP.Size = new Size(227, 45);
            labelOTP.TabIndex = 6;
            labelOTP.Text = "Nhập mã OTP";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(176, 67);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(101, 45);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 725);
            Controls.Add(groupBoxForgotPassword);
            Controls.Add(labelForgotPassword);
            Controls.Add(pictureBoxLogo0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "ForgotPassword";
            Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            groupBoxForgotPassword.ResumeLayout(false);
            groupBoxForgotPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo0;
        private Label labelForgotPassword;
        private GroupBox groupBoxForgotPassword;
        private Label labelOTP;
        private Label labelEmail;
        private TextBox textBoxOTP;
        private TextBox textBoxEmail;
        private Button buttonSavePassword;
        private Button buttonBack;
        private Button button1;
    }
}