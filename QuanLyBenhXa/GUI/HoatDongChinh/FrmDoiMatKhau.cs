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

namespace QuanLyBenhXa.GUI.HoatDongChinh
{
    public partial class FrmDoiMatKhau : Form
    {
        private TAIKHOANFactory TAIKHOANService = new TAIKHOANFactory();

        #region Hảm khởi tạo
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        #endregion


        #region Sự kiện
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string matkhaucu = txtMatKhauCu.Text;
            if (MD5Helper.GetMD5HashValue(matkhaucu) != ThamSoHeThong.curTaikhoan.PASSWORDMD5)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ThamSoHeThong.curTaikhoan.PASSWORDMD5 = MD5Helper.GetMD5HashValue(txtMatKhauMoi.Text);
            if (TAIKHOANService.Update(ThamSoHeThong.curTaikhoan))
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
