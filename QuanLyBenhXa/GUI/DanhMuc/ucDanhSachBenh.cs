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
    public partial class ucDanhSachBenh : UserControl
    {
        private NHOMBENHFactory NHOMBENHService = new NHOMBENHFactory();
        private LOAIBENHFactory LOAIBENHService = new LOAIBENHFactory();
        private BENHFactory BENHService = new BENHFactory();

        private int indexNhomBenh = 0, indexNhomBenh1 = 0;
        private int indexLoaiBenh = 0, indexLoaiBenh1 = 0;
        private int indexBenh = 0, indexBenh1 = 0;


        #region Hàm khởi tạo
        public ucDanhSachBenh()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvNHOMBENH()
        {
            try
            {
                int STT = 0;

                ClearControlNHOMBENH();

                dgvNHOMBENHMain.DataSource = NHOMBENHService.GetAllEntities().ToList()
                    .Select(p => new
                    {
                        STT = ++STT,
                        ID = p.ID,
                        Ten = p.TEN
                    })
                    .ToList();

                UpdateDetailNHOMBENH();
                LoadDgvLOAIBENH();

                try
                {
                    indexNhomBenh = indexNhomBenh1;
                    dgvNHOMBENH.FocusedRowHandle = indexNhomBenh;
                    dgvNHOMBENHMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void LoadDgvLOAIBENH()
        {
            try
            {
                int NhomBenhID = getNHOMBENHByID().ID;
                if (NhomBenhID == 0) return;

                ClearControlLOAIBENH();

                int STT = 0;

                dgvLOAIBENHMain.DataSource = LOAIBENHService.GetAllEntities().ToList()
                    .Where(p=>p.NHOMBENHID == NhomBenhID)
                    .Select(p => new
                    {
                        STT = ++STT,
                        ID = p.ID,
                        Ten = p.TEN
                    })
                    .ToList();

                UpdateDetailLOAIBENH();
                LoadDgvBENH();

                try
                {
                    indexLoaiBenh = indexLoaiBenh1;
                    dgvLOAIBENH.FocusedRowHandle = indexLoaiBenh;
                    dgvLOAIBENHMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void LoadDgvBENH()
        {
            try
            {
                int LoaiBenhID = getLOAIBENHByID().ID;
                if (LoaiBenhID == 0) return;

                int STT = 0;

                ClearControlBENH();

                dgvBENHMain.DataSource = BENHService.GetAllEntities().ToList()
                    .Where(p=>p.LOAIBENHID == LoaiBenhID)
                    .Select(p => new
                    {
                        STT = ++STT,
                        ID = p.ID,
                        Ten = p.TEN
                    })
                    .ToList();

                UpdateDetailBENH();

                try
                {
                    indexBenh = indexBenh1;
                    dgvBENH.FocusedRowHandle = indexBenh;
                    dgvBENHMain.Select();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void ucDanhSachBenh_Load(object sender, EventArgs e)
        {
            LoadDgvNHOMBENH();
            LockControl();
        }
        #endregion

        #region Hàm chức năng 
        private NHOMBENH getNHOMBENHByID()
        {
            try
            {
                int id = (int)dgvNHOMBENH.GetFocusedRowCellValue("ID");
                NHOMBENH ans = NHOMBENHService.GetAllBy(NHOMBENH.NHOMBENHFields.ID, id).FirstOrDefault();
                if (ans == null) return new NHOMBENH();
                return ans;
            }
            catch
            {
                return new NHOMBENH();
            }
        }

        private LOAIBENH getLOAIBENHByID()
        {
            try
            {
                int id = (int)dgvLOAIBENH.GetFocusedRowCellValue("ID");
                LOAIBENH ans = LOAIBENHService.GetAllBy(LOAIBENH.LOAIBENHFields.ID, id).FirstOrDefault();
                if (ans == null) return new LOAIBENH();
                return ans;
            }
            catch
            {
                return new LOAIBENH();
            }
        }

        private BENH getBENHByID()
        {
            try
            {
                int id = (int)dgvBENH.GetFocusedRowCellValue("ID");
                BENH ans = BENHService.GetAllBy(BENH.BENHFields.ID, id).FirstOrDefault();
                if (ans == null) return new BENH();
                return ans;
            }
            catch
            {
                return new BENH();
            }
        }

        private NHOMBENH getNHOMBENHByForm()
        {
            NHOMBENH ans = new NHOMBENH();

            ans.TEN = txtNHOMBENH.Text;

            return ans;
        }

        private LOAIBENH getLOAIBENHByForm()
        {
            LOAIBENH ans = new LOAIBENH();

            ans.TEN = txtLOAIBENH.Text;
            ans.NHOMBENHID = getNHOMBENHByID().ID;

            return ans;
        }

        private BENH getBENHByForm()
        {
            BENH ans = new BENH();

            ans.TEN = txtBENH.Text;
            ans.MOTA = txtMoTa.Text;
            ans.LOAIBENHID = getLOAIBENHByID().ID;

            return ans;
        }

        private void ClearControlNHOMBENH()
        {
            txtNHOMBENH.Text = "";
        }

        private void ClearControlLOAIBENH()
        {
            txtLOAIBENH.Text = "";
        }

        private void ClearControlBENH()
        {
            txtBENH.Text = "";
            txtMoTa.Text = "";
        }

        private void UpdateDetailNHOMBENH()
        {
            try
            {
                NHOMBENH tg = getNHOMBENHByID();

                if (tg.ID == 0) return;

                txtNHOMBENH.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void UpdateDetailLOAIBENH()
        {
            try
            {
                LOAIBENH tg = getLOAIBENHByID();

                if (tg.ID == 0) return;

                txtLOAIBENH.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void UpdateDetailBENH()
        {
            try
            {
                BENH tg = getBENHByID();

                if (tg.ID == 0) return;

                txtBENH.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtNHOMBENH.Enabled = false;
            txtLOAIBENH.Enabled = false;
            txtBENH.Enabled = false;
            txtMoTa.Enabled = false;

            dgvNHOMBENHMain.Enabled = true;
            dgvLOAIBENHMain.Enabled = true;
            dgvBENHMain.Enabled = true;

            btnThemNHOMBENH.Enabled = true;
            btnSuaNHOMBENH.Enabled = true;
            btnXoaNHOMBENH.Enabled = true;

            btnThemLOAIBENH.Enabled = true;
            btnSuaLOAIBENH.Enabled = true;
            btnXoaLOAIBENH.Enabled = true;

            btnThemBENH.Enabled = true;
            btnSuaBENH.Enabled = true;
            btnXoaBENH.Enabled = true;
        }

        private void UnlockControlNHOMBENH()
        {
            txtNHOMBENH.Enabled = true;
            txtLOAIBENH.Enabled = false;
            txtBENH.Enabled = false;
            txtMoTa.Enabled = false;

            dgvNHOMBENHMain.Enabled = false;
            dgvLOAIBENHMain.Enabled = false;
            dgvBENHMain.Enabled = false;

            btnThemLOAIBENH.Enabled = false;
            btnSuaLOAIBENH.Enabled = false;
            btnXoaLOAIBENH.Enabled = false;

            btnThemBENH.Enabled = false;
            btnSuaBENH.Enabled = false;
            btnXoaBENH.Enabled = false;
        }

        private void UnlockControlLOAIBENH()
        {
            txtNHOMBENH.Enabled = false;
            txtLOAIBENH.Enabled = true;
            txtBENH.Enabled = false;
            txtMoTa.Enabled = false;

            dgvNHOMBENHMain.Enabled = false;
            dgvLOAIBENHMain.Enabled = false;
            dgvBENHMain.Enabled = false;

            btnThemNHOMBENH.Enabled = false;
            btnSuaNHOMBENH.Enabled = false;
            btnXoaNHOMBENH.Enabled = false;

            btnThemBENH.Enabled = false;
            btnSuaBENH.Enabled = false;
            btnXoaBENH.Enabled = false;
        }

        private void UnlockControlBENH()
        {
            txtNHOMBENH.Enabled = false;
            txtLOAIBENH.Enabled = false;
            txtBENH.Enabled = true;
            txtMoTa.Enabled = true;

            dgvNHOMBENHMain.Enabled = false;
            dgvLOAIBENHMain.Enabled = false;
            dgvBENHMain.Enabled = false;

            btnThemLOAIBENH.Enabled = false;
            btnSuaLOAIBENH.Enabled = false;
            btnXoaLOAIBENH.Enabled = false;

            btnThemNHOMBENH.Enabled = false;
            btnSuaNHOMBENH.Enabled = false;
            btnXoaNHOMBENH.Enabled = false;
        }

        private bool CheckNHOMBENH()
        {
            if (txtNHOMBENH.Text == "")
            {
                MessageBox.Show("Tên của nhóm bệnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLOAIBENH()
        {
            if (txtLOAIBENH.Text == "")
            {
                MessageBox.Show("Tên của loại bệnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckBENH()
        {
            if (txtBENH.Text == "")
            {
                MessageBox.Show("Tên của bệnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMoTa.Text == "")
            {
                MessageBox.Show("Mô tả của bệnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChonNHOMBENH()
        {
            NHOMBENH tg = getNHOMBENHByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhóm bệnh nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckLuaChonLOAIBENH()
        {
            LOAIBENH tg = getLOAIBENHByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có loại bệnh nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckLuaChonBENH()
        {
            BENH tg = getBENHByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có bệnh nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhatNHOMBENH(ref NHOMBENH cu, NHOMBENH moi)
        {
            cu.TEN = moi.TEN;
        }

        private void CapNhatLOAIBENH(ref LOAIBENH cu, LOAIBENH moi)
        {
            cu.TEN = moi.TEN;
            cu.NHOMBENHID = moi.NHOMBENHID;
        }

        private void CapNhatBENH(ref BENH cu, BENH moi)
        {
            cu.TEN = moi.TEN;
            cu.MOTA = moi.MOTA;
            cu.LOAIBENHID = moi.LOAIBENHID;
        }

        #endregion

        #region Sự kiện ngầm
        private void dgvLOAIBENH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetailLOAIBENH();

            try
            {
                indexLoaiBenh1 = indexLoaiBenh;
                indexLoaiBenh = dgvLOAIBENH.FocusedRowHandle;
                LoadDgvBENH();
            }
            catch { }
        }

        private void dgvBENH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetailBENH();

            try
            {
                indexBenh1 = indexBenh;
                indexBenh = dgvBENH.FocusedRowHandle;
            }
            catch { }
        }

        private void dgvNHOMBENH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetailNHOMBENH();

            try
            {
                indexNhomBenh1 = indexNhomBenh;
                indexNhomBenh = dgvNHOMBENH.FocusedRowHandle;
                LoadDgvLOAIBENH();
            }
            catch { }
        }

        #endregion

        #region Sự kiện nhóm bệnh
        private void btnThemNhomBenh_Click(object sender, EventArgs e)
        {
            if (btnThemNHOMBENH.Text == "Thêm")
            {
                btnSuaNHOMBENH.Enabled = false;
                btnThemNHOMBENH.Text = "Lưu";
                btnXoaNHOMBENH.Text = "Hủy";

                ClearControlNHOMBENH();
                UnlockControlNHOMBENH();


                return;
            }

            if (btnThemNHOMBENH.Text == "Lưu")
            {
                if (CheckNHOMBENH())
                {
                    btnThemNHOMBENH.Text = "Thêm";
                    btnXoaNHOMBENH.Text = "Xóa";
                    LockControl();

                    NHOMBENH moi = getNHOMBENHByForm();
                    if (NHOMBENHService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin nhóm bệnh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin nhóm bệnh thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNHOMBENH();
                }
                return;
            }
        }

        private void btnSuaNhomBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;

            if (btnSuaNHOMBENH.Text == "Sửa")
            {
                btnSuaNHOMBENH.Text = "Lưu";
                btnXoaNHOMBENH.Text = "Hủy";
                btnThemNHOMBENH.Enabled = false;

                UnlockControlNHOMBENH();

                return;
            }

            if (btnSuaNHOMBENH.Text == "Lưu")
            {
                if (CheckNHOMBENH())
                {
                    btnSuaNHOMBENH.Text = "Sửa";
                    btnXoaNHOMBENH.Text = "Xóa";

                    LockControl();

                    NHOMBENH cu = getNHOMBENHByID();
                    NHOMBENH moi = getNHOMBENHByForm();
                    CapNhatNHOMBENH(ref cu, moi);

                    if (NHOMBENHService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin nhóm bệnh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhóm bệnh thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNHOMBENH();
                }

                return;
            }
        }

        private void btnXoaNhomBenh_Click(object sender, EventArgs e)
        {
            if (btnXoaNHOMBENH.Text == "Xóa")
            {
                if (!CheckLuaChonNHOMBENH()) return;

                NHOMBENH cu = getNHOMBENHByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhóm bệnh " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    NHOMBENHService.Delete(new NHOMBENHKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin nhóm bệnh thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin nhóm bệnh thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvNHOMBENH();

                return;
            }
            if (btnXoaNHOMBENH.Text == "Hủy")
            {
                btnSuaNHOMBENH.Text = "Sửa";
                btnThemNHOMBENH.Text = "Thêm";
                btnXoaNHOMBENH.Text = "Xóa";

                LockControl();
                UpdateDetailNHOMBENH();
                return;
            }
        }

        #endregion

        #region Sự kiện loại bệnh
        private void btnThemLoaiBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;

            if (btnThemLOAIBENH.Text == "Thêm")
            {
                btnSuaLOAIBENH.Enabled = false;
                btnThemLOAIBENH.Text = "Lưu";
                btnXoaLOAIBENH.Text = "Hủy";

                ClearControlLOAIBENH();
                UnlockControlLOAIBENH();


                return;
            }

            if (btnThemLOAIBENH.Text == "Lưu")
            {
                if (CheckLOAIBENH())
                {
                    btnThemLOAIBENH.Text = "Thêm";
                    btnXoaLOAIBENH.Text = "Xóa";
                    LockControl();

                    LOAIBENH moi = getLOAIBENHByForm();
                    if (LOAIBENHService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin loại bệnh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin loại bệnh thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvLOAIBENH();
                }
                return;
            }
        }

        private void btnSuaLoaiBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;
            if (!CheckLuaChonLOAIBENH()) return;

            if (btnSuaLOAIBENH.Text == "Sửa")
            {
                btnSuaLOAIBENH.Text = "Lưu";
                btnXoaLOAIBENH.Text = "Hủy";
                btnThemLOAIBENH.Enabled = false;

                UnlockControlLOAIBENH();

                return;
            }

            if (btnSuaLOAIBENH.Text == "Lưu")
            {
                if (CheckLOAIBENH())
                {
                    btnSuaLOAIBENH.Text = "Sửa";
                    btnXoaLOAIBENH.Text = "Xóa";

                    LockControl();

                    LOAIBENH cu = getLOAIBENHByID();
                    LOAIBENH moi = getLOAIBENHByForm();
                    CapNhatLOAIBENH(ref cu, moi);

                    if (LOAIBENHService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin loại bệnh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin loại bệnh thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvLOAIBENH();
                }

                return;
            }
        }

        private void btnXoaLoaiBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;

            if (btnXoaLOAIBENH.Text == "Xóa")
            {
                if (!CheckLuaChonLOAIBENH()) return;

                LOAIBENH cu = getLOAIBENHByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa loại bệnh " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    LOAIBENHService.Delete(new LOAIBENHKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin loại bệnh thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin loại bệnh thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvLOAIBENH();

                return;
            }
            if (btnXoaLOAIBENH.Text == "Hủy")
            {
                btnSuaLOAIBENH.Text = "Sửa";
                btnThemLOAIBENH.Text = "Thêm";
                btnXoaLOAIBENH.Text = "Xóa";

                LockControl();
                UpdateDetailLOAIBENH();
                return;
            }
        }
        #endregion

        #region Sự kiện bệnh
        private void btnThemBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;
            if (!CheckLuaChonLOAIBENH()) return;

            if (btnThemBENH.Text == "Thêm")
            {
                btnSuaBENH.Enabled = false;
                btnThemBENH.Text = "Lưu";
                btnXoaBENH.Text = "Hủy";

                ClearControlBENH();
                UnlockControlBENH();


                return;
            }

            if (btnThemBENH.Text == "Lưu")
            {
                if (CheckBENH())
                {
                    btnThemBENH.Text = "Thêm";
                    btnXoaBENH.Text = "Xóa";
                    LockControl();

                    BENH moi = getBENHByForm();
                    if (BENHService.Insert(moi))
                    {
                        MessageBox.Show("Thêm thông tin bệnh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin bệnh thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBENH();
                }
                return;
            }
        }

        private void btnSuaBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;
            if (!CheckLuaChonLOAIBENH()) return;
            if (!CheckLuaChonBENH()) return;

            if (btnSuaBENH.Text == "Sửa")
            {
                btnSuaBENH.Text = "Lưu";
                btnXoaBENH.Text = "Hủy";
                btnThemBENH.Enabled = false;

                UnlockControlBENH();

                return;
            }

            if (btnSuaBENH.Text == "Lưu")
            {
                if (CheckBENH())
                {
                    btnSuaBENH.Text = "Sửa";
                    btnXoaBENH.Text = "Xóa";

                    LockControl();

                    BENH cu = getBENHByID();
                    BENH moi = getBENHByForm();
                    CapNhatBENH(ref cu, moi);

                    if (BENHService.Update(cu))
                    {
                        MessageBox.Show("Sửa thông tin bệnh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin bệnh thất bại\n",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBENH();
                }

                return;
            }
        }

        private void btnXoaBenh_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChonNHOMBENH()) return;
            if (!CheckLuaChonLOAIBENH()) return;

            if (btnXoaBENH.Text == "Xóa")
            {
                if (!CheckLuaChonBENH()) return;

                BENH cu = getBENHByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa bệnh " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    BENHService.Delete(new BENHKeys(cu.ID));
                    MessageBox.Show("Xóa thông tin bệnh thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin bệnh thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvBENH();

                return;
            }
            if (btnXoaBENH.Text == "Hủy")
            {
                btnSuaBENH.Text = "Sửa";
                btnThemBENH.Text = "Thêm";
                btnXoaBENH.Text = "Xóa";

                LockControl();
                UpdateDetailBENH();
                return;
            }
        }
        #endregion

    }
}
