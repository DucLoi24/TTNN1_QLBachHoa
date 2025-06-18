namespace TTNN1_QLBachHoa
{
    partial class StaffMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.btnTaoPhieuNhapKho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(130, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ BÁCH HÓA";
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.Location = new System.Drawing.Point(213, 106);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(174, 96);
            this.btnTaoDonHang.TabIndex = 10;
            this.btnTaoDonHang.Text = "Tạo Đơn Hàng";
            this.btnTaoDonHang.UseVisualStyleBackColor = true;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // btnTaoPhieuNhapKho
            // 
            this.btnTaoPhieuNhapKho.Location = new System.Drawing.Point(213, 208);
            this.btnTaoPhieuNhapKho.Name = "btnTaoPhieuNhapKho";
            this.btnTaoPhieuNhapKho.Size = new System.Drawing.Size(174, 96);
            this.btnTaoPhieuNhapKho.TabIndex = 11;
            this.btnTaoPhieuNhapKho.Text = "Tạo Phiếu Nhập Kho";
            this.btnTaoPhieuNhapKho.UseVisualStyleBackColor = true;
            this.btnTaoPhieuNhapKho.Click += new System.EventHandler(this.btnTaoPhieuNhapKho_Click);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 392);
            this.Controls.Add(this.btnTaoPhieuNhapKho);
            this.Controls.Add(this.btnTaoDonHang);
            this.Controls.Add(this.label1);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.Button btnTaoPhieuNhapKho;
    }
}