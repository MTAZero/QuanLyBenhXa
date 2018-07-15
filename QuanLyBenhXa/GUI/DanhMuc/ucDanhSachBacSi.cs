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
    public partial class ucDanhSachBacSi : UserControl
    {
        private BACSIFactory bacsiService = new BACSIFactory();

        public ucDanhSachBacSi()
        {
            InitializeComponent();
        }

        private void ucDanhSachBacSi_Load(object sender, EventArgs e)
        {
            dgvBSMain.DataSource = bacsiService.GetAllEntities().Select(p => new { HOTEN = p.HOTEN, NGAYSINH = p.NGAYSINH }).ToList();
        }
    }
}
