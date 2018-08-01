namespace QuanLyBenhXa.GUI.KhamBenh
{
    partial class FrmInGiayGioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInGiayGioiThieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.txtYKienDeNghi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtCanBenh = new System.Windows.Forms.TextBox();
            this.txtSoSucKhoe = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSoSucKhoe);
            this.panel1.Controls.Add(this.txtCanBenh);
            this.panel1.Controls.Add(this.txtDonVi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXuatBaoCao);
            this.panel1.Controls.Add(this.txtYKienDeNghi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 321);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(376, 271);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 34);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnXuatBaoCao.Appearance.Options.UseFont = true;
            this.btnXuatBaoCao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuatBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatBaoCao.Image")));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(251, 271);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(119, 34);
            this.btnXuatBaoCao.TabIndex = 5;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // txtYKienDeNghi
            // 
            this.txtYKienDeNghi.Location = new System.Drawing.Point(126, 191);
            this.txtYKienDeNghi.Multiline = true;
            this.txtYKienDeNghi.Name = "txtYKienDeNghi";
            this.txtYKienDeNghi.Size = new System.Drawing.Size(369, 65);
            this.txtYKienDeNghi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ý kiến đề nghị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Căn bệnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sổ sức khỏe";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(126, 15);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(369, 24);
            this.txtDonVi.TabIndex = 1;
            // 
            // txtCanBenh
            // 
            this.txtCanBenh.Location = new System.Drawing.Point(126, 73);
            this.txtCanBenh.Name = "txtCanBenh";
            this.txtCanBenh.Size = new System.Drawing.Size(369, 24);
            this.txtCanBenh.TabIndex = 2;
            // 
            // txtSoSucKhoe
            // 
            this.txtSoSucKhoe.Location = new System.Drawing.Point(126, 131);
            this.txtSoSucKhoe.Name = "txtSoSucKhoe";
            this.txtSoSucKhoe.Size = new System.Drawing.Size(178, 24);
            this.txtSoSucKhoe.TabIndex = 3;
            // 
            // FrmInGiayGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 401);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInGiayGioiThieu";
            this.Resizable = false;
            this.Text = "IN GIẤY GIỚI THIỆU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtYKienDeNghi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXuatBaoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoSucKhoe;
        private System.Windows.Forms.TextBox txtCanBenh;
        private System.Windows.Forms.TextBox txtDonVi;
    }
}