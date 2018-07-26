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
    public partial class ucDanhSachBenhVien : UserControl
    {
        private BENHVIENFactory BENHVIENService = new BENHVIENFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachBenhVien()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvBENHVIEN()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvBENHVIENMain.DataSource = BENHVIENService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        Ten = p.TEN,
                        KiHieu = p.KIHIEU,
                        DiaChi = p.DIACHI
                    })
                    .Where(p => p.Ten.ToUpper().Contains(text) || p.KiHieu.ToUpper().Contains(text) || p.DiaChi.ToUpper().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        Ten = p.Ten,
                        KiHieu = p.KiHieu,
                        DiaChi = p.DiaChi
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvBENHVIEN.FocusedRowHandle = index;
                    dgvBENHVIENMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachBenhVien_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvBENHVIEN();
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
        private BENHVIEN getBENHVIENByID()
        {
            try
            {
                int id = (int)dgvBENHVIEN.GetFocusedRowCellValue("ID");
                BENHVIEN ans = BENHVIENService.GetAllBy(BENHVIEN.BENHVIENFields.ID, id).FirstOrDefault();
                if (ans == null) return new BENHVIEN();
                return ans;
            }
            catch
            {
                return new BENHVIEN();
            }
        }

        private BENHVIEN getBENHVIENByForm()
        {
            BENHVIEN ans = new BENHVIEN();

            ans.TEN = txtTen.Text;
            ans.KIHIEU = txtKiHieu.Text;
            ans.DIACHI = txtDiaChi.Text;

            return ans;
        }

        private void ClearControl()
        {
            txtTen.Text = "";
            txtKiHieu.Text = "";
            txtDiaChi.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                BENHVIEN tg = getBENHVIENByID();

                if (tg.ID == 0) return;

                txtTen.Text = tg.TEN;
                txtKiHieu.Text = tg.KIHIEU;
                txtDiaChi.Text = tg.DIACHI;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            txtKiHieu.Enabled = false;
            txtDiaChi.Enabled = false;

            dgvBENHVIENMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;
            txtDiaChi.Enabled = true;

            dgvBENHVIENMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của bệnh viện không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Kí hiệu của bệnh viện không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ của bệnh viện không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            BENHVIEN tg = getBENHVIENByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có bệnh viện nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        

        private void CapNhat(ref BENHVIEN cu, BENHVIEN moi)
        {
            cu.TEN = moi.TEN;
            cu.KIHIEU = moi.KIHIEU;
            cu.DIACHI = moi.DIACHI;
        }

        #endregion

        #region sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvBENHVIEN();
            txtTimKiem.Focus();
        }

        private void dgvBENHVIEN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvBENHVIEN.FocusedRowHandle;
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

                    BENHVIEN moi = getBENHVIENByForm();
                    if (BENHVIENService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin bệnh viện thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin bệnh viện thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBENHVIEN();
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

                    BENHVIEN cu = getBENHVIENByID();
                    BENHVIEN moi = getBENHVIENByForm();
                    CapNhat(ref cu, moi);

                    if (BENHVIENService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin bệnh viện thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin bệnh viện thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBENHVIEN();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                BENHVIEN cu = getBENHVIENByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa bệnh viện " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    BENHVIENService.Delete(new BENHVIENKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin bệnh viện thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin bệnh viện thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvBENHVIEN();

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
