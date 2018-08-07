namespace QuanLyBenhXa.GUI.ThongKe
{
    partial class ucThongKeKhamDinhKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThongKeKhamDinhKi));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKHAMDINHKIMain = new DevExpress.XtraGrid.GridControl();
            this.dgvKHAMDINHKI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhanLoaiSucKhoe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KetLuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxBenhNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.chkBenhNhan = new System.Windows.Forms.CheckBox();
            this.chkDonVi = new System.Windows.Forms.CheckBox();
            this.cbxDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKIMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKI)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBenhNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonVi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dateDenNgay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTuNgay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(583, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(81, 61);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(485, 24);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm kiếm";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(381, 23);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dateDenNgay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDenNgay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateDenNgay.Size = new System.Drawing.Size(185, 26);
            this.dateDenNgay.TabIndex = 19;
            this.dateDenNgay.DateTimeChanged += new System.EventHandler(this.dateTuNgay_DateTimeChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(81, 23);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dateTuNgay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateTuNgay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateTuNgay.Size = new System.Drawing.Size(185, 26);
            this.dateTuNgay.TabIndex = 17;
            this.dateTuNgay.DateTimeChanged += new System.EventHandler(this.dateTuNgay_DateTimeChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKHAMDINHKIMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khám định kì";
            // 
            // dgvKHAMDINHKIMain
            // 
            this.dgvKHAMDINHKIMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHAMDINHKIMain.Location = new System.Drawing.Point(3, 20);
            this.dgvKHAMDINHKIMain.MainView = this.dgvKHAMDINHKI;
            this.dgvKHAMDINHKIMain.Name = "dgvKHAMDINHKIMain";
            this.dgvKHAMDINHKIMain.Size = new System.Drawing.Size(1263, 403);
            this.dgvKHAMDINHKIMain.TabIndex = 5;
            this.dgvKHAMDINHKIMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKHAMDINHKI});
            // 
            // dgvKHAMDINHKI
            // 
            this.dgvKHAMDINHKI.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvKHAMDINHKI.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvKHAMDINHKI.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvKHAMDINHKI.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvKHAMDINHKI.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvKHAMDINHKI.Appearance.Row.Options.UseFont = true;
            this.dgvKHAMDINHKI.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvKHAMDINHKI.ColumnPanelRowHeight = 30;
            this.dgvKHAMDINHKI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ngay,
            this.BacSi,
            this.BenhNhan,
            this.DonVi,
            this.PhanLoaiSucKhoe,
            this.KetLuan});
            this.dgvKHAMDINHKI.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvKHAMDINHKI.GridControl = this.dgvKHAMDINHKIMain;
            this.dgvKHAMDINHKI.Name = "dgvKHAMDINHKI";
            this.dgvKHAMDINHKI.OptionsBehavior.Editable = false;
            this.dgvKHAMDINHKI.OptionsBehavior.ReadOnly = true;
            this.dgvKHAMDINHKI.OptionsCustomization.AllowColumnMoving = false;
            this.dgvKHAMDINHKI.OptionsCustomization.AllowColumnResizing = false;
            this.dgvKHAMDINHKI.OptionsCustomization.AllowFilter = false;
            this.dgvKHAMDINHKI.OptionsCustomization.AllowGroup = false;
            this.dgvKHAMDINHKI.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvKHAMDINHKI.OptionsFind.AllowFindPanel = false;
            this.dgvKHAMDINHKI.OptionsView.ShowGroupPanel = false;
            this.dgvKHAMDINHKI.PaintStyleName = "UltraFlat";
            this.dgvKHAMDINHKI.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 27;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 70;
            // 
            // BacSi
            // 
            this.BacSi.Caption = "Bác sĩ khám";
            this.BacSi.FieldName = "BacSi";
            this.BacSi.Name = "BacSi";
            this.BacSi.Visible = true;
            this.BacSi.VisibleIndex = 2;
            this.BacSi.Width = 126;
            // 
            // BenhNhan
            // 
            this.BenhNhan.Caption = "Bệnh nhân";
            this.BenhNhan.FieldName = "BenhNhan";
            this.BenhNhan.Name = "BenhNhan";
            this.BenhNhan.Visible = true;
            this.BenhNhan.VisibleIndex = 3;
            this.BenhNhan.Width = 110;
            // 
            // DonVi
            // 
            this.DonVi.Caption = "Đơn vị";
            this.DonVi.FieldName = "DonVi";
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 4;
            this.DonVi.Width = 118;
            // 
            // PhanLoaiSucKhoe
            // 
            this.PhanLoaiSucKhoe.Caption = "Phân loại sức khỏe";
            this.PhanLoaiSucKhoe.FieldName = "PhanLoaiSucKhoe";
            this.PhanLoaiSucKhoe.Name = "PhanLoaiSucKhoe";
            this.PhanLoaiSucKhoe.Visible = true;
            this.PhanLoaiSucKhoe.VisibleIndex = 5;
            this.PhanLoaiSucKhoe.Width = 100;
            // 
            // KetLuan
            // 
            this.KetLuan.Caption = "Kết luận";
            this.KetLuan.FieldName = "KetLuan";
            this.KetLuan.Name = "KetLuan";
            this.KetLuan.Visible = true;
            this.KetLuan.VisibleIndex = 6;
            this.KetLuan.Width = 148;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(1086, 79);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(93, 30);
            this.btnIn.TabIndex = 25;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxBenhNhan);
            this.groupBox2.Controls.Add(this.chkBenhNhan);
            this.groupBox2.Controls.Add(this.chkDonVi);
            this.groupBox2.Controls.Add(this.cbxDonVi);
            this.groupBox2.Location = new System.Drawing.Point(601, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 102);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // cbxBenhNhan
            // 
            this.cbxBenhNhan.Location = new System.Drawing.Point(124, 56);
            this.cbxBenhNhan.Name = "cbxBenhNhan";
            this.cbxBenhNhan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxBenhNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxBenhNhan.Properties.Appearance.Options.UseFont = true;
            this.cbxBenhNhan.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxBenhNhan.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxBenhNhan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxBenhNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxBenhNhan.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxBenhNhan.Properties.ShowHeader = false;
            this.cbxBenhNhan.Size = new System.Drawing.Size(255, 26);
            this.cbxBenhNhan.TabIndex = 6;
            this.cbxBenhNhan.EditValueChanged += new System.EventHandler(this.cbxBenhNhan_EditValueChanged);
            // 
            // chkBenhNhan
            // 
            this.chkBenhNhan.AutoSize = true;
            this.chkBenhNhan.Location = new System.Drawing.Point(25, 59);
            this.chkBenhNhan.Name = "chkBenhNhan";
            this.chkBenhNhan.Size = new System.Drawing.Size(90, 21);
            this.chkBenhNhan.TabIndex = 5;
            this.chkBenhNhan.Text = "Bệnh nhân";
            this.chkBenhNhan.UseVisualStyleBackColor = true;
            this.chkBenhNhan.CheckedChanged += new System.EventHandler(this.chkBenhNhan_CheckedChanged);
            // 
            // chkDonVi
            // 
            this.chkDonVi.AutoSize = true;
            this.chkDonVi.Location = new System.Drawing.Point(25, 23);
            this.chkDonVi.Name = "chkDonVi";
            this.chkDonVi.Size = new System.Drawing.Size(67, 21);
            this.chkDonVi.TabIndex = 4;
            this.chkDonVi.Text = "Đơn vị";
            this.chkDonVi.UseVisualStyleBackColor = true;
            this.chkDonVi.CheckedChanged += new System.EventHandler(this.chkDonVi_CheckedChanged);
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.Location = new System.Drawing.Point(124, 21);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxDonVi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxDonVi.Properties.Appearance.Options.UseFont = true;
            this.cbxDonVi.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxDonVi.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxDonVi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDonVi.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxDonVi.Properties.ShowHeader = false;
            this.cbxDonVi.Size = new System.Drawing.Size(255, 26);
            this.cbxDonVi.TabIndex = 3;
            this.cbxDonVi.EditValueChanged += new System.EventHandler(this.cbxBenhNhan_EditValueChanged);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Appearance.Options.UseFont = true;
            this.btnChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.Location = new System.Drawing.Point(1185, 79);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 30);
            this.btnChiTiet.TabIndex = 23;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // ucThongKeKhamDinhKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKeKhamDinhKi";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucThongKeKhamDinhKi_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKIMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBenhNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonVi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgvKHAMDINHKIMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKHAMDINHKI;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn BenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn PhanLoaiSucKhoe;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn KetLuan;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LookUpEdit cbxDonVi;
        private System.Windows.Forms.CheckBox chkBenhNhan;
        private System.Windows.Forms.CheckBox chkDonVi;
        private DevExpress.XtraEditors.LookUpEdit cbxBenhNhan;
    }
}
