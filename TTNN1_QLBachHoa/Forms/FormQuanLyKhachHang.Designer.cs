namespace TTNN1_QLBachHoa.Forms
{
    partial class FormQuanLyKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiemTichLuy = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnLichSu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 50);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(400, 350);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Location = new System.Drawing.Point(12, 15);
            this.lblTimKiem.Size = new System.Drawing.Size(60, 20);
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(75, 12);
            this.txtTimKiem.Size = new System.Drawing.Size(200, 22);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(285, 10);
            this.btnTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.Location = new System.Drawing.Point(430, 50);
            this.lblMaKH.Size = new System.Drawing.Size(80, 20);
            this.lblMaKH.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(520, 50);
            this.txtMaKH.Size = new System.Drawing.Size(200, 22);
            this.txtMaKH.ReadOnly = true;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Location = new System.Drawing.Point(430, 90);
            this.lblTenKH.Size = new System.Drawing.Size(80, 20);
            this.lblTenKH.Text = "Tên KH:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(520, 90);
            this.txtTenKH.Size = new System.Drawing.Size(200, 22);
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(430, 130);
            this.lblSDT.Size = new System.Drawing.Size(80, 20);
            this.lblSDT.Text = "SĐT:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(520, 130);
            this.txtSDT.Size = new System.Drawing.Size(200, 22);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(430, 170);
            this.lblDiaChi.Size = new System.Drawing.Size(80, 20);
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(520, 170);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(430, 210);
            this.lblEmail.Size = new System.Drawing.Size(80, 20);
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(520, 210);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            // 
            // lblDiemTichLuy
            // 
            this.lblDiemTichLuy.Location = new System.Drawing.Point(430, 250);
            this.lblDiemTichLuy.Size = new System.Drawing.Size(90, 20);
            this.lblDiemTichLuy.Text = "Điểm tích lũy:";
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Location = new System.Drawing.Point(520, 250);
            this.txtDiemTichLuy.Size = new System.Drawing.Size(200, 22);
            this.txtDiemTichLuy.ReadOnly = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(430, 300);
            this.btnThemMoi.Size = new System.Drawing.Size(90, 40);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(540, 300);
            this.btnLuu.Size = new System.Drawing.Size(90, 40);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(650, 300);
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(540, 360);
            this.btnLamMoi.Size = new System.Drawing.Size(90, 40);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(650, 360);
            this.btnLichSu.Size = new System.Drawing.Size(90, 40);
            this.btnLichSu.Text = "Xem lịch sử";
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // FormQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDiemTichLuy);
            this.Controls.Add(this.txtDiemTichLuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLichSu);
            this.Name = "FormQuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiemTichLuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnLichSu;
    }
}