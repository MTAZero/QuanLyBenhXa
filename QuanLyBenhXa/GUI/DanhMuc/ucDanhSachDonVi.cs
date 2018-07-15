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
    public partial class ucDanhSachDonVi : UserControl
    {
        private DONVIFactory DONVIService = new DONVIFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachDonVi()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvDONVI()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvDONVIMain.DataSource = DONVIService.GetAllEntities().ToList()
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
                    dgvDONVI.FocusedRowHandle = index;
                    dgvDONVIMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachDonVi_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvDONVI();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private DONVI getDONVIByID()
        {
            try
            {
                int id = (int)dgvDONVI.GetFocusedRowCellValue("ID");
                DONVI ans = DONVIService.GetAllBy(DONVI.DONVIFields.ID, id).FirstOrDefault();
                if (ans == null) return new DONVI();
                return ans;
            }
            catch
            {
                return new DONVI();
            }
        }

        private DONVI getDONVIByForm()
        {
            DONVI ans = new DONVI();

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
                DONVI tg = getDONVIByID();

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

            dgvDONVIMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;

            dgvDONVIMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của đơn vị không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Địa chỉ của đơn vị không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            DONVI tg = getDONVIByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có đơn vị nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        

        private void CapNhat(ref DONVI cu, DONVI moi)
        {
            cu.TEN = moi.TEN;
            cu.KIHIEU = moi.KIHIEU;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvDONVI();
            txtTimKiem.Focus();
        }

        private void dgvDonVi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvDONVI.FocusedRowHandle;
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

                    DONVI moi = getDONVIByForm();
                    if (DONVIService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin đơn vị thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin đơn vị thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvDONVI();
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

                    DONVI cu = getDONVIByID();
                    DONVI moi = getDONVIByForm();
                    CapNhat(ref cu, moi);

                    if (DONVIService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin đơn vị thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin đơn vị thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvDONVI();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                DONVI cu = getDONVIByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa đơn vị " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    DONVIService.Delete(new DONVIKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin đơn vị thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin đơn vị thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvDONVI();

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
