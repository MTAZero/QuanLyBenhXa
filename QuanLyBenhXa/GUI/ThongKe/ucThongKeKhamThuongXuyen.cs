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

namespace QuanLyBenhXa.GUI.ThongKe
{
    public partial class ucThongKeKhamThuongXuyen : UserControl
    {
        // service
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private BACSIFactory BACSISerice = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private BENHFactory BENHService = new BENHFactory();

        #region Hàm khởi tạo
        public ucThongKeKhamThuongXuyen()
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

        private string CachGiaiQuyetStr(int state)
        {
            if (state == 0) return "Điều trị tại đơn vị";
            if (state == 1) return "Điều trị tại tuyến";
            return "Điều trị tại tuyến trên";
        }

        private void LoadDgvKHAMTHUONGXUYEN()
        {
            try
            {
                int stt = 0;
                var listKhamThuongXuyen = KHAMTHUONGXUYENService.GetAllEntities().ToList()
                                            .Where(p=>p.THOIGIAN >= dateTuNgay.DateTime && p.THOIGIAN<=dateDenNgay.DateTime)
                                            .Select(p => new
                                            {
                                                STT = ++stt,
                                                Ngay = ((DateTime)p.THOIGIAN).ToString("dd/MM/yyyy"),
                                                BacSi = BACSISerice.GetAllEntities().Where(z=>z.ID == p.BACSIID).FirstOrDefault().HOTEN,
                                                BenhNhan = BENHNHANService.GetAllEntities().Where(z=>z.ID == p.BENHNHANID).FirstOrDefault().HOTEN,
                                                Benh = BENHService.GetAllEntities().Where(z=>z.ID == p.BENHID).FirstOrDefault().TEN,
                                                CachGiaiQuyet = CachGiaiQuyetStr((int)p.CACHGIAIQUYET)
                                            })
                                            .ToList();
                dgvKHAMTHUONGXUYENMain.DataSource = listKhamThuongXuyen;
            }
            catch
            {
            }
        }
        private void ucThongKeKhamThuongXuyen_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvKHAMTHUONGXUYEN();
        }
        #endregion

        private void dateDenNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvKHAMTHUONGXUYEN();
        }
    }
}
