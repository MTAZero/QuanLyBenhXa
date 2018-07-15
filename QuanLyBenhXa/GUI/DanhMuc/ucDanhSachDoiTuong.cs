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
    public partial class ucDanhSachDoiTuong : UserControl
    {
        private DOITUONGFactory DOITUONGService = new DOITUONGFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachDoiTuong()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvDOITUONG()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvDOITUONGMain.DataSource = DOITUONGService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        Ten = p.TEN,
                        KiHieu = p.KYHIEU
                    })
                    .Where(p => p.Ten.ToUpper().Contains(text) || p.KiHieu.ToUpper().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        Ten = p.Ten,
                        KiHieu = p.KiHieu
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvDOITUONG.FocusedRowHandle = index;
                    dgvDOITUONGMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachDoiTuong_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvDOITUONG();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private DOITUONG getDOITUONGByID()
        {
            try
            {
                int id = (int)dgvDOITUONG.GetFocusedRowCellValue("ID");
                DOITUONG ans = DOITUONGService.GetAllBy(DOITUONG.DOITUONGFields.ID, id).FirstOrDefault();
                if (ans == null) return new DOITUONG();
                return ans;
            }
            catch
            {
                return new DOITUONG();
            }
        }

        private DOITUONG getDOITUONGByForm()
        {
            DOITUONG ans = new DOITUONG();

            ans.TEN = txtTen.Text;
            ans.KYHIEU = txtKiHieu.Text;

            return ans;
        }

        private void ClearControl()
        {
            txtTen.Text = "";
            txtKiHieu.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                DOITUONG tg = getDOITUONGByID();

                if (tg.ID == 0) return;

                txtTen.Text = tg.TEN;
                txtKiHieu.Text = tg.KYHIEU;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            txtKiHieu.Enabled = false;

            dgvDOITUONGMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;

            dgvDOITUONGMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của đối tượng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Kí hiệu của đối tượng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            DOITUONG tg = getDOITUONGByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có đối tượng nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref DOITUONG cu, DOITUONG moi)
        {
            cu.TEN = moi.TEN;
            cu.KYHIEU = moi.KYHIEU;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvDOITUONG();
            txtTimKiem.Focus();
        }

        private void dgvDOITUONG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvDOITUONG.FocusedRowHandle;
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

                    DOITUONG moi = getDOITUONGByForm();
                    if (DOITUONGService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin đối tượng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin đối tượng thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvDOITUONG();
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

                    DOITUONG cu = getDOITUONGByID();
                    DOITUONG moi = getDOITUONGByForm();
                    CapNhat(ref cu, moi);

                    if (DOITUONGService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin đối tượng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin đối tượng thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvDOITUONG();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                DOITUONG cu = getDOITUONGByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa đối tượng " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    DOITUONGService.Delete(new DOITUONGKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin đối tượng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin đối tượng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvDOITUONG();

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
