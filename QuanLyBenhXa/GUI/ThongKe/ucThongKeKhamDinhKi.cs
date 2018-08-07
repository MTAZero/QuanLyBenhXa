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
using QuanLyBenhXa.Report;

namespace QuanLyBenhXa.GUI.ThongKe
{
    public partial class ucThongKeKhamDinhKi : UserControl
    {
        // service
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();
        private DONVIFactory DONVIService = new DONVIFactory();

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

            // cbx benh nhan
            cbxBenhNhan.Properties.DataSource = BENHNHANService.GetAllEntities().ToList()
                                                    .Select(p => new
                                                    {
                                                        ID = p.ID,
                                                        Ten = p.HOTEN
                                                    })
                                                    .ToList();
            cbxBenhNhan.Properties.DisplayMember = "Ten";
            cbxBenhNhan.Properties.ValueMember = "ID";
            cbxBenhNhan.ItemIndex = 0;

            // cbx don vi
            cbxDonVi.Properties.DataSource = DONVIService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxDonVi.Properties.DisplayMember = "Ten";
            cbxDonVi.Properties.ValueMember = "ID";
            cbxDonVi.ItemIndex = 0;

            // chk
            chkDonVi.Checked = false;
            chkBenhNhan.Checked = false;
            cbxBenhNhan.Visible = false;
            cbxDonVi.Visible = false;
        }
        private void LoadDgvKHAMDINHKI()
        {
            try
            {
                int stt = 0;
                string text = txtTimKiem.Text.ToUpper();
                dgvKHAMDINHKIMain.DataSource = KHAMDINHKIService.GetAllEntities().ToList()
                                                .Where(p => p.THOIGIANKHAM >= dateTuNgay.DateTime && p.THOIGIANKHAM <= dateDenNgay.DateTime)
                                                .Where(p=>!chkDonVi.Checked || BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).DONVIID == (int) cbxDonVi.EditValue)
                                                .Where(p=>!chkBenhNhan.Checked || p.BENHNHANID == (int)cbxBenhNhan.EditValue)
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    Ngay = ((DateTime)p.THOIGIANKHAM).ToString("dd/MM/yyyy"),
                                                    BacSi = BACSIService.GetAllEntities().Where(z => z.ID == p.BACSIID).FirstOrDefault().HOTEN,
                                                    BenhNhan = BENHNHANService.GetAllEntities().Where(z => z.ID == p.BENHNHANID).FirstOrDefault().HOTEN,
                                                    PhanLoaiSucKhoe = PHANLOAISUCKHOEService.GetAllEntities().Where(z => z.ID == p.PHANLOAISUCKHOEID).FirstOrDefault().TEN,
                                                    DonVi = DONVIService.GetByPrimaryKey(new DONVIKeys((int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).DONVIID)).TEN,
                                                    KetLuan = (p.KETLUAN == null) ? "" : p.KETLUAN
                                                })
                                                .Where(p => p.Ngay.ToUpper().Contains(text) || p.BacSi.ToUpper().Contains(text) || p.BenhNhan.ToUpper().Contains(text) || p.PhanLoaiSucKhoe.ToUpper().Contains(text) || p.DonVi.ToUpper().Contains(text))
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    Ngay = p.Ngay,
                                                    BacSi = p.BacSi,
                                                    BenhNhan = p.BenhNhan,
                                                    PhanLoaiSucKhoe = p.PhanLoaiSucKhoe,
                                                    DonVi = p.DonVi,
                                                    STT = ++stt,
                                                    KetLuan = p.KetLuan
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvKHAMDINHKI();
        }

        private void chkBenhNhan_CheckedChanged(object sender, EventArgs e)
        {
            cbxBenhNhan.Visible = chkBenhNhan.Checked;

            if (chkBenhNhan.Checked == true)
                chkDonVi.Checked = false;
            LoadDgvKHAMDINHKI();
        }

        private void chkDonVi_CheckedChanged(object sender, EventArgs e)
        {
            cbxDonVi.Visible = chkDonVi.Checked;

            if (chkDonVi.Checked == true)
                chkBenhNhan.Checked = false;
            LoadDgvKHAMDINHKI();
        }

        private void cbxBenhNhan_EditValueChanged(object sender, EventArgs e)
        {
            LoadDgvKHAMDINHKI();
        }

        private String getHeader()
        {
            if (chkBenhNhan.Checked)
                return "KẾT QUẢ KHÁM ĐỊNH KÌ CỦA ĐỒNG CHÍ " + cbxBenhNhan.Text.ToUpper();

            if (chkDonVi.Checked)
                return "KẾT QUẢ KHÁM ĐỊNH KÌ CỦA " + cbxDonVi.Text.ToUpper();

            return "THỐNG KÊ KHÁM ĐỊNH KÌ";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string header = getHeader();
            FrmRpKhamDinhKi form = new FrmRpKhamDinhKi(header, dateTuNgay.DateTime, dateDenNgay.DateTime, chkDonVi.Checked, (int)cbxDonVi.EditValue, chkBenhNhan.Checked, (int)cbxBenhNhan.EditValue);
            form.ShowDialog();
        }
    }
}
