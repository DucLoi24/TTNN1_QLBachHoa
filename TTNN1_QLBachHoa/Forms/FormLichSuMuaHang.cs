using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNN1_QLBachHoa.Forms
{
    public partial class FormLichSuMuaHang : Form
    {
        private readonly string _maKH;
        private readonly string _tenKH;
        private readonly QuanLyBachHoaEntities _context = new QuanLyBachHoaEntities();

        public FormLichSuMuaHang(string maKH, string tenKH)
        {
            InitializeComponent();
            _maKH = maKH;
            _tenKH = tenKH;
            lblKhachHang.Text = $"Lịch sử mua hàng của: {_tenKH} ({_maKH})";
            LoadDonHang();
        }

        // Load danh sách đơn hàng của khách hàng
        private void LoadDonHang()
        {
            try
            {
                var donHangs = _context.DON_HANG
                    .Where(dh => dh.MaKH == _maKH)
                    .Select(dh => new
                    {
                        dh.MaDH,
                        dh.NgayTao,
                        dh.TongTien,
                        dh.TrangThai,
                        dh.PhuongThucThanhToan
                    })
                    .OrderByDescending(dh => dh.NgayTao)
                    .ToList();

                dgvDonHang.DataSource = donHangs;
                dgvChiTiet.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi chọn một đơn hàng, hiển thị chi tiết đơn hàng đó
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDonHang.Rows.Count > e.RowIndex)
            {
                var maDH = dgvDonHang.Rows[e.RowIndex].Cells["MaDH"].Value?.ToString();
                LoadChiTietDonHang(maDH);
            }
        }

        // Load chi tiết đơn hàng
        private void LoadChiTietDonHang(string maDH)
        {
            try
            {
                var chiTiets = _context.CHI_TIET_DON_HANG
                    .Where(ct => ct.MaDH == maDH)
                    .Select(ct => new
                    {
                        ct.MaSP,
                        TenSP = ct.SAN_PHAM.TenSP,
                        ct.SoLuong,
                        ct.DonGia,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvChiTiet.DataSource = chiTiets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đóng form
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
