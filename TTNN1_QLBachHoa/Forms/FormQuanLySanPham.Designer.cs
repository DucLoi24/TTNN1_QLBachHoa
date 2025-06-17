namespace TTNN1_QLBachHoa.Forms
{
    partial class FormQuanLySanPham
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cbLocLoaiSP = new System.Windows.Forms.ComboBox();
            this.cbLocNCC = new System.Windows.Forms.ComboBox();
            this.lblLocLoaiSP = new System.Windows.Forms.Label();
            this.lblLocNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 50);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(400, 380);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(520, 60);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(200, 22);
            this.txtMaSP.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(520, 100);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 22);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(520, 140);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(200, 22);
            this.txtGiaBan.TabIndex = 12;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(520, 180);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(200, 22);
            this.txtGiaNhap.TabIndex = 14;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(520, 220);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuongTon.TabIndex = 16;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(520, 260);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(200, 22);
            this.txtDonViTinh.TabIndex = 18;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.Location = new System.Drawing.Point(520, 300);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(200, 24);
            this.cbLoaiSP.TabIndex = 20;
            // 
            // cbNCC
            // 
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.Location = new System.Drawing.Point(520, 340);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(200, 24);
            this.cbNCC.TabIndex = 22;
            // 
            // lblMaSP
            // 
            this.lblMaSP.Location = new System.Drawing.Point(430, 60);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(80, 20);
            this.lblMaSP.TabIndex = 7;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(430, 100);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(80, 20);
            this.lblTenSP.TabIndex = 9;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Location = new System.Drawing.Point(430, 140);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(80, 20);
            this.lblGiaBan.TabIndex = 11;
            this.lblGiaBan.Text = "Giá Bán:";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.Location = new System.Drawing.Point(430, 180);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(80, 20);
            this.lblGiaNhap.TabIndex = 13;
            this.lblGiaNhap.Text = "Giá Nhập:";
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.Location = new System.Drawing.Point(430, 220);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(80, 20);
            this.lblSoLuongTon.TabIndex = 15;
            this.lblSoLuongTon.Text = "SL Tồn:";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.Location = new System.Drawing.Point(430, 260);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(80, 20);
            this.lblDonViTinh.TabIndex = 17;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.Location = new System.Drawing.Point(430, 300);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(80, 20);
            this.lblLoaiSP.TabIndex = 19;
            this.lblLoaiSP.Text = "Loại SP:";
            // 
            // lblNCC
            // 
            this.lblNCC.Location = new System.Drawing.Point(430, 340);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(80, 20);
            this.lblNCC.TabIndex = 21;
            this.lblNCC.Text = "Nhà CC:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(430, 380);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(70, 40);
            this.btnThemMoi.TabIndex = 23;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(510, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 40);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(590, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 40);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(670, 380);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(70, 40);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(75, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(230, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Location = new System.Drawing.Point(12, 15);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(60, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // cbLocLoaiSP
            // 
            this.cbLocLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocLoaiSP.Location = new System.Drawing.Point(370, 12);
            this.cbLocLoaiSP.Name = "cbLocLoaiSP";
            this.cbLocLoaiSP.Size = new System.Drawing.Size(100, 24);
            this.cbLocLoaiSP.TabIndex = 4;
            this.cbLocLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLocLoaiSP_SelectedIndexChanged);
            // 
            // cbLocNCC
            // 
            this.cbLocNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocNCC.Location = new System.Drawing.Point(540, 12);
            this.cbLocNCC.Name = "cbLocNCC";
            this.cbLocNCC.Size = new System.Drawing.Size(100, 24);
            this.cbLocNCC.TabIndex = 6;
            this.cbLocNCC.SelectedIndexChanged += new System.EventHandler(this.cbLocNCC_SelectedIndexChanged);
            // 
            // lblLocLoaiSP
            // 
            this.lblLocLoaiSP.Location = new System.Drawing.Point(310, 15);
            this.lblLocLoaiSP.Name = "lblLocLoaiSP";
            this.lblLocLoaiSP.Size = new System.Drawing.Size(60, 20);
            this.lblLocLoaiSP.TabIndex = 3;
            this.lblLocLoaiSP.Text = "Loại SP:";
            // 
            // lblLocNCC
            // 
            this.lblLocNCC.Location = new System.Drawing.Point(480, 15);
            this.lblLocNCC.Name = "lblLocNCC";
            this.lblLocNCC.Size = new System.Drawing.Size(60, 20);
            this.lblLocNCC.TabIndex = 5;
            this.lblLocNCC.Text = "Nhà CC:";
            // 
            // FormQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblLocLoaiSP);
            this.Controls.Add(this.cbLocLoaiSP);
            this.Controls.Add(this.lblLocNCC);
            this.Controls.Add(this.cbLocNCC);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.lblSoLuongTon);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Name = "FormQuanLySanPham";
            this.Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.ComboBox cbLocLoaiSP;
        private System.Windows.Forms.ComboBox cbLocNCC;
        private System.Windows.Forms.Label lblLocLoaiSP;
        private System.Windows.Forms.Label lblLocNCC;
    }
}