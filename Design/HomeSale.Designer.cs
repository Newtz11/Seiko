namespace Design
{
    partial class HomeSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSale));
            labelHome = new Label();
            pictureBoxHomeMain = new PictureBox();
            pictureBoxIconHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).BeginInit();
            SuspendLayout();
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.Location = new Point(177, 54);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(123, 25);
            labelHome.TabIndex = 15;
            labelHome.Text = " TRANG CHỦ";
            // 
            // pictureBoxHomeMain
            // 
            pictureBoxHomeMain.Image = Properties.Resources.HomeMain;
            pictureBoxHomeMain.Location = new Point(82, 127);
            pictureBoxHomeMain.Name = "pictureBoxHomeMain";
            pictureBoxHomeMain.Size = new Size(1021, 445);
            pictureBoxHomeMain.TabIndex = 8;
            pictureBoxHomeMain.TabStop = false;
            // 
            // pictureBoxIconHome
            // 
            pictureBoxIconHome.Image = Properties.Resources.Home;
            pictureBoxIconHome.Location = new Point(82, 12);
            pictureBoxIconHome.Name = "pictureBoxIconHome";
            pictureBoxIconHome.Size = new Size(72, 67);
            pictureBoxIconHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconHome.TabIndex = 13;
            pictureBoxIconHome.TabStop = false;
            // 
            // HomeSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1266, 951);
            Controls.Add(labelHome);
            Controls.Add(pictureBoxIconHome);
            Controls.Add(pictureBoxHomeMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeSale";
            Text = "Seiko";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomeMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonFinacialReports;
        private Label labelHome;
        private PictureBox pictureBoxHomeMain;
        private PictureBox pictureBoxIconHome;
    }
}