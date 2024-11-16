namespace Design
{
    partial class LogOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOut));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            Logo = new PictureBox();
            label1 = new Label();
            buttonComeBack = new Button();
            buttonConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(0, 128);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(810, 3);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 37);
            label3.TabIndex = 41;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(297, 41);
            label2.TabIndex = 40;
            label2.Text = "Xác nhận đăng xuất";
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(375, 11);
            Logo.Margin = new Padding(2);
            Logo.Name = "Logo";
            Logo.Size = new Size(67, 58);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 39;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 203);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(680, 37);
            label1.TabIndex = 38;
            label1.Text = "Bạn có chắc chắn muốn đăng xuất khỏi tài khoản này?";
            // 
            // buttonComeBack
            // 
            buttonComeBack.BackColor = Color.Crimson;
            buttonComeBack.FlatStyle = FlatStyle.Popup;
            buttonComeBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonComeBack.ForeColor = Color.White;
            buttonComeBack.Location = new Point(468, 309);
            buttonComeBack.Name = "buttonComeBack";
            buttonComeBack.Size = new Size(190, 31);
            buttonComeBack.TabIndex = 37;
            buttonComeBack.Text = "QUAY LẠI";
            buttonComeBack.UseVisualStyleBackColor = false;
            buttonComeBack.Click += this.buttonComeBack_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.DodgerBlue;
            buttonConfirm.FlatStyle = FlatStyle.Popup;
            buttonConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(124, 309);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(190, 31);
            buttonConfirm.TabIndex = 36;
            buttonConfirm.Text = "XÁC NHẬN";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // LogOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Logo);
            Controls.Add(label1);
            Controls.Add(buttonComeBack);
            Controls.Add(buttonConfirm);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LogOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng xuất";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private PictureBox Logo;
        private Label label1;
        private Button buttonComeBack;
        private Button buttonConfirm;
    }
}