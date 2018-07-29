using MetroFramework.Forms;
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

namespace QuanLyBenhXa.GUI.KhamBenh
{
    public partial class FrmMuonThemVatTu : MetroForm
    {
        // service
        private VATTUFactory VATTUService = new VATTUFactory();
        private CHITIETMUONVATTUFactory CHITIETMUONVATTUService = new CHITIETMUONVATTUFactory();

        private int muonvattuID = 0;

        #region Hàm khởi tạo
        public FrmMuonThemVatTu(int _muonvattuID)
        {
            InitializeComponent();
            muonvattuID = _muonvattuID;
        }

        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            // cbx vat tu
            cbxVatTu.Properties.DataSource = VATTUService.GetAllEntities().Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxVatTu.Properties.DisplayMember = "Ten";
            cbxVatTu.Properties.ValueMember = "ID";
            cbxVatTu.ItemIndex = 0;
        }
        private void FrmMuonThemVatTu_Load(object sender, EventArgs e)
        {
            LoadInitControl();
        }
        #endregion

        #region Sự kiện
        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                CHITIETMUONVATTU chitiet = new CHITIETMUONVATTU();
                chitiet.MUONVATTUID = muonvattuID;
                chitiet.VATTUID = (int)cbxVatTu.EditValue;
                chitiet.SOLUONG = Int32.Parse(txtSoLuong.Text);
                chitiet.GHICHU = txtGhiChu.Text;

                bool ok = CHITIETMUONVATTUService.Insert(chitiet);
                if (ok)
                {
                    MessageBox.Show("Thêm chi tiết mượn vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết mượn vật tư thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hàm chức năng
        private bool Check()
        {
            int soluong;
            try
            {
                soluong = Int32.Parse(txtSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // kiểm tra kho
            VATTU thuoc = VATTUService.GetAllEntities().Where(p => p.ID == (int)cbxVatTu.EditValue).FirstOrDefault();
            if (soluong > thuoc.SOLUONG)
            {
                MessageBox.Show("Số lượng vật tư " + thuoc.TEN + " còn lại không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion
    }
}
