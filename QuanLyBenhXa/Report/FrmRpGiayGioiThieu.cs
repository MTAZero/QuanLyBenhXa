using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmRpGiayGioiThieu : MetroForm
    {
        private dynamic param;
        public FrmRpGiayGioiThieu(dynamic _param)
        {
            param = _param;
            InitializeComponent();
        }

        private void FrmRpGiayGioiThieu_Load(object sender, EventArgs e)
        {

            ReportParameter[] listPara = new ReportParameter[]{
                    new ReportParameter("BenhVienCapTren", param.BenhVienCapTren),
                    new ReportParameter("HoTen", param.HoTen),
                    new ReportParameter("Tuoi", param.Tuoi.ToString()),
                    new ReportParameter("CapBac", param.CapBac),
                    new ReportParameter("ChucVu", param.ChucVu),
                    new ReportParameter("DonVi", param.DonVi),
                    new ReportParameter("Benh", param.Benh),
                    new ReportParameter("YKienDeNghi", param.YKienDeNghi),
                    new ReportParameter("Ngay", param.Ngay),
                    new ReportParameter("SoSucKhoe", param.SoSucKhoe),
                    new ReportParameter("DonViBenhNhan", param.DonViBenhNhan)
             };
            this.reportViewer1.LocalReport.SetParameters(listPara);


            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
