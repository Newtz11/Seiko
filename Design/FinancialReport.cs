using BLL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Design
{
    public partial class FinancialReport : System.Windows.Forms.Form
    {
        private long tongDoanhThu = 0;
        public FinancialReport()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonLapThongKe);
            ApplyRoundedCorners(buttonCapNhat);
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

        private void groupBoxListUser_Enter(object sender, EventArgs e)
        {

        }

        private void FinancialReport_Load(object sender, EventArgs e)
        {
            dataGridViewFinancial.Rows.Clear();
            DataTable dt = HopDongBLL.loadFinancialReport();
            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row[0].ToString();
                string tenHopDong = row[1].ToString();
                string ngayThanhToan = ((DateTime)row[2]).ToString("dd/MM/yyyy");
                string doanhThu = row[3].ToString();
                dataGridViewFinancial.Rows.Add(maHopDong, tenHopDong, ngayThanhToan, doanhThu);
            }
            chartFinancialReport.Series["Doanh Thu"].IsValueShownAsLabel = true;
            chartFinancialReport.Series["Doanh Thu"].LabelFormat = "{0:N0} VND";
        }

        private void radioButtonThang_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tháng 1");
            comboBox1.Items.Add("Tháng 2");
            comboBox1.Items.Add("Tháng 3");
            comboBox1.Items.Add("Tháng 4");
            comboBox1.Items.Add("Tháng 5");
            comboBox1.Items.Add("Tháng 6");
            comboBox1.Items.Add("Tháng 7");
            comboBox1.Items.Add("Tháng 8");
            comboBox1.Items.Add("Tháng 9");
            comboBox1.Items.Add("Tháng 10");
            comboBox1.Items.Add("Tháng 11");
            comboBox1.Items.Add("Tháng 12");
        }

        private void radioButtonQuy_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Quý 1");
            comboBox1.Items.Add("Quý 2");
            comboBox1.Items.Add("Quý 3");
            comboBox1.Items.Add("Quý 4");
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DataTable dt = HopDongBLL.getAllYear();
            foreach (DataRow dr in dt.Rows)
            {
                string year = dr[0].ToString();
                comboBox1.Items.Add(year);
            }
        }

        private void buttonLapThongKe_Click(object sender, EventArgs e)
        {
            chartFinancialReport.Series["Doanh Thu"].Points.Clear();
            if (radioButtonThang.Checked)
            {
                //lap thong ke theo thang
                string thang = comboBox1.Text;
                DataTable dt = HopDongBLL.getChartByMonth(thang);
                foreach (DataRow dr in dt.Rows)
                {
                    tongDoanhThu += long.Parse(dr[3].ToString());
                }
                chartFinancialReport.Series["Doanh Thu"].Points.AddXY(thang, tongDoanhThu);
                chartFinancialReport.Visible = true;
                tongDoanhThu = 0;
            }
            else if (radioButtonQuy.Checked)
            {
                string quy = comboBox1.Text;
                DataTable dt = HopDongBLL.getChartByQuater(quy);

                int startMonth, endMonth;

                switch (quy)
                {
                    case "Quý 1":
                        startMonth = 1;
                        endMonth = 3;
                        break;
                    case "Quý 2":
                        startMonth = 4;
                        endMonth = 6;
                        break;
                    case "Quý 3":
                        startMonth = 7;
                        endMonth = 9;
                        break;
                    case "Quý 4":
                        startMonth = 10;
                        endMonth = 12;
                        break;
                    default:
                        return;
                }
                Dictionary<int, long> doanhThuTheoThang = new Dictionary<int, long>();
                for (int i = startMonth; i <= endMonth; i++)
                {
                    doanhThuTheoThang.Add(i, 0);
                }


                foreach (DataRow dr in dt.Rows)
                {
                    DateTime ngayThanhToan = (DateTime)dr[2];
                    int thang = ngayThanhToan.Month;
                    long doanhThu = long.Parse(dr[3].ToString());
                    doanhThuTheoThang[thang] += doanhThu;
                }
                int index = 0;
                foreach (var item in doanhThuTheoThang)
                {
                    string label = "Tháng " + item.Key.ToString();
                    chartFinancialReport.Series["Doanh Thu"].Points.AddXY(index, item.Value);
                    chartFinancialReport.Series["Doanh Thu"].Points[index].AxisLabel = label;
                    index++;

                }


                chartFinancialReport.Visible = true;

            }
            else
            {
                //lap thong ke theo nam
                string year = comboBox1.Text;
                DataTable dt = HopDongBLL.getChartByYear(year); // Assuming this function fetches data for a specific year

                Dictionary<int, long> doanhThuTheoThang = new Dictionary<int, long>();
                for (int i = 1; i <= 12; i++)
                {
                    doanhThuTheoThang.Add(i, 0);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    DateTime ngayThanhToan = (DateTime)dr[2];
                    int thang = ngayThanhToan.Month;
                    long doanhThu = long.Parse(dr[3].ToString());
                    doanhThuTheoThang[thang] += doanhThu;
                }

                int index = 0;
                foreach (var item in doanhThuTheoThang)
                {
                    string label = "Tháng " + item.Key.ToString();
                    chartFinancialReport.Series["Doanh Thu"].Points.AddXY(index, item.Value);
                    chartFinancialReport.Series["Doanh Thu"].Points[index].AxisLabel = label;
                    index++;
                }

                chartFinancialReport.Visible = true;


            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchHopDong = textBoxSearch.Text.ToString().Trim();
            DataTable dt = HopDongBLL.searchFinancialReport(searchHopDong);
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                textBoxSearch.Text = "";
                return;
            }
            else
            {
                dataGridViewFinancial.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string maHopDong = row[0].ToString();
                    string tenHopDong = row[1].ToString();
                    DateTime ngayThanhToan = (DateTime)row[2];
                    int doanhThu = Convert.ToInt32(row[3].ToString());
                    dataGridViewFinancial.Rows.Add(maHopDong, tenHopDong, ngayThanhToan, doanhThu);
                }
                textBoxSearch.Text = "";
            }
        }
    }
}
