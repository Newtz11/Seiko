﻿namespace Design
{
    partial class AccountantUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantUserInfo));
            pictureBox4 = new PictureBox();
            labelUserInfo = new Label();
            panel1 = new Panel();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            buttonLuu = new Button();
            buttonChinhSua = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // labelUserInfo
            // 
            labelUserInfo.AutoSize = true;
            labelUserInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserInfo.Location = new Point(99, 62);
            labelUserInfo.Name = "labelUserInfo";
            labelUserInfo.Size = new Size(203, 25);
            labelUserInfo.TabIndex = 24;
            labelUserInfo.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dataGridView4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(buttonLuu);
            panel1.Controls.Add(buttonChinhSua);
            panel1.Location = new Point(15, 101);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 472);
            panel1.TabIndex = 25;
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22, dataGridViewTextBoxColumn23, dataGridViewTextBoxColumn24 });
            dataGridView4.Location = new Point(191, 594);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(604, 0);
            dataGridView4.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.HeaderText = "Chức vụ";
            dataGridViewTextBoxColumn21.MinimumWidth = 6;
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.HeaderText = "Phòng ban";
            dataGridViewTextBoxColumn22.MinimumWidth = 6;
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.HeaderText = "Ngày vào làm";
            dataGridViewTextBoxColumn23.MinimumWidth = 6;
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.HeaderText = "Trạng thái công việc(Đang hoạt động, tạm thời, đã nghỉ việc)";
            dataGridViewTextBoxColumn24.MinimumWidth = 6;
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 594);
            label8.Name = "label8";
            label8.Size = new Size(172, 25);
            label8.TabIndex = 46;
            label8.Text = "Thông tin công việc:";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20 });
            dataGridView3.Location = new Point(191, 436);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(604, 0);
            dataGridView3.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Mã nhân viên";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Họ và tên";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Ngày tháng năm sinh";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Giới tính";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Số điện thoại";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "Email cá nhân";
            dataGridViewTextBoxColumn19.MinimumWidth = 6;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.HeaderText = "Chức vụ";
            dataGridViewTextBoxColumn20.MinimumWidth = 6;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 436);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 44;
            label7.Text = "Thông tin cá nhân:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(230, 204);
            button1.Name = "button1";
            button1.Size = new Size(186, 35);
            button1.TabIndex = 43;
            button1.Text = "Đổi mật khẩu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(337, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 30);
            textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(337, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 30);
            textBox2.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 291);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 40;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 236);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 39;
            label5.Text = "Tên đăng nhập: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 236);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 37;
            label6.Text = "Thông tin tài khoản:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DodgerBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(404, 9);
            button2.Name = "button2";
            button2.Size = new Size(233, 31);
            button2.TabIndex = 38;
            button2.Text = "THAY ĐỔI ẢNH ĐẠI DIỆN ";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.avatar;
            pictureBox3.Location = new Point(618, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // buttonLuu
            // 
            buttonLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLuu.BackColor = Color.DodgerBlue;
            buttonLuu.FlatStyle = FlatStyle.Popup;
            buttonLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLuu.ForeColor = Color.White;
            buttonLuu.Location = new Point(790, 21);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(116, 31);
            buttonLuu.TabIndex = 35;
            buttonLuu.Text = "LƯU";
            buttonLuu.UseVisualStyleBackColor = false;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonChinhSua.BackColor = Color.DodgerBlue;
            buttonChinhSua.FlatStyle = FlatStyle.Popup;
            buttonChinhSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChinhSua.ForeColor = Color.White;
            buttonChinhSua.Location = new Point(640, 21);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(116, 31);
            buttonChinhSua.TabIndex = 34;
            buttonChinhSua.Text = "CHỈNH SỬA";
            buttonChinhSua.UseVisualStyleBackColor = false;
            // 
            // AccountantUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 689);
            Controls.Add(panel1);
            Controls.Add(labelUserInfo);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AccountantUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox4;
        private Label labelUserInfo;
        private Panel panel1;
        private Button buttonLuu;
        private Button buttonChinhSua;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private PictureBox pictureBox3;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private Label label8;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private Label label7;
    }
}