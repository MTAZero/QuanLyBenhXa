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
    public partial class FrmRpKhamDinhKi : MetroForm
    {
        // service
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();
        private BACSIFactory BACSIService = new BACSIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();
        private DONVIFactory DONVIService = new DONVIFactory();

        // variable
        private DateTime tungay = new DateTime(), denngay = new DateTime();
        private string header = "";
        private bool chkDonVi = false, chkBenhNhan = false;
        private int DonViID, BenhNhanID;

        #region Hàm khởi tạo
        public FrmRpKhamDinhKi(String _header, DateTime _tungay, DateTime _denngay, bool _chkDonvi, int _DonViID, bool _chkBenhNhan, int _BenhNhanID)
        {
            tungay = _tungay;
            denngay = _denngay;
            header = _header;
            chkDonVi = _chkDonvi;
            chkBenhNhan = _chkBenhNhan;
            DonViID = _DonViID;
            BenhNhanID = _BenhNhanID;

            InitializeComponent();
        }
        #endregion

        private void FrmRpCanBoDieuTri_Load(object sender, EventArgs e)
        {
            // thống kê sức khỏe
            int i = 0;
            KhamDinhKiBindingSource.DataSource = KHAMDINHKIService.GetAllEntities().ToList()
                                                .Where(p => p.THOIGIANKHAM >= tungay && p.THOIGIANKHAM <= denngay)
                                                .Where(p => !chkDonVi || BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).DONVIID == (int)DonViID)
                                                .Where(p => !chkBenhNhan || p.BENHNHANID == BenhNhanID)
                                                .Select(p => new
                                                {
                                                    STT = ++i,
                                                    Ngay = ((DateTime)p.THOIGIANKHAM).ToString("dd/MM/yyyy"),
                                                    BacSi = BACSIService.GetAllEntities().Where(z => z.ID == p.BACSIID).FirstOrDefault().HOTEN,
                                                    BenhNhan = BENHNHANService.GetAllEntities().Where(z => z.ID == p.BENHNHANID).FirstOrDefault().HOTEN,
                                                    PhanLoai = PHANLOAISUCKHOEService.GetAllEntities().Where(z => z.ID == p.PHANLOAISUCKHOEID).FirstOrDefault().TEN,
                                                    DonVi = DONVIService.GetByPrimaryKey(new DONVIKeys((int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).DONVIID)).TEN,
                                                    KetLuan = (p.KETLUAN == null) ? "" : p.KETLUAN
                                                })
                                                .ToList();

            ReportParameter[] listPara = new ReportParameter[]{
                new ReportParameter("Header", header)
            };
            this.reportViewer1.LocalReport.SetParameters(listPara);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
