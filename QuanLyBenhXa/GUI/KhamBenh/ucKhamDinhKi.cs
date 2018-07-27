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

namespace QuanLyBenhXa.GUI.KhamBenh
{
    public partial class ucKhamDinhKi : UserControl
    {
        // service
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();
        private KHAMTHELUCFactory KHAMTHELUCService = new KHAMTHELUCFactory();
        private KHAMCHUYENKHOAFactory KHAMCHUYENKHOAService = new KHAMCHUYENKHOAFactory();
        private KHAMCANLAMSANGFactory KHAMCANLAMSANGService = new KHAMCANLAMSANGFactory();

        // variable
        private KHAMDINHKI khamdinhki = new KHAMDINHKI();

        #region Hàm khởi tạo
        public ucKhamDinhKi()
        {
            InitializeComponent();
        }

        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            // bac si
            cbxBacSi.Properties.DataSource = BACSIService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBacSi.Properties.DisplayMember = "Ten";
            cbxBacSi.Properties.ValueMember = "ID";
            cbxBacSi.ItemIndex = 0;

            // bac si the luc
            cbxBacSiTheLuc.Properties.DataSource = BACSIService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBacSiTheLuc.Properties.DisplayMember = "Ten";
            cbxBacSiTheLuc.Properties.ValueMember = "ID";
            cbxBacSiTheLuc.ItemIndex = 0;

            // bac si can lam sang
            cbxBacSiCanLamSang.Properties.DataSource = BACSIService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBacSiCanLamSang.Properties.DisplayMember = "Ten";
            cbxBacSiCanLamSang.Properties.ValueMember = "ID";
            cbxBacSiCanLamSang.ItemIndex = 0;

            // bac si chuyen khoa
            cbxBacSiKhamChuyenKhoa.Properties.DataSource = BACSIService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBacSiKhamChuyenKhoa.Properties.DisplayMember = "Ten";
            cbxBacSiKhamChuyenKhoa.Properties.ValueMember = "ID";
            cbxBacSiKhamChuyenKhoa.ItemIndex = 0;

            // benh nhan
            cbxBenhNhan.Properties.DataSource = BENHNHANService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBenhNhan.Properties.DisplayMember = "Ten";
            cbxBenhNhan.Properties.ValueMember = "ID";
            cbxBenhNhan.ItemIndex = 0;

            // phan loai suc khoe
            cbxPhanLoaiSucKhoe.Properties.DataSource = PHANLOAISUCKHOEService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxPhanLoaiSucKhoe.Properties.DisplayMember = "Ten";
            cbxPhanLoaiSucKhoe.Properties.ValueMember = "ID";
            cbxPhanLoaiSucKhoe.ItemIndex = 0;

            dateThoiGianKham.DateTime = DateTime.Now;
        }
        private void ucKhamDinhKi_Load(object sender, EventArgs e)
        {
            LoadInitControl();
        }
        #endregion

        #region Hàm chức năng
        private KHAMDINHKI GetKHAMDINHKIByForm()
        {
            KHAMDINHKI ans = new KHAMDINHKI();

            ans.BACSIID = (int)cbxBacSi.EditValue;
            ans.BENHNHANID = (int)cbxBenhNhan.EditValue;
            ans.THOIGIANKHAM = dateThoiGianKham.DateTime;
            ans.PHANLOAISUCKHOEID = (int)cbxPhanLoaiSucKhoe.EditValue;
            ans.KETLUAN = txtKetLuan.Text;

            return ans;
        }

        private KHAMTHELUC GetKHAMTHELUCByForm()
        {
            KHAMTHELUC ans = new KHAMTHELUC();

            ans.BACSIID = (int)cbxBacSiTheLuc.EditValue;
            ans.CHIEUCAO = txtTheLucChieuCao.Text;
            ans.CANNANG = Int32.Parse(txtTheLucCanNang.Text);
            ans.MACH = txtTheLucMach.Text;
            ans.HUYETAP = txtTheLucHuyetAp.Text;
            ans.GHICHU = txtTheLucGhiChu.Text;
            ans.VONGNGUC = Int32.Parse(txtTheLucVongNguc.Text);
            ans.NHIETDO = Int32.Parse(txtTheLucNhietDo.Text);
            ans.KETQUALAMSANG = txtTheLucKetQua.Text;

            return ans;
        }

        private KHAMCANLAMSANG GetKHAMCANLAMSANGByForm()
        {
            KHAMCANLAMSANG ans = new KHAMCANLAMSANG();

            ans.BACSIID = (int)cbxBacSiCanLamSang.EditValue;
            ans.MAU = txtCanLamSangMau.Text;
            ans.NUOCTIEU = txtCanLamSangNuocTieu.Text;
            ans.SIEUAM = txtCanLamSangSieuAm.Text;
            ans.DIENTIM = txtCanLamSangDienTim.Text;
            ans.GHICHU = txtTheLucGhiChu.Text;
            ans.XQUANG = txtCanLamSangXQuang.Text;
            ans.XETNGHIEMKHAC = txtCanLamSangXetNghiemKhac.Text;
            ans.KETQUACANLAMSANG = txtCanLamSangKetQua.Text;

            return ans;
        }

