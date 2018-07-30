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
    public partial class ucThongKeBenhLy : UserControl
    {
        // service
        private BENHFactory BENHService = new BENHFactory();
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();

        #region Hàm khởi tạo
        public ucThongKeBenhLy()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            dateTuNgay.DateTime = DateTime.Now.AddYears(-1);
            dateDenNgay.DateTime = DateTime.Now;
        }
        private void LoadDgvBenh()
        {
            try
            {
                int stt = 0;
                var listBenh = BENHService.GetAllEntities().ToList()
                                            .Select(p => new
                                            {
                                                STT = ++stt,
                                                Benh = p.TEN,
                                                SoLuotMac = KHAMTHUONGXUYENService.GetAllEntities().Where(z=>z.THOIGIAN>=dateTuNgay.DateTime && z.THOIGIAN<=dateDenNgay.DateTime && z.BENHID==p.ID).ToList().Count
                                            })
                                            .ToList();

                DgvBENHMain.DataSource = listBenh;
                chartBenh.DataSource = listBenh;
                chartBenh.Series[0].XValueMember = "Benh";
                chartBenh.Series[0].XValueType = ChartValueType.String;
                chartBenh.Series[0].YValueMembers = "SoLuotMac";
                chartBenh.Series[0].YValueType = ChartValueType.Int32;
            }
            catch
            {
            }
        }
        private void ucThongKeBenhLy_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvBenh();
        }
        #endregion

        #region Sự kiện ngầm
        private void dateDenNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvBenh();
        }
        #endregion
    }
}
