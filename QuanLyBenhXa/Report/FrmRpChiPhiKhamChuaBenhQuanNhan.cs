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
    public partial class FrmRpChiPhiKhamChuaBenhQuanNhan : MetroForm
    {
        // service
        private KHAMTHUONGXUYENFactory KHAMTHUONGXUYENService = new KHAMTHUONGXUYENFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private THUOCFactory THUOCService = new THUOCFactory();
        private VATTUFactory VATTUService = new VATTUFactory();
        private CAPTHUOCFactory CAPTHUOCService = new CAPTHUOCFactory();
        private MUONVATTUFactory MUONVATTUService = new MUONVATTUFactory();
        private CHITIETCAPTHUOCFactory CHITIETCAPTHUOCService = new CHITIETCAPTHUOCFactory();
        private CHITIETMUONVATTUFactory CHITIETMUONVATTUService = new CHITIETMUONVATTUFactory();
        private DONVIFactory DONVIService = new DONVIFactory();

        // variable
        private KHAMTHUONGXUYEN khamthuongxuyen = new KHAMTHUONGXUYEN();
        private string nguoilapbangke = "", phutrachquany = "";
        public FrmRpChiPhiKhamChuaBenhQuanNhan(int _khamthuongxuyenID, string _nguoilapbangke, string _phutrachquany)
        {
            khamthuongxuyen = KHAMTHUONGXUYENService.GetByPrimaryKey(new KHAMTHUONGXUYENKeys(_khamthuongxuyenID));
            nguoilapbangke = _nguoilapbangke;
            phutrachquany = _phutrachquany;

            InitializeComponent();
        }

        private void FrmRpChiPhiKhamChuaBenhQuanNhan_Load(object sender, EventArgs e)
        {
            try
            {
                BENHNHAN benhnhan = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)khamthuongxuyen.BENHNHANID));
                int tong = 0;

                CAPTHUOC capthuoc = CAPTHUOCService.GetAllEntities().Where(p => p.KHAMTHUONGXUYENID == khamthuongxuyen.ID).FirstOrDefault();
                MUONVATTU muonvattu = MUONVATTUService.GetAllEntities().Where(p => p.KHAMTHUONGXUYENID == khamthuongxuyen.ID).FirstOrDefault();

                // thuoc
                int stt = 0;
                ChiPhiKhamBenhThuocBindingSource.DataSource = CHITIETCAPTHUOCService.GetAllEntities().ToList()
                                                                .Where(p => p.CAPTHUOCID == capthuoc.ID)
                                                                .Select(p => new
                                                                {
                                                                    STT = ++stt,
                                                                    Thuoc = THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).TEN,
                                                                    Dvt = THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).GHICHU,
                                                                    SoLuong = p.SOLUONG,
                                                                    DonGia = Int32.Parse(THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).HAMLUONG).ToString("N0"),
                                                                    ThanhTien = ((int)p.SOLUONG * Int32.Parse(THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).HAMLUONG)).ToString("N0")
                                                                })
                                                               .ToList();

                // vat tu
                int i = 0;
                ChiPhiKhamBenhVatTuBindingSource.DataSource = CHITIETMUONVATTUService.GetAllEntities().ToList()
                                                                .Where(p => p.MUONVATTUID == muonvattu.ID)
                                                                .Select(p => new
                                                                {
                                                                    STT = ++i,
                                                                    VatTu = VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).TEN,
                                                                    Dvt = VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).KYHIEU,
                                                                    SoLuong = p.SOLUONG,
                                                                    DonGia = Int32.Parse(VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).GHICHU).ToString("N0"),
                                                                    ThanhTien = ((int)p.SOLUONG * Int32.Parse(VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).GHICHU)).ToString("N0")
                                                                })
                                                                .ToList();
                tong = CHITIETCAPTHUOCService.GetAllEntities().ToList()
                                                                .Where(p => p.CAPTHUOCID == capthuoc.ID)
                                                                .Select(p => new
                                                                {
                                                                    STT = ++stt,
                                                                    Thuoc = THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).TEN,
                                                                    Dvt = THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).GHICHU,
                                                                    SoLuong = p.SOLUONG,
                                                                    DonGia = Int32.Parse(THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).HAMLUONG).ToString("N0"),
                                                                    ThanhTien = p.SOLUONG * Int32.Parse(THUOCService.GetByPrimaryKey(new THUOCKeys((int)p.THUOCID)).HAMLUONG)
                                                                })
                                                               .Sum(p => (int)p.ThanhTien) +
                       CHITIETMUONVATTUService.GetAllEntities().ToList()
                                                                .Where(p => p.MUONVATTUID == muonvattu.ID)
                                                                .Select(p => new
                                                                {
                                                                    STT = ++i,
                                                                    VatTu = VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).TEN,
                                                                    Dvt = VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).KYHIEU,
                                                                    SoLuong = p.SOLUONG,
                                                                    DonGia = Int32.Parse(VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).GHICHU).ToString("N0"),
                                                                    ThanhTien = p.SOLUONG * Int32.Parse(VATTUService.GetByPrimaryKey(new VATTUKeys((int)p.VATTUID)).GHICHU)
                                                                })
                                                                .Sum(p => (int)p.ThanhTien);


                ReportParameter[] listPara = new ReportParameter[]{
                    new ReportParameter("HoTen", benhnhan.HOTEN),
                    new ReportParameter("NgaySinh", ((DateTime)benhnhan.NGAYSINH).ToString("dd/MM/yyyy")),
                    new ReportParameter("GioiTinh", (benhnhan.GIOITINH == 1) ? "Nam" : "Nữ"),
                    new ReportParameter("DonVi", DONVIService.GetByPrimaryKey(new DONVIKeys((int)benhnhan.DONVIID)).TEN),
                    new ReportParameter("MaTheBHYT", benhnhan.MATHEBHYT),
                    new ReportParameter("ChanDoan", (khamthuongxuyen.CHANDOANSOBO == null) ? "" : khamthuongxuyen.CHANDOANSOBO),
                    new ReportParameter("ThoiGian", ((DateTime)khamthuongxuyen.THOIGIAN).ToString("dd/MM/yyyy")),
                    new ReportParameter("NguoiLapBangKe", nguoilapbangke),
                    new ReportParameter("PhuTrachQuanY", phutrachquany),
                    new ReportParameter("Ngay", ((DateTime)khamthuongxuyen.THOIGIAN).ToString(@"\N\g\à\y dd \t\h\á\n\g MM \n\ă\m yyyy")),
                    new ReportParameter("Tong", tong.ToString("N0"))
                };
                this.reportViewer1.LocalReport.SetParameters(listPara);


                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch
            {
            }

        }
    }

}
