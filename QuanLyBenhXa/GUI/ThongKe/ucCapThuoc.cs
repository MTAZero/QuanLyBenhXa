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
    public partial class ucCapThuoc : UserControl
    {
        // service 
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private CAPTHUOCFactory CAPTHUOCService = new CAPTHUOCFactory();
        private CHITIETCAPTHUOCFactory CHITIETCAPTHUOCService = new CHITIETCAPTHUOCFactory();
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private BENHFactory BENHService = new BENHFactory();
        private THUOCFactory THUOCService = new THUOCFactory();

        #region Hàm khởi tạo
        public ucCapThuoc()
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

        private void LoadDgvCAPTHUOC()
        {
            try
            {
                int stt = 0;
                string text = txtTimKiem.Text.ToUpper();
                dgvCAPTHUOCMain.DataSource = CAPTHUOCService.GetAllEntities().ToList()
                                                .Where(p => p.NGAY >= dateTuNgay.DateTime && p.NGAY <= dateDenNgay.DateTime)
                                                .Select(p => new
                                                { 
                                                    ID = p.ID,
                                                    Ngay = ((DateTime)p.NGAY).ToString("dd/MM/yyyy"),
                                                    BacSi = BACSIService.GetAllEntities().Where(z => z.ID == p.BACSIID).FirstOrDefault().HOTEN,
                                                    BenhNhan = BENHNHANService.GetAllEntities().Where(z => z.ID == KHAMTHUONGXUYENService.GetAllEntities().Where(y => y.ID == p.KHAMTHUONGXUYENID).FirstOrDefault().BENHNHANID).FirstOrDefault().HOTEN,
                                                    Benh = BENHService.GetAllEntities().Where(z => z.ID == KHAMTHUONGXUYENService.GetAllEntities().Where(y => y.ID == p.KHAMTHUONGXUYENID).FirstOrDefault().BENHID).FirstOrDefault().TEN
                                                })
                                                .Where(p=>p.Ngay.ToUpper().Contains(text) || p.BacSi.ToUpper().Contains(text) || p.BenhNhan.ToUpper().Contains(text) || p.Benh.ToUpper().Contains(text))
                                                .Select(p=> new {
                                                    STT = ++stt,
                                                    ID = p.ID,
                                                    BacSi = p.BacSi,
                                                    BenhNhan = p.BenhNhan,
                                                    Benh = p.Benh
                                                })
                                                .ToList();
                LoadDgvCHITIETCAPTHUOC();
            }
            catch
            {
            }
        }

        private void LoadDgvCHITIETCAPTHUOC()
        {
            try
            {
                int stt = 0;
                int capthuocID = (int)dgvCAPTHUOC.GetFocusedRowCellValue("ID");

                dgvCHITIETCAPTHUOCMain.DataSource = CHITIETCAPTHUOCService.GetAllEntities().ToList()
                                                .Where(p => p.CAPTHUOCID == capthuocID)
                                                .Select(p => new
                                                {
                                                    STT = ++stt,
                                                    ID = p.ID,
                                                    Thuoc = THUOCService.GetAllEntities().Where(z => z.ID == p.THUOCID).FirstOrDefault().TEN,
                                                    SoLuong = p.SOLUONG
                                                })
                                                .ToList();
            }
            catch
            {
            }
        }
        private void ucCapThuoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvCAPTHUOC();
        }
        #endregion

        #region Sự kiện ngầm
        private void dateDenNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvCAPTHUOC();
        }

        private void dgvCAPTHUOCMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadDgvCHITIETCAPTHUOC();
        }
        #endregion



    }
}
