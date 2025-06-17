namespace TTNN1_QLBachHoa.Forms
{
    partial class FormTaoDonHang
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
            this.groupSanPham = new System.Windows.Forms.GroupBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.cbPTTT = new System.Windows.Forms.ComboBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSanPham
            // 
            this.groupSanPham.Controls.Add(this.cbMaSP);
            this.groupSanPham.Controls.Add(this.lblTenSP);
            this.groupSanPham.Controls.Add(this.lblDonGia);
            this.groupSanPham.Controls.Add(this.txtSoLuong);
            this.groupSanPham.Controls.Add(this.lblSoLuong);
            this.groupSanPham.Controls.Add(this.btnThemSP);
            this.groupSanPham.Location = new System.Drawing.Point(12, 12);
            this.groupSanPham.Name = "groupSanPham";
            this.groupSanPham.Size = new System.Drawing.Size(416, 130);
            this.groupSanPham.TabIndex = 0;
            this.groupSanPham.TabStop = false;
            this.groupSanPham.Text = "Chọn sản phẩm";
            // 
            // cbMaSP
            // 
            this.cbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSP.Location = new System.Drawing.Point(15, 25);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(120, 24);
            this.cbMaSP.TabIndex = 0;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(150, 25);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(247, 24);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(15, 60);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(120, 24);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(226, 60);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(110, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(150, 60);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(70, 24);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(226, 94);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(115, 30);
            this.btnThemSP.TabIndex = 5;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(12, 150);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(600, 200);
            this.dgvGioHang.TabIndex = 1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(12, 360);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(200, 24);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền: 0";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(300, 360);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(80, 22);
            this.txtGiamGia.TabIndex = 6;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.Location = new System.Drawing.Point(230, 360);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(60, 24);
            this.lblGiamGia.TabIndex = 5;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Location = new System.Drawing.Point(400, 360);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(80, 24);
            this.lblKhachHang.TabIndex = 7;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.Location = new System.Drawing.Point(490, 360);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(120, 24);
            this.cbKhachHang.TabIndex = 8;
            // 
            // lblPTTT
            // 
            this.lblPTTT.Location = new System.Drawing.Point(12, 400);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(120, 24);
            this.lblPTTT.TabIndex = 9;
            this.lblPTTT.Text = "Phương thức TT:";
            // 
            // cbPTTT
            // 
            this.cbPTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTTT.Location = new System.Drawing.Point(130, 400);
            this.cbPTTT.Name = "cbPTTT";
            this.cbPTTT.Size = new System.Drawing.Size(120, 24);
            this.cbPTTT.TabIndex = 10;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(620, 400);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(120, 35);
            this.btnHoanTat.TabIndex = 11;
            this.btnHoanTat.Text = "Hoàn tất đơn hàng";
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(620, 150);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(120, 30);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa khỏi giỏ";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(620, 190);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 30);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormTaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupSanPham);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.lblPTTT);
            this.Controls.Add(this.cbPTTT);
            this.Controls.Add(this.btnHoanTat);
            this.Name = "FormTaoDonHang";
            this.Text = "Tạo đơn hàng";
            this.groupSanPham.ResumeLayout(false);
            this.groupSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSanPham;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.ComboBox cbPTTT;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLamMoi;
    }
}