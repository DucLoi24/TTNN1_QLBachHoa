using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNN1_QLBachHoa.Forms;
using TTNN1_QLBachHoa.Services;

namespace TTNN1_QLBachHoa
{
    public partial class AdminMenu : Form
    {
        private readonly NhanVienService _nvService = new NhanVienService();

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            // Mở form quản lý sản phẩm
            FormQuanLySanPham formQuanLySanPham = new FormQuanLySanPham();
            formQuanLySanPham.Show(); // Hiển thị form quản lý sản phẩm
        }

        private void btnQuanLyLoaiSanPham_Click(object sender, EventArgs e)
        {
            // Mở form quản lý loại sản phẩm
            FormQuanLyLoaiSanPham formQuanLyLoaiSanPham = new FormQuanLyLoaiSanPham();
            formQuanLyLoaiSanPham.Show(); // Hiển thị form quản lý loại sản phẩm
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng
            Application.Exit();
        }

        private void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            // Mở form quản lý nhà cung cấp
            FormQuanLyNhaCungCap formQuanLyNhaCungCap = new FormQuanLyNhaCungCap();
            formQuanLyNhaCungCap.Show(); // Hiển thị form quản lý nhà cung cấp
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            // Mở form quản lý nhân viên
            FormQuanLyNhanVien formQuanLyNhanVien = new FormQuanLyNhanVien();
            formQuanLyNhanVien.Show(); // Hiển thị form quản lý nhân viên
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            // Mở form quản lý khách hàng
            FormQuanLyKhachHang formQuanLyKhachHang = new FormQuanLyKhachHang();
            formQuanLyKhachHang.Show(); // Hiển thị form quản lý khách hàng
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            FormTaoDonHang formTaoDonHang = new FormTaoDonHang("ADMIN");
            formTaoDonHang.Show();
        }

        private void btnQuanLyDonHang_Click(object sender, EventArgs e)
        {
            // Mở form quản lý đơn hàng
            FormQuanLyDonHang formQuanLyDonHang = new FormQuanLyDonHang();
            formQuanLyDonHang.Show(); // Hiển thị form quản lý đơn hàng
        }

        private void btnTaoPhieuNhapKho_Click(object sender, EventArgs e)
        {
            // Mở form tạo phiếu nhập kho
            FormTaoPhieuNhapKho formTaoPhieuNhapKho = new FormTaoPhieuNhapKho("ADMIN");
            formTaoPhieuNhapKho.Show(); // Hiển thị form tạo phiếu nhập kho
        }

        private void btnQuanLyPhieuNhapKho_Click(object sender, EventArgs e)
        {
            // Mở form quản lý phiếu nhập kho
            FormQuanLyPhieuNhapKho formQuanLyPhieuNhapKho = new FormQuanLyPhieuNhapKho();
            formQuanLyPhieuNhapKho.Show(); // Hiển thị form quản lý phiếu nhập kho
        }

        private void btnQuanLyBaoCao_Click(object sender, EventArgs e)
        {
            // Mở form quản lý báo cáo
            FormBaoCao formQuanLyBaoCao = new FormBaoCao();
            formQuanLyBaoCao.Show(); // Hiển thị form quản lý báo cáo
        }
    }
}
