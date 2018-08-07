using MetroFramework.Forms;
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
    public partial class FrmBaoCaoCanBoCaoCapDieuTri : MetroForm
    {

        #region Hàm khởi tạo
        public FrmBaoCaoCanBoCaoCapDieuTri()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void FrmBaoCaoPhanLoaiSucKhoe_Load(object sender, EventArgs e)
        {
            dateTuNgay.DateTime = DateTime.Now.AddMonths(-6);
            dateDenNgay.DateTime = DateTime.Now;
        }
        #endregion

        #region Sự kiện
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (dateTuNgay.DateTime>dateDenNgay.DateTime)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmRpCanBoDieuTri form = new FrmRpCanBoDieuTri(dateTuNgay.DateTime, dateDenNgay.DateTime);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
