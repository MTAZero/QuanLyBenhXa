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
    public partial class FrmChiTietKhamDinhKi : MetroForm
    {
        // service 
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();

        #region Hàm khởi tạo
        public FrmChiTietKhamDinhKi(int _khamdinhkiid)
        {
            InitializeComponent();

            KHAMDINHKI khamdinhki = KHAMDINHKIService.GetByPrimaryKey(new KHAMDINHKIKeys(_khamdinhkiid));
            panelMain.Controls.Clear();
            ucKhamDinhKi uc = new ucKhamDinhKi(khamdinhki, 1);
            panelMain.Controls.Add(uc);
            uc.Show();
        }
        #endregion


    }
}
