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
            groupBoxCreatePassword = new GroupBox();
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
            pictureBoxLogo0 = new PictureBox();
            groupBoxCreatePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            SuspendLayout();
            // 
            // labelCreatePassword
            // 
            labelCreatePassword.AutoSize = true;
            labelCreatePassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreatePassword.Location = new Point(203, 107);
            labelCreatePassword.Margin = new Padding(5, 0, 5, 0);
            labelCreatePassword.Name = "labelCreatePassword";
            labelCreatePassword.Size = new Size(397, 65);
            labelCreatePassword.TabIndex = 2;
            labelCreatePassword.Text = "TẠO MẬT KHẨU";
            labelCreatePassword.Click += labelCreatePassword_Click;
            // 
            // groupBoxCreatePassword
            // 
            groupBoxCreatePassword.Controls.Add(buttonShowPassword2);
            groupBoxCreatePassword.Controls.Add(buttonHidePassword2);
            groupBoxCreatePassword.Controls.Add(buttonShowPassword1);
            groupBoxCreatePassword.Controls.Add(buttonHidePassword1);
            groupBoxCreatePassword.Controls.Add(buttonCancel);
            groupBoxCreatePassword.Controls.Add(buttonSavePassword);
            groupBoxCreatePassword.Controls.Add(textBoxConfirmPassword);
            groupBoxCreatePassword.Controls.Add(textBoxNewPassword);
            groupBoxCreatePassword.Controls.Add(labelConfirmPassword);
            groupBoxCreatePassword.Controls.Add(labelNewPassword);
            groupBoxCreatePassword.Location = new Point(-132, 192);
            groupBoxCreatePassword.Margin = new Padding(5);
            groupBoxCreatePassword.Name = "groupBoxCreatePassword";
            groupBoxCreatePassword.Padding = new Padding(5);
            groupBoxCreatePassword.Size = new Size(918, 539);
            groupBoxCreatePassword.TabIndex = 3;
            groupBoxCreatePassword.TabStop = false;
            // 
            // buttonShowPassword2
            // 
            buttonShowPassword2.Image = Properties.Resources.show__1_;
            buttonShowPassword2.Location = new Point(842, 286);
            buttonShowPassword2.Margin = new Padding(5);
            buttonShowPassword2.Name = "buttonShowPassword2";
            buttonShowPassword2.Size = new Size(54, 48);
            buttonShowPassword2.TabIndex = 16;
            buttonShowPassword2.UseVisualStyleBackColor = true;
            // 
            // buttonHidePassword2
            // 
            buttonHidePassword2.Image = Properties.Resources.hide__1_;
            buttonHidePassword2.Location = new Point(840, 286);
            buttonHidePassword2.Margin = new Padding(5);
            buttonHidePassword2.Name = "buttonHidePassword2";
            buttonHidePassword2.Size = new Size(55, 48);
            buttonHidePassword2.TabIndex = 15;
            buttonHidePassword2.UseVisualStyleBackColor = true;
            // 
            // buttonShowPassword1
            // 
            buttonShowPassword1.Image = Properties.Resources.show__1_;
            buttonShowPassword1.Location = new Point(843, 123);
            buttonShowPassword1.Margin = new Padding(5);
            buttonShowPassword1.Name = "buttonShowPassword1";
            buttonShowPassword1.Size = new Size(52, 48);
            buttonShowPassword1.TabIndex = 14;
            buttonShowPassword1.UseVisualStyleBackColor = true;
            buttonShowPassword1.Click += buttonShowPassword1_Click;
            // 
            // buttonHidePassword1
            // 
            buttonHidePassword1.Image = Properties.Resources.hide__1_;
            buttonHidePassword1.Location = new Point(842, 123);
            buttonHidePassword1.Margin = new Padding(5);
            buttonHidePassword1.Name = "buttonHidePassword1";
            buttonHidePassword1.Size = new Size(54, 48);
            buttonHidePassword1.TabIndex = 13;
            buttonHidePassword1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.BackColor = Color.Crimson;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(757, 467);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(138, 42);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSavePassword.BackColor = Color.DodgerBlue;
            buttonSavePassword.FlatStyle = FlatStyle.Popup;
            buttonSavePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePassword.ForeColor = Color.White;
            buttonSavePassword.Location = new Point(416, 368);
            buttonSavePassword.Margin = new Padding(5);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new Size(240, 66);
            buttonSavePassword.TabIndex = 11;
            buttonSavePassword.Text = "LƯU MẬT KHẨU";
            buttonSavePassword.UseVisualStyleBackColor = false;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(151, 286);
            textBoxConfirmPassword.Margin = new Padding(5);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Xác nhận mật khẩu mới (phải trùng với mật khẩu mới )";
            textBoxConfirmPassword.Size = new Size(742, 44);
            textBoxConfirmPassword.TabIndex = 7;
            textBoxConfirmPassword.TextChanged += textBoxConfirmPassword_TextChanged;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(151, 123);
            textBoxNewPassword.Margin = new Padding(5);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "Mật khẩu mới";
            textBoxNewPassword.Size = new Size(742, 44);
            textBoxNewPassword.TabIndex = 6;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.Location = new Point(167, 214);
            labelConfirmPassword.Margin = new Padding(5, 0, 5, 0);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(305, 45);
            labelConfirmPassword.TabIndex = 5;
            labelConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(167, 56);
            labelNewPassword.Margin = new Padding(5, 0, 5, 0);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(229, 45);
            labelNewPassword.TabIndex = 4;
            labelNewPassword.Text = "Mật khẩu mới";
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Image = Properties.Resources.logo0;
            pictureBoxLogo0.Location = new Point(364, 19);
            pictureBoxLogo0.Margin = new Padding(5);
            pictureBoxLogo0.Name = "pictureBoxLogo0";
            pictureBoxLogo0.Size = new Size(43, 43);
            pictureBoxLogo0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo0.TabIndex = 3;
            pictureBoxLogo0.TabStop = false;
            // 
            // CreatePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 725);
            Controls.Add(pictureBoxLogo0);
            Controls.Add(groupBoxCreatePassword);
            Controls.Add(labelCreatePassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "CreatePassword";
            Text = "Tạo mật khẩu";
            groupBoxCreatePassword.ResumeLayout(false);
            groupBoxCreatePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCreatePassword;
        private GroupBox groupBoxCreatePassword;
        private PictureBox pictureBoxLogo0;
        private Label labelNewPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxNewPassword;
        private Button buttonCancel;
        private Button buttonSavePassword;
        private Button buttonHidePassword1;
        private Button buttonShowPassword1;
        private Button buttonShowPassword2;
        private Button buttonHidePassword2;
    }
}