namespace Design
{
    partial class SaleChangePassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleChangePassWord));
            Logo = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBoxPass = new TextBox();
            labelMatKhau = new Label();
            labelNewPassword = new Label();
            textBoxNewPassword = new TextBox();
            labelXacNhanMatKhau = new Label();
            textBox1 = new TextBox();
            buttonSavePassword = new Button();
            buttonComeBack = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(414, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(109, 93);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 33;
            Logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 3);
            panel1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, -31);
            label2.Name = "label2";
            label2.Size = new Size(476, 65);
            label2.TabIndex = 34;
            label2.Text = "Xác nhận đăng xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 144);
            label1.Name = "label1";
            label1.Size = new Size(346, 59);
            label1.TabIndex = 35;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // textBoxPass
            // 
            textBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.Location = new Point(26, 371);
            textBoxPass.Margin = new Padding(5);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(913, 50);
            textBoxPass.TabIndex = 36;
            textBoxPass.Text = "Mật khẩu hiện tại";
            // 
            // labelMatKhau
            // 
            labelMatKhau.AutoSize = true;
            labelMatKhau.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatKhau.Location = new Point(26, 298);
            labelMatKhau.Name = "labelMatKhau";
            labelMatKhau.Size = new Size(186, 50);
            labelMatKhau.TabIndex = 37;
            labelMatKhau.Text = "Mật khẩu";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(26, 484);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(264, 50);
            labelNewPassword.TabIndex = 38;
            labelNewPassword.Text = "Mật khẩu mới";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(26, 554);
            textBoxNewPassword.Margin = new Padding(5);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(913, 50);
            textBoxNewPassword.TabIndex = 39;
            textBoxNewPassword.Text = "Mật khẩu mới";
            // 
            // labelXacNhanMatKhau
            // 
            labelXacNhanMatKhau.AutoSize = true;
            labelXacNhanMatKhau.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelXacNhanMatKhau.Location = new Point(26, 670);
            labelXacNhanMatKhau.Name = "labelXacNhanMatKhau";
            labelXacNhanMatKhau.Size = new Size(353, 50);
            labelXacNhanMatKhau.TabIndex = 40;
            labelXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(26, 741);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(913, 50);
            textBox1.TabIndex = 41;
            textBox1.Text = "Xác nhận mật khẩu mới (phải trùng với mật khẩu mới)";
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSavePassword.BackColor = Color.DodgerBlue;
            buttonSavePassword.FlatStyle = FlatStyle.Popup;
            buttonSavePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePassword.ForeColor = Color.White;
            buttonSavePassword.Location = new Point(304, 838);
            buttonSavePassword.Margin = new Padding(5);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(308, 50);
            buttonSavePassword.TabIndex = 42;
            buttonSavePassword.Text = "LƯU MẬT KHẨU";
            buttonSavePassword.UseVisualStyleBackColor = false;
            // 
            // buttonComeBack
            // 
            buttonComeBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonComeBack.BackColor = Color.Crimson;
            buttonComeBack.FlatStyle = FlatStyle.Popup;
            buttonComeBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonComeBack.ForeColor = Color.White;
            buttonComeBack.Location = new Point(784, 909);
            buttonComeBack.Margin = new Padding(5);
            buttonComeBack.Name = "buttonComeBack";
            buttonComeBack.Size = new Size(155, 50);
            buttonComeBack.TabIndex = 43;
            buttonComeBack.Text = "QUAY LẠI";
            buttonComeBack.UseVisualStyleBackColor = false;
            // 
            // SaleChangePassWord
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 973);
            Controls.Add(buttonComeBack);
            Controls.Add(buttonSavePassword);
            Controls.Add(textBox1);
            Controls.Add(labelXacNhanMatKhau);
            Controls.Add(textBoxNewPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(labelMatKhau);
            Controls.Add(textBoxPass);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SaleChangePassWord";
            Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBoxPass;
        private Label labelMatKhau;
        private Label labelNewPassword;
        private TextBox textBoxNewPassword;
        private Label labelXacNhanMatKhau;
        private TextBox textBox1;
        private Button buttonSavePassword;
        private Button buttonComeBack;
    }
}