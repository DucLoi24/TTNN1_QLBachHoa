namespace TTNN1_QLBachHoa.Forms
{
    partial class FormQuanLyPhieuNhapKho
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
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.txtTimMaPN = new System.Windows.Forms.TextBox();
            this.txtTimTenNCC = new System.Windows.Forms.TextBox();
            this.lblTimMaPN = new System.Windows.Forms.Label();
            this.lblTimTenNCC = new System.Windows.Forms.Label();
            this.lblTimNgay = new System.Windows.Forms.Label();
            this.dtpTimNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupChiTiet = new System.Windows.Forms.GroupBox();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(12, 50);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(916, 180);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // txtTimMaPN
            // 
            this.txtTimMaPN.Location = new System.Drawing.Point(65, 12);
            this.txtTimMaPN.Name = "txtTimMaPN";
            this.txtTimMaPN.Size = new System.Drawing.Size(80, 22);
            this.txtTimMaPN.TabIndex = 1;
            // 
            // txtTimTenNCC
            // 
            this.txtTimTenNCC.Location = new System.Drawing.Point(225, 12);
            this.txtTimTenNCC.Name = "txtTimTenNCC";
            this.txtTimTenNCC.Size = new System.Drawing.Size(100, 22);
            this.txtTimTenNCC.TabIndex = 2;
            // 
            // lblTimMaPN
            // 
            this.lblTimMaPN.Location = new System.Drawing.Point(12, 15);
            this.lblTimMaPN.Name = "lblTimMaPN";
            this.lblTimMaPN.Size = new System.Drawing.Size(60, 20);
            this.lblTimMaPN.TabIndex = 3;
            this.lblTimMaPN.Text = "Mã PN:";
            // 
            // lblTimTenNCC
            // 
            this.lblTimTenNCC.Location = new System.Drawing.Point(155, 15);
            this.lblTimTenNCC.Name = "lblTimTenNCC";
            this.lblTimTenNCC.Size = new System.Drawing.Size(70, 20);
            this.lblTimTenNCC.TabIndex = 4;
            this.lblTimTenNCC.Text = "Tên NCC:";
            // 
            // lblTimNgay
            // 
            this.lblTimNgay.Location = new System.Drawing.Point(348, 15);
            this.lblTimNgay.Name = "lblTimNgay";
            this.lblTimNgay.Size = new System.Drawing.Size(53, 20);
            this.lblTimNgay.TabIndex = 5;
            this.lblTimNgay.Text = "Ngày:";
            // 
            // dtpTimNgay
            // 
            this.dtpTimNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimNgay.Location = new System.Drawing.Point(397, 12);
            this.dtpTimNgay.Name = "dtpTimNgay";
            this.dtpTimNgay.ShowCheckBox = true;
            this.dtpTimNgay.Size = new System.Drawing.Size(157, 22);
            this.dtpTimNgay.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(595, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 26);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm/Lọc";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupChiTiet
            // 
            this.groupChiTiet.Controls.Add(this.lblMaPN);
            this.groupChiTiet.Controls.Add(this.lblNCC);
            this.groupChiTiet.Controls.Add(this.lblNV);
            this.groupChiTiet.Controls.Add(this.lblNgay);
            this.groupChiTiet.Controls.Add(this.lblTongTien);
            this.groupChiTiet.Controls.Add(this.lblGhiChu);
            this.groupChiTiet.Controls.Add(this.dgvChiTiet);
            this.groupChiTiet.Location = new System.Drawing.Point(12, 240);
            this.groupChiTiet.Name = "groupChiTiet";
            this.groupChiTiet.Size = new System.Drawing.Size(916, 200);
            this.groupChiTiet.TabIndex = 1;
            this.groupChiTiet.TabStop = false;
            this.groupChiTiet.Text = "Chi tiết phiếu nhập";
            // 
            // lblMaPN
            // 
            this.lblMaPN.Location = new System.Drawing.Point(10, 20);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(194, 20);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã PN:";
            // 
            // lblNCC
            // 
            this.lblNCC.Location = new System.Drawing.Point(210, 20);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(311, 20);
            this.lblNCC.TabIndex = 1;
            this.lblNCC.Text = "Nhà cung cấp:";
            // 
            // lblNV
            // 
            this.lblNV.Location = new System.Drawing.Point(580, 70);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(272, 20);
            this.lblNV.TabIndex = 2;
            this.lblNV.Text = "Nhân viên:";
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(580, 20);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(214, 20);
            this.lblNgay.TabIndex = 3;
            this.lblNgay.Text = "Ngày:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(10, 47);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(194, 20);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(210, 47);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(277, 20);
            this.lblGhiChu.TabIndex = 5;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 70);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(564, 120);
            this.dgvChiTiet.TabIndex = 2;
            // 
            // FormQuanLyPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.txtTimMaPN);
            this.Controls.Add(this.txtTimTenNCC);
            this.Controls.Add(this.lblTimMaPN);
            this.Controls.Add(this.lblTimTenNCC);
            this.Controls.Add(this.lblTimNgay);
            this.Controls.Add(this.dtpTimNgay);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupChiTiet);
            this.Name = "FormQuanLyPhieuNhapKho";
            this.Text = "Quản lý phiếu nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.TextBox txtTimMaPN;
        private System.Windows.Forms.TextBox txtTimTenNCC;
        private System.Windows.Forms.Label lblTimMaPN;
        private System.Windows.Forms.Label lblTimTenNCC;
        private System.Windows.Forms.Label lblTimNgay;
        private System.Windows.Forms.DateTimePicker dtpTimNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupChiTiet;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DataGridView dgvChiTiet;
    }
}