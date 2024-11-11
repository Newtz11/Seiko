namespace Design
{
    partial class SAListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAListUser));
            pictureBoxIconListUser = new PictureBox();
            labelListUser = new Label();
            groupBoxListUser = new GroupBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewListUser = new DataGridView();
            soThuTu = new DataGridViewTextBoxColumn();
            tenNguoiDung = new DataGridViewTextBoxColumn();
            phongBan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconListUser).BeginInit();
            groupBoxListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListUser).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconListUser
            // 
            pictureBoxIconListUser.Image = (Image)resources.GetObject("pictureBoxIconListUser.Image");
            pictureBoxIconListUser.Location = new Point(118, 35);
            pictureBoxIconListUser.Margin = new Padding(5);
            pictureBoxIconListUser.Name = "pictureBoxIconListUser";
            pictureBoxIconListUser.Size = new Size(100, 100);
            pictureBoxIconListUser.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconListUser.TabIndex = 12;
            pictureBoxIconListUser.TabStop = false;
            // 
            // labelListUser
            // 
            labelListUser.AutoSize = true;
            labelListUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListUser.Location = new Point(253, 95);
            labelListUser.Margin = new Padding(5, 0, 5, 0);
            labelListUser.Name = "labelListUser";
            labelListUser.Size = new Size(388, 40);
            labelListUser.TabIndex = 13;
            labelListUser.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // groupBoxListUser
            // 
            groupBoxListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxListUser.BackColor = Color.LightGray;
            groupBoxListUser.Controls.Add(buttonSearch);
            groupBoxListUser.Controls.Add(textBoxSearch);
            groupBoxListUser.Controls.Add(dataGridViewListUser);
            groupBoxListUser.Location = new Point(118, 162);
            groupBoxListUser.Margin = new Padding(5);
            groupBoxListUser.Name = "groupBoxListUser";
            groupBoxListUser.Padding = new Padding(5);
            groupBoxListUser.Size = new Size(845, 1070);
            groupBoxListUser.TabIndex = 15;
            groupBoxListUser.TabStop = false;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(596, 42);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(172, 53);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(101, 46);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm người dùng trong danh sách ";
            textBoxSearch.Size = new Size(511, 44);
            textBoxSearch.TabIndex = 16;
            // 
            // dataGridViewListUser
            // 
            dataGridViewListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewListUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListUser.BackgroundColor = Color.Silver;
            dataGridViewListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListUser.Columns.AddRange(new DataGridViewColumn[] { soThuTu, tenNguoiDung, phongBan });
            dataGridViewListUser.Location = new Point(73, 112);
            dataGridViewListUser.Margin = new Padding(5);
            dataGridViewListUser.Name = "dataGridViewListUser";
            dataGridViewListUser.RowHeadersWidth = 51;
            dataGridViewListUser.Size = new Size(696, 923);
            dataGridViewListUser.TabIndex = 15;
            // 
            // soThuTu
            // 
            soThuTu.HeaderText = "#";
            soThuTu.MinimumWidth = 6;
            soThuTu.Name = "soThuTu";
            // 
            // tenNguoiDung
            // 
            tenNguoiDung.HeaderText = "Tên người dùng";
            tenNguoiDung.MinimumWidth = 6;
            tenNguoiDung.Name = "tenNguoiDung";
            // 
            // phongBan
            // 
            phongBan.HeaderText = "Phòng ban";
            phongBan.MinimumWidth = 6;
            phongBan.Name = "phongBan";
            // 
            // SAListUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1531, 1525);
            Controls.Add(groupBoxListUser);
            Controls.Add(labelListUser);
            Controls.Add(pictureBoxIconListUser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "SAListUser";
            Text = "Danh sách người dùng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconListUser).EndInit();
            groupBoxListUser.ResumeLayout(false);
            groupBoxListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconListUser;
        private Label labelListUser;
        private GroupBox groupBoxListUser;
        private DataGridView dataGridViewListUser;
        private DataGridViewTextBoxColumn soThuTu;
        private DataGridViewTextBoxColumn tenNguoiDung;
        private DataGridViewTextBoxColumn phongBan;
        private TextBox textBoxSearch;
        private Button buttonSearch;
    }
}