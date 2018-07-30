using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhXa.BusinessLayer;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyBenhXa.GUI.ThongKe
{
    public partial class ucThongKeLuotKham : UserControl
    {
        // service
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();

        #region Hàm khởi tạo
        public ucThongKeLuotKham()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            dateTuNgay.DateTime = DateTime.Now.AddMonths(-1);
            dateDenNgay.DateTime = DateTime.Now;
            cbxLoaiThongKe.SelectedIndex = 0;
        }
        private void LoadDgvTHOIGIAN()
        {
            try
            {
                int stt = 0;
                var listTHOIGIAN = new List<dynamic>();

                DateTime tg = dateTuNgay.DateTime;

                while (tg<=dateDenNgay.DateTime)
                {
                    DateTime kt = new DateTime();
                    kt = tg;

                    // tuần
                    if (cbxLoaiThongKe.SelectedIndex == 0)
                        kt = tg.AddDays(7);

                    // tháng 
                    if (cbxLoaiThongKe.SelectedIndex == 1)
                        kt = tg.AddMonths(1);

                    // năm 
                    if (cbxLoaiThongKe.SelectedIndex == 2)
                        kt = tg.AddYears(1);

                    if (kt >= dateDenNgay.DateTime) kt = dateDenNgay.DateTime;

                    string thoigian = tg.ToString("dd/MM/yyyy");
                    int soluong = KHAMTHUONGXUYENService.GetAllEntities().ToList()
                                    .Where(p => p.THOIGIAN >= tg && p.THOIGIAN <= kt)
                                    .ToList()
                                    .Count;

                    listTHOIGIAN.Add(new { STT = ++stt, ThoiGian = thoigian, SoLuongKham = soluong });

                    tg = kt.AddDays(1);
                }

                dgvTHOIGIANMain.DataSource = listTHOIGIAN;

                chartThongKe.DataSource = listTHOIGIAN;
                chartThongKe.Series[0].XValueMember = "ThoiGian";
                chartThongKe.Series[0].XValueType = ChartValueType.String;
                chartThongKe.Series[0].YValueMembers = "SoLuongKham";
                chartThongKe.Series[0].YValueType = ChartValueType.Int32;
            }
            catch
            {
            }
        }
        private void ucThongKeLuotKham_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvTHOIGIAN();
        }
        #endregion

        #region Sự kiện ngầm
        private void dateDenNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvTHOIGIAN();
        }

        private void cbxLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgvTHOIGIAN();
        }
        #endregion

    }
}
