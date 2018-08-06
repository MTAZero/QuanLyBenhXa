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
    public partial class FrmDanhSachPhanLoaiSucKhoeCanBoCaoCap : MetroForm
    {
        // service
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private BENHFactory BENHService = new BENHFactory();

        // variable
        private DateTime tungay = new DateTime(), denngay = new DateTime();
        public FrmDanhSachPhanLoaiSucKhoeCanBoCaoCap(DateTime _tungay, DateTime _denngay)
        {
            tungay = _tungay;
            denngay = _denngay;
            InitializeComponent();
        }

        private void FrmDanhSachPhanLoaiSucKhoeCanBoCaoCap_Load(object sender, EventArgs e)
        {
            // thống kê sức khỏe
            int i = 0;
            PhanLoaiSucKhoeCaoCapBindingSource.DataSource = KHAMTHUONGXUYENService.GetAllEntities().ToList()
                                                                .Where(p => p.THOIGIAN >= tungay && p.THOIGIAN <= denngay)
                                                                .Where(p =>CAPBACService.GetByPrimaryKey(new CAPBACKeys(
                                                                             (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CAPBACID
                                                                            )).CANBOCAPCAO == 1
                                                                )
                                                                .Select(p => new
                                                                {
                                                                    STT = ++i,
                                                                    HoTen = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).HOTEN,
                                                                    Benh = BENHService.GetByPrimaryKey(new BENHKeys((int)p.BENHID)).TEN,
                                                                    CapBac = CAPBACService.GetByPrimaryKey(new CAPBACKeys(
                                                                               (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CAPBACID
                                                                               )).TEN,
                                                                    ChucVu = CHUCVUService.GetByPrimaryKey(new CHUCVUKeys(
                                                                               (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CHUCVUID
                                                                               )).TEN,
                                                                    GhiChu = (p.GHICHU == null) ? "" : p.GHICHU
                                                                })
                                                                .ToList();

            ReportParameter[] listPara = new ReportParameter[]{
                };
            this.reportViewer1.LocalReport.SetParameters(listPara);


            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
