using MetroFramework.Forms;
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
        public FrmRpChiPhiKhamChuaBenhQuanNhan()
        {
            InitializeComponent();
        }

        private void FrmRpChiPhiKhamChuaBenhQuanNhan_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
