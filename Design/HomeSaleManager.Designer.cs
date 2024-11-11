namespace Design
{
    partial class HomeSaleManager
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
            groupBoxHome = new GroupBox();
            pictureBoxSubHome = new PictureBox();
            pictureBoxHomeMain = new PictureBox();
            labelDescribe = new Label();
            labelHome = new Label();
            pictureBoxIconHome = new PictureBox();
            groupBoxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHome
            // 
            groupBoxHome.Controls.Add(pictureBoxSubHome);
            groupBoxHome.Controls.Add(pictureBoxHomeMain);
            groupBoxHome.Controls.Add(labelDescribe);
            groupBoxHome.Location = new Point(34, 97);
            groupBoxHome.Name = "groupBoxHome";
            groupBoxHome.Size = new Size(1211, 826);
            groupBoxHome.TabIndex = 26;
            groupBoxHome.TabStop = false;
            groupBoxHome.Text = "Trang chủ";
            // 
            // pictureBoxSubHome
            // 
            pictureBoxSubHome.Image = Properties.Resources.SubHome;
            pictureBoxSubHome.Location = new Point(173, 586);
            pictureBoxSubHome.Name = "pictureBoxSubHome";
            pictureBoxSubHome.Size = new Size(941, 222);
            pictureBoxSubHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSubHome.TabIndex = 10;
            pictureBoxSubHome.TabStop = false;
            // 
            // pictureBoxHomeMain
            // 
            pictureBoxHomeMain.Image = Properties.Resources.HomeMain;
            pictureBoxHomeMain.Location = new Point(134, 78);
            pictureBoxHomeMain.Name = "pictureBoxHomeMain";
            pictureBoxHomeMain.Size = new Size(1021, 432);
            pictureBoxHomeMain.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxHomeMain.TabIndex = 8;
            pictureBoxHomeMain.TabStop = false;
            // 
            // labelDescribe
            // 
            labelDescribe.AutoSize = true;
            labelDescribe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescribe.Location = new Point(249, 532);
            labelDescribe.Name = "labelDescribe";
            labelDescribe.Size = new Size(727, 31);
            labelDescribe.TabIndex = 9;
            labelDescribe.Text = "Quản lý hợp đồng hiệu quả - Nền tảng cho sự phát triển bền vững.";
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.Location = new Point(101, 54);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 25;
            labelHome.Text = " TRANG CHỦ";
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(23, 12);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 24;
            pictureBoxIconHome.TabStop = false;
            // 
            // HomeSaleManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 951);
            Controls.Add(groupBoxHome);
            Controls.Add(labelHome);
            Controls.Add(pictureBoxIconHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeSaleManager";
            Text = "HomeSaleManager";
            groupBoxHome.ResumeLayout(false);
            groupBoxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxHome;
        private PictureBox pictureBoxSubHome;
        private PictureBox pictureBoxHomeMain;
        private Label labelDescribe;
        private Label labelHome;
        private PictureBox pictureBoxIconHome;
    }
}