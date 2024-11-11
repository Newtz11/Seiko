namespace Design
{
    partial class GDLogOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDLogOut));
            buttonConfirm = new Button();
            buttonComeBack = new Button();
            label1 = new Label();
            Logo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            GDLouOut = new GroupBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            GDLouOut.SuspendLayout();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.DodgerBlue;
            buttonConfirm.FlatStyle = FlatStyle.Popup;
            buttonConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(199, 698);
            buttonConfirm.Margin = new Padding(5);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(308, 50);
            buttonConfirm.TabIndex = 29;
            buttonConfirm.Text = "XÁC NHẬN";
            buttonConfirm.UseVisualStyleBackColor = false;
            // 
            // buttonComeBack
            // 
            buttonComeBack.BackColor = Color.Crimson;
            buttonComeBack.FlatStyle = FlatStyle.Popup;
            buttonComeBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonComeBack.ForeColor = Color.White;
            buttonComeBack.Location = new Point(758, 698);
            buttonComeBack.Margin = new Padding(5);
            buttonComeBack.Name = "buttonComeBack";
            buttonComeBack.Size = new Size(308, 50);
            buttonComeBack.TabIndex = 30;
            buttonComeBack.Text = "QUAY LẠI";
            buttonComeBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 528);
            label1.Name = "label1";
            label1.Size = new Size(1083, 59);
            label1.TabIndex = 31;
            label1.Text = "Bạn có chắc chắn muốn đăng xuất khỏi tài khoản này?";
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(602, 24);
            Logo.Name = "Logo";
            Logo.Size = new Size(109, 93);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 32;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(417, 184);
            label2.Name = "label2";
            label2.Size = new Size(476, 65);
            label2.TabIndex = 33;
            label2.Text = "Xác nhận đăng xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(417, 435);
            label3.Name = "label3";
            label3.Size = new Size(0, 59);
            label3.TabIndex = 34;
            label3.Click += label3_Click;
            // 
            // GDLouOut
            // 
            GDLouOut.Anchor = AnchorStyles.Top;
            GDLouOut.BackColor = SystemColors.ControlLightLight;
            GDLouOut.Controls.Add(panel1);
            GDLouOut.Controls.Add(groupBox1);
            GDLouOut.Controls.Add(label3);
            GDLouOut.Controls.Add(label2);
            GDLouOut.Controls.Add(Logo);
            GDLouOut.Controls.Add(label1);
            GDLouOut.Controls.Add(buttonComeBack);
            GDLouOut.Controls.Add(buttonConfirm);
            GDLouOut.Location = new Point(12, 2);
            GDLouOut.Name = "GDLouOut";
            GDLouOut.Size = new Size(1302, 854);
            GDLouOut.TabIndex = 0;
            GDLouOut.TabStop = false;
            GDLouOut.Enter += GDLouOut_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(1308, 3);
            panel1.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(101, 453);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(925, 10);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // GDLogOut
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 868);
            Controls.Add(GDLouOut);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GDLogOut";
            Text = "Đăng xuất";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            GDLouOut.ResumeLayout(false);
            GDLouOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonComeBack;
        private Label label1;
        private PictureBox Logo;
        private Label label2;
        private Label label3;
        private GroupBox GDLouOut;
        private GroupBox groupBox1;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}