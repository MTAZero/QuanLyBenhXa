using MetroFramework.Forms;
using QuanLyBenhXa.BusinessLayer;
using QuanLyBenhXa.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhXa.GUI
{
    public partial class FrmLogin : MetroForm
    {
        private TAIKHOANFactory TAIKHOANService = new TAIKHOANFactory();
        private BACSIFactory BACSIService = new BACSIFactory();

        #region Hàm khởi tạo
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Sự kiện
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckTaiKhoan())
            {

                FrmMain form = new FrmMain();

                TAIKHOAN taikhoan = TAIKHOANService.GetAllEntities().ToList()
                                .Where(p => p.TENDANGNHAP == txtTaiKhoan.Text)
                                .FirstOrDefault();
                ThamSoHeThong.curTaikhoan = taikhoan;

                if (TAIKHOANService.LoaiTaiKhoan(taikhoan) == 0)
                    ThamSoHeThong.curBacsi = new BACSI();
                else
                    ThamSoHeThong.curBacsi = TAIKHOANService.ChuSoHuu(taikhoan);

                this.Hide();
                form.ShowDialog();
                this.Show();

                ThamSoHeThong.curBacsi = new BACSI();
                ThamSoHeThong.curTaikhoan = new TAIKHOAN();

                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hàm chức năng
        private bool CheckTaiKhoan()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            TAIKHOAN taikhoan = TAIKHOANService.GetAllEntities().ToList()
                                .Where(p => p.TENDANGNHAP == txtTaiKhoan.Text)
                                .FirstOrDefault();
            if (taikhoan.ID == 0 || MD5Helper.GetMD5HashValue(txtMatKhau.Text) != taikhoan.PASSWORDMD5)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion
    }
}
