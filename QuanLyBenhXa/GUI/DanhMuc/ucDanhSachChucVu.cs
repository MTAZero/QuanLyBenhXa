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
    public partial class ucDanhSachChucVu : UserControl
    {
        private CHUCVUFactory chucvuService = new CHUCVUFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachChucVu()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvCHUCVU()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvCHUCVUMain.DataSource = chucvuService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        Ten = p.TEN,
                        KiHieu = p.KIHIEU
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
                    dgvCHUCVU.FocusedRowHandle = index;
                    dgvCHUCVUMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachChucVu_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvCHUCVU();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private CHUCVU getCHUCVUByID()
        {
            try
            {
                int id = (int)dgvCHUCVU.GetFocusedRowCellValue("ID");
                CHUCVU ans = chucvuService.GetAllBy(CHUCVU.CHUCVUFields.ID, id).FirstOrDefault();
                if (ans == null) return new CHUCVU();
                return ans;
            }
            catch
            {
                return new CHUCVU();
            }
        }

        private CHUCVU getCHUCVUByForm()
        {
            CHUCVU ans = new CHUCVU();

            ans.TEN = txtTen.Text;
            ans.KIHIEU = txtKiHieu.Text;

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
                CHUCVU tg = getCHUCVUByID();

                if (tg.ID == 0) return;

                txtTen.Text = tg.TEN;
                txtKiHieu.Text = tg.KIHIEU;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            txtKiHieu.Enabled = false;

            dgvCHUCVUMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;

            dgvCHUCVUMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của chức vụ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Địa chỉ của chức vụ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            CHUCVU tg = getCHUCVUByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có chức vụ nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        

        private void CapNhat(ref CHUCVU cu, CHUCVU moi)
        {
            cu.TEN = moi.TEN;
            cu.KIHIEU = moi.KIHIEU;
        }

        #endregion

        #region sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvCHUCVU();
            txtTimKiem.Focus();
        }

        private void dgvCHUCVU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvCHUCVU.FocusedRowHandle;
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

                    CHUCVU moi = getCHUCVUByForm();
                    if (chucvuService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin chức vụ thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin chức vụ thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvCHUCVU();
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

                    CHUCVU cu = getCHUCVUByID();
                    CHUCVU moi = getCHUCVUByForm();
                    CapNhat(ref cu, moi);

                    if (chucvuService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin chức vụ thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin chức vụ thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvCHUCVU();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                CHUCVU cu = getCHUCVUByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chức vụ " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    chucvuService.Delete(new CHUCVUKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin chức vụ thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin chức vụ thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvCHUCVU();

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
