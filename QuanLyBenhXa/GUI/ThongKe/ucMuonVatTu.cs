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
    public partial class ucMuonVatTu : UserControl
    {
        // service 
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private BENHFactory BENHService = new BENHFactory();
        private MUONVATTUFactory MUONVATTUService = new MUONVATTUFactory();
        private CHITIETMUONVATTUFactory CHITIETMUONVATTUService = new CHITIETMUONVATTUFactory();
        private VATTUFactory VATTUService = new VATTUFactory();
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();

        #region Hàm khởi tạo
        public ucMuonVatTu()
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

        private void LoadDgvMUONVATTU()
        {
            try
            {
                int stt = 0;
                string text = txtTimKiem.Text.ToUpper();
                dgvMUONVATTUMain.DataSource = MUONVATTUService.GetAllEntities().ToList()
                                                .Where(p=>p.NGAYMUON>=dateTuNgay.DateTime && p.NGAYMUON<=dateDenNgay.DateTime)
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    Ngay = ((DateTime)p.NGAYMUON).ToString("dd/MM/yyyy"),
                                                    BacSi = BACSIService.GetAllEntities().Where(z => z.ID == p.BACSIMUONID).FirstOrDefault().HOTEN,
                                                    BenhNhan = BENHNHANService.GetAllEntities().Where(z => z.ID == KHAMTHUONGXUYENService.GetAllEntities().Where(y => y.ID == p.KHAMTHUONGXUYENID).FirstOrDefault().BENHNHANID).FirstOrDefault().HOTEN,
                                                    Benh = BENHService.GetAllEntities().Where(z => z.ID == KHAMTHUONGXUYENService.GetAllEntities().Where(y => y.ID == p.KHAMTHUONGXUYENID).FirstOrDefault().BENHID).FirstOrDefault().TEN,
                                                    TrangThai = (p.TRANGTHAI == 0) ? "Đang mượn" : "Đã trả"
                                                })
                                                .Where(p => p.Ngay.ToUpper().Contains(text) || p.BacSi.ToUpper().Contains(text) || p.BenhNhan.ToUpper().Contains(text) || p.Benh.ToUpper().Contains(text) || p.TrangThai.ToUpper().Contains(text))
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    STT = ++stt,
                                                    Ngay = p.Ngay,
                                                    BacSi = p.BacSi,
                                                    BenhNhan = p.BenhNhan,
                                                    Benh = p.Benh,
                                                    TrangThai = p.TrangThai
                                                })
                                                .ToList();
                LoadDgvCHITIETMUONVATTU();
                UpdateDetail();
            }
            catch { }
        }

        private void LoadDgvCHITIETMUONVATTU()
        {
            try
            {
                int stt = 0;
                int muonvattuID = (int)dgvMUONVATTU.GetFocusedRowCellValue("ID");
                dgvCHITIETMUONVATTUMain.DataSource = CHITIETMUONVATTUService.GetAllEntities().ToList()
                                                .Where(p=>p.MUONVATTUID == muonvattuID)
                                                .Select(p => new
                                                {
                                                    STT = ++stt,
                                                    VatTu = VATTUService.GetAllEntities().Where(z=>z.ID == p.VATTUID).FirstOrDefault().TEN,
                                                    SoLuong = p.SOLUONG
                                                })
                                                .ToList();
            }
            catch { }
        }
        private void ucMuonVatTu_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvMUONVATTU();
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvMUONVATTU();
        }

        private void dateTuNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvMUONVATTU();
        }

        private void dgvMUONVATTU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadDgvCHITIETMUONVATTU();
        }
        #endregion

        #region Sự kiện
        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                int muonvattuID = (int)dgvMUONVATTU.GetFocusedRowCellValue("ID");
                MUONVATTU muonvattu = MUONVATTUService.GetByPrimaryKey(new MUONVATTUKeys(muonvattuID));
                KHAMTHUONGXUYEN khamthuongxuyen = KHAMTHUONGXUYENService.GetByPrimaryKey(new KHAMTHUONGXUYENKeys((int)muonvattu.KHAMTHUONGXUYENID));

                if (muonvattu.TRANGTHAI == 1)
                {
                    MessageBox.Show("Thông tin mượn vật tư đã được trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // cập nhật lại thông tin mượn vật tư
                muonvattu.TRANGTHAI = 1;
                muonvattu.NGAYTRA = DateTime.Now;
                MUONVATTUService.Update(muonvattu);

                // cập nhật lại kho
                var listChiTiet = CHITIETMUONVATTUService.GetAllEntities().Where(p => p.MUONVATTUID == muonvattu.ID).ToList();
                foreach(var item in listChiTiet)
                {
                    VATTU vattu = VATTUService.GetByPrimaryKey(new VATTUKeys((int)item.VATTUID));
                    vattu.SOLUONG += item.SOLUONG;
                    VATTUService.Update(vattu);
                }

                MessageBox.Show("Xác nhận trả vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDgvMUONVATTU();
            }
            catch
            {
                MessageBox.Show("Chưa có thông tin mượn vật tư nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Hàm chức năng
        private void UpdateDetail()
        {
            try
            {
                int muonvattuID = (int)dgvMUONVATTU.GetFocusedRowCellValue("ID");
                MUONVATTU muonvattu = MUONVATTUService.GetByPrimaryKey(new MUONVATTUKeys(muonvattuID));
                KHAMTHUONGXUYEN khamthuongxuyen = KHAMTHUONGXUYENService.GetByPrimaryKey(new KHAMTHUONGXUYENKeys((int)muonvattu.KHAMTHUONGXUYENID));

                // cập nhât
                txtNgay.Text = ((DateTime)khamthuongxuyen.THOIGIAN).ToString("dd/MM/yyyy");
                txtBacSi.Text = BACSIService.GetByPrimaryKey(new BACSIKeys((int)khamthuongxuyen.BACSIID)).HOTEN;
                txtBenhNhan.Text = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)khamthuongxuyen.BENHNHANID)).HOTEN;
                txtBenh.Text = BENHService.GetByPrimaryKey(new BENHKeys((int)khamthuongxuyen.BENHID)).TEN;
            }
            catch
            {
            }
        }
        #endregion
    }
}
