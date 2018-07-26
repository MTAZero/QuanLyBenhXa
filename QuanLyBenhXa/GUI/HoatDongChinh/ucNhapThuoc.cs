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

namespace QuanLyBenhXa.GUI.HoatDongChinh
{
    public partial class ucNhapThuoc : UserControl
    {
        private BACSIFactory BACSIService = new BACSIFactory();
        private THUOCFactory THUOCService = new THUOCFactory();
        private NHAPTHUOCFactory NHAPTHUOCService = new NHAPTHUOCFactory();
        private CHITIETNHAPFactory CHITIETNHAPService = new CHITIETNHAPFactory();

        // Phiếu nhập hiện tại
        private NHAPTHUOC nhapthuoc = new NHAPTHUOC();

        #region Hàm khởi tạo
        public ucNhapThuoc()
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

            cbxBacSi.EditValue = ThamSoHeThong.curBacsi.ID;

            // thuoc
            cbxThuoc.Properties.DataSource = THUOCService.GetAllEntities().ToList().Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxThuoc.Properties.DisplayMember = "Ten";
            cbxThuoc.Properties.ValueMember = "ID";
        }

        private void LoadDgvCHITIETNHAP()
        {
            try
            {
                if (nhapthuoc.ID == 0)
                {
                    dgvCHITIETNHAPMain.DataSource = null;
                    return;
                }

                int i = 0;
                dgvCHITIETNHAPMain.DataSource = CHITIETNHAPService.GetAllEntities().ToList()
                                                .Where(p=>p.NHAPTHUOCID == nhapthuoc.ID)
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    STT = ++i,
                                                    Thuoc = THUOCService.GetAllEntities().ToList().Where(z => z.ID == p.THUOCID).FirstOrDefault().TEN,
                                                    SoLuong = ((int)p.SOLUONG).ToString("N0"),
                                                    DonGia = ((int)p.DONGIA).ToString("N0"),
                                                    ThanhTien = ((int)p.THANHTIEN).ToString("N0")
                                                })
                                                .ToList();

