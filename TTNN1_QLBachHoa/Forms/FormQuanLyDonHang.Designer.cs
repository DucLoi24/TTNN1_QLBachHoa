namespace TTNN1_QLBachHoa.Forms
{
    partial class FormQuanLyDonHang
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
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.txtTimMaDH = new System.Windows.Forms.TextBox();
            this.txtTimTenKH = new System.Windows.Forms.TextBox();
            this.lblTimMaDH = new System.Windows.Forms.Label();
            this.lblTimTenKH = new System.Windows.Forms.Label();
            this.lblTimNgay = new System.Windows.Forms.Label();
            this.dtpTimNgay = new System.Windows.Forms.DateTimePicker();
            this.cbTimTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTimTrangThai = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupChiTiet = new System.Windows.Forms.GroupBox();
            this.lblMaDH = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.cbCapNhatTrangThai = new System.Windows.Forms.ComboBox();
            this.lblCapNhatTrangThai = new System.Windows.Forms.Label();
            this.btnLuuTrangThai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.groupChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(12, 50);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(866, 180);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // txtTimMaDH
            // 
            this.txtTimMaDH.Location = new System.Drawing.Point(65, 12);
            this.txtTimMaDH.Name = "txtTimMaDH";
            this.txtTimMaDH.Size = new System.Drawing.Size(80, 22);
            this.txtTimMaDH.TabIndex = 1;
            // 
            // txtTimTenKH
            // 
            this.txtTimTenKH.Location = new System.Drawing.Point(215, 12);
            this.txtTimTenKH.Name = "txtTimTenKH";
            this.txtTimTenKH.Size = new System.Drawing.Size(100, 22);
            this.txtTimTenKH.TabIndex = 2;
            // 
            // lblTimMaDH
            // 
            this.lblTimMaDH.Location = new System.Drawing.Point(12, 15);
            this.lblTimMaDH.Name = "lblTimMaDH";
            this.lblTimMaDH.Size = new System.Drawing.Size(60, 20);
            this.lblTimMaDH.TabIndex = 3;
            this.lblTimMaDH.Text = "Mã ĐH:";
            // 
            // lblTimTenKH
            // 
            this.lblTimTenKH.Location = new System.Drawing.Point(155, 15);
            this.lblTimTenKH.Name = "lblTimTenKH";
            this.lblTimTenKH.Size = new System.Drawing.Size(60, 20);
            this.lblTimTenKH.TabIndex = 4;
            this.lblTimTenKH.Text = "Tên KH:";
            // 
            // lblTimNgay
            // 
            this.lblTimNgay.Location = new System.Drawing.Point(325, 15);
            this.lblTimNgay.Name = "lblTimNgay";
            this.lblTimNgay.Size = new System.Drawing.Size(47, 20);
            this.lblTimNgay.TabIndex = 5;
            this.lblTimNgay.Text = "Ngày:";
            // 
            // dtpTimNgay
            // 
            this.dtpTimNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimNgay.Location = new System.Drawing.Point(378, 12);
            this.dtpTimNgay.Name = "dtpTimNgay";
            this.dtpTimNgay.ShowCheckBox = true;
            this.dtpTimNgay.Size = new System.Drawing.Size(120, 22);
            this.dtpTimNgay.TabIndex = 6;
            // 
            // cbTimTrangThai
            // 
            this.cbTimTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimTrangThai.Location = new System.Drawing.Point(602, 9);
            this.cbTimTrangThai.Name = "cbTimTrangThai";
            this.cbTimTrangThai.Size = new System.Drawing.Size(100, 24);
            this.cbTimTrangThai.TabIndex = 8;
            // 
            // lblTimTrangThai
            // 
            this.lblTimTrangThai.Location = new System.Drawing.Point(519, 12);
            this.lblTimTrangThai.Name = "lblTimTrangThai";
            this.lblTimTrangThai.Size = new System.Drawing.Size(77, 20);
            this.lblTimTrangThai.TabIndex = 7;
            this.lblTimTrangThai.Text = "Trạng thái:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(708, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 25);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm/Lọc";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupChiTiet
            // 
            this.groupChiTiet.Controls.Add(this.lblMaDH);
            this.groupChiTiet.Controls.Add(this.lblKH);
            this.groupChiTiet.Controls.Add(this.lblNV);
            this.groupChiTiet.Controls.Add(this.lblNgay);
            this.groupChiTiet.Controls.Add(this.lblTrangThai);
            this.groupChiTiet.Controls.Add(this.lblPTTT);
            this.groupChiTiet.Controls.Add(this.lblTongTien);
            this.groupChiTiet.Controls.Add(this.dgvChiTiet);
            this.groupChiTiet.Controls.Add(this.cbCapNhatTrangThai);
            this.groupChiTiet.Controls.Add(this.lblCapNhatTrangThai);
            this.groupChiTiet.Controls.Add(this.btnLuuTrangThai);
            this.groupChiTiet.Location = new System.Drawing.Point(12, 240);
            this.groupChiTiet.Name = "groupChiTiet";
            this.groupChiTiet.Size = new System.Drawing.Size(866, 200);
            this.groupChiTiet.TabIndex = 1;
            this.groupChiTiet.TabStop = false;
            this.groupChiTiet.Text = "Chi tiết đơn hàng";
            // 
            // lblMaDH
            // 
            this.lblMaDH.Location = new System.Drawing.Point(10, 20);
            this.lblMaDH.Name = "lblMaDH";
            this.lblMaDH.Size = new System.Drawing.Size(120, 20);
            this.lblMaDH.TabIndex = 0;
            this.lblMaDH.Text = "Mã ĐH:";
            // 
            // lblKH
            // 
            this.lblKH.Location = new System.Drawing.Point(150, 20);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(180, 20);
            this.lblKH.TabIndex = 1;
            this.lblKH.Text = "Khách hàng:";
            // 
            // lblNV
            // 
            this.lblNV.Location = new System.Drawing.Point(350, 20);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(180, 20);
            this.lblNV.TabIndex = 2;
            this.lblNV.Text = "Nhân viên:";
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(550, 20);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(120, 20);
            this.lblNgay.TabIndex = 3;
            this.lblNgay.Text = "Ngày:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(10, 45);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(120, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblPTTT
            // 
            this.lblPTTT.Location = new System.Drawing.Point(150, 45);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(180, 20);
            this.lblPTTT.TabIndex = 5;
            this.lblPTTT.Text = "Phương thức TT:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(350, 45);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(180, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 70);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(500, 120);
            this.dgvChiTiet.TabIndex = 2;
            // 
            // cbCapNhatTrangThai
            // 
            this.cbCapNhatTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapNhatTrangThai.Location = new System.Drawing.Point(530, 95);
            this.cbCapNhatTrangThai.Name = "cbCapNhatTrangThai";
            this.cbCapNhatTrangThai.Size = new System.Drawing.Size(218, 24);
            this.cbCapNhatTrangThai.TabIndex = 7;
            // 
            // lblCapNhatTrangThai
            // 
            this.lblCapNhatTrangThai.Location = new System.Drawing.Point(530, 70);
            this.lblCapNhatTrangThai.Name = "lblCapNhatTrangThai";
            this.lblCapNhatTrangThai.Size = new System.Drawing.Size(100, 20);
            this.lblCapNhatTrangThai.TabIndex = 8;
            this.lblCapNhatTrangThai.Text = "Cập nhật trạng thái:";
            // 
            // btnLuuTrangThai
            // 
            this.btnLuuTrangThai.Location = new System.Drawing.Point(530, 130);
            this.btnLuuTrangThai.Name = "btnLuuTrangThai";
            this.btnLuuTrangThai.Size = new System.Drawing.Size(218, 30);
            this.btnLuuTrangThai.TabIndex = 9;
            this.btnLuuTrangThai.Text = "Lưu trạng thái";
            this.btnLuuTrangThai.Click += new System.EventHandler(this.btnLuuTrangThai_Click);
            // 
            // FormQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.txtTimMaDH);
            this.Controls.Add(this.txtTimTenKH);
            this.Controls.Add(this.lblTimMaDH);
            this.Controls.Add(this.lblTimTenKH);
            this.Controls.Add(this.lblTimNgay);
            this.Controls.Add(this.dtpTimNgay);
            this.Controls.Add(this.lblTimTrangThai);
            this.Controls.Add(this.cbTimTrangThai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupChiTiet);
            this.Name = "FormQuanLyDonHang";
            this.Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.groupChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TextBox txtTimMaDH;
        private System.Windows.Forms.TextBox txtTimTenKH;
        private System.Windows.Forms.Label lblTimMaDH;
        private System.Windows.Forms.Label lblTimTenKH;
        private System.Windows.Forms.Label lblTimNgay;
        private System.Windows.Forms.DateTimePicker dtpTimNgay;
        private System.Windows.Forms.ComboBox cbTimTrangThai;
        private System.Windows.Forms.Label lblTimTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupChiTiet;
        private System.Windows.Forms.Label lblMaDH;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.ComboBox cbCapNhatTrangThai;
        private System.Windows.Forms.Label lblCapNhatTrangThai;
        private System.Windows.Forms.Button btnLuuTrangThai;
    }
}