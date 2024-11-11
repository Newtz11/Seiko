namespace Design
{
    partial class ProjectSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSchedule));
            pictureBoxIconProjectSchedule = new PictureBox();
            labelProjectSchedule = new Label();
            groupBoxProjectSchedule = new GroupBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewProjectSchedule = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            tenHopDong = new DataGridViewTextBoxColumn();
            tienDoThucHien = new DataGridViewTextBoxColumn();
            trangThaiHopDong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconProjectSchedule).BeginInit();
            groupBoxProjectSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIconProjectSchedule
            // 
            pictureBoxIconProjectSchedule.Image = (Image)resources.GetObject("pictureBoxIconProjectSchedule.Image");
            pictureBoxIconProjectSchedule.Location = new Point(33, 12);
            pictureBoxIconProjectSchedule.Name = "pictureBoxIconProjectSchedule";
            pictureBoxIconProjectSchedule.Size = new Size(100, 100);
            pictureBoxIconProjectSchedule.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconProjectSchedule.TabIndex = 14;
            pictureBoxIconProjectSchedule.TabStop = false;
            // 
            // labelProjectSchedule
            // 
            labelProjectSchedule.AutoSize = true;
            labelProjectSchedule.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjectSchedule.Location = new Point(157, 87);
            labelProjectSchedule.Name = "labelProjectSchedule";
            labelProjectSchedule.Size = new Size(154, 25);
            labelProjectSchedule.TabIndex = 15;
            labelProjectSchedule.Text = "TIẾN ĐỘ DỰ ÁN ";
            labelProjectSchedule.Click += labelProjectSchedule_Click;
            // 
            // groupBoxProjectSchedule
            // 
            groupBoxProjectSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProjectSchedule.BackColor = Color.LightGray;
            groupBoxProjectSchedule.Controls.Add(buttonSearch);
            groupBoxProjectSchedule.Controls.Add(textBoxSearch);
            groupBoxProjectSchedule.Controls.Add(dataGridViewProjectSchedule);
            groupBoxProjectSchedule.Location = new Point(33, 141);
            groupBoxProjectSchedule.Name = "groupBoxProjectSchedule";
            groupBoxProjectSchedule.Size = new Size(1098, 762);
            groupBoxProjectSchedule.TabIndex = 17;
            groupBoxProjectSchedule.TabStop = false;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(803, 105);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 30);
            buttonSearch.TabIndex = 19;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(71, 106);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm ";
            textBoxSearch.Size = new Size(656, 30);
            textBoxSearch.TabIndex = 18;
            // 
            // dataGridViewProjectSchedule
            // 
            dataGridViewProjectSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProjectSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectSchedule.Columns.AddRange(new DataGridViewColumn[] { maHopDong, tenHopDong, tienDoThucHien, trangThaiHopDong });
            dataGridViewProjectSchedule.Location = new Point(71, 165);
            dataGridViewProjectSchedule.Name = "dataGridViewProjectSchedule";
            dataGridViewProjectSchedule.RowHeadersWidth = 51;
            dataGridViewProjectSchedule.Size = new Size(862, 554);
            dataGridViewProjectSchedule.TabIndex = 0;
            // 
            // maHopDong
            // 
            maHopDong.HeaderText = "Mã hợp đồng";
            maHopDong.MinimumWidth = 6;
            maHopDong.Name = "maHopDong";
            // 
            // tenHopDong
            // 
            tenHopDong.HeaderText = "Tên hợp đồng";
            tenHopDong.MinimumWidth = 6;
            tenHopDong.Name = "tenHopDong";
            // 
            // tienDoThucHien
            // 
            tienDoThucHien.HeaderText = "Tiến độ thực hiện";
            tienDoThucHien.MinimumWidth = 6;
            tienDoThucHien.Name = "tienDoThucHien";
            // 
            // trangThaiHopDong
            // 
            trangThaiHopDong.HeaderText = "Trạng thái hợp đồng";
            trangThaiHopDong.MinimumWidth = 6;
            trangThaiHopDong.Name = "trangThaiHopDong";
            // 
            // ProjectSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1266, 951);
            Controls.Add(groupBoxProjectSchedule);
            Controls.Add(labelProjectSchedule);
            Controls.Add(pictureBoxIconProjectSchedule);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProjectSchedule";
            Text = "Tiến độ dự án";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconProjectSchedule).EndInit();
            groupBoxProjectSchedule.ResumeLayout(false);
            groupBoxProjectSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxIconProjectSchedule;
        private Label labelProjectSchedule;
        private GroupBox groupBoxFeature;
        private Label labelSuperAdmin;
        private Button buttonUserList;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Button buttonFinacialReports;
        private Button buttonRole;
        private Button buttonCreateAccount;
        private Button buttonContractTracking;
        private Button buttonPerformanceReport;
        private Button buttonProjectSchedule;
        private Button buttonHome;
        private Button buttonInformation;
        private PictureBox pictureBoxSuperAdmin;
        private GroupBox groupBoxProjectSchedule;
        private DataGridView dataGridViewProjectSchedule;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn tenHopDong;
        private DataGridViewTextBoxColumn tienDoThucHien;
        private DataGridViewTextBoxColumn trangThaiHopDong;
    }
}