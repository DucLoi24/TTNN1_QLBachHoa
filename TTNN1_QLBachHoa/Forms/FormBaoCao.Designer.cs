namespace TTNN1_QLBachHoa.Forms
{
    partial class FormBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXemBaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.lblNguongTon = new System.Windows.Forms.Label();
            this.txtNguongTon = new System.Windows.Forms.TextBox();
            this.btnLocTonKho = new System.Windows.Forms.Button();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDoanhThu);
            this.tabControl.Controls.Add(this.tabTonKho);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(967, 499);
            this.tabControl.TabIndex = 0;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.lblTuNgay);
            this.tabDoanhThu.Controls.Add(this.lblDenNgay);
            this.tabDoanhThu.Controls.Add(this.dtpTuNgay);
            this.tabDoanhThu.Controls.Add(this.dtpDenNgay);
            this.tabDoanhThu.Controls.Add(this.btnXemBaoCaoDoanhThu);
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(959, 470);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Báo cáo Doanh thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(87, 16);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(59, 16);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(427, 16);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(67, 16);
            this.lblDenNgay.TabIndex = 1;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(163, 14);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(247, 22);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(509, 14);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(258, 22);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // btnXemBaoCaoDoanhThu
            // 
            this.btnXemBaoCaoDoanhThu.Location = new System.Drawing.Point(805, 10);
            this.btnXemBaoCaoDoanhThu.Name = "btnXemBaoCaoDoanhThu";
            this.btnXemBaoCaoDoanhThu.Size = new System.Drawing.Size(120, 28);
            this.btnXemBaoCaoDoanhThu.TabIndex = 4;
            this.btnXemBaoCaoDoanhThu.Text = "Xem báo cáo";
            this.btnXemBaoCaoDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(20, 60);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.Size = new System.Drawing.Size(920, 386);
            this.dgvDoanhThu.TabIndex = 5;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(17, 449);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(113, 16);
            this.lblTongDoanhThu.TabIndex = 6;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0";
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.lblNguongTon);
            this.tabTonKho.Controls.Add(this.txtNguongTon);
            this.tabTonKho.Controls.Add(this.btnLocTonKho);
            this.tabTonKho.Controls.Add(this.dgvTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 25);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.Size = new System.Drawing.Size(959, 470);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "Báo cáo Tồn kho";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // lblNguongTon
            // 
            this.lblNguongTon.AutoSize = true;
            this.lblNguongTon.Location = new System.Drawing.Point(20, 20);
            this.lblNguongTon.Name = "lblNguongTon";
            this.lblNguongTon.Size = new System.Drawing.Size(118, 16);
            this.lblNguongTon.TabIndex = 0;
            this.lblNguongTon.Text = "Ngưỡng tồn kho <=";
            // 
            // txtNguongTon
            // 
            this.txtNguongTon.Location = new System.Drawing.Point(150, 17);
            this.txtNguongTon.Name = "txtNguongTon";
            this.txtNguongTon.Size = new System.Drawing.Size(80, 22);
            this.txtNguongTon.TabIndex = 1;
            // 
            // btnLocTonKho
            // 
            this.btnLocTonKho.Location = new System.Drawing.Point(250, 15);
            this.btnLocTonKho.Name = "btnLocTonKho";
            this.btnLocTonKho.Size = new System.Drawing.Size(80, 28);
            this.btnLocTonKho.TabIndex = 2;
            this.btnLocTonKho.Text = "Lọc";
            this.btnLocTonKho.UseVisualStyleBackColor = true;
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Location = new System.Drawing.Point(20, 60);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.Size = new System.Drawing.Size(915, 390);
            this.dgvTonKho.TabIndex = 3;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 499);
            this.Controls.Add(this.tabControl);
            this.Name = "FormBaoCao";
            this.Text = "Báo cáo tổng hợp";
            this.tabControl.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.tabDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabTonKho.ResumeLayout(false);
            this.tabTonKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXemBaoCaoDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblNguongTon;
        private System.Windows.Forms.TextBox txtNguongTon;
        private System.Windows.Forms.Button btnLocTonKho;
        private System.Windows.Forms.DataGridView dgvTonKho;
    }
}