using MetroFramework.Forms;
using QuanLyBenhXa.BusinessLayer;
using QuanLyBenhXa.GUI.KhamBenh;
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
    public partial class FrmChiTietKhamThuongXuyen : MetroForm
    {
        // service 
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();

        #region Hàm khởi tạo
        public FrmChiTietKhamThuongXuyen(int _id)
        {
            InitializeComponent();

            KHAMTHUONGXUYEN khamthuongxuyen = KHAMTHUONGXUYENService.GetByPrimaryKey(new KHAMTHUONGXUYENKeys(_id));
            panelMain.Controls.Clear();
            ucKhamThuongXuyen uc = new ucKhamThuongXuyen(khamthuongxuyen);
            panelMain.Controls.Add(uc);
            uc.Show();
        }
        #endregion


    }
}
