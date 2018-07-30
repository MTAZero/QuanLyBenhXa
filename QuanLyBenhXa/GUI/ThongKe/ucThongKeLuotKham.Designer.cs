namespace QuanLyBenhXa.GUI.ThongKe
{
    partial class ucThongKeLuotKham
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxLoaiThongKe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTHOIGIANMain = new DevExpress.XtraGrid.GridControl();
            this.dgvTHOIGIAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiThongKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHOIGIANMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHOIGIAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartThongKe);
            this.groupBox2.Location = new System.Drawing.Point(701, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 441);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ thị";
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(3, 20);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(575, 418);
            this.chartThongKe.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxLoaiThongKe);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dateDenNgay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTuNgay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(870, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // cbxLoaiThongKe
            // 
            this.cbxLoaiThongKe.Location = new System.Drawing.Point(622, 28);
            this.cbxLoaiThongKe.Name = "cbxLoaiThongKe";
            this.cbxLoaiThongKe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxLoaiThongKe.Properties.Appearance.Options.UseFont = true;
            this.cbxLoaiThongKe.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxLoaiThongKe.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxLoaiThongKe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxLoaiThongKe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLoaiThongKe.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxLoaiThongKe.Properties.Items.AddRange(new object[] {
            "Tuần",
            "Tháng",
            "Năm"});
            this.cbxLoaiThongKe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLoaiThongKe.Size = new System.Drawing.Size(219, 26);
            this.cbxLoaiThongKe.TabIndex = 21;
            this.cbxLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiThongKe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Loại thống kê";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(347, 28);
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
            this.dateDenNgay.Size = new System.Drawing.Size(139, 26);
            this.dateDenNgay.TabIndex = 19;
            this.dateDenNgay.DateTimeChanged += new System.EventHandler(this.dateDenNgay_DateTimeChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(99, 28);
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
            this.dateTuNgay.Size = new System.Drawing.Size(131, 26);
            this.dateTuNgay.TabIndex = 17;
            this.dateTuNgay.DateTimeChanged += new System.EventHandler(this.dateDenNgay_DateTimeChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTHOIGIANMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thời gian";
            // 
            // dgvTHOIGIANMain
            // 
            this.dgvTHOIGIANMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTHOIGIANMain.Location = new System.Drawing.Point(3, 20);
            this.dgvTHOIGIANMain.MainView = this.dgvTHOIGIAN;
            this.dgvTHOIGIANMain.Name = "dgvTHOIGIANMain";
            this.dgvTHOIGIANMain.Size = new System.Drawing.Size(677, 421);
            this.dgvTHOIGIANMain.TabIndex = 5;
            this.dgvTHOIGIANMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvTHOIGIAN});
            // 
            // dgvTHOIGIAN
            // 
            this.dgvTHOIGIAN.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvTHOIGIAN.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvTHOIGIAN.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvTHOIGIAN.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvTHOIGIAN.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvTHOIGIAN.Appearance.Row.Options.UseFont = true;
            this.dgvTHOIGIAN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvTHOIGIAN.ColumnPanelRowHeight = 30;
            this.dgvTHOIGIAN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.ThoiGian,
            this.SoLuongKham});
            this.dgvTHOIGIAN.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvTHOIGIAN.GridControl = this.dgvTHOIGIANMain;
            this.dgvTHOIGIAN.Name = "dgvTHOIGIAN";
            this.dgvTHOIGIAN.OptionsBehavior.Editable = false;
            this.dgvTHOIGIAN.OptionsBehavior.ReadOnly = true;
            this.dgvTHOIGIAN.OptionsCustomization.AllowColumnMoving = false;
            this.dgvTHOIGIAN.OptionsCustomization.AllowColumnResizing = false;
            this.dgvTHOIGIAN.OptionsCustomization.AllowFilter = false;
            this.dgvTHOIGIAN.OptionsCustomization.AllowGroup = false;
            this.dgvTHOIGIAN.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvTHOIGIAN.OptionsFind.AllowFindPanel = false;
            this.dgvTHOIGIAN.OptionsView.ShowGroupPanel = false;
            this.dgvTHOIGIAN.PaintStyleName = "UltraFlat";
            this.dgvTHOIGIAN.RowHeight = 30;
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
            // ThoiGian
            // 
            this.ThoiGian.Caption = "Thời gian";
            this.ThoiGian.FieldName = "ThoiGian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Visible = true;
            this.ThoiGian.VisibleIndex = 1;
            this.ThoiGian.Width = 141;
            // 
            // SoLuongKham
            // 
            this.SoLuongKham.Caption = "Số lượt khám";
            this.SoLuongKham.FieldName = "SoLuongKham";
            this.SoLuongKham.Name = "SoLuongKham";
            this.SoLuongKham.Visible = true;
            this.SoLuongKham.VisibleIndex = 2;
            // 
            // ucThongKeLuotKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKeLuotKham";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucThongKeLuotKham_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiThongKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHOIGIANMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHOIGIAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvTHOIGIANMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongKham;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLoaiThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}
