using MetroFramework.Forms;
using QuanLyBenhXa.GUI.DanhMuc;
using QuanLyBenhXa.GUI.HoatDongChinh;
using QuanLyBenhXa.GUI.KhamBenh;
using QuanLyBenhXa.GUI.TaiKhoan;
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
    public partial class FrmMain : MetroForm
    {
        #region Hàm khởi tạo
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region các hàm mở các form
        private void barCapBac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachCapBac uc = new ucDanhSachCapBac();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBacSi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachBacSi uc = new ucDanhSachBacSi();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachChucVu uc = new ucDanhSachChucVu();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barDoiTuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachDoiTuong uc = new ucDanhSachDoiTuong();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachDonVi uc = new ucDanhSachDonVi();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBenhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachBenhVien uc = new ucDanhSachBenhVien();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barPhanLoaiSucKhoe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachPhanLoaiSucKhoe uc = new ucDanhSachPhanLoaiSucKhoe();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barVatTuYTe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachVatTu uc = new ucDanhSachVatTu();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barKhamDinhKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucKhamDinhKi uc = new ucKhamDinhKi();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barKhamThuongXuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucKhamThuongXuyen uc = new ucKhamThuongXuyen();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }


        private void barBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachBenhNhan uc = new ucDanhSachBenhNhan();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachThuoc uc = new ucDanhSachThuoc();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachBenh uc = new ucDanhSachBenh();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucKhoThuoc uc = new ucKhoThuoc();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barKhoVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucKhoVatTu uc = new ucKhoVatTu();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barNhapThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhapThuoc uc = new ucNhapThuoc();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barDanhSachTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDanhSachTaiKhoan uc = new ucDanhSachTaiKhoan();
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        #endregion

        #region Load Form

        private void LoadViewTheoTaiKhoan()
        {
            ribonAdmin.Visible = false;
            ribonThongKe.Visible = false;
            ribonTaiKhoan.Visible = false;
            ribonPublic.Visible = false;

            pageAdmin.Visible = false;

            if (ThamSoHeThong.curBacsi.ID == 0)
            {
                // Tài khoản công khai
                ribonPublic.Visible = true;
                ribonAdmin.Visible = true;
                return;
            }

            txtTenBacSi.Text = ThamSoHeThong.curBacsi.HOTEN;

            if (ThamSoHeThong.curBacsi.QUYEN == 0)
            {
                // tài khoản bác sĩ thường
                ribonPublic.Visible = true;
                ribonAdmin.Visible = true;
                pageAdmin.Visible = true;
                
                return;
            }

            if (ThamSoHeThong.curBacsi.QUYEN == 1)
            {
                // tài khoản bác sĩ quản trị
                ribonPublic.Visible = true;
                ribonAdmin.Visible = true;
                ribonTaiKhoan.Visible = true;
                ribonThongKe.Visible = true;
                pageAdmin.Visible = true;
                return;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadViewTheoTaiKhoan();
            
        }
        #endregion

        private void barDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) return;
            this.Close();
        }

        private void barThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ThamSoHeThong.curBacsi.ID == 0)
            {
                MessageBox.Show("Đây là tài khoản công khai",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            FrmThongTinCaNhan form = new FrmThongTinCaNhan();
            form.ShowDialog();

            txtTenBacSi.Text = ThamSoHeThong.curBacsi.HOTEN;
        }

        private void barDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ThamSoHeThong.curBacsi.ID == 0)
            {
                MessageBox.Show("Tài khoản này không được phép đổi mật khẩu",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            FrmDoiMatKhau form = new FrmDoiMatKhau();
            form.ShowDialog();
        }
    }
}
