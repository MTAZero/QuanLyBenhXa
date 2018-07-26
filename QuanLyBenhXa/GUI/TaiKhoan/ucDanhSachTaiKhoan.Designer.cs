namespace QuanLyBenhXa.GUI.TaiKhoan
{
    partial class ucDanhSachTaiKhoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTaiKhoanCongKhai = new System.Windows.Forms.RadioButton();
            this.rdTaiKhoanCaNhan = new System.Windows.Forms.RadioButton();
            this.cbxChuTaiKhoan = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTAIKHOANMain = new DevExpress.XtraGrid.GridControl();
            this.dgvTAIKHOAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChuTaiKhoan.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAIKHOANMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAIKHOAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(856, 274);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 38);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1000, 274);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 38);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1144, 274);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 38);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(86, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(313, 24);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTaiKhoanCongKhai);
            this.groupBox3.Controls.Add(this.rdTaiKhoanCaNhan);
            this.groupBox3.Controls.Add(this.cbxChuTaiKhoan);
            this.groupBox3.Controls.Add(this.txtTenDangNhap);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(788, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 213);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết tài khoản";
            // 
            // rdTaiKhoanCongKhai
            // 
            this.rdTaiKhoanCongKhai.AutoSize = true;
            this.rdTaiKhoanCongKhai.Location = new System.Drawing.Point(317, 39);
            this.rdTaiKhoanCongKhai.Name = "rdTaiKhoanCongKhai";
            this.rdTaiKhoanCongKhai.Size = new System.Drawing.Size(144, 21);
            this.rdTaiKhoanCongKhai.TabIndex = 7;
            this.rdTaiKhoanCongKhai.TabStop = true;
            this.rdTaiKhoanCongKhai.Text = "Tài khoản công khai";
            this.rdTaiKhoanCongKhai.UseVisualStyleBackColor = true;
            // 
            // rdTaiKhoanCaNhan
            // 
            this.rdTaiKhoanCaNhan.AutoSize = true;
            this.rdTaiKhoanCaNhan.Checked = true;
            this.rdTaiKhoanCaNhan.Location = new System.Drawing.Point(156, 39);
            this.rdTaiKhoanCaNhan.Name = "rdTaiKhoanCaNhan";
            this.rdTaiKhoanCaNhan.Size = new System.Drawing.Size(134, 21);
            this.rdTaiKhoanCaNhan.TabIndex = 6;
            this.rdTaiKhoanCaNhan.TabStop = true;
            this.rdTaiKhoanCaNhan.Text = "Tài khoản cá nhân";
            this.rdTaiKhoanCaNhan.UseVisualStyleBackColor = true;
            // 
            // cbxChuTaiKhoan
            // 
            this.cbxChuTaiKhoan.Location = new System.Drawing.Point(156, 148);
            this.cbxChuTaiKhoan.Name = "cbxChuTaiKhoan";
            this.cbxChuTaiKhoan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxChuTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxChuTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.cbxChuTaiKhoan.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxChuTaiKhoan.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxChuTaiKhoan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxChuTaiKhoan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChuTaiKhoan.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxChuTaiKhoan.Properties.ShowHeader = false;
            this.cbxChuTaiKhoan.Size = new System.Drawing.Size(296, 26);
            this.cbxChuTaiKhoan.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(156, 91);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(296, 24);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chủ tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvTAIKHOANMain);
            this.groupBox2.Location = new System.Drawing.Point(17, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 487);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dgvTAIKHOANMain
            // 
            this.dgvTAIKHOANMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTAIKHOANMain.Location = new System.Drawing.Point(3, 20);
            this.dgvTAIKHOANMain.MainView = this.dgvTAIKHOAN;
            this.dgvTAIKHOANMain.Name = "dgvTAIKHOANMain";
            this.dgvTAIKHOANMain.Size = new System.Drawing.Size(748, 464);
            this.dgvTAIKHOANMain.TabIndex = 2;
            this.dgvTAIKHOANMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvTAIKHOAN});
            // 
            // dgvTAIKHOAN
            // 
            this.dgvTAIKHOAN.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvTAIKHOAN.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvTAIKHOAN.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvTAIKHOAN.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvTAIKHOAN.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvTAIKHOAN.Appearance.Row.Options.UseFont = true;
            this.dgvTAIKHOAN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvTAIKHOAN.ColumnPanelRowHeight = 30;
            this.dgvTAIKHOAN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TenDangNhap,
            this.LoaiTaiKhoan,
            this.ChuTaiKhoan});
            this.dgvTAIKHOAN.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvTAIKHOAN.GridControl = this.dgvTAIKHOANMain;
            this.dgvTAIKHOAN.Name = "dgvTAIKHOAN";
            this.dgvTAIKHOAN.OptionsBehavior.Editable = false;
            this.dgvTAIKHOAN.OptionsBehavior.ReadOnly = true;
            this.dgvTAIKHOAN.OptionsCustomization.AllowColumnMoving = false;
            this.dgvTAIKHOAN.OptionsCustomization.AllowColumnResizing = false;
            this.dgvTAIKHOAN.OptionsCustomization.AllowFilter = false;
            this.dgvTAIKHOAN.OptionsCustomization.AllowGroup = false;
            this.dgvTAIKHOAN.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvTAIKHOAN.OptionsFind.AllowFindPanel = false;
            this.dgvTAIKHOAN.OptionsView.ShowGroupPanel = false;
            this.dgvTAIKHOAN.PaintStyleName = "UltraFlat";
            this.dgvTAIKHOAN.RowHeight = 30;
            this.dgvTAIKHOAN.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvTAIKHOAN_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 57;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Caption = "Tên đăng nhập";
            this.TenDangNhap.FieldName = "TenDangNhap";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Visible = true;
            this.TenDangNhap.VisibleIndex = 1;
            this.TenDangNhap.Width = 212;
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.Caption = "Loại tài khoản";
            this.LoaiTaiKhoan.FieldName = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.Visible = true;
            this.LoaiTaiKhoan.VisibleIndex = 2;
            this.LoaiTaiKhoan.Width = 212;
            // 
            // ChuTaiKhoan
            // 
            this.ChuTaiKhoan.Caption = "Chủ tài khoản";
            this.ChuTaiKhoan.FieldName = "ChuTaiKhoan";
            this.ChuTaiKhoan.Name = "ChuTaiKhoan";
            this.ChuTaiKhoan.Visible = true;
            this.ChuTaiKhoan.VisibleIndex = 3;
            this.ChuTaiKhoan.Width = 218;
            // 
            // ucDanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucDanhSachTaiKhoan";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucDanhSachTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChuTaiKhoan.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAIKHOANMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAIKHOAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl dgvTAIKHOANMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvTAIKHOAN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private DevExpress.XtraEditors.LookUpEdit cbxChuTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn ChuTaiKhoan;
        private System.Windows.Forms.RadioButton rdTaiKhoanCongKhai;
        private System.Windows.Forms.RadioButton rdTaiKhoanCaNhan;
    }
}
