namespace Design
{
    partial class SaleManagerProjectProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManagerProjectProgress));
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridViewTienDoDuAn = new DataGridView();
            ColMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColTienDoThucHien = new DataGridViewTextBoxColumn();
            ColTrangThaiHopDong = new DataGridViewTextBoxColumn();
            label9 = new Label();
            buttonSearching = new Button();
            textBoxSearch = new TextBox();
            pictureBoxIconContractTracking = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTienDoDuAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buttonSearching);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(pictureBoxIconContractTracking);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(2404, 1521);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridViewTienDoDuAn);
            panel2.Location = new Point(29, 358);
            panel2.Name = "panel2";
            panel2.Size = new Size(1846, 1076);
            panel2.TabIndex = 50;
            // 
            // dataGridViewTienDoDuAn
            // 
            dataGridViewTienDoDuAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTienDoDuAn.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTienDoDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTienDoDuAn.Columns.AddRange(new DataGridViewColumn[] { ColMaHopDong, ColTenHopDong, ColTienDoThucHien, ColTrangThaiHopDong });
            dataGridViewTienDoDuAn.Location = new Point(74, 40);
            dataGridViewTienDoDuAn.Name = "dataGridViewTienDoDuAn";
            dataGridViewTienDoDuAn.RowHeadersWidth = 82;
            dataGridViewTienDoDuAn.Size = new Size(1684, 495);
            dataGridViewTienDoDuAn.TabIndex = 20;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(158, 153);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(235, 40);
            label9.TabIndex = 49;
            label9.Text = "TIẾN ĐỘ DỰ ÁN";
            // 
            // buttonSearching
            // 
            buttonSearching.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearching.BackColor = Color.DodgerBlue;
            buttonSearching.FlatStyle = FlatStyle.Popup;
            buttonSearching.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearching.ForeColor = Color.White;
            buttonSearching.Location = new Point(1587, 240);
            buttonSearching.Margin = new Padding(5);
            buttonSearching.Name = "buttonSearching";
            buttonSearching.Size = new Size(288, 44);
            buttonSearching.TabIndex = 48;
            buttonSearching.Text = "Tìm kiếm";
            buttonSearching.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(29, 240);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm hợp đồng danh sách ";
            textBoxSearch.Size = new Size(1294, 44);
            textBoxSearch.TabIndex = 47;
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(29, 93);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 46;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // TPSProjectProgress
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2408, 1525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TPSProjectProgress";
            Text = "Tiến độ dự án";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTienDoDuAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button buttonSearching;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxIconContractTracking;
        private Panel panel2;
        private DataGridView dataGridViewTienDoDuAn;
        private DataGridViewTextBoxColumn ColMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColTienDoThucHien;
        private DataGridViewTextBoxColumn ColTrangThaiHopDong;
    }
}