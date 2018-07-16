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
    public partial class ucDanhSachVatTu : UserControl
    {
        private VATTUFactory VATTUService = new VATTUFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachVatTu()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvVATTU()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvVATTUMain.DataSource = VATTUService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        Ten = p.TEN,
                        KiHieu = p.KYHIEU,
                        SoLuong = p.SOLUONG
                    })
                    .Where(p => p.Ten.ToUpper().Contains(text) || p.KiHieu.ToUpper().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        Ten = p.Ten,
                        KiHieu = p.KiHieu,
                        SoLuong = p.SoLuong
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvVATTU.FocusedRowHandle = index;
                    dgvVATTUMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachVatTu_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvVATTU();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private VATTU getVATTUByID()
        {
            try
            {
                int id = (int)dgvVATTU.GetFocusedRowCellValue("ID");
                VATTU ans = VATTUService.GetAllBy(VATTU.VATTUFields.ID, id).FirstOrDefault();
                if (ans == null) return new VATTU();
                return ans;
            }
            catch
            {
                return new VATTU();
            }
        }

        private VATTU getVATTUByForm()
        {
            VATTU ans = new VATTU();

            ans.TEN = txtTen.Text;
            ans.KYHIEU = txtKiHieu.Text;
            ans.SOLUONG = Int32.Parse(txtSoLuong.Text);

            return ans;
        }

        private void ClearControl()
        {
            txtTen.Text = "";
            txtKiHieu.Text = "";
            txtSoLuong.Text = "0";
        }

        private void UpdateDetail()
        {
            try
            {
                VATTU tg = getVATTUByID();

                if (tg.ID == 0) return;

                txtTen.Text = tg.TEN;
                txtKiHieu.Text = tg.KYHIEU;
                txtSoLuong.Text = tg.SOLUONG.ToString();
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            txtKiHieu.Enabled = false;

            dgvVATTUMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtKiHieu.Enabled = true;

            dgvVATTUMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của vật tư không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKiHieu.Text == "")
            {
                MessageBox.Show("Kí hiệu của vật tư không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            VATTU tg = getVATTUByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có vật tư nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref VATTU cu, VATTU moi)
        {
            cu.TEN = moi.TEN;
            cu.KYHIEU = moi.KYHIEU;
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvVATTU();
            txtTimKiem.Focus();
        }

        private void dgvVATTU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvVATTU.FocusedRowHandle;
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

                    VATTU moi = getVATTUByForm();
                    if (VATTUService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin vật tư thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin vật tư thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvVATTU();
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

                    VATTU cu = getVATTUByID();
                    VATTU moi = getVATTUByForm();
                    CapNhat(ref cu, moi);

                    if (VATTUService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin vật tư thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin vật tư thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvVATTU();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                VATTU cu = getVATTUByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa vật tư " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    VATTUService.Delete(new VATTUKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin vật tư thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin vật tư thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvVATTU();

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
