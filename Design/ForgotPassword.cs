using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Design
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonConfirmOTP);
            ApplyRoundedCorners(buttonSendOTP);
            ApplyRoundedCorners(buttonBack);
        }

        // Hàm để tạo vùng hình chữ nhật có góc bo tròn
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // Tọa độ x của góc trên bên trái
            int nTopRect,  // Tọa độ y của góc trên bên trái
            int nRightRect, // Tọa độ x của góc dưới bên phải
            int nBottomRect, // Tọa độ y của góc dưới bên phải
            int nWidthEllipse, // Bán kính bo tròn theo chiều ngang
            int nHeightEllipse // Bán kính bo tròn theo chiều dọc
        );

        // Hàm áp dụng bo góc cho nút
        private void ApplyRoundedCorners(Button button)
        {
            // Loại bỏ viền mặc định của nút
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Tạo vùng hình chữ nhật có góc bo tròn
            IntPtr hRgn = CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15);
            button.Region = Region.FromHrgn(hRgn);
        }

        private void labelCreatePassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string verificationCode;
        private void buttonSendOTP_Click(object sender, EventArgs e)
        {
            timerVCode.Stop();
            string to, from, pass;
            to = textBoxEmail.Text.ToString();
            from = "seikoapplication@gmail.com";
            verificationCode = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";
            pass = "kxff xduw vtgt xecl";
            MailMessage mess = new MailMessage();
            mess.To.Add(to);
            mess.From = new MailAddress(from);
            mess.Subject = "Seiko - Reset Password Verified Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                mess.Body = "Your Reset Password Verification Code is: " + verificationCode;
                smtp.Send(mess);
                MessageBox.Show("Verified Code sent successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void timerVCode_Tick(object sender, EventArgs e)
        {
            
        }

        private void buttonConfirmOTP_Click(object sender, EventArgs e)
        {
            if (verificationCode.Equals(textBoxOTP.Text.ToString())) 
            {
                CreatePassword fCreatePassword = new CreatePassword();
                this.Close();
                fCreatePassword.Show();
            }
            else
            {
                MessageBox.Show("Wrong verified code please try again!");
            }
        }

        
    }
}
