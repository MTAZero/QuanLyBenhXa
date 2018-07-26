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
using System.Security.Cryptography;
using QuanLyBenhXa.Lib;

namespace QuanLyBenhXa.GUI.TaiKhoan
{
    public partial class ucDanhSachTaiKhoan : UserControl
    {
        private int index = 0, index1 = 0;
        private BACSIFactory BACSIService = new BACSIFactory();
        private TAIKHOANFactory TAIKHOANService = new TAIKHOANFactory();

        #region Hàm khởi tạo
        public ucDanhSachTaiKhoan()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            // cbxChuTaiKhoan
            var listTaiKhoan = BACSIService.GetAllEntities().ToList()
                               .Select(p => new { ID = p.ID, Ten = p.HOTEN })
                               .ToList();

            cbxChuTaiKhoan.Properties.DataSource = listTaiKhoan;
            cbxChuTaiKhoan.Properties.DisplayMember = "Ten";
            cbxChuTaiKhoan.Properties.ValueMember = "ID";
        }

        private void LoadDgvTAIKHOAN()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvTAIKHOANMain.DataSource = TAIKHOANService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        TenDangNhap = p.TENDANGNHAP,
                        LoaiTaiKhoan = (TAIKHOANService.LoaiTaiKhoan(p) == 0) ? "Công khai" : "Cá nhân",
                        ChuTaiKhoan = (TAIKHOANService.ChuSoHuu(p) == null) ? "Không" : TAIKHOANService.ChuSoHuu(p).HOTEN
                    })
                    .Where(p => p.TenDangNhap.ToUpper().Contains(text) || p.LoaiTaiKhoan.ToUpper().Contains(text) || p.ChuTaiKhoan.ToUpper().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        TenDangNhap = p.TenDangNhap,
                        LoaiTaiKhoan = p.LoaiTaiKhoan,
                        ChuTaiKhoan = p.ChuTaiKhoan
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvTAIKHOAN.FocusedRowHandle = index;
                    dgvTAIKHOANMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvTAIKHOAN();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private TAIKHOAN getTAIKHOANByID()
        {
            try
            {
                int id = (int)dgvTAIKHOAN.GetFocusedRowCellValue("ID");
                TAIKHOAN ans = TAIKHOANService.GetAllBy(TAIKHOAN.TAIKHOANFields.ID, id).FirstOrDefault();
                if (ans == null) return new TAIKHOAN();
                return ans;
            }
            catch
            {
                return new TAIKHOAN();
            }
        }

        private TAIKHOAN getTAIKHOANByForm()
        {
            TAIKHOAN ans = new TAIKHOAN();

            ans.TENDANGNHAP = txtTenDangNhap.Text;
            ans.PASSWORDMD5 = MD5Helper.GetMD5HashValue("123456");

            return ans;
        }

        private void ClearControl()
        {
            txtTenDangNhap.Text = "";
            rdTaiKhoanCongKhai.Checked = true;
        }

        private void UpdateDetail()
        {
            try
            {
                TAIKHOAN tg = getTAIKHOANByID();

                if (tg.ID == 0) return;

                txtTenDangNhap.Text = tg.TENDANGNHAP;

                int SOLUONG = BACSIService.GetAllEntities().ToList()
                              .Where(p => p.TAIKHOANID == tg.ID)
                              .ToList()
                              .Count;
                if (SOLUONG == 0)
                {
                    cbxChuTaiKhoan.Visible = false;
                    lblChuTaiKhoan.Visible = false;
                    rdTaiKhoanCongKhai.Checked = true;
                }
                else
                {
                    cbxChuTaiKhoan.Visible = true;
                    lblChuTaiKhoan.Visible = true;
                    rdTaiKhoanCaNhan.Checked = true;
                    BACSI bacsi = BACSIService.GetAllEntities().ToList()
                                  .Where(p => p.TAIKHOANID == tg.ID)
                                  .FirstOrDefault();
                    cbxChuTaiKhoan.EditValue = bacsi.ID;
                }
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenDangNhap.Enabled = false;
            cbxChuTaiKhoan.Enabled = false;
            rdTaiKhoanCaNhan.Enabled = false;
            rdTaiKhoanCongKhai.Enabled = false;

            dgvTAIKHOANMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenDangNhap.Enabled = true;
            cbxChuTaiKhoan.Enabled = true;
            rdTaiKhoanCaNhan.Enabled = true;
            rdTaiKhoanCongKhai.Enabled = true;

            dgvTAIKHOANMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập của tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // kiem tra khoang trang
            if (txtTenDangNhap.Text.Contains(' '))
            {
                MessageBox.Show("Tên đăng nhập của tài khoản không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // kiểm tra trùng
            try
            {
                int soluong = TAIKHOANService.GetAllEntities().ToList()
                               .Where(p => p.TENDANGNHAP.ToUpper() == txtTenDangNhap.Text.ToUpper())
                               .ToList()
                               .Count;
                if (soluong > 0) soluong = soluong / 0;
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // kiểm tra cá nhân
            if (rdTaiKhoanCaNhan.Checked == true)
            {
                try
                {
                    int bacsiid = (int)cbxChuTaiKhoan.EditValue;
                    BACSI bacsi = BACSIService.GetByPrimaryKey(new BACSIKeys(bacsiid));
                    if (bacsi.TAIKHOANID != null) bacsiid = bacsiid / 0;
                }
                catch
                {
                    MessageBox.Show("Cá nhân đã sở hữu tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            TAIKHOAN tg = getTAIKHOANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có tài khoản nào được chọn",
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
            if (btnThem.Text == "Thêm")
            {
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

                    TAIKHOAN moi = getTAIKHOANByForm();
                    int bacsiID = 0;
                    if (rdTaiKhoanCongKhai.Checked)
                        bacsiID = 0;
                    else
                        bacsiID = (int) cbxChuTaiKhoan.EditValue;
                    if (TAIKHOANService.Insert(moi, bacsiID))
                    {
                        MessageBox.Show("Thêm thông tin tài khoản thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin tài khoản thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTAIKHOAN();
                }
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                TAIKHOAN cu = getTAIKHOANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa tài khoản này không?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    TAIKHOANService.Delete(new TAIKHOANKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin tài khoản thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin tài khoản thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvTAIKHOAN();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvTAIKHOAN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvTAIKHOAN.FocusedRowHandle;
            }
            catch { }
        }

        private void rdTaiKhoanCongKhai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTaiKhoanCaNhan.Checked)
            {
                cbxChuTaiKhoan.Visible = true;
                lblChuTaiKhoan.Visible = true;
            }
            else
            {
                cbxChuTaiKhoan.Visible = false;
                lblChuTaiKhoan.Visible = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvTAIKHOAN();
            txtTimKiem.Focus();
        }
        #endregion
    }
}
