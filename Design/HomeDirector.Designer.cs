namespace Design
{
    partial class HomeDirector
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
            labelHome = new Label();
            groupBoxHome = new GroupBox();
            pictureBoxSubHome = new PictureBox();
            pictureBoxHomeMain = new PictureBox();
            labelDescribe = new Label();
            pictureBoxIconHome = new PictureBox();
            groupBoxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            SuspendLayout();
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.Location = new Point(102, 54);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 20;
            labelHome.Text = " TRANG CHỦ";
            // 
            // groupBoxHome
            // 
            groupBoxHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxHome.Controls.Add(pictureBoxSubHome);
            groupBoxHome.Controls.Add(pictureBoxHomeMain);
            groupBoxHome.Controls.Add(labelDescribe);
            groupBoxHome.Location = new Point(12, 102);
            groupBoxHome.Name = "groupBoxHome";
            groupBoxHome.Size = new Size(1183, 507);
            groupBoxHome.TabIndex = 18;
            groupBoxHome.TabStop = false;
            // 
            // pictureBoxSubHome
            // 
            pictureBoxSubHome.Image = Properties.Resources.SubHome;
            pictureBoxSubHome.Location = new Point(177, 590);
            pictureBoxSubHome.Name = "pictureBoxSubHome";
            pictureBoxSubHome.Size = new Size(941, 222);
            pictureBoxSubHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSubHome.TabIndex = 10;
            pictureBoxSubHome.TabStop = false;
            // 
            // pictureBoxHomeMain
            // 
            pictureBoxHomeMain.Image = Properties.Resources.HomeMain;
            pictureBoxHomeMain.Location = new Point(138, 82);
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
            labelDescribe.Location = new Point(253, 536);
            labelDescribe.Name = "labelDescribe";
            labelDescribe.Size = new Size(727, 31);
            labelDescribe.TabIndex = 9;
            labelDescribe.Text = "Quản lý hợp đồng hiệu quả - Nền tảng cho sự phát triển bền vững.";
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(12, 12);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 19;
            pictureBoxIconHome.TabStop = false;
            // 
            // HomeDirector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 906);
            Controls.Add(labelHome);
            Controls.Add(groupBoxHome);
            Controls.Add(pictureBoxIconHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeDirector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeDirector";
            groupBoxHome.ResumeLayout(false);
            groupBoxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHome;
        private GroupBox groupBoxHome;
        private PictureBox pictureBoxSubHome;
        private PictureBox pictureBoxHomeMain;
        private Label labelDescribe;
        private PictureBox pictureBoxIconHome;
    }
}