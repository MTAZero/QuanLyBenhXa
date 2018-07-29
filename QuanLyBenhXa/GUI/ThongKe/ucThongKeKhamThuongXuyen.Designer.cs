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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKHAMDINHKIMain = new DevExpress.XtraGrid.GridControl();
            this.dgvKHAMDINHKI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Benh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CachGiaiQuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKIMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateEdit2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateEdit1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1057, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Enabled = false;
            this.dateEdit2.Location = new System.Drawing.Point(553, 26);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit2.Size = new System.Drawing.Size(185, 26);
            this.dateEdit2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Enabled = false;
            this.dateEdit1.Location = new System.Drawing.Point(253, 26);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Size = new System.Drawing.Size(185, 26);
            this.dateEdit1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKHAMDINHKIMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khám thường xuyên";
            // 
            // dgvKHAMDINHKIMain
            // 
            this.dgvKHAMDINHKIMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHAMDINHKIMain.Location = new System.Drawing.Point(3, 20);
            this.dgvKHAMDINHKIMain.MainView = this.dgvKHAMDINHKI;
            this.dgvKHAMDINHKIMain.Name = "dgvKHAMDINHKIMain";
            this.dgvKHAMDINHKIMain.Size = new System.Drawing.Size(1051, 421);
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
            this.Benh,
            this.CachGiaiQuyet});
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
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKIMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHAMDINHKI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvKHAMDINHKIMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKHAMDINHKI;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn BenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn Benh;
        private DevExpress.XtraGrid.Columns.GridColumn CachGiaiQuyet;
    }
}
