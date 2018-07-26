using MetroFramework.Forms;
using QuanLyBenhXa.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhXa.GUI.HoatDongChinh
{
    public partial class FrmThongTinCaNhan : MetroForm
    {
        private BACSIFactory BACSIService = new BACSIFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private DONVIFactory DONVIService = new DONVIFactory();
        private DOITUONGFactory DOITUONGService = new DOITUONGFactory();

        #region Hàm khởi tạo
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }
        #endregion


        #region LoadForm

        private void LoadInitControl()
        {
            // Chức vụ
            cbxChucVu.Properties.DataSource = CHUCVUService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxChucVu.Properties.DisplayMember = "TEN";
            cbxChucVu.Properties.ValueMember = "ID";

            // Cấp bậc
            cbxCapBac.Properties.DataSource = CAPBACService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxCapBac.Properties.DisplayMember = "TEN";
            cbxCapBac.Properties.ValueMember = "ID";

            // Đối tượng
            cbxDoiTuong.Properties.DataSource = DOITUONGService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxDoiTuong.Properties.DisplayMember = "TEN";
            cbxDoiTuong.Properties.ValueMember = "ID";

            // Đơn vị
            cbxDonVi.Properties.DataSource = DONVIService.GetAllEntities()
                    .ToList().Select(p => new
                    {
                        ID = p.ID,
                        TEN = p.TEN
                    })
                    .ToList();
            cbxDonVi.Properties.DisplayMember = "TEN";
            cbxDonVi.Properties.ValueMember = "ID";
        }
        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            UpdateDetail();
        }
        #endregion

        #region Hàm chức năng
        private void UpdateDetail()
        {
            try
            {
                BACSI tg = ThamSoHeThong.curBacsi;

                if (tg.ID == 0) return;

                txtHoTen.Text = tg.HOTEN;
                txtSDT.Text = tg.SDT;
                txtQueQuan.Text = tg.QUEQUAN;
                txtDanToc.Text = tg.DANTOC;
                txtTrinhDo.Text = tg.TRINHDOVANHOA;

                cbxCapBac.EditValue = (int)tg.CAPBACID;
                cbxChucVu.EditValue = (int)tg.CHUCVUID;
                cbxDonVi.EditValue = (int)tg.DONVIID;
                cbxDoiTuong.EditValue = (int)tg.DOITUONGID;
                cbxQuyen.SelectedIndex = (int)tg.QUYEN;
                cbxGioiTinh.SelectedIndex = (int)tg.GIOITINH;
                dateNgaySinh.DateTime = (DateTime)tg.NGAYSINH;
            }
            catch
            {

            }
        }

        private bool Check()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ và tên của bác sĩ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại của bác sĩ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtQueQuan.Text == "")
            {
                MessageBox.Show("Quê quán của bác sĩ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Dân tộc của bác sĩ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTrinhDo.Text == "")
            {
                MessageBox.Show("Trình độ văn hóa của bác sĩ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateNgaySinh.DateTime > DateTime.Now.AddYears(-20))
            {
                MessageBox.Show("Ngày sinh của bác sĩ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private BACSI getBACSIByForm()
        {
            BACSI ans = new BACSI();

            ans.HOTEN = txtHoTen.Text;
            ans.NGAYSINH = dateNgaySinh.DateTime;
            ans.SDT = txtSDT.Text;
            ans.QUEQUAN = txtQueQuan.Text;
            ans.DANTOC = txtDanToc.Text;
            ans.TRINHDOVANHOA = txtTrinhDo.Text;

            ans.DONVIID = (int)cbxDonVi.EditValue;
            ans.CAPBACID = (int)cbxCapBac.EditValue;
            ans.CHUCVUID = (int)cbxChucVu.EditValue;
            ans.DOITUONGID = (int)cbxDoiTuong.EditValue;
            ans.QUYEN = cbxQuyen.SelectedIndex;
            ans.GIOITINH = cbxGioiTinh.SelectedIndex;

            return ans;
        }

        private void CapNhat(ref BACSI cu, BACSI moi)
        {
            cu.HOTEN = moi.HOTEN;
            cu.DONVIID = moi.DONVIID;
            cu.CAPBACID = moi.CAPBACID;
            cu.CHUCVUID = moi.CHUCVUID;
            cu.DOITUONGID = moi.DOITUONGID;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.GIOITINH = moi.GIOITINH;
            cu.QUYEN = moi.QUYEN;
            cu.SDT = moi.SDT;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.DANTOC = moi.DANTOC;
            cu.TRINHDOVANHOA = moi.TRINHDOVANHOA;
        }
        #endregion

        #region Sự kiện
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    BACSI moi = getBACSIByForm();
                    BACSI cu = ThamSoHeThong.curBacsi;
                    CapNhat(ref cu, moi);
                    if (BACSIService.Update(cu))
                        MessageBox.Show("Cập nhật thông tin cá nhân thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cập nhật thông tin cá nhân thất bại",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                    this.Close();
                }
                catch
                {
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
