namespace QuanLyBenhXa.Report
{
    partial class FrmRpTongHopPhanLoaiSucKhoe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpDataSet = new QuanLyBenhXa.Report.rpDataSet();
            this.TongHopPhanLoaiSucKhoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongHopPhanLoaiSucKhoeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 486);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rpPhanLoaiSuckhoe";
            reportDataSource1.Value = this.TongHopPhanLoaiSucKhoeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBenhXa.Report.rpTongHopPhanLoaiSucKhoe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(629, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // rpDataSet
            // 
            this.rpDataSet.DataSetName = "rpDataSet";
            this.rpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TongHopPhanLoaiSucKhoeBindingSource
            // 
            this.TongHopPhanLoaiSucKhoeBindingSource.DataMember = "TongHopPhanLoaiSucKhoe";
            this.TongHopPhanLoaiSucKhoeBindingSource.DataSource = this.rpDataSet;
            // 
            // FrmRpTongHopPhanLoaiSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 566);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRpTongHopPhanLoaiSucKhoe";
            this.Resizable = false;
            this.Text = "TỔNG HỢP PHÂN LOẠI SỨC KHỎE ĐỊNH KÌ";
            this.Load += new System.EventHandler(this.FrmRpTongHopPhanLoaiSucKhoe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongHopPhanLoaiSucKhoeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TongHopPhanLoaiSucKhoeBindingSource;
        private rpDataSet rpDataSet;
    }
}