                CapNhatTongTien();
            }
            catch
            {
            }
        }

        private void ucNhapThuoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvCHITIETNHAP();
            LockPHIEUNHAP();
            LockControl();
        }
        #endregion

        #region Hàm chức năng
        private void LockPHIEUNHAP()
        {
            txtGhiChu.Enabled = false;
            btnLuu.Enabled = false;
            btnLapPhieuNhap.Enabled = true;
            btnHoanThanh.Enabled = false;
        }

        private void UnLockPHIEUNHAP()
        {
            txtGhiChu.Enabled = true;
            btnLuu.Enabled = true;
            btnLapPhieuNhap.Enabled = false;
            btnHoanThanh.Enabled = false;
        }

        private void ClearPhieuNhap()
        {
            try
            {
                DateNgay.DateTime = DateTime.Now;
                txtGhiChu.Text = "";
                CapNhatTongTien();
            }
            catch
            {
            }
        }

        private bool CheckLuaChonPhieuNhap()
        {

            if (nhapthuoc.ID == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private NHAPTHUOC GetPhieuNhapByForm()
        {
            NHAPTHUOC ans = new NHAPTHUOC();
            ans.BACSIID = (int) cbxBacSi.EditValue;
            ans.NGAY = DateNgay.DateTime;
            ans.GHICHU = txtGhiChu.Text;
            ans.TONGTIEN = CHITIETNHAPService.GetAllEntities().ToList()
                               .Where(p => p.NHAPTHUOCID == nhapthuoc.ID)
                               .Sum(p => p.THANHTIEN)
                               .Value;
            return ans;
        }

        private CHITIETNHAP getCHITIETNHAPByID()
        {
            try
            {
                int id = (int)dgvCHITIETNHAP.GetFocusedRowCellValue("ID");
                CHITIETNHAP ans = CHITIETNHAPService.GetAllBy(CHITIETNHAP.CHITIETNHAPFields.ID, id).FirstOrDefault();
                if (ans == null) return new CHITIETNHAP();
                return ans;
            }
            catch
            {
                return new CHITIETNHAP();
            }
        }

        private CHITIETNHAP getCHITIETNHAPByForm()
        {
            CHITIETNHAP ans = new CHITIETNHAP();

            ans.NHAPTHUOCID = nhapthuoc.ID;
            ans.THUOCID = (int) cbxThuoc.EditValue;
            ans.SOLUONG = Int32.Parse(txtSoLuong.Text);
            ans.DONGIA = Int32.Parse(txtDonGia.Text);
            ans.GHICHU = txtGhiChu.Text;
            ans.THANHTIEN = ans.SOLUONG * ans.DONGIA;

            return ans;
        }

        private void CapNhatThanhTien()
        {
            try
            {
                txtThanhTien.Text = "0";
                int soluong = Int32.Parse(txtSoLuong.Text);
                int dongia = Int32.Parse(txtDonGia.Text);
                int thanhtien = dongia * soluong;
                txtThanhTien.Text = thanhtien.ToString("N0");
            }
            catch
            {
            }
        }

        private void CapNhatTongTien()
        {
            try
            {
                txtTongTien.Text = "0";
                if (nhapthuoc.ID == 0) return;
                int tongtien = CHITIETNHAPService.GetAllEntities().ToList()
                               .Where(p => p.NHAPTHUOCID == nhapthuoc.ID)
                               .Sum(p => p.THANHTIEN)
                               .Value;
                txtTongTien.Text = tongtien.ToString("N0");
            } catch
            {
            }
        }

        private void ClearControl()
        {
            cbxThuoc.ItemIndex = 0;
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
            CapNhatThanhTien();
        }

        private void UpdateDetail()
        {
            try
            {
                CHITIETNHAP tg = getCHITIETNHAPByID();

                if (tg.ID == 0) return;

                cbxThuoc.EditValue = tg.THUOCID;
                txtSoLuong.Text = tg.SOLUONG.ToString();
                txtDonGia.Text = tg.DONGIA.ToString();
                txtGhiChu.Text = tg.GHICHU;
                CapNhatThanhTien();

            }
            catch
            {

            }
        }

        private void LockControl()
        {
            cbxThuoc.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtGhiChu.Enabled = false;

            dgvCHITIETNHAPMain.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            cbxThuoc.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            txtGhiChu.Enabled = true;

            dgvCHITIETNHAPMain.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private bool Check()
        {
            // so luong
            try
            {
                int k = Int32.Parse(txtSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // don gia
            try
            {
                int k = Int32.Parse(txtDonGia.Text);
            }
            catch
            {
                MessageBox.Show("Đơn giá phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            CHITIETNHAP tg = getCHITIETNHAPByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref CHITIETNHAP cu, CHITIETNHAP moi)
        {
            cu.THUOCID = moi.THUOCID;
            cu.SOLUONG = moi.SOLUONG;
            cu.DONGIA = moi.DONGIA;
            cu.THANHTIEN = moi.THANHTIEN;
            cu.GHICHU = moi.GHICHU;
        }

        #endregion

        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonPhieuNhap()) return;
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

                    CHITIETNHAP moi = getCHITIETNHAPByForm();
                    if (CHITIETNHAPService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin chi tiết nhập thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin chi tiết nhập thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvCHITIETNHAP();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonPhieuNhap()) return;
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

                    CHITIETNHAP cu = getCHITIETNHAPByID();
                    CHITIETNHAP moi = getCHITIETNHAPByForm();
                    CapNhat(ref cu, moi);

                    if (CHITIETNHAPService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin chi tiết nhập thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin chi tiết nhập thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvCHITIETNHAP();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                CHITIETNHAP cu = getCHITIETNHAPByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết nhập ?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    CHITIETNHAPService.Delete(new CHITIETNHAPKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin chi tiết nhập thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin chi tiết nhập thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvCHITIETNHAP();

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

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            ClearPhieuNhap();
            UnLockPHIEUNHAP();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhapthuoc = GetPhieuNhapByForm();
            if (NHAPTHUOCService.Insert(nhapthuoc))
            {
                btnHoanThanh.Enabled = true;
                btnLuu.Enabled = false;
                MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (nhapthuoc.ID != 0)
                NHAPTHUOCService.Update(nhapthuoc);
            nhapthuoc = new NHAPTHUOC();
            ClearPhieuNhap();
            LockPHIEUNHAP();
            LoadDgvCHITIETNHAP();
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvCHITIETNHAP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();
        }
        #endregion

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
            CapNhatTongTien();
        }
    }
}
