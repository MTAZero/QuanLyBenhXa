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
    public partial class ucThongKeKhamDinhKi : UserControl
    {
        // service
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();

        #region Hàm khởi tạo
        public ucThongKeKhamDinhKi()
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
        private void LoadDgvKHAMDINHKI()
        {
            try
            {
                int stt = 0;
                dgvKHAMDINHKIMain.DataSource = KHAMDINHKIService.GetAllEntities().ToList()
                                                .Where(p=>p.THOIGIANKHAM>=dateTuNgay.DateTime && p.THOIGIANKHAM<= dateDenNgay.DateTime)
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    STT = ++stt,
                                                    Ngay = ((DateTime)p.THOIGIANKHAM).ToString("dd/MM/yyyy"),
                                                    BacSi = BACSIService.GetAllEntities().Where(z => z.ID == p.BACSIID).FirstOrDefault().HOTEN,
                                                    BenhNhan = BENHNHANService.GetAllEntities().Where(z => z.ID == p.BENHNHANID).FirstOrDefault().HOTEN,
                                                    PhanLoaiSucKhoe = PHANLOAISUCKHOEService.GetAllEntities().Where(z=>z.ID == p.PHANLOAISUCKHOEID).FirstOrDefault().TEN
                                                })
                                                .ToList();
            }
            catch
            {
            }
        }
     
        private void ucThongKeKhamDinhKi_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvKHAMDINHKI();
        }
        #endregion

        private void dateTuNgay_DateTimeChanged(object sender, EventArgs e)
        {
            LoadDgvKHAMDINHKI();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                int khamdinhkiID = (int)dgvKHAMDINHKI.GetFocusedRowCellValue("ID");
                FrmChiTietKhamDinhKi form = new FrmChiTietKhamDinhKi(khamdinhkiID);
                form.ShowDialog();

                LoadDgvKHAMDINHKI();
            }
            catch
            {
                MessageBox.Show("Chưa có phiếu khám định kì nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
