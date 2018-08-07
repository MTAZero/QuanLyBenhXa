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
    public partial class FrmRpCanBoDieuTri : MetroForm
    {
        // service
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private BENHFactory BENHService = new BENHFactory();
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();
        private DONVIFactory DONVIService = new DONVIFactory();

        // variable
        private DateTime tungay = new DateTime(), denngay = new DateTime();

        #region Hàm khởi tạo
        public FrmRpCanBoDieuTri(DateTime _tungay, DateTime _denngay)
        {
            tungay = _tungay;
            denngay = _denngay;
            InitializeComponent();
        }
        #endregion

        private String CachGiaiQuyet(int k)
        {
            if (k == 0) return "Điều trị tại đơn vị";
            if (k == 1) return "Điều trị tại bệnh xá";
            if (k == 2) return "Điều trị tại tuyến trên";
            return "";
        }

        private void FrmRpCanBoDieuTri_Load(object sender, EventArgs e)
        {
            // thống kê sức khỏe
            int i = 0;
            CanBoCapCaoDieuTriBindingSource.DataSource = KHAMTHUONGXUYENService.GetAllEntities().ToList()
                                                                .Where(p => p.THOIGIAN >= tungay && p.THOIGIAN <= denngay)
                                                                .Where(p => CAPBACService.GetByPrimaryKey(new CAPBACKeys(
                                                                             (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CAPBACID
                                                                            )).CANBOCAPCAO == 1
                                                                )
                                                                .Select(p => new
                                                                {
                                                                    STT = ++i,
                                                                    HoTen = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).HOTEN,
                                                                    MacBenh = BENHService.GetByPrimaryKey(new BENHKeys((int) p.BENHID)).TEN,
                                                                    CapBac = CAPBACService.GetByPrimaryKey(new CAPBACKeys(
                                                                               (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CAPBACID
                                                                               )).KIHIEU,
                                                                    DonVi = DONVIService.GetByPrimaryKey(new DONVIKeys(
                                                                               (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).DONVIID
                                                                               )).TEN,
                                                                    BienPhapGiaiQuyet = CachGiaiQuyet((int)p.CACHGIAIQUYET),
                                                                    ThoiGianDieuTri = (p.THOIGIANVAO == null) ? "Không" : "Từ "+((DateTime)p.THOIGIANVAO).ToString("dd /MM/yyyy")+ " đến " + ((DateTime)p.THOIGIANRA).ToString("dd/MM/yyyy")
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
