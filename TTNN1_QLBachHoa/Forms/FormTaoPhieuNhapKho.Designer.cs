namespace TTNN1_QLBachHoa.Forms
{
    partial class FormTaoPhieuNhapKho
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
            this.lblNCC = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.lblTongTienNhap = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNCC
            // 
            this.lblNCC.Location = new System.Drawing.Point(20, 20);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(110, 22);
            this.lblNCC.TabIndex = 0;
            this.lblNCC.Text = "Nhà cung cấp:";
            // 
            // cbNCC
            // 
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.Location = new System.Drawing.Point(136, 17);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(180, 24);
            this.cbNCC.TabIndex = 1;
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            // 
            // lblMaSP
            // 
            this.lblMaSP.Location = new System.Drawing.Point(21, 60);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(109, 22);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // cbMaSP
            // 
            this.cbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSP.Location = new System.Drawing.Point(136, 57);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(120, 24);
            this.cbMaSP.TabIndex = 3;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(276, 59);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(200, 22);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(21, 99);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(109, 22);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(136, 97);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 22);
            this.txtSoLuong.TabIndex = 6;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.Location = new System.Drawing.Point(216, 99);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(80, 22);
            this.lblGiaNhap.TabIndex = 7;
            this.lblGiaNhap.Text = "Giá nhập:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(296, 97);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(80, 22);
            this.txtGiaNhap.TabIndex = 8;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(396, 94);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(120, 28);
            this.btnThemSP.TabIndex = 9;
            this.btnThemSP.Text = "Thêm vào phiếu";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(20, 140);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(600, 180);
            this.dgvPhieuNhap.TabIndex = 1;
            // 
            // lblTongTienNhap
            // 
            this.lblTongTienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTienNhap.Location = new System.Drawing.Point(20, 340);
            this.lblTongTienNhap.Name = "lblTongTienNhap";
            this.lblTongTienNhap.Size = new System.Drawing.Size(250, 24);
            this.lblTongTienNhap.TabIndex = 12;
            this.lblTongTienNhap.Text = "Tổng tiền nhập: 0";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(20, 380);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(60, 22);
            this.lblGhiChu.TabIndex = 13;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(80, 378);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(300, 22);
            this.txtGhiChu.TabIndex = 14;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(640, 340);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(120, 80);
            this.btnHoanTat.TabIndex = 15;
            this.btnHoanTat.Text = "Hoàn tất Phiếu nhập";
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(640, 140);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(120, 30);
            this.btnXoaSP.TabIndex = 10;
            this.btnXoaSP.Text = "Xóa khỏi phiếu";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(640, 180);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 30);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormTaoPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTongTienNhap);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnHoanTat);
            this.Name = "FormTaoPhieuNhapKho";
            this.Text = "Tạo phiếu nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Label lblTongTienNhap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLamMoi;
    }
}