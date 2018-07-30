namespace QuanLyBenhXa.GUI.ThongKe
{
    partial class ucThongKeBenhLy
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
            this.chartBenh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvBENHMain = new DevExpress.XtraGrid.GridControl();
            this.dgvBENH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Benh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBenh)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBENHMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBENH)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartBenh);
            this.groupBox2.Location = new System.Drawing.Point(756, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 441);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ thị";
            // 
            // chartBenh
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBenh.ChartAreas.Add(chartArea1);
            this.chartBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBenh.Legends.Add(legend1);
            this.chartBenh.Location = new System.Drawing.Point(3, 20);
            this.chartBenh.Name = "chartBenh";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBenh.Series.Add(series1);
            this.chartBenh.Size = new System.Drawing.Size(524, 418);
            this.chartBenh.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateDenNgay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTuNgay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ lọc";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(308, 26);
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
            this.label6.Location = new System.Drawing.Point(237, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(86, 26);
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
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvBENHMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh";
            // 
            // DgvBENHMain
            // 
            this.DgvBENHMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBENHMain.Location = new System.Drawing.Point(3, 20);
            this.DgvBENHMain.MainView = this.dgvBENH;
            this.DgvBENHMain.Name = "DgvBENHMain";
            this.DgvBENHMain.Size = new System.Drawing.Size(732, 421);
            this.DgvBENHMain.TabIndex = 5;
            this.DgvBENHMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBENH});
            // 
            // dgvBENH
            // 
            this.dgvBENH.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvBENH.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvBENH.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvBENH.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvBENH.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvBENH.Appearance.Row.Options.UseFont = true;
            this.dgvBENH.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvBENH.ColumnPanelRowHeight = 30;
            this.dgvBENH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Benh,
            this.SoLuong});
            this.dgvBENH.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvBENH.GridControl = this.DgvBENHMain;
            this.dgvBENH.Name = "dgvBENH";
            this.dgvBENH.OptionsBehavior.Editable = false;
            this.dgvBENH.OptionsBehavior.ReadOnly = true;
            this.dgvBENH.OptionsCustomization.AllowColumnMoving = false;
            this.dgvBENH.OptionsCustomization.AllowColumnResizing = false;
            this.dgvBENH.OptionsCustomization.AllowFilter = false;
            this.dgvBENH.OptionsCustomization.AllowGroup = false;
            this.dgvBENH.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvBENH.OptionsFind.AllowFindPanel = false;
            this.dgvBENH.OptionsView.ShowGroupPanel = false;
            this.dgvBENH.PaintStyleName = "UltraFlat";
            this.dgvBENH.RowHeight = 30;
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
            // Benh
            // 
            this.Benh.Caption = "Bệnh";
            this.Benh.FieldName = "Benh";
            this.Benh.Name = "Benh";
            this.Benh.Visible = true;
            this.Benh.VisibleIndex = 1;
            this.Benh.Width = 141;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượt mắc";
            this.SoLuong.FieldName = "SoLuotMac";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            // 
            // ucThongKeBenhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKeBenhLy";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucThongKeBenhLy_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBenh)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBENHMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBENH)).EndInit();
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
        private DevExpress.XtraGrid.GridControl DgvBENHMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBENH;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Benh;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBenh;
    }
}
