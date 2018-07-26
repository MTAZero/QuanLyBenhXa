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
    public partial class ucDanhSachPhanLoaiSucKhoe : UserControl
    {
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachPhanLoaiSucKhoe()
        {
            InitializeComponent();
        }
        #endregion

        #region Load Form
        private void LoadDgvPHANLOAISUCKHOE()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvPHANLOAISUCKHOEMain.DataSource = PHANLOAISUCKHOEService.GetAllEntities().ToList()
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
                    dgvPHANLOAISUCKHOE.FocusedRowHandle = index;
                    dgvPHANLOAISUCKHOEMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachPhanLoaiSucKhoe_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvPHANLOAISUCKHOE();
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
        private PHANLOAISUCKHOE getPHANLOAISUCKHOEByID()
        {
            try
            {
                int id = (int)dgvPHANLOAISUCKHOE.GetFocusedRowCellValue("ID");
                PHANLOAISUCKHOE ans = PHANLOAISUCKHOEService.GetAllBy(PHANLOAISUCKHOE.PHANLOAISUCKHOEFields.ID, id).FirstOrDefault();
                if (ans == null) return new PHANLOAISUCKHOE();
                return ans;
            }
            catch
            {
                return new PHANLOAISUCKHOE();
            }
        }

        private PHANLOAISUCKHOE getPHANLOAISUCKHOEByForm()
        {
            PHANLOAISUCKHOE ans = new PHANLOAISUCKHOE();

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
                PHANLOAISUCKHOE tg = getPHANLOAISUCKHOEByID();

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

            dgvPHANLOAISUCKHOEMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;

            dgvPHANLOAISUCKHOEMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của phân loại sức khỏe không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Kí hiệu của phân loại sức khỏe không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            PHANLOAISUCKHOE tg = getPHANLOAISUCKHOEByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có phân loại sức khỏe nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref PHANLOAISUCKHOE cu, PHANLOAISUCKHOE moi)
        {
            cu.TEN = moi.TEN;
            cu.KIHIEU = moi.KIHIEU;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvPHANLOAISUCKHOE();
            txtTimKiem.Focus();
        }

        private void dgvPHANLOAISUCKHOE_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvPHANLOAISUCKHOE.FocusedRowHandle;
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

                    PHANLOAISUCKHOE moi = getPHANLOAISUCKHOEByForm();
                    if (PHANLOAISUCKHOEService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin phân loại sức khỏe thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin phân loại sức khỏe thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvPHANLOAISUCKHOE();
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

                    PHANLOAISUCKHOE cu = getPHANLOAISUCKHOEByID();
                    PHANLOAISUCKHOE moi = getPHANLOAISUCKHOEByForm();
                    CapNhat(ref cu, moi);

                    if (PHANLOAISUCKHOEService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin phân loại sức khỏe thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin phân loại sức khỏe thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvPHANLOAISUCKHOE();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                PHANLOAISUCKHOE cu = getPHANLOAISUCKHOEByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa phân loại sức khỏe " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    PHANLOAISUCKHOEService.Delete(new PHANLOAISUCKHOEKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin phân loại sức khỏe thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin phân loại sức khỏe thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvPHANLOAISUCKHOE();

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
