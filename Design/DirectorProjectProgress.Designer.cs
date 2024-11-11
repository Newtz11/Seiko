namespace Design
{
    partial class DirectorProjectProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorProjectProgress));
            pictureBoxIconContractTracking = new PictureBox();
            labelProjectProgress = new Label();
            textBoxSearch = new TextBox();
            buttonSearching = new Button();
            panel1 = new Panel();
            dataGridViewTienDoDuAn = new DataGridView();
            ColMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColTienDoThucHien = new DataGridViewTextBoxColumn();
            ColTrangThaiHopDong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTienDoDuAn).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(41, 66);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 17;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // labelProjectProgress
            // 
            labelProjectProgress.AutoSize = true;
            labelProjectProgress.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjectProgress.Location = new Point(184, 126);
            labelProjectProgress.Margin = new Padding(5, 0, 5, 0);
            labelProjectProgress.Name = "labelProjectProgress";
            labelProjectProgress.Size = new Size(235, 40);
            labelProjectProgress.TabIndex = 25;
            labelProjectProgress.Text = "TIẾN ĐỘ DỰ ÁN";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(197, 211);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1294, 44);
            textBoxSearch.TabIndex = 26;
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1599, 211);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 44);
            buttonSearching.TabIndex = 31;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dataGridViewTienDoDuAn);
            panel1.Location = new Point(41, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(1846, 1076);
            panel1.TabIndex = 32;
            // 
            // dataGridViewTienDoDuAn
            // 
            dataGridViewTienDoDuAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTienDoDuAn.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTienDoDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTienDoDuAn.Columns.AddRange(new DataGridViewColumn[] { ColMaHopDong, ColTenHopDong, ColTienDoThucHien, ColTrangThaiHopDong });
            dataGridViewTienDoDuAn.Location = new Point(81, 70);
            dataGridViewTienDoDuAn.Name = "dataGridViewTienDoDuAn";
            dataGridViewTienDoDuAn.RowHeadersWidth = 82;
            dataGridViewTienDoDuAn.Size = new Size(1686, 495);
            dataGridViewTienDoDuAn.TabIndex = 24;
            // 
            // ColMaHopDong
            // 
            ColMaHopDong.HeaderText = "Mã hợp đồng";
            ColMaHopDong.MinimumWidth = 10;
            ColMaHopDong.Name = "ColMaHopDong";
            ColMaHopDong.Width = 400;
            // 
            // ColTenHopDong
            // 
            ColTenHopDong.HeaderText = "Tên hợp đồng";
            ColTenHopDong.MinimumWidth = 10;
            ColTenHopDong.Name = "ColTenHopDong";
            ColTenHopDong.Width = 400;
            // 
            // ColTienDoThucHien
            // 
            ColTienDoThucHien.HeaderText = "Tiến độ thực hiện";
            ColTienDoThucHien.MinimumWidth = 10;
            ColTienDoThucHien.Name = "ColTienDoThucHien";
            ColTienDoThucHien.Width = 400;
            // 
            // ColTrangThaiHopDong
            // 
            ColTrangThaiHopDong.HeaderText = "Trạng thái hợp đồng";
            ColTrangThaiHopDong.MinimumWidth = 10;
            ColTrangThaiHopDong.Name = "ColTrangThaiHopDong";
            ColTrangThaiHopDong.Width = 400;
            // 
            // GDProjectProgress
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            Controls.Add(buttonSearching);
            Controls.Add(textBoxSearch);
            Controls.Add(labelProjectProgress);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GDProjectProgress";
            Text = "Tiến độ dự án";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTienDoDuAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconContractTracking;
        private Label labelProjectProgress;
        private TextBox textBoxSearch;
        private Button buttonSearching;
        private Panel panel1;
        private DataGridView dataGridViewTienDoDuAn;
        private DataGridViewTextBoxColumn ColMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColTienDoThucHien;
        private DataGridViewTextBoxColumn ColTrangThaiHopDong;
    }
}