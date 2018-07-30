namespace QuanLyBenhXa.GUI.ThongKe
{
    partial class ucThongKeKhamThuongXuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThongKeKhamThuongXuyen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKHAMTHUONGXUYENMain = new DevExpress.XtraGrid.GridControl();
            this.dgvKHAMTHUONGXUYEN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Benh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CachGiaiQuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMTHUONGXUYENMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMTHUONGXUYEN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 2;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Appearance.Options.UseFont = true;
            this.btnChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.Location = new System.Drawing.Point(1184, 61);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 30);
            this.btnChiTiet.TabIndex = 24;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateDenNgay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTuNgay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(641, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(413, 30);
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
            this.label6.Location = new System.Drawing.Point(342, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(113, 30);
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
            this.label5.Location = new System.Drawing.Point(50, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKHAMTHUONGXUYENMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khám thường xuyên";
            // 
            // dgvKHAMTHUONGXUYENMain
            // 
            this.dgvKHAMTHUONGXUYENMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHAMTHUONGXUYENMain.Location = new System.Drawing.Point(3, 20);
            this.dgvKHAMTHUONGXUYENMain.MainView = this.dgvKHAMTHUONGXUYEN;
            this.dgvKHAMTHUONGXUYENMain.Name = "dgvKHAMTHUONGXUYENMain";
            this.dgvKHAMTHUONGXUYENMain.Size = new System.Drawing.Size(1262, 421);
            this.dgvKHAMTHUONGXUYENMain.TabIndex = 5;
            this.dgvKHAMTHUONGXUYENMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKHAMTHUONGXUYEN});
            // 
            // dgvKHAMTHUONGXUYEN
            // 
            this.dgvKHAMTHUONGXUYEN.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvKHAMTHUONGXUYEN.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvKHAMTHUONGXUYEN.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvKHAMTHUONGXUYEN.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvKHAMTHUONGXUYEN.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvKHAMTHUONGXUYEN.Appearance.Row.Options.UseFont = true;
            this.dgvKHAMTHUONGXUYEN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvKHAMTHUONGXUYEN.ColumnPanelRowHeight = 30;
            this.dgvKHAMTHUONGXUYEN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ngay,
            this.BacSi,
            this.BenhNhan,
            this.Benh,
            this.CachGiaiQuyet});
            this.dgvKHAMTHUONGXUYEN.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvKHAMTHUONGXUYEN.GridControl = this.dgvKHAMTHUONGXUYENMain;
            this.dgvKHAMTHUONGXUYEN.Name = "dgvKHAMTHUONGXUYEN";
            this.dgvKHAMTHUONGXUYEN.OptionsBehavior.Editable = false;
            this.dgvKHAMTHUONGXUYEN.OptionsBehavior.ReadOnly = true;
            this.dgvKHAMTHUONGXUYEN.OptionsCustomization.AllowColumnMoving = false;
            this.dgvKHAMTHUONGXUYEN.OptionsCustomization.AllowColumnResizing = false;
            this.dgvKHAMTHUONGXUYEN.OptionsCustomization.AllowFilter = false;
            this.dgvKHAMTHUONGXUYEN.OptionsCustomization.AllowGroup = false;
            this.dgvKHAMTHUONGXUYEN.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvKHAMTHUONGXUYEN.OptionsFind.AllowFindPanel = false;
            this.dgvKHAMTHUONGXUYEN.OptionsView.ShowGroupPanel = false;
            this.dgvKHAMTHUONGXUYEN.PaintStyleName = "UltraFlat";
            this.dgvKHAMTHUONGXUYEN.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 82;
            // 
            // BacSi
            // 
            this.BacSi.Caption = "Bác sĩ khám";
            this.BacSi.FieldName = "BacSi";
            this.BacSi.Name = "BacSi";
            this.BacSi.Visible = true;
            this.BacSi.VisibleIndex = 2;
            this.BacSi.Width = 143;
            // 
            // BenhNhan
            // 
            this.BenhNhan.Caption = "Bệnh nhân";
            this.BenhNhan.FieldName = "BenhNhan";
            this.BenhNhan.Name = "BenhNhan";
            this.BenhNhan.Visible = true;
            this.BenhNhan.VisibleIndex = 3;
            this.BenhNhan.Width = 164;
            // 
            // Benh
            // 
            this.Benh.Caption = "Bệnh";
            this.Benh.FieldName = "Benh";
            this.Benh.Name = "Benh";
            this.Benh.Visible = true;
            this.Benh.VisibleIndex = 4;
            this.Benh.Width = 141;
            // 
            // CachGiaiQuyet
            // 
            this.CachGiaiQuyet.Caption = "Cách giải quyết";
            this.CachGiaiQuyet.FieldName = "CachGiaiQuyet";
            this.CachGiaiQuyet.Name = "CachGiaiQuyet";
            this.CachGiaiQuyet.Visible = true;
            this.CachGiaiQuyet.VisibleIndex = 5;
            this.CachGiaiQuyet.Width = 131;
            // 
            // ucThongKeKhamThuongXuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKeKhamThuongXuyen";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucThongKeKhamThuongXuyen_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMTHUONGXUYENMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMTHUONGXUYEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvKHAMTHUONGXUYENMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKHAMTHUONGXUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn BenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn Benh;
        private DevExpress.XtraGrid.Columns.GridColumn CachGiaiQuyet;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
    }
}