        private KHAMCHUYENKHOA GetKHAMCHUYENKHOAByForm()
        {
            KHAMCHUYENKHOA ans = new KHAMCHUYENKHOA();

            ans.BACSIID = (int)cbxBacSiKhamChuyenKhoa.EditValue;
            ans.TAI = txtChuyenKhoaTai.Text;
            ans.MUI = txtChuyenKhoaMui.Text;
            ans.HONG = txtChuyenKhoaHong.Text;
            ans.RANG = txtChuyenKhoaRang.Text;
            ans.HAM = txtChuyenKhoaHam.Text;
            ans.MAT = txtChuyenKhoaMat.Text;
            ans.GHICHU = txtChuyenKhoaKetQua.Text;
            ans.KHAC = txtChuyenKhoaKhac.Text;

            return ans;
        }

        private bool CheckKhamDinhKi()
        {
            if (txtKetLuan.Text == "")
            {
                MessageBox.Show("Kết luận không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!CheckKhamTheLuc()) return false;
            if (!CheckKhamCanLamSang()) return false;
            if (!CheckKhamChuyenKhoa()) return false;

            return true;
        }

        private bool CheckKhamTheLuc()
        {
            if (txtTheLucChieuCao.Text == "")
            {
                MessageBox.Show("Chiều cao của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucCanNang.Text == "")
            {
                MessageBox.Show("Cân nặng của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucVongNguc.Text == "")
            {
                MessageBox.Show("Vòng ngực của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucNhietDo.Text == "")
            {
                MessageBox.Show("Nhiệt độ của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucMach.Text == "")
            {
                MessageBox.Show("Mạch của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucHuyetAp.Text == "")
            {
                MessageBox.Show("Huyết áp của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangKetQua.Text == "")
            {
                MessageBox.Show("Kết quả khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckKhamCanLamSang()
        {
            if (txtCanLamSangMau.Text == "")
            {
                MessageBox.Show("Chiều cao của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangXQuang.Text == "")
            {
                MessageBox.Show("X quang của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangNuocTieu.Text == "")
            {
                MessageBox.Show("Nước tiểu của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangXetNghiemKhac.Text == "")
            {
                MessageBox.Show("Xét nghiệm khác của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangSieuAm.Text == "")
            {
                MessageBox.Show("Siêu âm của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangDienTim.Text == "")
            {
                MessageBox.Show("Điện tim của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanLamSangKetQua.Text == "")
            {
                MessageBox.Show("Kết quả của khám cận lâm sàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckKhamChuyenKhoa()
        {
            if (txtChuyenKhoaTai.Text == "")
            {
                MessageBox.Show("Tai của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtChuyenKhoaMui.Text == "")
            {
                MessageBox.Show("Mũi của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtChuyenKhoaHong.Text == "")
            {
                MessageBox.Show("Họng của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtChuyenKhoaRang.Text == "")
            {
                MessageBox.Show("Răng của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtChuyenKhoaHam.Text == "")
            {
                MessageBox.Show("Hàm của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtChuyenKhoaMat.Text == "")
            {
                MessageBox.Show("Mặt của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucKetQua.Text == "")
            {
                MessageBox.Show("Kết quả của khám chuyên khoa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LockControl()
        {
            cbxBacSi.Enabled = false;
            cbxBenhNhan.Enabled = false;
            dateThoiGianKham.Enabled = false;
            cbxPhanLoaiSucKhoe.Enabled = false;
            txtKetLuan.Enabled = false;

            LockControlKhamTheLuc();
            LockControlKhamChuyenKhoa();
            LockControlKhamCanLamSang();
        }

        private void LockControlKhamTheLuc()
        {
            cbxBacSiTheLuc.Enabled = false;
            txtTheLucChieuCao.Enabled = false;
            txtTheLucCanNang.Enabled = false;
            txtTheLucMach.Enabled = false;
            txtTheLucHuyetAp.Enabled = false;
            txtTheLucGhiChu.Enabled = false;
            txtTheLucVongNguc.Enabled = false;
            txtTheLucNhietDo.Enabled = false;
            txtTheLucKetQua.Enabled = false;
           
        }

        private void LockControlKhamChuyenKhoa()
        {
            cbxBacSiKhamChuyenKhoa.Enabled = false;
            txtChuyenKhoaTai.Enabled = false;
            txtChuyenKhoaMui.Enabled = false;
            txtChuyenKhoaHong.Enabled = false;
            txtChuyenKhoaRang.Enabled = false;
            txtChuyenKhoaHam.Enabled = false;
            txtChuyenKhoaMat.Enabled = false;
            txtChuyenKhoaKhac.Enabled = false;
            txtChuyenKhoaKetQua.Enabled = false;
        }

        private void LockControlKhamCanLamSang()
        {
            cbxBacSiCanLamSang.Enabled = false;
            txtCanLamSangMau.Enabled = false;
            txtCanLamSangXQuang.Enabled = false;
            txtCanLamSangNuocTieu.Enabled = false;
            txtCanLamSangXetNghiemKhac.Enabled = false;
            txtCanLamSangSieuAm.Enabled = false;
            txtCanLamSangDienTim.Enabled = false;
            txtCanLamSangKetQua.Enabled = false;
            txtCanLamSangGhiChu.Enabled = false;
        }


        private void UnlockControl()
        {
        }

        #endregion
    }
}
