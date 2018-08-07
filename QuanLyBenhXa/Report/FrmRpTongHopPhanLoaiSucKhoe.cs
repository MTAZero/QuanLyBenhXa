using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyBenhXa.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhXa.Report
{
    public partial class FrmRpTongHopPhanLoaiSucKhoe : MetroForm
    {
        // service 
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private PHANLOAISUCKHOEFactory PHANLOAIService = new PHANLOAISUCKHOEFactory();
        private DONVIFactory DONVIService = new DONVIFactory();

        // variable
        private DateTime tungay = new DateTime(), denngay = new DateTime();
        public FrmRpTongHopPhanLoaiSucKhoe(DateTime _tungay, DateTime _denngay)
        {
            tungay = _tungay;
            denngay = _denngay;
            InitializeComponent();
        }

        private void FrmRpTongHopPhanLoaiSucKhoe_Load(object sender, EventArgs e)
        {
            // thống kê sức khỏe
            int i = 0;
            TongHopPhanLoaiSucKhoeBindingSource.DataSource = KHAMDINHKIService.GetAllEntities().ToList()
                                                                .Where(p => p.THOIGIANKHAM >= tungay && p.THOIGIANKHAM <= denngay)
                                                                .Select(p => new
                                                                {
                                                                    STT = ++i,
                                                                    HoTen = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).HOTEN,
                                                                    PhanLoai = PHANLOAIService.GetByPrimaryKey(new PHANLOAISUCKHOEKeys((int)p.PHANLOAISUCKHOEID)).TEN,
                                                                    GhiChu = (p.GHICHU == null) ? "" : p.GHICHU,
                                                                    DonVi = DONVIService.GetByPrimaryKey(new DONVIKeys((int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).DONVIID)).TEN,
                                                                    KetQuaKham = p.KETLUAN
                                                                })
                                                                .ToList();

            ReportParameter[] listPara = new ReportParameter[]{
                    new ReportParameter("Nam", denngay.Year.ToString()),
                };
            this.reportViewer1.LocalReport.SetParameters(listPara);


            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
