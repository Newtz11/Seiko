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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            pictureBoxLogo0 = new PictureBox();
            labelForgotPassword = new Label();
            buttonSendOTP = new Button();
            buttonBack = new Button();
            buttonConfirmOTP = new Button();
            textBoxOTP = new TextBox();
            textBoxEmail = new TextBox();
            labelOTP = new Label();
            labelEmail = new Label();
            timerVCode = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Image = Properties.Resources.logo0;
            pictureBoxLogo0.Location = new Point(223, 12);
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
            labelForgotPassword.Location = new Point(107, 72);
            labelForgotPassword.Name = "labelForgotPassword";
            labelForgotPassword.Size = new Size(272, 41);
            labelForgotPassword.TabIndex = 5;
            labelForgotPassword.Text = "QUÊN MẬT KHẨU";
            labelForgotPassword.Click += labelCreatePassword_Click;
            // 
            // buttonSendOTP
            // 
            buttonSendOTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSendOTP.BackColor = Color.DodgerBlue;
            buttonSendOTP.FlatStyle = FlatStyle.Popup;
            buttonSendOTP.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSendOTP.ForeColor = Color.White;
            buttonSendOTP.Location = new Point(368, 304);
            buttonSendOTP.Name = "buttonSendOTP";
            buttonSendOTP.Size = new Size(85, 30);
            buttonSendOTP.TabIndex = 21;
            buttonSendOTP.Text = "Gửi OTP";
            buttonSendOTP.UseVisualStyleBackColor = false;
            buttonSendOTP.Click += buttonSendOTP_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBack.BackColor = Color.Crimson;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(385, 415);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(85, 26);
            buttonBack.TabIndex = 20;
            buttonBack.Text = "Quay lại";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonConfirmOTP
            // 
            buttonConfirmOTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfirmOTP.BackColor = Color.DodgerBlue;
            buttonConfirmOTP.FlatStyle = FlatStyle.Popup;
            buttonConfirmOTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfirmOTP.ForeColor = Color.White;
            buttonConfirmOTP.Location = new Point(183, 383);
            buttonConfirmOTP.Name = "buttonConfirmOTP";
            buttonConfirmOTP.Size = new Size(111, 41);
            buttonConfirmOTP.TabIndex = 19;
            buttonConfirmOTP.Text = "XÁC THỰC";
            buttonConfirmOTP.UseVisualStyleBackColor = false;
            buttonConfirmOTP.Click += buttonConfirmOTP_Click;
            // 
            // textBoxOTP
            // 
            textBoxOTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOTP.Location = new Point(32, 304);
            textBoxOTP.Name = "textBoxOTP";
            textBoxOTP.PlaceholderText = "Nhập mã OTP mà bạn nhận được";
            textBoxOTP.Size = new Size(306, 30);
            textBoxOTP.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(32, 202);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email: ( ví dụ: abc@gmail.com )";
            textBoxEmail.Size = new Size(421, 30);
            textBoxEmail.TabIndex = 17;
            // 
            // labelOTP
            // 
            labelOTP.AutoSize = true;
            labelOTP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOTP.Location = new Point(32, 256);
            labelOTP.Name = "labelOTP";
            labelOTP.Size = new Size(142, 28);
            labelOTP.TabIndex = 16;
            labelOTP.Text = "Nhập mã OTP";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(32, 162);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(64, 28);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // timerVCode
            // 
            timerVCode.Enabled = true;
            timerVCode.Interval = 1000;
            timerVCode.Tick += timerVCode_Tick;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 453);
            Controls.Add(buttonSendOTP);
            Controls.Add(buttonBack);
            Controls.Add(buttonConfirmOTP);
            Controls.Add(textBoxOTP);
            Controls.Add(textBoxEmail);
            Controls.Add(labelOTP);
            Controls.Add(labelEmail);
            Controls.Add(labelForgotPassword);
            Controls.Add(pictureBoxLogo0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo0;
        private Label labelForgotPassword;
        private Button buttonSendOTP;
        private Button buttonBack;
        private Button buttonConfirmOTP;
        private TextBox textBoxOTP;
        private TextBox textBoxEmail;
        private Label labelOTP;
        private Label labelEmail;
        private System.Windows.Forms.Timer timerVCode;
    }
}