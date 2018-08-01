using MetroFramework.Forms;
using QuanLyBenhXa.BusinessLayer;
using QuanLyBenhXa.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhXa.GUI.KhamBenh
{
    public partial class FrmInGiayGioiThieu : MetroForm
    {
        // service
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private DONVIFactory DONVIService = new DONVIFactory();
        private BENHFactory BENHService = new BENHFactory();
        private BENHVIENFactory BENHVIENService = new BENHVIENFactory();

        // variable
        private KHAMTHUONGXUYEN khamthuongxuyen = new KHAMTHUONGXUYEN();

        #region Hàm khởi tạo
        public FrmInGiayGioiThieu(KHAMTHUONGXUYEN _khamthuongxuyen)
        {
            khamthuongxuyen = _khamthuongxuyen;
            InitializeComponent();
        }

        #endregion

        #region Sự kiện
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (Check())
            {

                BENHNHAN benhnhan = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)khamthuongxuyen.BENHNHANID));
                dynamic param = new
                {
                    YKienDeNghi = txtYKienDeNghi.Text,
                    BenhVienCapTren = BENHVIENService.GetByPrimaryKey(new BENHVIENKeys((int)khamthuongxuyen.BENHVIENID)).TEN,
                    HoTen = benhnhan.HOTEN,
                    Tuoi = DateTime.Now.Year - ((DateTime)benhnhan.NGAYSINH).Year,
                    CapBac = CAPBACService.GetByPrimaryKey(new CAPBACKeys((int)benhnhan.CAPBACID)).TEN,
                    ChucVu = CHUCVUService.GetByPrimaryKey(new CHUCVUKeys((int)benhnhan.CHUCVUID)).TEN,
                    DonVi = txtDonVi.Text, //DONVIService.GetByPrimaryKey(new DONVIKeys((int)benhnhan.DONVIID)).TEN,
                    Benh = txtCanBenh.Text, //BENHService.GetByPrimaryKey(new BENHKeys((int)khamthuongxuyen.BENHID)).TEN,
                    Ngay = DateTime.Now.ToString(@"\N\g\à\y dd \t\h\á\n\g MM \n\ă\m yyyy"),
                    SoSucKhoe = txtSoSucKhoe.Text
                };

                FrmRpGiayGioiThieu form = new FrmRpGiayGioiThieu(param);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hàm chức năng
        private bool Check()
        {
            // don vi
            if (txtDonVi.Text == "")
            {
                MessageBox.Show("Đơn vị không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCanBenh.Text == "")
            {
                MessageBox.Show("Căn bệnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSoSucKhoe.Text == "")
            {
                MessageBox.Show("Số sức khỏe không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // y kien de nghi
            if (txtYKienDeNghi.Text == "")
            {
                MessageBox.Show("Ý kiến đề nghị không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }
        #endregion
    }
}