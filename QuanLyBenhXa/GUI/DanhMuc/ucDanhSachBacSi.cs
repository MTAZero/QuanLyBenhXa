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
    public partial class ucDanhSachBacSi : UserControl
    {
        private BACSIFactory BACSIService = new BACSIFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private DONVIFactory DONVIService = new DONVIFactory();
        private DOITUONGFactory DOITUONGService = new DOITUONGFactory();

        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachBacSi()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
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
        private void LoadDgvBACSI()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvBACSIMain.DataSource = BACSIService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        HoTen = p.HOTEN,
                        ChucVu = CHUCVUService.GetAllEntities().ToList().Where(z => z.ID == p.CHUCVUID).FirstOrDefault().TEN
                    })
                    .Where(p => p.HoTen.ToUpper().Contains(text) || p.ChucVu.ToUpper().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        HoTen = p.HoTen,
                        ChucVu = p.ChucVu
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvBACSI.FocusedRowHandle = index;
                    dgvBACSIMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachBacSi_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvBACSI();
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
        private BACSI getBACSIByID()
        {
            try
            {
                int id = (int)dgvBACSI.GetFocusedRowCellValue("ID");
                BACSI ans = BACSIService.GetAllBy(BACSI.BACSIFields.ID, id).FirstOrDefault();
                if (ans == null) return new BACSI();
                return ans;
            }
            catch
            {
                return new BACSI();
            }
        }

        private BACSI getBACSIByForm()
        {
            BACSI ans = new BACSI();

            ans.HOTEN = txtHoTen.Text;
            ans.NGAYSINH = dateNgaySinh.DateTime;
            ans.SDT = txtSDT.Text;
            ans.QUEQUAN = txtQueQuan.Text;
            ans.DANTOC = txtDanToc.Text;
            ans.TRINHDOVANHOA = txtTrinhDo.Text;

            ans.DONVIID = (int) cbxDonVi.EditValue;
            ans.CAPBACID = (int) cbxCapBac.EditValue;
            ans.CHUCVUID = (int) cbxChucVu.EditValue;
            ans.DOITUONGID = (int) cbxDoiTuong.EditValue;
            ans.QUYEN = cbxQuyen.SelectedIndex;
            ans.GIOITINH = cbxGioiTinh.SelectedIndex;

            return ans;
        }

        private void ClearControl()
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text = "";
            txtDanToc.Text = "";
            txtTrinhDo.Text = "";

            cbxCapBac.ItemIndex = 0;
            cbxChucVu.ItemIndex = 0;
            cbxDonVi.ItemIndex = 0;
            cbxDoiTuong.ItemIndex = 0;
            cbxQuyen.SelectedIndex = 0;
            cbxGioiTinh.SelectedIndex = 0;
            dateNgaySinh.DateTime = DateTime.Now;
        }

        private void UpdateDetail()
        {
            try
            {
                BACSI tg = getBACSIByID();

                if (tg.ID == 0) return;

                txtHoTen.Text = tg.HOTEN;
                txtSDT.Text = tg.SDT;
                txtQueQuan.Text = tg.QUEQUAN;
                txtDanToc.Text = tg.DANTOC;
                txtTrinhDo.Text = tg.TRINHDOVANHOA;

                cbxCapBac.EditValue = (int) tg.CAPBACID;
                cbxChucVu.EditValue = (int) tg.CHUCVUID;
                cbxDonVi.EditValue = (int) tg.DONVIID;
                cbxDoiTuong.EditValue = (int) tg.DOITUONGID;
                cbxQuyen.SelectedIndex = (int) tg.QUYEN;
                cbxGioiTinh.SelectedIndex = (int) tg.GIOITINH;
                dateNgaySinh.DateTime = (DateTime) tg.NGAYSINH;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtQueQuan.Enabled = false;
            txtDanToc.Enabled = false;
            txtTrinhDo.Enabled = false;

            cbxCapBac.Enabled = false;
            cbxChucVu.Enabled = false;
            cbxDonVi.Enabled = false;
            cbxDoiTuong.Enabled = false;
            cbxQuyen.Enabled = false;
            cbxGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;

            dgvBACSIMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            txtQueQuan.Enabled = true;
            txtDanToc.Enabled = true;
            txtTrinhDo.Enabled = true;

            cbxCapBac.Enabled = true;
            cbxChucVu.Enabled = true;
            cbxDonVi.Enabled = true;
            cbxDoiTuong.Enabled = true;
            cbxQuyen.Enabled = true;
            cbxGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;

            dgvBACSIMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ và tên của bác sĩ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateNgaySinh.DateTime > DateTime.Now.AddYears(-20))
            {
                MessageBox.Show("Ngày sinh của bác sĩ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            BACSI tg = getBACSIByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có bác sĩ nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref BACSI cu, BACSI moi)
        {
            cu.HOTEN = moi.HOTEN;
            cu.DONVIID = moi.DONVIID;
            cu.CAPBACID = moi.CAPBACID;
            cu.CHUCVUID = moi.CHUCVUID;
            cu.DOITUONGID = moi.DOITUONGID;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.GIOITINH = moi.GIOITINH;
            cu.QUYEN = moi.QUYEN;
            cu.SDT = moi.SDT;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.DANTOC = moi.DANTOC;
            cu.TRINHDOVANHOA = moi.TRINHDOVANHOA;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvBACSI();
            txtTimKiem.Focus();
        }

        private void dgvBACSI_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvBACSI.FocusedRowHandle;
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

                    BACSI moi = getBACSIByForm();
                    if (BACSIService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin bác sĩ thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin bác sĩ thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBACSI();
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

                    BACSI cu = getBACSIByID();
                    BACSI moi = getBACSIByForm();
                    CapNhat(ref cu, moi);

                    if (BACSIService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin bác sĩ thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin bác sĩ thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBACSI();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                BACSI cu = getBACSIByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa bác sĩ " + cu.HOTEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    BACSIService.Delete(new BACSIKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin bác sĩ thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin bác sĩ thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvBACSI();

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
