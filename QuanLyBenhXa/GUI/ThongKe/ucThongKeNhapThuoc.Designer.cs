namespace QuanLyBenhXa.GUI.ThongKe
{
    partial class ucThongKeNhapThuoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCHITIETNHAPMain = new DevExpress.XtraGrid.GridControl();
            this.dgvCHITIETNHAP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STTChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNHAPTHUOCMain = new DevExpress.XtraGrid.GridControl();
            this.dgvNHAPTHUOC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAPMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHAPTHUOCMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHAPTHUOC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTongNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateDenNgay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTuNgay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(359, 31);
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
            this.label6.Location = new System.Drawing.Point(288, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(69, 31);
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
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCHITIETNHAPMain);
            this.groupBox3.Location = new System.Drawing.Point(583, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 524);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chi tiết nhập";
            // 
            // dgvCHITIETNHAPMain
            // 
            this.dgvCHITIETNHAPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCHITIETNHAPMain.Location = new System.Drawing.Point(3, 20);
            this.dgvCHITIETNHAPMain.MainView = this.dgvCHITIETNHAP;
            this.dgvCHITIETNHAPMain.Name = "dgvCHITIETNHAPMain";
            this.dgvCHITIETNHAPMain.Size = new System.Drawing.Size(690, 501);
            this.dgvCHITIETNHAPMain.TabIndex = 4;
            this.dgvCHITIETNHAPMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCHITIETNHAP});
            // 
            // dgvCHITIETNHAP
            // 
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvCHITIETNHAP.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCHITIETNHAP.Appearance.Row.Options.UseFont = true;
            this.dgvCHITIETNHAP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvCHITIETNHAP.ColumnPanelRowHeight = 30;
            this.dgvCHITIETNHAP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STTChiTiet,
            this.Thuoc,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvCHITIETNHAP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvCHITIETNHAP.GridControl = this.dgvCHITIETNHAPMain;
            this.dgvCHITIETNHAP.Name = "dgvCHITIETNHAP";
            this.dgvCHITIETNHAP.OptionsBehavior.Editable = false;
            this.dgvCHITIETNHAP.OptionsBehavior.ReadOnly = true;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowColumnMoving = false;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowColumnResizing = false;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowFilter = false;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowGroup = false;
            this.dgvCHITIETNHAP.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvCHITIETNHAP.OptionsFind.AllowFindPanel = false;
            this.dgvCHITIETNHAP.OptionsView.ShowGroupPanel = false;
            this.dgvCHITIETNHAP.PaintStyleName = "UltraFlat";
            this.dgvCHITIETNHAP.RowHeight = 30;
            // 
            // STTChiTiet
            // 
            this.STTChiTiet.Caption = "STT";
            this.STTChiTiet.FieldName = "STT";
            this.STTChiTiet.Name = "STTChiTiet";
            this.STTChiTiet.Visible = true;
            this.STTChiTiet.VisibleIndex = 0;
            this.STTChiTiet.Width = 61;
            // 
            // Thuoc
            // 
            this.Thuoc.Caption = "Thuốc";
            this.Thuoc.FieldName = "Thuoc";
            this.Thuoc.Name = "Thuoc";
            this.Thuoc.Visible = true;
            this.Thuoc.VisibleIndex = 1;
            this.Thuoc.Width = 259;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 98;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            this.DonGia.Width = 136;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 145;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNHAPTHUOCMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhập thuốc";
            // 
            // dgvNHAPTHUOCMain
            // 
            this.dgvNHAPTHUOCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNHAPTHUOCMain.Location = new System.Drawing.Point(3, 20);
            this.dgvNHAPTHUOCMain.MainView = this.dgvNHAPTHUOC;
            this.dgvNHAPTHUOCMain.Name = "dgvNHAPTHUOCMain";
            this.dgvNHAPTHUOCMain.Size = new System.Drawing.Size(559, 401);
            this.dgvNHAPTHUOCMain.TabIndex = 4;
            this.dgvNHAPTHUOCMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNHAPTHUOC});
            // 
            // dgvNHAPTHUOC
            // 
            this.dgvNHAPTHUOC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvNHAPTHUOC.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvNHAPTHUOC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvNHAPTHUOC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvNHAPTHUOC.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvNHAPTHUOC.Appearance.Row.Options.UseFont = true;
            this.dgvNHAPTHUOC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvNHAPTHUOC.ColumnPanelRowHeight = 30;
            this.dgvNHAPTHUOC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.NgayNhap,
            this.BacSi,
            this.TongTien});
            this.dgvNHAPTHUOC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvNHAPTHUOC.GridControl = this.dgvNHAPTHUOCMain;
            this.dgvNHAPTHUOC.Name = "dgvNHAPTHUOC";
            this.dgvNHAPTHUOC.OptionsBehavior.Editable = false;
            this.dgvNHAPTHUOC.OptionsBehavior.ReadOnly = true;
            this.dgvNHAPTHUOC.OptionsCustomization.AllowColumnMoving = false;
            this.dgvNHAPTHUOC.OptionsCustomization.AllowColumnResizing = false;
            this.dgvNHAPTHUOC.OptionsCustomization.AllowFilter = false;
            this.dgvNHAPTHUOC.OptionsCustomization.AllowGroup = false;
            this.dgvNHAPTHUOC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvNHAPTHUOC.OptionsFind.AllowFindPanel = false;
            this.dgvNHAPTHUOC.OptionsView.ShowGroupPanel = false;
            this.dgvNHAPTHUOC.PaintStyleName = "UltraFlat";
            this.dgvNHAPTHUOC.RowHeight = 30;
            this.dgvNHAPTHUOC.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvNHAPTHUOC_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 58;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 1;
            this.NgayNhap.Width = 162;
            // 
            // BacSi
            // 
            this.BacSi.Caption = "Bác sĩ";
            this.BacSi.FieldName = "BacSi";
            this.BacSi.Name = "BacSi";
            this.BacSi.Visible = true;
            this.BacSi.VisibleIndex = 2;
            this.BacSi.Width = 293;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 3;
            this.TongTien.Width = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng nhập: ";
            // 
            // txtTongNhap
            // 
            this.txtTongNhap.AutoSize = true;
            this.txtTongNhap.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongNhap.Location = new System.Drawing.Point(101, 94);
            this.txtTongNhap.Name = "txtTongNhap";
            this.txtTongNhap.Size = new System.Drawing.Size(16, 17);
            this.txtTongNhap.TabIndex = 5;
            this.txtTongNhap.Text = "0";
            // 
            // ucThongKeNhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKeNhapThuoc";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucThongKeNhapThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAPMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHAPTHUOCMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHAPTHUOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl dgvCHITIETNHAPMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCHITIETNHAP;
        private DevExpress.XtraGrid.GridControl dgvNHAPTHUOCMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNHAPTHUOC;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraGrid.Columns.GridColumn STTChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn Thuoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.Label txtTongNhap;
        private System.Windows.Forms.Label label1;
    }
}
