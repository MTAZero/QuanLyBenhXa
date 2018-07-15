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
    public partial class ucDanhSachCapBac : UserControl
    {
        private CAPBACFactory capbacService = new CAPBACFactory();

        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachCapBac()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvCapBac()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvCapBacMain.DataSource = capbacService.GetAllEntities().ToList()
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
                    dgvCapBac.FocusedRowHandle = index;
                    dgvCapBacMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachCapBac_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvCapBac();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private CAPBAC getCAPBACByID()
        {
            try
            {
                int id = (int)dgvCapBac.GetFocusedRowCellValue("ID");
                CAPBAC ans = capbacService.GetAllBy(CAPBAC.CAPBACFields.ID, id).FirstOrDefault(); 
                    //db.CAPBACs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new CAPBAC();
                return ans;
            }
            catch
            {
                return new CAPBAC();
            }
        }

        private CAPBAC getCAPBACByForm()
        {
            CAPBAC ans = new CAPBAC();

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
                CAPBAC tg = getCAPBACByID();

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

            dgvCapBacMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;

            dgvCapBacMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của cấp bậc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Kí hiệu của cấp bậc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            CAPBAC tg = getCAPBACByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có cấp bậc nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref CAPBAC cu, CAPBAC moi)
        {
            cu.TEN = moi.TEN;
            cu.KIHIEU = moi.KIHIEU;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvCapBac();
            txtTimKiem.Focus();
        }

        private void dgvCapBac_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvCapBac.FocusedRowHandle;
            }
            catch { }
        }
        #endregion

        #region sự kiện
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

                    CAPBAC moi = getCAPBACByForm();
                    if (capbacService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin cấp bậc thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin cấp bậc thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvCapBac();
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

                    CAPBAC cu = getCAPBACByID();
                    CAPBAC moi = getCAPBACByForm();
                    CapNhat(ref cu, moi);

                    if (capbacService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin cấp bậc thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Sửa thông tin cấp bậc thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvCapBac();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                CAPBAC cu = getCAPBACByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa cấp bậc " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    capbacService.Delete(new CAPBACKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin cấp bậc thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin cấp bậc thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvCapBac();

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
