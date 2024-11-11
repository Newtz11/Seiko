namespace Design
{
    partial class HomeSuperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSuperAdmin));
            pictureBoxHomeMain = new PictureBox();
            pictureBoxSubHome = new PictureBox();
            labelHome = new Label();
            pictureBoxIconHome = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHomeMain
            // 
            pictureBoxHomeMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxHomeMain.Image = Properties.Resources.HomeMain;
            pictureBoxHomeMain.Location = new Point(236, -188);
            pictureBoxHomeMain.Name = "pictureBoxHomeMain";
            pictureBoxHomeMain.Size = new Size(215, 0);
            pictureBoxHomeMain.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxHomeMain.TabIndex = 8;
            pictureBoxHomeMain.TabStop = false;
            // 
            // pictureBoxSubHome
            // 
            pictureBoxSubHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxSubHome.Image = Properties.Resources.SubHome;
            pictureBoxSubHome.Location = new Point(-170, 543);
            pictureBoxSubHome.Name = "pictureBoxSubHome";
            pictureBoxSubHome.Size = new Size(71, 0);
            pictureBoxSubHome.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSubHome.TabIndex = 10;
            pictureBoxSubHome.TabStop = false;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.Location = new Point(107, 54);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 18;
            labelHome.Text = " TRANG CHỦ";
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(12, 12);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 17;
            pictureBoxIconHome.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.HomeMain;
            pictureBox1.Location = new Point(12, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1138, 483);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // HomeSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1266, 951);
            Controls.Add(labelHome);
            Controls.Add(pictureBoxIconHome);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxSubHome);
            Controls.Add(pictureBoxHomeMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeSuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += HomeSuperAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxSubHome;
        private PictureBox pictureBoxHomeMain;
        private Label labelHome;
        private PictureBox pictureBoxIconHome;
        private PictureBox pictureBox1;
    }
}