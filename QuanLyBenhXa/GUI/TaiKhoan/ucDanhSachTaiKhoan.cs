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

namespace QuanLyBenhXa.GUI.TaiKhoan
{
    public partial class ucDanhSachTaiKhoan : UserControl
    {
        private int index = 0, index1 = 0;
        private BACSIFactory BACSIService = new BACSIFactory();
        private TAIKHOANFactory TAIKHOANService = new TAIKHOANFactory();

        #region Hàm khởi tạo
        public ucDanhSachTaiKhoan()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            // cbxChuTaiKhoan
            var listTaiKhoan = BACSIService.GetAllEntities().ToList()
                               .Select(p => new { ID = p.ID, Ten = p.HOTEN })
                               .ToList();

            cbxChuTaiKhoan.Properties.DataSource = listTaiKhoan;
            cbxChuTaiKhoan.Properties.DisplayMember = "Ten";
            cbxChuTaiKhoan.Properties.ValueMember = "ID";
        }

        private void LoadDgvTAIKHOAN()
        {
        }
        private void ucDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadInitControl();
        }
        #endregion
    }
}
