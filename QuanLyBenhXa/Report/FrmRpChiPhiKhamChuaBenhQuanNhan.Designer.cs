namespace QuanLyBenhXa.Report
{
    partial class FrmRpChiPhiKhamChuaBenhQuanNhan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpDataSet = new QuanLyBenhXa.Report.rpDataSet();
            this.ChiPhiKhamBenhThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiPhiKhamBenhVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiPhiKhamBenhThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiPhiKhamBenhVatTuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 612);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtThuoc";
            reportDataSource1.Value = this.ChiPhiKhamBenhThuocBindingSource;
            reportDataSource2.Name = "dtVatTu";
            reportDataSource2.Value = this.ChiPhiKhamBenhVatTuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBenhXa.Report.rpChiPhiKhamChuaBenhQuanNhan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(669, 610);
            this.reportViewer1.TabIndex = 0;
            // 
            // rpDataSet
            // 
            this.rpDataSet.DataSetName = "rpDataSet";
            this.rpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiPhiKhamBenhThuocBindingSource
            // 
            this.ChiPhiKhamBenhThuocBindingSource.DataMember = "ChiPhiKhamBenhThuoc";
            this.ChiPhiKhamBenhThuocBindingSource.DataSource = this.rpDataSet;
            // 
            // ChiPhiKhamBenhVatTuBindingSource
            // 
            this.ChiPhiKhamBenhVatTuBindingSource.DataMember = "ChiPhiKhamBenhVatTu";
            this.ChiPhiKhamBenhVatTuBindingSource.DataSource = this.rpDataSet;
            // 
            // FrmRpChiPhiKhamChuaBenhQuanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 692);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRpChiPhiKhamChuaBenhQuanNhan";
            this.Resizable = false;
            this.Text = "THÔNG KÊ CHI PHÍ KHÁM CHỮA BỆNH";
            this.Load += new System.EventHandler(this.FrmRpChiPhiKhamChuaBenhQuanNhan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiPhiKhamBenhThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiPhiKhamBenhVatTuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiPhiKhamBenhThuocBindingSource;
        private rpDataSet rpDataSet;
        private System.Windows.Forms.BindingSource ChiPhiKhamBenhVatTuBindingSource;
    }
}