namespace QuanLyBenhXa.GUI.ThongKe
{
    partial class ucCapThuoc
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCHITIETCAPTHUOCMain = new DevExpress.XtraGrid.GridControl();
            this.dgvCHITIETCAPTHUOC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STTChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCAPTHUOCMain = new DevExpress.XtraGrid.GridControl();
            this.dgvCAPTHUOC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Benh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETCAPTHUOCMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETCAPTHUOC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAPTHUOCMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAPTHUOC)).BeginInit();
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
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(694, 113);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(435, 31);
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
            this.dateDenNgay.DateTimeChanged += new System.EventHandler(this.dateDenNgay_DateTimeChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(122, 31);
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
            this.dateTuNgay.DateTimeChanged += new System.EventHandler(this.dateDenNgay_DateTimeChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCHITIETCAPTHUOCMain);
            this.groupBox3.Location = new System.Drawing.Point(709, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 524);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chi tiếp cấp thuốc";
            // 
            // dgvCHITIETCAPTHUOCMain
            // 
            this.dgvCHITIETCAPTHUOCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCHITIETCAPTHUOCMain.Location = new System.Drawing.Point(3, 20);
            this.dgvCHITIETCAPTHUOCMain.MainView = this.dgvCHITIETCAPTHUOC;
            this.dgvCHITIETCAPTHUOCMain.Name = "dgvCHITIETCAPTHUOCMain";
            this.dgvCHITIETCAPTHUOCMain.Size = new System.Drawing.Size(564, 501);
            this.dgvCHITIETCAPTHUOCMain.TabIndex = 4;
            this.dgvCHITIETCAPTHUOCMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCHITIETCAPTHUOC});
            // 
            // dgvCHITIETCAPTHUOC
            // 
            this.dgvCHITIETCAPTHUOC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCHITIETCAPTHUOC.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvCHITIETCAPTHUOC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvCHITIETCAPTHUOC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvCHITIETCAPTHUOC.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCHITIETCAPTHUOC.Appearance.Row.Options.UseFont = true;
            this.dgvCHITIETCAPTHUOC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvCHITIETCAPTHUOC.ColumnPanelRowHeight = 30;
            this.dgvCHITIETCAPTHUOC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STTChiTiet,
            this.Thuoc,
            this.SoLuong});
            this.dgvCHITIETCAPTHUOC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvCHITIETCAPTHUOC.GridControl = this.dgvCHITIETCAPTHUOCMain;
            this.dgvCHITIETCAPTHUOC.Name = "dgvCHITIETCAPTHUOC";
            this.dgvCHITIETCAPTHUOC.OptionsBehavior.Editable = false;
            this.dgvCHITIETCAPTHUOC.OptionsBehavior.ReadOnly = true;
            this.dgvCHITIETCAPTHUOC.OptionsCustomization.AllowColumnMoving = false;
            this.dgvCHITIETCAPTHUOC.OptionsCustomization.AllowColumnResizing = false;
            this.dgvCHITIETCAPTHUOC.OptionsCustomization.AllowFilter = false;
            this.dgvCHITIETCAPTHUOC.OptionsCustomization.AllowGroup = false;
            this.dgvCHITIETCAPTHUOC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvCHITIETCAPTHUOC.OptionsFind.AllowFindPanel = false;
            this.dgvCHITIETCAPTHUOC.OptionsView.ShowGroupPanel = false;
            this.dgvCHITIETCAPTHUOC.PaintStyleName = "UltraFlat";
            this.dgvCHITIETCAPTHUOC.RowHeight = 30;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCAPTHUOCMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách cấp thuốc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 1;
            // 
            // dgvCAPTHUOCMain
            // 
            this.dgvCAPTHUOCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCAPTHUOCMain.Location = new System.Drawing.Point(3, 20);
            this.dgvCAPTHUOCMain.MainView = this.dgvCAPTHUOC;
            this.dgvCAPTHUOCMain.Name = "dgvCAPTHUOCMain";
            this.dgvCAPTHUOCMain.Size = new System.Drawing.Size(688, 382);
            this.dgvCAPTHUOCMain.TabIndex = 5;
            this.dgvCAPTHUOCMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCAPTHUOC});
            // 
            // dgvCAPTHUOC
            // 
            this.dgvCAPTHUOC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCAPTHUOC.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvCAPTHUOC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvCAPTHUOC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvCAPTHUOC.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCAPTHUOC.Appearance.Row.Options.UseFont = true;
            this.dgvCAPTHUOC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvCAPTHUOC.ColumnPanelRowHeight = 30;
            this.dgvCAPTHUOC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ngay,
            this.BacSi,
            this.BenhNhan,
            this.Benh});
            this.dgvCAPTHUOC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvCAPTHUOC.GridControl = this.dgvCAPTHUOCMain;
            this.dgvCAPTHUOC.Name = "dgvCAPTHUOC";
            this.dgvCAPTHUOC.OptionsBehavior.Editable = false;
            this.dgvCAPTHUOC.OptionsBehavior.ReadOnly = true;
            this.dgvCAPTHUOC.OptionsCustomization.AllowColumnMoving = false;
            this.dgvCAPTHUOC.OptionsCustomization.AllowColumnResizing = false;
            this.dgvCAPTHUOC.OptionsCustomization.AllowFilter = false;
            this.dgvCAPTHUOC.OptionsCustomization.AllowGroup = false;
            this.dgvCAPTHUOC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvCAPTHUOC.OptionsFind.AllowFindPanel = false;
            this.dgvCAPTHUOC.OptionsView.ShowGroupPanel = false;
            this.dgvCAPTHUOC.PaintStyleName = "UltraFlat";
            this.dgvCAPTHUOC.RowHeight = 30;
            this.dgvCAPTHUOC.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvCAPTHUOCMain_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 37;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 107;
            // 
            // BacSi
            // 
            this.BacSi.Caption = "Bác sĩ";
            this.BacSi.FieldName = "BacSi";
            this.BacSi.Name = "BacSi";
            this.BacSi.Visible = true;
            this.BacSi.VisibleIndex = 2;
            this.BacSi.Width = 182;
            // 
            // BenhNhan
            // 
            this.BenhNhan.Caption = "Bệnh nhân";
            this.BenhNhan.FieldName = "BenhNhan";
            this.BenhNhan.Name = "BenhNhan";
            this.BenhNhan.Visible = true;
            this.BenhNhan.VisibleIndex = 3;
            this.BenhNhan.Width = 182;
            // 
            // Benh
            // 
            this.Benh.Caption = "Bệnh";
            this.Benh.FieldName = "Benh";
            this.Benh.Name = "Benh";
            this.Benh.Visible = true;
            this.Benh.VisibleIndex = 4;
            this.Benh.Width = 191;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(122, 74);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(498, 24);
            this.txtTimKiem.TabIndex = 21;
            // 
            // ucCapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucCapThuoc";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucCapThuoc_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETCAPTHUOCMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETCAPTHUOC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAPTHUOCMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAPTHUOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl dgvCHITIETCAPTHUOCMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCHITIETCAPTHUOC;
        private DevExpress.XtraGrid.Columns.GridColumn STTChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn Thuoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgvCAPTHUOCMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCAPTHUOC;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn BenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn Benh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}
