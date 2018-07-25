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

namespace QuanLyBenhXa.GUI.HoatDongChinh
{
    public partial class ucKhoVatTu : UserControl
    {
        private VATTUFactory VATTUService = new VATTUFactory();

        #region Hàm khởi tạo
        public ucKhoVatTu()
        {
            InitializeComponent();
        }

        #endregion

        #region Load Form
        private void LoadDgvVATTU()
        {
            int i = 0;
            string text = txtTimKiem.Text.ToUpper();

            try
            {
                if (rdSapXepTheoTen.Checked == true)
                {
                    dgvVATTUMain.DataSource = VATTUService.GetAllEntities().ToList()
                                              .Where(p => p.TEN.ToUpper().Contains(text) || p.SOLUONG.ToString().Contains(text))
                                              .OrderBy(p => p.TEN)
                                              .Select(p => new
                                              {
                                                  STT = ++i,
                                                  Ten = p.TEN,
                                                  SoLuong = p.SOLUONG
                                              })
                                              .ToList();
                }
                else
                {
                    dgvVATTUMain.DataSource = VATTUService.GetAllEntities().ToList()
                                              .Where(p => p.TEN.ToUpper().Contains(text) || p.SOLUONG.ToString().Contains(text))
                                              .OrderByDescending(p => p.SOLUONG)
                                              .Select(p => new
                                              {
                                                  STT = ++i,
                                                  Ten = p.TEN,
                                                  SoLuong = p.SOLUONG
                                              })                                 
                                              .ToList();
                }
            }
            catch
            {

            }
        }

        private void ucKhoThuoc_Load(object sender, EventArgs e)
        {
            LoadDgvVATTU();
        }

        #endregion

        #region Sự kiện ngầm
        private void rdSapXepTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            LoadDgvVATTU();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvVATTU();
        }
        #endregion
    }
}
