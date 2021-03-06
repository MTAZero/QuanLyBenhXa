﻿namespace QuanLyBenhXa.GUI.HoatDongChinh
{
    partial class ucKhoThuoc
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTHUOCMain = new DevExpress.XtraGrid.GridControl();
            this.dgvTHUOC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdSapXepTheoTen = new System.Windows.Forms.RadioButton();
            this.rdSapXepTheoSoLuong = new System.Windows.Forms.RadioButton();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHUOCMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHUOC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 558);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(84, 40);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(309, 24);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvTHUOCMain);
            this.groupBox1.Location = new System.Drawing.Point(409, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 512);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc";
            // 
            // dgvTHUOCMain
            // 
            this.dgvTHUOCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTHUOCMain.Location = new System.Drawing.Point(3, 20);
            this.dgvTHUOCMain.MainView = this.dgvTHUOC;
            this.dgvTHUOCMain.Name = "dgvTHUOCMain";
            this.dgvTHUOCMain.Size = new System.Drawing.Size(860, 489);
            this.dgvTHUOCMain.TabIndex = 2;
            this.dgvTHUOCMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvTHUOC});
            // 
            // dgvTHUOC
            // 
            this.dgvTHUOC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvTHUOC.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvTHUOC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvTHUOC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvTHUOC.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvTHUOC.Appearance.Row.Options.UseFont = true;
            this.dgvTHUOC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvTHUOC.ColumnPanelRowHeight = 30;
            this.dgvTHUOC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.SoLuong});
            this.dgvTHUOC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvTHUOC.GridControl = this.dgvTHUOCMain;
            this.dgvTHUOC.Name = "dgvTHUOC";
            this.dgvTHUOC.OptionsBehavior.Editable = false;
            this.dgvTHUOC.OptionsBehavior.ReadOnly = true;
            this.dgvTHUOC.OptionsCustomization.AllowColumnMoving = false;
            this.dgvTHUOC.OptionsCustomization.AllowColumnResizing = false;
            this.dgvTHUOC.OptionsCustomization.AllowFilter = false;
            this.dgvTHUOC.OptionsCustomization.AllowGroup = false;
            this.dgvTHUOC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvTHUOC.OptionsFind.AllowFindPanel = false;
            this.dgvTHUOC.OptionsView.ShowGroupPanel = false;
            this.dgvTHUOC.PaintStyleName = "UltraFlat";
            this.dgvTHUOC.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 84;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên thuốc";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 360;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdSapXepTheoSoLuong);
            this.groupBox2.Controls.Add(this.rdSapXepTheoTen);
            this.groupBox2.Location = new System.Drawing.Point(18, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 82);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc";
            // 
            // rdSapXepTheoTen
            // 
            this.rdSapXepTheoTen.AutoSize = true;
            this.rdSapXepTheoTen.Checked = true;
            this.rdSapXepTheoTen.Location = new System.Drawing.Point(30, 34);
            this.rdSapXepTheoTen.Name = "rdSapXepTheoTen";
            this.rdSapXepTheoTen.Size = new System.Drawing.Size(124, 21);
            this.rdSapXepTheoTen.TabIndex = 0;
            this.rdSapXepTheoTen.TabStop = true;
            this.rdSapXepTheoTen.Text = "Sắp xếp theo tên";
            this.rdSapXepTheoTen.UseVisualStyleBackColor = true;
            this.rdSapXepTheoTen.CheckedChanged += new System.EventHandler(this.rdSapXepTheoTen_CheckedChanged);
            // 
            // rdSapXepTheoSoLuong
            // 
            this.rdSapXepTheoSoLuong.AutoSize = true;
            this.rdSapXepTheoSoLuong.Location = new System.Drawing.Point(194, 34);
            this.rdSapXepTheoSoLuong.Name = "rdSapXepTheoSoLuong";
            this.rdSapXepTheoSoLuong.Size = new System.Drawing.Size(156, 21);
            this.rdSapXepTheoSoLuong.TabIndex = 1;
            this.rdSapXepTheoSoLuong.Text = "Sắp xếp theo số lượng";
            this.rdSapXepTheoSoLuong.UseVisualStyleBackColor = true;
            this.rdSapXepTheoSoLuong.CheckedChanged += new System.EventHandler(this.rdSapXepTheoTen_CheckedChanged);
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 255;
            // 
            // ucKhoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucKhoThuoc";
            this.Size = new System.Drawing.Size(1298, 558);
            this.Load += new System.EventHandler(this.ucKhoThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHUOCMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHUOC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvTHUOCMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvTHUOC;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private System.Windows.Forms.RadioButton rdSapXepTheoSoLuong;
        private System.Windows.Forms.RadioButton rdSapXepTheoTen;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
    }
}
