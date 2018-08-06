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

namespace QuanLyBenhXa.GUI.ThongKe
{
    public partial class FrmBaoCaoChiPhiKhamBenh : MetroForm
    {
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();

        private int khamthuongxuyenID = 0;
        public FrmBaoCaoChiPhiKhamBenh(int _khamthuongxuyenID)
        {
            khamthuongxuyenID = _khamthuongxuyenID;
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNguoiLap.Text == "")
                {
                    MessageBox.Show("Người lập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPhuTrachQuanY.Text == "")
                {
                    MessageBox.Show("Phụ trách quân y không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmRpChiPhiKhamChuaBenhQuanNhan form = new FrmRpChiPhiKhamChuaBenhQuanNhan((int) khamthuongxuyenID, txtNguoiLap.Text, txtPhuTrachQuanY.Text);
                form.ShowDialog();
                this.Close();
                return;
            }catch
            {


            }
        }
    }
}
