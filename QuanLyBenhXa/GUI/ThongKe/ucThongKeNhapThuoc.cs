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
    public partial class ucThongKeNhapThuoc : UserControl
    {
        // service 
        private BACSIFactory BACSIService = new BACSIFactory();
        private THUOCFactory THUOCService = new THUOCFactory();
        private NHAPTHUOCFactory NHAPTHUOCService = new NHAPTHUOCFactory();
        private CHITIETNHAPFactory CHITIETNHAPService = new CHITIETNHAPFactory();

        #region Hàm khởi tạo
        public ucThongKeNhapThuoc()
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

        private void LoadDgvNHAPTHUOC()
        {
            try
            {
                int stt = 0;
                dgvNHAPTHUOCMain.DataSource = NHAPTHUOCService.GetAllEntities().ToList()
                                                .Where(p => p.NGAY >= dateTuNgay.DateTime && p.NGAY <= dateDenNgay.DateTime)
                                                .Select(p => new
                                                {
                                                    STT = ++stt,
                                                    ID = p.ID,
                                                    NgayNhap = ((DateTime)p.NGAY).ToString("dd/MM/yyyy"),
                                                    BacSi = BACSIService.GetAllEntities().Where(z => z.ID == p.BACSIID).FirstOrDefault().HOTEN,
                                                    TongTien = ((int)p.TONGTIEN).ToString("N0"),
                                                })
                                                .ToList();
                txtTongNhap.Text = ((int)
                                     NHAPTHUOCService.GetAllEntities().ToList()
                                     .Where(p => p.NGAY >= dateTuNgay.DateTime && p.NGAY <= dateDenNgay.DateTime)
                                     .Sum(p => p.TONGTIEN)
                                   )
                                   .ToString("N0");

                LoadDgvCHITIETNHAPTHUOC();
            }
            catch
            {
            }
        }

        private void LoadDgvCHITIETNHAPTHUOC()
        {
            try
            {
                int stt = 0;
                int nhapthuocID = (int)dgvNHAPTHUOC.GetFocusedRowCellValue("ID");

                dgvCHITIETNHAPMain.DataSource = CHITIETNHAPService.GetAllEntities().ToList()
                                                .Where(p => p.NHAPTHUOCID == nhapthuocID)
                                                .Select(p => new
                                                {
                                                    STT = ++stt,
                                                    Thuoc = THUOCService.GetAllEntities().Where(z => z.ID == p.THUOCID).FirstOrDefault().TEN,
                                                    SoLuong = p.SOLUONG,
                                                    DonGia = ((int)p.DONGIA).ToString("N0"),
                                                    ThanhTien = ((int)p.THANHTIEN).ToString("N0")
                                                })
                                                .ToList();
            }
            catch
            {
            }
        }
        private void ucThongKeNhapThuoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvNHAPTHUOC();
        }

        #endregion


        #region Sự kiện ngầm
        private void dateTuNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvNHAPTHUOC();
        }

        private void dgvNHAPTHUOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadDgvCHITIETNHAPTHUOC();
        }
        #endregion
    }
}
