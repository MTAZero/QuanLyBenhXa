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
    public partial class ucKhamThuongXuyen : UserControl
    {
        // service
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private BENHFactory BENHService = new BENHFactory();
        private BENHVIENFactory BENHVIENService = new BENHVIENFactory();
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private MUONVATTUFactory MUONVATTUService = new MUONVATTUFactory();
        private CAPTHUOCFactory CAPTHUOCService = new CAPTHUOCFactory();
        private CHITIETCAPTHUOCFactory CHITIETCAPTHUOCService = new CHITIETCAPTHUOCFactory();
        private CHITIETMUONVATTUFactory CHITIETMUONVATTUService = new CHITIETMUONVATTUFactory();
        private THUOCFactory THUOCService = new THUOCFactory();
        private VATTUFactory VATTUService = new VATTUFactory();

        // trang thai cua form
        // 0: chua nhap, 1: đang nhập thông tin, 2: đang cấp thuốc

        // variable
        private KHAMTHUONGXUYEN khamthuongxuyen = ThamSoHeThong.khamthuongxuyen;
        private CAPTHUOC capthuoc = ThamSoHeThong.capthuoc;
        private MUONVATTU muonvattu = ThamSoHeThong.muonvattu;

        // mode 
        private int mode = 0;

        #region Hàm khởi tạo
        public ucKhamThuongXuyen()
        {
            InitializeComponent();
        }

        public ucKhamThuongXuyen(KHAMTHUONGXUYEN _khamthuongxuyen)
        {
            khamthuongxuyen = _khamthuongxuyen;;

            try
            {
                capthuoc = CAPTHUOCService.GetAllEntities().Where(p => p.KHAMTHUONGXUYENID == _khamthuongxuyen.ID).FirstOrDefault();
                muonvattu = MUONVATTUService.GetAllEntities().Where(p => p.KHAMTHUONGXUYENID == _khamthuongxuyen.ID).FirstOrDefault();
            }
            catch
            {
            }

            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            // cbxBacSi
            cbxBacSi.Properties.DataSource = BACSIService.GetAllEntities().ToList()
                                                .Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBacSi.Properties.DisplayMember = "Ten";
            cbxBacSi.Properties.ValueMember = "ID";

            // cbx Benh nhan
            cbxBenhNhan.Properties.DataSource = BENHNHANService.GetAllEntities().ToList()
                                                  .Select(p => new { ID = p.ID, Ten = p.HOTEN }).ToList();
            cbxBenhNhan.Properties.DisplayMember = "Ten";
            cbxBenhNhan.Properties.ValueMember = "ID";

            // cbx Benh
            cbxBenh.Properties.DataSource = BENHService.GetAllEntities().ToList()
                                                .Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxBenh.Properties.DisplayMember = "Ten";
            cbxBenh.Properties.ValueMember = "ID";

            // cbx Benh vien
            cbxBenhVien.Properties.DataSource = BENHVIENService.GetAllEntities().ToList()
                                                    .Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxBenhVien.Properties.DisplayMember = "Ten";
            cbxBenhVien.Properties.ValueMember = "ID";
        }

        private void LoadDgvCHITIETCAPTHUOC()
        {
            try
            {
                int STT = 0;

                dgvCHITIETCAPTHUOCMain.DataSource = CHITIETCAPTHUOCService.GetAllEntities().ToList()
                    .Where(p=>p.CAPTHUOCID == capthuoc.ID)
                    .Select(p => new
                    {
                        STT = ++STT,
                        ID = p.ID,
                        Ten = THUOCService.GetAllEntities().Where(z=>z.ID == p.THUOCID).FirstOrDefault().TEN,
                        SoLuong = p.SOLUONG
                    })
                    .ToList();
            }
            catch
            {

            }
        }

        private void LoadDgvCHITIETMUONVATTU()
        {
            try
            {
                int STT = 0;

                var list = CHITIETMUONVATTUService.GetAllEntities().ToList()
                    .Where(p=>p.MUONVATTUID == muonvattu.ID)
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        Ten = VATTUService.GetAllEntities().Where(z=>z.ID == p.VATTUID).FirstOrDefault().TEN,
                        SoLuong = p.SOLUONG
                    })
                    .ToList();

                dgvCHITIETMUONVATTUMain.DataSource = list;

                if (list.Count == 0)
                {
                    muonvattu.TRANGTHAI = 2; // chưa mượn
                    MUONVATTUService.Update(muonvattu);
                }
                else
                {
                    muonvattu.TRANGTHAI = 0; // đang mượn
                    MUONVATTUService.Update(muonvattu);
                }
            }
            catch
            {

            }
        }

        private void ucKhamThuongXuyen_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            ClearControl();
            UpdateDetail();
            UpdateStateForm(0);
        }
        #endregion

        #region Hàm chức năng 
        private KHAMTHUONGXUYEN getKHAMTHUONGXUYENByForm()
        {
            KHAMTHUONGXUYEN ans = new KHAMTHUONGXUYEN();

            ans.BACSIID = (int)cbxBacSi.EditValue;
            ans.BENHNHANID = (int)cbxBenhNhan.EditValue;
            ans.THOIGIAN = dateThoiGianKham.DateTime;
            ans.BENHID = (int)cbxBenh.EditValue;
            ans.CACHGIAIQUYET = cbxCachGiaiQuyet.SelectedIndex;
            ans.CHANDOANSOBO = txtKetLuan.Text;
            ans.TRIEUCHUNG = txtTrieuChung.Text;

            // điều trị tại tuyến
            if (ans.CACHGIAIQUYET == 1)
            {
                ans.THOIGIANVAO = dateThoiGianVao.DateTime;
                ans.THOIGIANRA = dateThoiGianRa.DateTime;
                ans.PHUONGPHAPDIEUTRI = txtPhuongPhap.Text;
            }

            // chuyển lên tuyến trên
            if (ans.CACHGIAIQUYET == 2)
            {
                ans.BENHVIENID = (int)cbxBenhVien.EditValue;
                ans.THOIGIANCHUYEN = dateThoiGianChuyen.DateTime;
            }

            return ans;
        }

        private void ClearControl()
        {
            cbxBacSi.ItemIndex = 0;
            cbxBenhNhan.ItemIndex = 0;
            dateThoiGianKham.DateTime = DateTime.Now;

            cbxBenh.ItemIndex = 0;
            cbxCachGiaiQuyet.SelectedIndex = 0;
            txtKetLuan.Text = "";

            dateThoiGianVao.DateTime = DateTime.Now;
            dateThoiGianRa.DateTime = DateTime.Now;
            txtPhuongPhap.Text = "";

            txtTrieuChung.Text = "";

            cbxBenhVien.ItemIndex = 0;
            dateThoiGianChuyen.DateTime = DateTime.Now;
        }

        private void UpdateDetail()
        {
            try
            {
                KHAMTHUONGXUYEN tg = khamthuongxuyen;

                if (tg.ID == 0) return;

                ClearControl();

                cbxBacSi.EditValue = (int)tg.BACSIID;
                cbxBenhNhan.EditValue = (int)tg.BENHNHANID;
                dateThoiGianKham.DateTime = (DateTime)tg.THOIGIAN;

                cbxBenh.EditValue = (int)tg.BENHID;
                cbxCachGiaiQuyet.SelectedIndex = (int)tg.CACHGIAIQUYET;
                txtKetLuan.Text = tg.CHANDOANSOBO;
                txtTrieuChung.Text = tg.TRIEUCHUNG;

                if (tg.CACHGIAIQUYET == 1)
                {
                    dateThoiGianVao.DateTime = (DateTime)tg.THOIGIANVAO;
                    dateThoiGianRa.DateTime = (DateTime)tg.THOIGIANRA;
                    txtPhuongPhap.Text = tg.PHUONGPHAPDIEUTRI;
                }

                if (tg.CACHGIAIQUYET == 2)
                {
                    cbxBenhVien.EditValue = (int)tg.BENHVIENID;
                    dateThoiGianChuyen.DateTime = (DateTime)tg.THOIGIANCHUYEN;
                }

                LoadDgvCHITIETCAPTHUOC();
                LoadDgvCHITIETMUONVATTU();
            }
            catch
            {

            }
        }

        private void UpdateStateForm(int state)
        {
            if (state == 0)
            {
                // chưa nhập thông tin hoặc đang sửa thông tin
                cbxBacSi.Enabled = false;
                cbxBenhNhan.Enabled = false;
                dateThoiGianKham.Enabled = false;

                cbxBenh.Enabled = false;
                cbxCachGiaiQuyet.Enabled = false;
                txtKetLuan.Enabled = false;

                dateThoiGianVao.Enabled = false;
                dateThoiGianRa.Enabled = false;
                txtPhuongPhap.Enabled = false;

                cbxBenhVien.Enabled = false;
                dateThoiGianChuyen.Enabled = false;
                btnInGiayGioiThieu.Enabled = true;

                txtTrieuChung.Enabled = false;

                dgvCHITIETCAPTHUOCMain.Enabled = false;
                dgvCHITIETMUONVATTUMain.Enabled = false;

                btnCapThemThuoc.Enabled = false;
                btnThuHoiThuoc.Enabled = false;
                btnMuonThemVatTu.Enabled = false;
                btnTraVatTu.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = (khamthuongxuyen.ID != 0);
                btnLuuThongTin.Enabled = false;
                btnHoanThanhNhap.Visible = false;
                btnHuy.Enabled = false;
                return;
            }

            if (state == 1)
            {
                // đang nhập thông tin của phiếu khám
                cbxBacSi.Enabled = true;
                cbxBenhNhan.Enabled = true;
                dateThoiGianKham.Enabled = true;

                cbxBenh.Enabled = true;
                cbxCachGiaiQuyet.Enabled = true;
                txtKetLuan.Enabled = true;

                dateThoiGianVao.Enabled = true;
                dateThoiGianRa.Enabled = true;
                txtPhuongPhap.Enabled = true;

                cbxBenhVien.Enabled = true;
                dateThoiGianChuyen.Enabled = true;
                btnInGiayGioiThieu.Enabled = false;

                txtTrieuChung.Enabled = true;

                dgvCHITIETCAPTHUOCMain.Enabled = false;
                dgvCHITIETMUONVATTUMain.Enabled = false;

                btnCapThemThuoc.Enabled = false;
                btnThuHoiThuoc.Enabled = false;
                btnMuonThemVatTu.Enabled = false;
                btnTraVatTu.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;
                btnLuuThongTin.Enabled = true;
                btnHoanThanhNhap.Visible = false;
                return;
            }

            if (state == 2)
            {
                // đang cấp thuốc
                cbxBacSi.Enabled = false;
                cbxBenhNhan.Enabled = false;
                dateThoiGianKham.Enabled = false;

                cbxBenh.Enabled = false;
                cbxCachGiaiQuyet.Enabled = false;
                txtKetLuan.Enabled = false;

                dateThoiGianVao.Enabled = false;
                dateThoiGianRa.Enabled = false;
                txtPhuongPhap.Enabled = false;

                cbxBenhVien.Enabled = false;
                dateThoiGianChuyen.Enabled = false;
                btnInGiayGioiThieu.Enabled = false;

                txtTrieuChung.Enabled = false;

                dgvCHITIETCAPTHUOCMain.Enabled = true;
                dgvCHITIETMUONVATTUMain.Enabled = true;

                btnCapThemThuoc.Enabled = true;
                btnThuHoiThuoc.Enabled = true;
                btnMuonThemVatTu.Enabled = true;
                btnTraVatTu.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnHuy.Enabled = true;
                btnLuuThongTin.Enabled = false;
                btnHoanThanhNhap.Visible = true;
                return;
            }
        }

        private bool Check()
        {

            // trieu chung
            if (txtTrieuChung.Text == "")
            {
                MessageBox.Show("Triệu chứng của bệnh nhân không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // ket luan
            if (txtKetLuan.Text == "")
            {
                MessageBox.Show("Kết luận không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // kham tai tuyến
            if (cbxCachGiaiQuyet.SelectedIndex == 1)
            {
                // thoi gian
                if (dateThoiGianRa.DateTime < dateThoiGianVao.DateTime)
                {
                    MessageBox.Show("Thời gian ra của bệnh nhân phải lớn hơn thời gian vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // phuong phap
                if (txtPhuongPhap.Text == "")
                {
                    MessageBox.Show("Phương pháp điều trị của bệnh nhân không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }

        private CHITIETCAPTHUOC getCHITIETCAPTHUOCByID()
        {
            try
            {
                int id = (int)dgvCHITIETCAPTHUOC.GetFocusedRowCellValue("ID");
                CHITIETCAPTHUOC ans = CHITIETCAPTHUOCService.GetAllBy(CHITIETCAPTHUOC.CHITIETCAPTHUOCFields.ID, id).FirstOrDefault();
                //db.CHITIETCAPTHUOCs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new CHITIETCAPTHUOC();
                return ans;
            }
            catch
            {
                return new CHITIETCAPTHUOC();
            }
        }

        private CHITIETMUONVATTU getCHITIETMUONVATTUByID()
        {
            try
            {
                int id = (int)dgvCHITIETMUONVATTU.GetFocusedRowCellValue("ID");
                CHITIETMUONVATTU ans = CHITIETMUONVATTUService.GetAllBy(CHITIETMUONVATTU.CHITIETMUONVATTUFields.ID, id).FirstOrDefault();
                //db.CHITIETMUONVATTUs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new CHITIETMUONVATTU();
                return ans;
            }
            catch
            {
                return new CHITIETMUONVATTU();
            }
        }

        private void CapNhat(ref KHAMTHUONGXUYEN cu, KHAMTHUONGXUYEN moi)
        {
            cu.BACSIID = moi.BACSIID;
            cu.BENHNHANID = moi.BENHNHANID;
            cu.THOIGIAN = moi.THOIGIAN;
            cu.BENHID = moi.BENHID;
            cu.CACHGIAIQUYET = moi.CACHGIAIQUYET;
            cu.KETQUADIEUTRI = moi.KETQUADIEUTRI;
            cu.CHANDOANSOBO = moi.CHANDOANSOBO;

            cu.THOIGIANVAO = moi.THOIGIANVAO;
            cu.THOIGIANRA = moi.THOIGIANRA;
            cu.PHUONGPHAPDIEUTRI = moi.PHUONGPHAPDIEUTRI;

            cu.BENHVIENID = moi.BENHVIENID;
            cu.THOIGIANCHUYEN = moi.THOIGIANCHUYEN;

            cu.TRIEUCHUNG = moi.TRIEUCHUNG;
        }

        private bool CheckLuaChonCHITIETMUONVATTU()
        {
            CHITIETMUONVATTU tg = getCHITIETMUONVATTUByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết mượn vật tư nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckLuaChonCHITIETCAPTHUOC()
        {
            CHITIETCAPTHUOC tg = getCHITIETCAPTHUOCByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết cấp thuốc nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            khamthuongxuyen = new KHAMTHUONGXUYEN();
            ThamSoHeThong.khamthuongxuyen = khamthuongxuyen;

            dgvCHITIETCAPTHUOCMain.DataSource = null;
            dgvCHITIETMUONVATTUMain.DataSource = null;

            ClearControl();
            UpdateStateForm(1);
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            int exceptionHelp = 0;// -> giúp tạo ra exception
            if (Check())
            {
                try
                {
                    KHAMTHUONGXUYEN tg = getKHAMTHUONGXUYENByForm();

                    if (khamthuongxuyen.ID == 0)
                    {
                        bool kt = KHAMTHUONGXUYENService.Insert(tg);
                        if (kt == false) exceptionHelp /= 0;

                        khamthuongxuyen = tg;
                        ThamSoHeThong.khamthuongxuyen = tg;

                        // thêm mới
                        muonvattu = new MUONVATTU();
                        ThamSoHeThong.muonvattu = muonvattu;
                        muonvattu.KHAMTHUONGXUYENID = khamthuongxuyen.ID;
                        muonvattu.BACSIMUONID = khamthuongxuyen.BACSIID;
                        muonvattu.NGAYMUON = khamthuongxuyen.THOIGIAN;
                        muonvattu.TRANGTHAI = 2; // Chưa mượn 
                        MUONVATTUService.Insert(muonvattu);

                        capthuoc = new CAPTHUOC();
                        ThamSoHeThong.capthuoc = capthuoc;
                        capthuoc.KHAMTHUONGXUYENID = khamthuongxuyen.ID;
                        capthuoc.BACSIID = khamthuongxuyen.BACSIID;
                        capthuoc.NGAY = khamthuongxuyen.THOIGIAN;
                        CAPTHUOCService.Insert(capthuoc);

                        LoadDgvCHITIETCAPTHUOC();
                        LoadDgvCHITIETMUONVATTU();

                        MessageBox.Show("Thêm thông tin phiếu khám bệnh thường xuyên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // cập nhật
                        CapNhat(ref khamthuongxuyen, tg);
                        bool kt = KHAMTHUONGXUYENService.Update(khamthuongxuyen);
                        if (kt == false) exceptionHelp /= 0;

                        MessageBox.Show("Cập nhật thông tin phiếu khám bệnh thường xuyên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    if (khamthuongxuyen.ID == 0)
                        MessageBox.Show("Thêm phiếu khám bệnh thường xuyên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Sửa thông tin phiếu khám bệnh thường xuyên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (cbxCachGiaiQuyet.SelectedIndex < 2)
                        UpdateStateForm(2);
                    else
                        UpdateStateForm(0);
                    UpdateDetail();
                }
            }
        }

        private void btnHoanThanhNhap_Click(object sender, EventArgs e)
        {
            UpdateDetail();
            UpdateStateForm(0);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateDetail();
            UpdateStateForm(1);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            UpdateDetail();
            UpdateStateForm(0);
        }

        private void btnInGiayGioiThieu_Click(object sender, EventArgs e)
        {
            if (khamthuongxuyen.ID == 0)
            {
                MessageBox.Show("Chưa nhập thông tin phiếu khám bệnh",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (khamthuongxuyen.CACHGIAIQUYET != 2)
            {
                MessageBox.Show("Bệnh nhân không chuyển lên tuyến trên để in giấy giới thiệu",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            FrmInGiayGioiThieu form = new FrmInGiayGioiThieu(khamthuongxuyen);
            form.ShowDialog();
        }

        private void btnCapThemThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCapThemThuoc form = new FrmCapThemThuoc(capthuoc.ID);
                form.ShowDialog();
            }
            catch
            {
            }
            finally
            {
                LoadDgvCHITIETCAPTHUOC();
            }
        }

        private void btnThuHoiThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckLuaChonCHITIETCAPTHUOC())
                {
                    CHITIETCAPTHUOC chitietcapthuoc = getCHITIETCAPTHUOCByID();
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết cấp thuốc này không?",
                                                      "Thông báo",
                                                      MessageBoxButtons.OKCancel,
                                                      MessageBoxIcon.Question);
                    if (rs == DialogResult.Cancel) return;

                    int exceptionHelp = 0;
                    if (!CHITIETCAPTHUOCService.Delete(new CHITIETCAPTHUOCKeys(chitietcapthuoc.ID)))
                        exceptionHelp /= 0;
                }
            }
            catch
            {
                MessageBox.Show("Xóa thông tin chi tiết cấp thuốc thất bại",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                LoadDgvCHITIETCAPTHUOC();
            }
        }

        private void btnMuonThemVatTu_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMuonThemVatTu form = new FrmMuonThemVatTu(muonvattu.ID);
                form.ShowDialog();
            }
            catch
            {
            }
            finally
            {
                LoadDgvCHITIETMUONVATTU();
            }
        }

        private void btnTraVatTu_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckLuaChonCHITIETMUONVATTU())
                {
                    CHITIETMUONVATTU chitietmuonvattu = getCHITIETMUONVATTUByID();
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết mượn vật tư này không?",
                                                      "Thông báo",
                                                      MessageBoxButtons.OKCancel,
                                                      MessageBoxIcon.Question);
                    if (rs == DialogResult.Cancel) return;

                    int exceptionHelp = 0;
                    if (!CHITIETMUONVATTUService.Delete(new CHITIETMUONVATTUKeys(chitietmuonvattu.ID)))
                        exceptionHelp /= 0;
                }
            }
            catch
            {
                MessageBox.Show("Xóa thông tin chi tiết mượn vật tư thất bại",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                LoadDgvCHITIETMUONVATTU();
            }
        }
        #endregion

        #region Sự kiện ngầm
        private void cbxCachGiaiQuyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupDieuTriTaiTuyen.Enabled = false;
            groupChuyenLenTuyenTren.Enabled = false;

            if (cbxCachGiaiQuyet.SelectedIndex == 1)
                groupDieuTriTaiTuyen.Enabled = true;

            if (cbxCachGiaiQuyet.SelectedIndex == 2)
                groupChuyenLenTuyenTren.Enabled = true;
        }
        #endregion

    }
}
