﻿using MetroFramework.Forms;
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
        private KHAMDINHKIFactory KHAMDINHKIService = new KHAMDINHKIFactory();
        private BENHNHANFactory BENHNHANService = new BENHNHANFactory();
        private CHUCVUFactory CHUCVUService = new CHUCVUFactory();
        private CAPBACFactory CAPBACService = new CAPBACFactory();
        private BENHFactory BENHService = new BENHFactory();
        private PHANLOAISUCKHOEFactory PHANLOAISUCKHOEService = new PHANLOAISUCKHOEFactory();

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
            PhanLoaiSucKhoeCaoCapBindingSource.DataSource = KHAMDINHKIService.GetAllEntities().ToList()
                                                                .Where(p => p.THOIGIANKHAM >= tungay && p.THOIGIANKHAM <= denngay)
                                                                .Where(p =>CAPBACService.GetByPrimaryKey(new CAPBACKeys(
                                                                             (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CAPBACID
                                                                            )).CANBOCAPCAO == 1
                                                                )
                                                                .Select(p => new
                                                                {
                                                                    STT = ++i,
                                                                    HoTen = BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).HOTEN,
                                                                    Benh = p.KETLUAN,
                                                                    CapBac = CAPBACService.GetByPrimaryKey(new CAPBACKeys(
                                                                               (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CAPBACID
                                                                               )).KIHIEU,
                                                                    ChucVu = CHUCVUService.GetByPrimaryKey(new CHUCVUKeys(
                                                                               (int)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).CHUCVUID
                                                                               )).TEN,
                                                                    GhiChu = (p.GHICHU == null) ? "" : p.GHICHU,
                                                                    PhanLoaiSK = PHANLOAISUCKHOEService.GetByPrimaryKey(new PHANLOAISUCKHOEKeys((int)p.PHANLOAISUCKHOEID)).TEN,
                                                                    NamSinh = ((DateTime)BENHNHANService.GetByPrimaryKey(new BENHNHANKeys((int)p.BENHNHANID)).NGAYSINH).Year.ToString()
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
