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

namespace QuanLyBenhXa.GUI.DanhMuc
{
    public partial class ucDanhSachBenhNhan : UserControl
    {
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private DONVIFactory DONVIService = new DONVIFactory();
        private DOITUONGFactory DOITUONGService = new DOITUONGFactory();

        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachBenhNhan()
        {
            InitializeComponent();
        }
        #endregion

        #region Load Form
        private void LoadInitControl()
        {
            // Chức vụ
            cbxChucVu.Properties.DataSource = CHUCVUService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxChucVu.Properties.DisplayMember = "TEN";
            cbxChucVu.Properties.ValueMember = "ID";

            // Cấp bậc
            cbxCapBac.Properties.DataSource = CAPBACService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxCapBac.Properties.DisplayMember = "TEN";
            cbxCapBac.Properties.ValueMember = "ID";

            // Đối tượng
            cbxDoiTuong.Properties.DataSource = DOITUONGService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxDoiTuong.Properties.DisplayMember = "TEN";
            cbxDoiTuong.Properties.ValueMember = "ID";

            // Đơn vị
            cbxDonVi.Properties.DataSource = DONVIService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxDonVi.Properties.DisplayMember = "TEN";
            cbxDonVi.Properties.ValueMember = "ID";
        }
        private void LoadDgvBENHNHAN()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvBENHNHANMain.DataSource = BENHNHANService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        HoTen = p.HOTEN,
                        ChucVu = CHUCVUService.GetAllEntities().ToList().Where(z => z.ID == p.CHUCVUID).FirstOrDefault().TEN,
                        DonVi = DONVIService.GetByPrimaryKey(new DONVIKeys((int)p.DONVIID)).TEN,
                        DoiTuong = DOITUONGService.GetByPrimaryKey(new DOITUONGKeys((int)p.DOITUONGID)).TEN
                    })
                    .Where(p => p.HoTen.ToUpper().Contains(text) || p.ChucVu.ToUpper().Contains(text) || p.DonVi.ToUpper().Contains(text) || p.DoiTuong.ToUpper().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        HoTen = p.HoTen,
                        ChucVu = p.ChucVu,
                        DonVi = p.DonVi,
                        DoiTuong = p.DoiTuong
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvBENHNHAN.FocusedRowHandle = index;
                    dgvBENHNHANMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachBenhNhan_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvBENHNHAN();
            LockControl();

            if (ThamSoHeThong.curBacsi.ID == 0 || ThamSoHeThong.curBacsi.QUYEN == 0)
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
        }
        #endregion

        #region Hàm chức năng 
        private BENHNHAN getBENHNHANByID()
        {
            try
            {
                int id = (int)dgvBENHNHAN.GetFocusedRowCellValue("ID");
                BENHNHAN ans = BENHNHANService.GetAllBy(BENHNHAN.BENHNHANFields.ID, id).FirstOrDefault();
                if (ans == null) return new BENHNHAN();
                return ans;
            }
            catch
            {
                return new BENHNHAN();
            }
        }

        private BENHNHAN getBENHNHANByForm()
        {
            BENHNHAN ans = new BENHNHAN();

            ans.HOTEN = txtHoTen.Text;
            ans.NGAYSINH = dateNgaySinh.DateTime;
            ans.SDT = txtSDT.Text;
            ans.QUEQUAN = txtQueQuan.Text;
            ans.MATHEBHYT = txtMaBHYT.Text;
            ans.TRINHDOVANHOA = txtTrinhDo.Text;
            ans.NGHENGHIEPTRUOCNN = txtNgheNghiepTruoc.Text;
            ans.NGHENGHIEPSAUNN = txtNgheNghiepSau.Text;
            ans.NHOMMAU = txtNhomMau.Text;
            ans.TIENSUGIADINH = txtTienSuGiaDinh.Text;
            ans.TIENSUBANTHAN = txtTienSuBanThan.Text;
            ans.NAMNHAPNGU = Int32.Parse(txtNamNhapNgu.Text);

            ans.DONVIID = (int)cbxDonVi.EditValue;
            ans.CAPBACID = (int)cbxCapBac.EditValue;
            ans.CHUCVUID = (int)cbxChucVu.EditValue;
            ans.DOITUONGID = (int)cbxDoiTuong.EditValue;
            ans.GIOITINH = cbxGioiTinh.SelectedIndex;

            return ans;
        }

        private void ClearControl()
        {
            txtHoTen.Text = "";
            txtMaBHYT.Text = "";
            txtSDT.Text = "";
            txtNamNhapNgu.Text = "";
            txtQueQuan.Text = "";
            txtNgheNghiepSau.Text = "";
            txtNhomMau.Text = "";
            txtTienSuBanThan.Text = "";
            txtTrinhDo.Text = "";

            cbxCapBac.ItemIndex = 0;
            cbxChucVu.ItemIndex = 0;
            cbxDonVi.ItemIndex = 0;
            cbxDoiTuong.ItemIndex = 0;
            cbxGioiTinh.SelectedIndex = 0;
            dateNgaySinh.DateTime = DateTime.Now;
        }

        private void UpdateDetail()
        {
            try
            {
                BENHNHAN tg = getBENHNHANByID();

                if (tg.ID == 0) return;

                txtHoTen.Text = tg.HOTEN;
                txtMaBHYT.Text = tg.MATHEBHYT;
                txtSDT.Text = tg.SDT;
                txtNamNhapNgu.Text = tg.NAMNHAPNGU.ToString();
                txtQueQuan.Text = tg.QUEQUAN;
                txtNgheNghiepSau.Text = tg.NGHENGHIEPSAUNN;
                txtNgheNghiepTruoc.Text = tg.NGHENGHIEPTRUOCNN;
                txtNhomMau.Text = tg.NHOMMAU;
                txtTienSuBanThan.Text = tg.TIENSUBANTHAN;
                txtTienSuGiaDinh.Text = tg.TIENSUGIADINH;
                txtTrinhDo.Text = tg.TRINHDOVANHOA;

                cbxCapBac.EditValue = (int)tg.CAPBACID;
                cbxChucVu.EditValue = (int)tg.CHUCVUID;
                cbxDonVi.EditValue = (int)tg.DONVIID;
                cbxDoiTuong.EditValue = (int)tg.DOITUONGID;
                cbxGioiTinh.SelectedIndex = (int)tg.GIOITINH;
                dateNgaySinh.DateTime = (DateTime)tg.NGAYSINH;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtHoTen.Enabled = false;
            txtMaBHYT.Enabled = false;
            txtSDT.Enabled = false;
            txtNamNhapNgu.Enabled = false;
            txtQueQuan.Enabled = false;
            txtNgheNghiepTruoc.Enabled = false;
            txtNgheNghiepSau.Enabled = false;
            txtNhomMau.Enabled = false;
            txtTienSuBanThan.Enabled = false;
            txtTienSuGiaDinh.Enabled = false;
            txtTrinhDo.Enabled = false;
            
            cbxCapBac.Enabled = false;
            cbxChucVu.Enabled = false;
            cbxDonVi.Enabled = false;
            cbxDoiTuong.Enabled = false;
            cbxGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;

            dgvBENHNHANMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtHoTen.Enabled = true;
            txtMaBHYT.Enabled = true;
            txtSDT.Enabled = true;
            txtNamNhapNgu.Enabled = true;
            txtQueQuan.Enabled = true;
            txtNgheNghiepTruoc.Enabled = true;
            txtNgheNghiepSau.Enabled = true;
            txtNhomMau.Enabled = true;
            txtTienSuBanThan.Enabled = true;
            txtTienSuGiaDinh.Enabled = true;
            txtTrinhDo.Enabled = true;

            cbxCapBac.Enabled = true;
            cbxChucVu.Enabled = true;
            cbxDonVi.Enabled = true;
            cbxDoiTuong.Enabled = true;
            cbxGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;

            dgvBENHNHANMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ và tên của bệnh nhân không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateNgaySinh.DateTime > DateTime.Now.AddYears(-20))
            {
                MessageBox.Show("Ngày sinh của bệnh nhân không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int nnn = Int32.Parse(txtNamNhapNgu.Text);
            }
            catch
            {
                MessageBox.Show("Năm nhập ngũ phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            BENHNHAN tg = getBENHNHANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có bệnh nhân nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref BENHNHAN cu, BENHNHAN moi)
        {
            cu.HOTEN = moi.HOTEN;
            cu.DONVIID = moi.DONVIID;
            cu.CAPBACID = moi.CAPBACID;
            cu.CHUCVUID = moi.CHUCVUID;
            cu.DOITUONGID = moi.DOITUONGID;
            cu.MATHEBHYT = moi.MATHEBHYT;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.GIOITINH = moi.GIOITINH;
            cu.SDT = moi.SDT;
            cu.NAMNHAPNGU = moi.NAMNHAPNGU;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.NGHENGHIEPTRUOCNN = moi.NGHENGHIEPTRUOCNN;
            cu.NGHENGHIEPSAUNN = moi.NGHENGHIEPSAUNN;
            cu.NHOMMAU = moi.NHOMMAU;
            cu.TIENSUBANTHAN = moi.TIENSUBANTHAN;
            cu.TIENSUGIADINH = moi.TIENSUGIADINH;
            cu.TRINHDOVANHOA = moi.TRINHDOVANHOA;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvBENHNHAN();
            txtTimKiem.Focus();
        }

        private void dgvBENHNHAN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvBENHNHAN.FocusedRowHandle;
            }
            catch { }
        }

        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnSua.Enabled = false;
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";

                ClearControl();
                UnlockControl();


                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    BENHNHAN moi = getBENHNHANByForm();
                    if (BENHNHANService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin bệnh nhân thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin bệnh nhân thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBENHNHAN();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    LockControl();

                    BENHNHAN cu = getBENHNHANByID();
                    BENHNHAN moi = getBENHNHANByForm();
                    CapNhat(ref cu, moi);

                    if (BENHNHANService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin bệnh nhân thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin bệnh nhân thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBENHNHAN();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                BENHNHAN cu = getBENHNHANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa bệnh nhân " + cu.HOTEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    BENHNHANService.Delete(new BENHNHANKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin bệnh nhân thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin bệnh nhân thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvBENHNHAN();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }
        #endregion
    }
}
