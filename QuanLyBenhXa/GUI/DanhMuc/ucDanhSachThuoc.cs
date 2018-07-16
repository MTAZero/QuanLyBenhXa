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
    public partial class ucDanhSachThuoc : UserControl
    {
        private THUOCFactory THUOCService = new THUOCFactory();
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachThuoc()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvTHUOC()
        {
            try
            {
                int STT = 0;
                String text = txtTimKiem.Text.ToUpper();

                dgvTHUOCMain.DataSource = THUOCService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        ID = p.ID,
                        Ten = p.TEN,
                        HanSuDung = p.HANSUDUNG.ToString(),
                        SoLuong = p.SOLUONG
                    })
                    .Where(p => p.Ten.ToUpper().Contains(text) || p.HanSuDung.ToUpper().Contains(text) || p.SoLuong.ToString().Contains(text))
                    .Select(p => new
                    {
                        ID = p.ID,
                        STT = ++STT,
                        Ten = p.Ten,
                        HanSuDung = p.HanSuDung,
                        SoLuong = p.SoLuong
                    })
                    .ToList();

                UpdateDetail();

                try
                {
                    index = index1;
                    dgvTHUOC.FocusedRowHandle = index;
                    dgvTHUOCMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachThuoc_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvTHUOC();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private THUOC getTHUOCByID()
        {
            try
            {
                int id = (int)dgvTHUOC.GetFocusedRowCellValue("ID");
                THUOC ans = THUOCService.GetAllBy(THUOC.THUOCFields.ID, id).FirstOrDefault();
                if (ans == null) return new THUOC();
                return ans;
            }
            catch
            {
                return new THUOC();
            }
        }

        private THUOC getTHUOCByForm()
        {
            THUOC ans = new THUOC();

            ans.TEN = txtTen.Text;
            ans.HAMLUONG = txtHamLuong.Text;
            ans.CACHSUDUNG = txtCachSuDung.Text;
            ans.HANSUDUNG = Int32.Parse(txtHanSuDung.Text);
            ans.SOLUONG = Int32.Parse(txtSoLuong.Text);

            return ans;
        }

        private void ClearControl()
        {
            txtTen.Text = "";
            txtHamLuong.Text = "";
            txtCachSuDung.Text = "";
            txtHanSuDung.Text = "";
            txtSoLuong.Text = "0";
        }

        private void UpdateDetail()
        {
            try
            {
                THUOC tg = getTHUOCByID();

                if (tg.ID == 0) return;

                txtTen.Text = tg.TEN;
                txtHamLuong.Text = tg.HAMLUONG;
                txtCachSuDung.Text = tg.CACHSUDUNG;
                txtHanSuDung.Text = tg.HANSUDUNG.ToString();
                txtSoLuong.Text = tg.SOLUONG.ToString();
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            txtHamLuong.Enabled = false;
            txtCachSuDung.Enabled = false;
            txtHanSuDung.Enabled = false;

            dgvTHUOCMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtHamLuong.Enabled = true;
            txtCachSuDung.Enabled = true;
            txtHanSuDung.Enabled = true;

            dgvTHUOCMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của thuốc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHamLuong.Text == "")
            {
                MessageBox.Show("Kí hiệu của thuốc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCachSuDung.Text == "")
            {
                MessageBox.Show("Cách sử dụng của thuốc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHanSuDung.Text == "")
            {
                MessageBox.Show("Hạn sử dụng của thuốc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int k = Int32.Parse(txtHanSuDung.Text);
            }
            catch
            {
                MessageBox.Show("Hạn sử dụng của thuốc phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            THUOC tg = getTHUOCByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thuốc nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        

        private void CapNhat(ref THUOC cu, THUOC moi)
        {
            cu.TEN = moi.TEN;
            cu.HAMLUONG = moi.HAMLUONG;
            cu.CACHSUDUNG = moi.CACHSUDUNG;
            cu.HANSUDUNG = moi.HANSUDUNG;
            cu.SOLUONG = moi.SOLUONG;
        }

        #endregion

        #region sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvTHUOC();
            txtTimKiem.Focus();
        }

        private void dgvTHUOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvTHUOC.FocusedRowHandle;
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

                    THUOC moi = getTHUOCByForm();
                    if (THUOCService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin thuốc thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin thuốc thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTHUOC();
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

                    THUOC cu = getTHUOCByID();
                    THUOC moi = getTHUOCByForm();
                    CapNhat(ref cu, moi);

                    if (THUOCService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin thuốc thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin thuốc thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTHUOC();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                THUOC cu = getTHUOCByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thuốc " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    THUOCService.Delete(new THUOCKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin thuốc thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin thuốc thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvTHUOC();

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
