﻿namespace Design
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
            buttonSendOTP = new Button();
            buttonBack = new Button();
            buttonConfirmOTP = new Button();
            textBoxOTP = new TextBox();
            textBoxEmail = new TextBox();
            labelOTP = new Label();
            labelEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Anchor = AnchorStyles.Top;
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
            labelForgotPassword.Anchor = AnchorStyles.Top;
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
            buttonSendOTP.Anchor = AnchorStyles.Top;
            buttonSendOTP.BackColor = Color.DodgerBlue;
            buttonSendOTP.FlatStyle = FlatStyle.Popup;
            buttonSendOTP.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSendOTP.ForeColor = Color.White;
            buttonSendOTP.Location = new Point(376, 204);
            buttonSendOTP.Name = "buttonSendOTP";
            buttonSendOTP.Size = new Size(84, 30);
            buttonSendOTP.TabIndex = 21;
            buttonSendOTP.Text = "Gửi OTP";
            buttonSendOTP.UseVisualStyleBackColor = false;
            buttonSendOTP.Click += buttonSendOTP_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top;
            buttonBack.BackColor = Color.Crimson;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(376, 400);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(84, 30);
            buttonBack.TabIndex = 20;
            buttonBack.Text = "Quay lại";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonConfirmOTP
            // 
            buttonConfirmOTP.Anchor = AnchorStyles.Top;
            buttonConfirmOTP.BackColor = Color.DodgerBlue;
            buttonConfirmOTP.FlatStyle = FlatStyle.Popup;
            buttonConfirmOTP.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            buttonConfirmOTP.ForeColor = Color.White;
            buttonConfirmOTP.Location = new Point(376, 315);
            buttonConfirmOTP.Name = "buttonConfirmOTP";
            buttonConfirmOTP.Size = new Size(84, 30);
            buttonConfirmOTP.TabIndex = 19;
            buttonConfirmOTP.Text = "XÁC THỰC";
            buttonConfirmOTP.UseVisualStyleBackColor = false;
            buttonConfirmOTP.Click += buttonConfirmOTP_Click;
            // 
            // textBoxOTP
            // 
            textBoxOTP.Anchor = AnchorStyles.Top;
            textBoxOTP.BorderStyle = BorderStyle.FixedSingle;
            textBoxOTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOTP.Location = new Point(48, 315);
            textBoxOTP.MaxLength = 6;
            textBoxOTP.Name = "textBoxOTP";
            textBoxOTP.PlaceholderText = "Điền mã OTP tại đây";
            textBoxOTP.Size = new Size(303, 30);
            textBoxOTP.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(48, 204);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email: ( ví dụ: abc@gmail.com )";
            textBoxEmail.Size = new Size(303, 30);
            textBoxEmail.TabIndex = 17;
            // 
            // labelOTP
            // 
            labelOTP.Anchor = AnchorStyles.Top;
            labelOTP.AutoSize = true;
            labelOTP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOTP.Location = new Point(32, 265);
            labelOTP.Name = "labelOTP";
            labelOTP.Size = new Size(147, 28);
            labelOTP.TabIndex = 16;
            labelOTP.Text = "Nhập mã OTP:";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(32, 160);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(69, 28);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email:";
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
    }
}