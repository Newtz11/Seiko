namespace Design
{
    partial class AccountantCreateContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantCreateContract));
            labelContractTracking = new Label();
            pictureBoxIconContractTracking = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            ColMaHopDong = new DataGridViewTextBoxColumn();
            ColTenHopDong = new DataGridViewTextBoxColumn();
            ColTenKhachHang = new DataGridViewTextBoxColumn();
            ColMucHoaHong = new DataGridViewTextBoxColumn();
            ColNgayHetHan = new DataGridViewTextBoxColumn();
            ColGiaTriHopDong = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            buttonCreate = new Button();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelContractTracking
            // 
            labelContractTracking.AutoSize = true;
            labelContractTracking.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContractTracking.Location = new Point(141, 76);
            labelContractTracking.Margin = new Padding(5, 0, 5, 0);
            labelContractTracking.Name = "labelContractTracking";
            labelContractTracking.Size = new Size(242, 40);
            labelContractTracking.TabIndex = 17;
            labelContractTracking.Text = "TẠO HỢP ĐỒNG";
            // 
            // pictureBoxIconContractTracking
            // 
            pictureBoxIconContractTracking.Image = (Image)resources.GetObject("pictureBoxIconContractTracking.Image");
            pictureBoxIconContractTracking.Location = new Point(14, 33);
            pictureBoxIconContractTracking.Margin = new Padding(5);
            pictureBoxIconContractTracking.Name = "pictureBoxIconContractTracking";
            pictureBoxIconContractTracking.Size = new Size(100, 100);
            pictureBoxIconContractTracking.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxIconContractTracking.TabIndex = 16;
            pictureBoxIconContractTracking.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(14, 1137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1985, 359);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColMaHopDong, ColTenHopDong, ColTenKhachHang, ColMucHoaHong, ColNgayHetHan, ColGiaTriHopDong });
            dataGridView1.Location = new Point(20, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1942, 145);
            dataGridView1.TabIndex = 16;
            // 
            // ColMaHopDong
            // 
            ColMaHopDong.HeaderText = "Mã hợp đồng";
            ColMaHopDong.MinimumWidth = 10;
            ColMaHopDong.Name = "ColMaHopDong";
            ColMaHopDong.Width = 300;
            // 
            // ColTenHopDong
            // 
            ColTenHopDong.HeaderText = "Tên hợp đồng";
            ColTenHopDong.MinimumWidth = 10;
            ColTenHopDong.Name = "ColTenHopDong";
            ColTenHopDong.Width = 300;
            // 
            // ColTenKhachHang
            // 
            ColTenKhachHang.HeaderText = "Tên khách hàng (công ty của người liên hệ đại diện)";
            ColTenKhachHang.MinimumWidth = 10;
            ColTenKhachHang.Name = "ColTenKhachHang";
            ColTenKhachHang.Width = 400;
            // 
            // ColMucHoaHong
            // 
            ColMucHoaHong.HeaderText = "Mức hoa hồng";
            ColMucHoaHong.MinimumWidth = 10;
            ColMucHoaHong.Name = "ColMucHoaHong";
            ColMucHoaHong.Width = 300;
            // 
            // ColNgayHetHan
            // 
            ColNgayHetHan.HeaderText = "Ngày hết hạn";
            ColNgayHetHan.MinimumWidth = 10;
            ColNgayHetHan.Name = "ColNgayHetHan";
            ColNgayHetHan.Width = 300;
            // 
            // ColGiaTriHopDong
            // 
            ColGiaTriHopDong.HeaderText = "Giá trị hợp đồng";
            ColGiaTriHopDong.MinimumWidth = 10;
            ColGiaTriHopDong.Name = "ColGiaTriHopDong";
            ColGiaTriHopDong.Width = 300;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(1987, 978);
            panel1.TabIndex = 44;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCreate.BackColor = Color.DodgerBlue;
            buttonCreate.FlatStyle = FlatStyle.Popup;
            buttonCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(1743, 37);
            buttonCreate.Margin = new Padding(5);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(217, 48);
            buttonCreate.TabIndex = 65;
            buttonCreate.Text = "TẠO";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(271, 906);
            textBox11.Margin = new Padding(5);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(1689, 44);
            textBox11.TabIndex = 64;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(337, 828);
            textBox10.Margin = new Padding(5);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(1623, 44);
            textBox10.TabIndex = 63;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(281, 742);
            textBox9.Margin = new Padding(5);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(1679, 44);
            textBox9.TabIndex = 62;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(360, 668);
            textBox8.Margin = new Padding(5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(1600, 44);
            textBox8.TabIndex = 61;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(322, 591);
            textBox7.Margin = new Padding(5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(1638, 44);
            textBox7.TabIndex = 60;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(322, 520);
            textBox6.Margin = new Padding(5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1638, 44);
            textBox6.TabIndex = 59;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(157, 444);
            textBox5.Margin = new Padding(5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(1803, 44);
            textBox5.TabIndex = 58;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(124, 359);
            textBox4.Margin = new Padding(5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1836, 44);
            textBox4.TabIndex = 57;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(727, 289);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1233, 44);
            textBox3.TabIndex = 56;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(245, 213);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1715, 44);
            textBox2.TabIndex = 55;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.No;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(245, 135);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1715, 44);
            textBox1.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 906);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(229, 40);
            label12.TabIndex = 53;
            label12.Text = "Trạng thái duyệt:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(22, 828);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(294, 40);
            label11.TabIndex = 52;
            label11.Text = "Hình thức thanh toán:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(944, 486);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 40);
            label10.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 746);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(233, 40);
            label9.TabIndex = 50;
            label9.Text = "Giá trị hợp đồng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 668);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(328, 40);
            label8.TabIndex = 49;
            label8.Text = "Ngày hết hạn hợp đồng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 520);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(276, 40);
            label7.TabIndex = 48;
            label7.Text = "Nội dung hợp đồng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 589);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(253, 40);
            label5.TabIndex = 47;
            label5.Text = "Ngày kí hợp đồng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 444);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 40);
            label4.TabIndex = 46;
            label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 363);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 40);
            label3.TabIndex = 45;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 289);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(677, 40);
            label2.TabIndex = 44;
            label2.Text = "Tên khách hàng (công ty của người liên hệ đại diện):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 213);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 43;
            label1.Text = "Tên hợp đồng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 135);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(197, 40);
            label6.TabIndex = 42;
            label6.Text = "Mã hợp đồng:";
            // 
            // AccountantCreateContract
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2434, 1596);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(labelContractTracking);
            Controls.Add(pictureBoxIconContractTracking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountantCreateContract";
            Text = "AccountantCreateContract";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconContractTracking).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelContractTracking;
        private PictureBox pictureBoxIconContractTracking;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColMaHopDong;
        private DataGridViewTextBoxColumn ColTenHopDong;
        private DataGridViewTextBoxColumn ColTenKhachHang;
        private DataGridViewTextBoxColumn ColMucHoaHong;
        private DataGridViewTextBoxColumn ColNgayHetHan;
        private DataGridViewTextBoxColumn ColGiaTriHopDong;
        private Panel panel1;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button buttonCreate;
    }
}