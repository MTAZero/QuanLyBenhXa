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
    public partial class FrmCapThemThuoc : MetroForm
    {
        // service
        private THUOCFactory THUOCService = new THUOCFactory();
        private CHITIETCAPTHUOCFactory CHITIETCAPTHUOCService = new CHITIETCAPTHUOCFactory();
        private int capthuocID = 0;

        #region Hàm khởi tạo
        public FrmCapThemThuoc(int _capthuocid)
        {
            InitializeComponent();
            capthuocID = _capthuocid;
        }
        #endregion


        #region  Sự kiện
        private void btnCap_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                CHITIETCAPTHUOC chitiet = new CHITIETCAPTHUOC();
                chitiet.CAPTHUOCID = capthuocID;
                chitiet.THUOCID = (int)cbxThuoc.EditValue;
                chitiet.SOLUONG = Int32.Parse(txtSoLuong.Text);
                chitiet.GHICHU = txtGhiChu.Text;

                bool ok = CHITIETCAPTHUOCService.Insert(chitiet);
                if (ok)
                {
                    MessageBox.Show("Thêm chi tiết cấp thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết cấp thuốc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            // cbx thuoc
            cbxThuoc.Properties.DataSource = THUOCService.GetAllEntities().Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxThuoc.Properties.DisplayMember = "Ten";
            cbxThuoc.Properties.ValueMember = "ID";
            cbxThuoc.ItemIndex = 0;
        }

        private void FrmCapThemThuoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
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
            THUOC thuoc = THUOCService.GetAllEntities().Where(p => p.ID == (int)cbxThuoc.EditValue).FirstOrDefault();
            if (soluong > thuoc.SOLUONG)
            {
                MessageBox.Show("Số lượng thuốc " + thuoc.TEN + " còn lại không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion
    }
}
