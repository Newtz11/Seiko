namespace Design
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBoxLogo0 = new PictureBox();
            labelLoginName = new Label();
            labelPassword = new Label();
            textBoxLoginName = new TextBox();
            textBoxPassword = new TextBox();
            buttonHidePassword = new Button();
            buttonShowPassword = new Button();
            linkLabelForgotPassword = new LinkLabel();
            buttonLogin = new Button();
            pictureBox1 = new PictureBox();
            labelHello = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo0
            // 
            pictureBoxLogo0.Anchor = AnchorStyles.None;
            pictureBoxLogo0.Image = (Image)resources.GetObject("pictureBoxLogo0.Image");
            pictureBoxLogo0.Location = new Point(691, 66);
            pictureBoxLogo0.Name = "pictureBoxLogo0";
            pictureBoxLogo0.Size = new Size(50, 50);
            pictureBoxLogo0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo0.TabIndex = 2;
            pictureBoxLogo0.TabStop = false;
            pictureBoxLogo0.Click += pictureBoxLogo0_Click;
            // 
            // labelLoginName
            // 
            labelLoginName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelLoginName.AutoSize = true;
            labelLoginName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoginName.Location = new Point(482, 138);
            labelLoginName.Name = "labelLoginName";
            labelLoginName.Size = new Size(152, 28);
            labelLoginName.TabIndex = 3;
            labelLoginName.Text = "Tên đăng nhập";
            labelLoginName.Click += label1_Click;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(482, 243);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(102, 28);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Mật khẩu";
            // 
            // textBoxLoginName
            // 
            textBoxLoginName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLoginName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginName.Location = new Point(456, 183);
            textBoxLoginName.MaxLength = 50;
            textBoxLoginName.Name = "textBoxLoginName";
            textBoxLoginName.PlaceholderText = "Nhập tên đăng nhập";
            textBoxLoginName.Size = new Size(494, 34);
            textBoxLoginName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(456, 295);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Nhập mật khẩu";
            textBoxPassword.Size = new Size(494, 34);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBox1_TextChanged;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // buttonHidePassword
            // 
            buttonHidePassword.Anchor = AnchorStyles.Right;
            buttonHidePassword.Image = Properties.Resources.hide__1_;
            buttonHidePassword.Location = new Point(908, 295);
            buttonHidePassword.Name = "buttonHidePassword";
            buttonHidePassword.Size = new Size(42, 34);
            buttonHidePassword.TabIndex = 7;
            buttonHidePassword.UseVisualStyleBackColor = true;
            buttonHidePassword.Click += buttonHidePassword_Click;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.Anchor = AnchorStyles.Right;
            buttonShowPassword.Image = Properties.Resources.show__1_;
            buttonShowPassword.Location = new Point(908, 295);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(42, 34);
            buttonShowPassword.TabIndex = 8;
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // linkLabelForgotPassword
            // 
            linkLabelForgotPassword.Anchor = AnchorStyles.Right;
            linkLabelForgotPassword.AutoSize = true;
            linkLabelForgotPassword.LinkColor = Color.Blue;
            linkLabelForgotPassword.Location = new Point(815, 345);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(116, 20);
            linkLabelForgotPassword.TabIndex = 9;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Quên mật khẩu?";
            linkLabelForgotPassword.LinkClicked += linkLabelForgotPassword_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.BackColor = Color.DodgerBlue;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(640, 387);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(148, 41);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "ĐĂNG NHẬP";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Image = Properties.Resources._0logo;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelHello
            // 
            labelHello.Anchor = AnchorStyles.None;
            labelHello.AutoSize = true;
            labelHello.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHello.Location = new Point(629, 22);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(176, 41);
            labelHello.TabIndex = 12;
            labelHello.Text = "XIN CHÀO!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 453);
            Controls.Add(labelHello);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogin);
            Controls.Add(linkLabelForgotPassword);
            Controls.Add(buttonShowPassword);
            Controls.Add(buttonHidePassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLoginName);
            Controls.Add(labelPassword);
            Controls.Add(labelLoginName);
            Controls.Add(pictureBoxLogo0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxLogo0;
        private Label labelLoginName;
        private Label labelPassword;
        private TextBox textBoxLoginName;
        private TextBox textBoxPassword;
        private Button buttonHidePassword;
        private Button buttonShowPassword;
        private LinkLabel linkLabelForgotPassword;
        private Button buttonLogin;
        private PictureBox pictureBox1;
        private Label labelHello;
    }
}