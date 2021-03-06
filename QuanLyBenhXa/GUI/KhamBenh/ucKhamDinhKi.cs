﻿using System;
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
        private KHAMDINHKI khamdinhki = ThamSoHeThong.khamdinhki;

        // mode: 0: them, luu; 1: luu
        private int mode = 0;

        #region Hàm khởi tạo
        public ucKhamDinhKi()
        {
            InitializeComponent();
        }

        public ucKhamDinhKi(KHAMDINHKI _khamdinhki, int _mode)
        {
            khamdinhki = _khamdinhki;
            mode = _mode;
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

            cbxLoaiHinhKham.SelectedIndex = 0;
            cbxBenhHiemNgheo.SelectedIndex = 0;

            dateThoiGianKham.DateTime = DateTime.Now;
        }
        private void ucKhamDinhKi_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            if (mode == 0) LockControl();
            if (mode == 1)
            {
                btnThem.Visible = false;
                btnDong.Visible = false;
                UpdateDetail();
                UnlockControl();
            }
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
            ans.BENHHIEMNGHEO = cbxBenhHiemNgheo.SelectedIndex;
            ans.LOAIHINHKHAM = cbxLoaiHinhKham.SelectedIndex;

            return ans;
        }
        private KHAMTHELUC GetKHAMTHELUCByForm()
        {
            KHAMTHELUC ans = new KHAMTHELUC();

            ans.BACSIID = (int)cbxBacSiTheLuc.EditValue;
            ans.CHIEUCAO = txtTheLucChieuCao.Text;
            ans.KETQUALAMSANG = txtTheLucKetQua.Text;
            ans.MACH = txtTheLucMach.Text;
            ans.HUYETAP = txtTheLucHuyetAp.Text;
            ans.GHICHU = txtTheLucGhiChu.Text;

            // can nang
            try
            {
                ans.CANNANG = Int32.Parse(txtTheLucCanNang.Text);
            }
            catch
            {
                ans.CANNANG = 0;
            }
            
            // vong nguc
            try
            {
                ans.VONGNGUC = Int32.Parse(txtTheLucVongNguc.Text);
            }
            catch
            {
                ans.VONGNGUC = 0;
            }

            // nhiet do
            try
            {
                ans.NHIETDO = Int32.Parse(txtTheLucNhietDo.Text);
            }
            catch
            {
                ans.NHIETDO = 0;
            }

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

            //if (!CheckKhamTheLuc()) return false;
            //if (!CheckKhamCanLamSang()) return false;
            //if (!CheckKhamChuyenKhoa()) return false;

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

            try
            {
                int k = Int32.Parse(txtTheLucCanNang.Text);
            }
            catch
            {
                MessageBox.Show("Cân nặng của khám thể lực phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucVongNguc.Text == "")
            {
                MessageBox.Show("Vòng ngực của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int k = Int32.Parse(txtTheLucVongNguc.Text);
            }
            catch
            {
                MessageBox.Show("Vòng ngực của khám thể lực phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTheLucNhietDo.Text == "")
            {
                MessageBox.Show("Nhiệt độ của khám thể lực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int k = Int32.Parse(txtTheLucNhietDo.Text);
            }
            catch
            {
                MessageBox.Show("Nhiệt độ của khám thể lực phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cbxLoaiHinhKham.Enabled = false;
            cbxBenhHiemNgheo.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;

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
            cbxBacSi.Enabled = true;
            cbxBenhNhan.Enabled = true;
            dateThoiGianKham.Enabled = true;
            cbxPhanLoaiSucKhoe.Enabled = true;
            txtKetLuan.Enabled = true;
            cbxLoaiHinhKham.Enabled = true;
            cbxBenhHiemNgheo.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;

            UnlockControlKhamTheLuc();
            UnlockControlKhamChuyenKhoa();
            UnlockControlKhamCanLamSang();
        }
        private void UnlockControlKhamTheLuc()
        {
            cbxBacSiTheLuc.Enabled = true;
            txtTheLucChieuCao.Enabled = true;
            txtTheLucCanNang.Enabled = true;
            txtTheLucMach.Enabled = true;
            txtTheLucHuyetAp.Enabled = true;
            txtTheLucGhiChu.Enabled = true;
            txtTheLucVongNguc.Enabled = true;
            txtTheLucNhietDo.Enabled = true;
            txtTheLucKetQua.Enabled = true;
        }
        private void UnlockControlKhamChuyenKhoa()
        {
            cbxBacSiKhamChuyenKhoa.Enabled = true;
            txtChuyenKhoaTai.Enabled = true;
            txtChuyenKhoaMui.Enabled = true;
            txtChuyenKhoaHong.Enabled = true;
            txtChuyenKhoaRang.Enabled = true;
            txtChuyenKhoaHam.Enabled = true;
            txtChuyenKhoaMat.Enabled = true;
            txtChuyenKhoaKhac.Enabled = true;
            txtChuyenKhoaKetQua.Enabled = true;
        }
        private void UnlockControlKhamCanLamSang()
        {
            cbxBacSiCanLamSang.Enabled = true;
            txtCanLamSangMau.Enabled = true;
            txtCanLamSangXQuang.Enabled = true;
            txtCanLamSangNuocTieu.Enabled = true;
            txtCanLamSangXetNghiemKhac.Enabled = true;
            txtCanLamSangSieuAm.Enabled = true;
            txtCanLamSangDienTim.Enabled = true;
            txtCanLamSangKetQua.Enabled = true;
            txtCanLamSangGhiChu.Enabled = true;
        }
        private void ClearControl()
        {
            cbxBacSi.Enabled = true;
            cbxBenhNhan.Enabled = true;
            dateThoiGianKham.Enabled = true;
            cbxPhanLoaiSucKhoe.Enabled = true;
            txtKetLuan.Enabled = true;
            cbxLoaiHinhKham.Enabled = true;
            cbxBenhHiemNgheo.Enabled = true;

            ClearControlKhamTheLuc();
            ClearControlKhamChuyenKhoa();
            ClearControlKhamCanLamSang();
        }
        private void ClearControlKhamTheLuc()
        {
            cbxBacSiTheLuc.ItemIndex = 0;
            txtTheLucChieuCao.Text = "";
            txtTheLucCanNang.Text = "";
            txtTheLucMach.Text = "";
            txtTheLucHuyetAp.Text = "";
            txtTheLucGhiChu.Text = "";
            txtTheLucVongNguc.Text = "";
            txtTheLucNhietDo.Text = "";
            txtTheLucKetQua.Text = "";
        }
        private void ClearControlKhamChuyenKhoa()
        {
            cbxBacSiKhamChuyenKhoa.ItemIndex = 0;
            txtChuyenKhoaTai.Text = "";
            txtChuyenKhoaMui.Text = "";
            txtChuyenKhoaHong.Text = "";
            txtChuyenKhoaRang.Text = "";
            txtChuyenKhoaHam.Text = "";
            txtChuyenKhoaMat.Text = "";
            txtChuyenKhoaKhac.Text = "";
            txtChuyenKhoaKetQua.Text = "";
        }
        private void ClearControlKhamCanLamSang()
        {
            cbxBacSiCanLamSang.ItemIndex = 0;
            txtCanLamSangMau.Text = "";
            txtCanLamSangXQuang.Text = "";
            txtCanLamSangNuocTieu.Text = "";
            txtCanLamSangXetNghiemKhac.Text = "";
            txtCanLamSangSieuAm.Text = "";
            txtCanLamSangDienTim.Text = "";
            txtCanLamSangKetQua.Text = "";
            txtCanLamSangGhiChu.Text = "";
        }
        private void CapNhat()
        {
            try
            {
                KHAMDINHKI khamdinhki1 = GetKHAMDINHKIByForm();
                KHAMCHUYENKHOA khamchuyenkhoa1 = GetKHAMCHUYENKHOAByForm();
                KHAMCANLAMSANG khamcanlamsang1 = GetKHAMCANLAMSANGByForm();
                KHAMTHELUC khamtheluc1 = GetKHAMTHELUCByForm();

                khamdinhki1.ID = khamdinhki.ID;
                khamdinhki1.KHAMCANLAMSANGID = khamdinhki.KHAMCANLAMSANGID;
                khamdinhki1.KHAMTHELUCID = khamdinhki.KHAMTHELUCID;
                khamdinhki1.KHAMCHUYENKHOAID = khamdinhki.KHAMCHUYENKHOAID;

                khamchuyenkhoa1.ID = (int) khamdinhki.KHAMCHUYENKHOAID;
                khamcanlamsang1.ID = (int)khamdinhki.KHAMCANLAMSANGID;
                khamtheluc1.ID = (int)khamdinhki.KHAMTHELUCID;

                KHAMDINHKIService.Update(khamdinhki1);
                KHAMCHUYENKHOAService.Update(khamchuyenkhoa1);
                KHAMCANLAMSANGService.Update(khamcanlamsang1);
                KHAMTHELUCService.Update(khamtheluc1);
            }
            catch
            {
            }


        }
        private void UpdateDetailKhamDinhKi(KHAMDINHKI khamdinhki)
        {
            try
            {
                cbxBacSi.EditValue = khamdinhki.BACSIID;
                cbxBenhNhan.EditValue = khamdinhki.BENHNHANID;
                dateThoiGianKham.DateTime = (DateTime) khamdinhki.THOIGIANKHAM;
                cbxPhanLoaiSucKhoe.EditValue = khamdinhki.PHANLOAISUCKHOEID;
                txtKetLuan.Text = khamdinhki.KETLUAN;
                cbxBenhHiemNgheo.SelectedIndex = (int) khamdinhki.BENHHIEMNGHEO;
                cbxLoaiHinhKham.SelectedIndex = (int)khamdinhki.LOAIHINHKHAM;
            }
            catch
            {
            }
        }

        private void UpdateDetailKhamChuyenKhoa(KHAMCHUYENKHOA khamchuyenkhoa)
        {
            try
            {
                cbxBacSiKhamChuyenKhoa.EditValue = khamchuyenkhoa.BACSIID;
                txtChuyenKhoaTai.Text = khamchuyenkhoa.TAI;
                txtChuyenKhoaMui.Text = khamchuyenkhoa.MUI;
                txtChuyenKhoaHong.Text = khamchuyenkhoa.HONG;
                txtChuyenKhoaRang.Text = khamchuyenkhoa.RANG;
                txtChuyenKhoaHam.Text = khamchuyenkhoa.HAM;
                txtChuyenKhoaMat.Text = khamchuyenkhoa.MAT;
                txtChuyenKhoaKhac.Text = khamchuyenkhoa.KHAC;
                txtChuyenKhoaKetQua.Text = khamchuyenkhoa.GHICHU;
            }
            catch
            {
            }
        }

        private void UpdateDetailKhamTheLuc(KHAMTHELUC khamtheluc)
        {
            try
            {
                cbxBacSiTheLuc.EditValue = khamtheluc.BACSIID;
                txtTheLucChieuCao.Text = khamtheluc.CHIEUCAO;
                txtTheLucCanNang.Text = khamtheluc.CANNANG.ToString();
                txtTheLucMach.Text = khamtheluc.MACH;
                txtTheLucHuyetAp.Text = khamtheluc.HUYETAP;
                txtTheLucGhiChu.Text = khamtheluc.GHICHU;
                txtTheLucVongNguc.Text = khamtheluc.VONGNGUC.ToString();
                txtTheLucNhietDo.Text = khamtheluc.NHIETDO.ToString();
                txtTheLucKetQua.Text = khamtheluc.KETQUALAMSANG;
            }
            catch
            {
            }
        }

        private void UpdateDetailKhamCanLamSang(KHAMCANLAMSANG khamcanlamsang)
        {
            try
            {
                cbxBacSiCanLamSang.EditValue = khamcanlamsang.BACSIID;
                txtCanLamSangMau.Text = khamcanlamsang.MAU;
                txtCanLamSangXQuang.Text = khamcanlamsang.XQUANG;
                txtCanLamSangNuocTieu.Text = khamcanlamsang.NUOCTIEU;
                txtCanLamSangXetNghiemKhac.Text = khamcanlamsang.XETNGHIEMKHAC;
                txtCanLamSangSieuAm.Text = khamcanlamsang.SIEUAM;
                txtCanLamSangDienTim.Text = khamcanlamsang.DIENTIM;
                txtCanLamSangKetQua.Text = khamcanlamsang.KETQUACANLAMSANG;
                txtCanLamSangGhiChu.Text = khamcanlamsang.GHICHU;
            }
            catch
            {
            }
        }

        private void UpdateDetail()
        {
            try
            {
                UpdateDetailKhamDinhKi(khamdinhki);
                KHAMCHUYENKHOA khamchuyenkhoa = KHAMCHUYENKHOAService.GetByPrimaryKey(new KHAMCHUYENKHOAKeys((int)khamdinhki.KHAMCHUYENKHOAID));
                KHAMCANLAMSANG khamcanlamsang = KHAMCANLAMSANGService.GetByPrimaryKey(new KHAMCANLAMSANGKeys((int)khamdinhki.KHAMCANLAMSANGID));
                KHAMTHELUC khamtheluc = KHAMTHELUCService.GetByPrimaryKey(new KHAMTHELUCKeys((int)khamdinhki.KHAMTHELUCID));

                UpdateDetailKhamChuyenKhoa(khamchuyenkhoa);
                UpdateDetailKhamCanLamSang(khamcanlamsang);
                UpdateDetailKhamTheLuc(khamtheluc);
            }
            catch
            {
            }
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckKhamDinhKi())
                {
                    KHAMDINHKI khamdinhki1 = GetKHAMDINHKIByForm();
                    KHAMCHUYENKHOA khamchuyenkhoa = GetKHAMCHUYENKHOAByForm();
                    KHAMCANLAMSANG khamcanlamsang = GetKHAMCANLAMSANGByForm();
                    KHAMTHELUC khamtheluc = GetKHAMTHELUCByForm();

                    if (khamdinhki.ID == 0)
                    {
                        KHAMCHUYENKHOAService.Insert(khamchuyenkhoa);
                        KHAMCANLAMSANGService.Insert(khamcanlamsang);
                        KHAMTHELUCService.Insert(khamtheluc);

                        khamdinhki1.KHAMCHUYENKHOAID = khamchuyenkhoa.ID;
                        khamdinhki1.KHAMTHELUCID = khamtheluc.ID;
                        khamdinhki1.KHAMCANLAMSANGID = khamcanlamsang.ID;

                        KHAMDINHKIService.Insert(khamdinhki1);

                        MessageBox.Show("Thêm thông tin khám định kì thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        LockControl();
                    }
                    else
                    {
                        CapNhat();
                        MessageBox.Show("Cập nhật thông tin khám định kì thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }

                    UpdateDetail();
                    
                }
            }
            catch
            {
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
