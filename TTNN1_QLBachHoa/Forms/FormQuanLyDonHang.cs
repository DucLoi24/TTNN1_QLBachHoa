using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNN1_QLBachHoa.Services;

namespace TTNN1_QLBachHoa.Forms
{
    public partial class FormQuanLyDonHang : Form
    {
        private readonly DonHangService _dhService = new DonHangService();
        private readonly KhachHangService _khService = new KhachHangService();
        private readonly NhanVienService _nvService = new NhanVienService();
        private readonly SanPhamService _spService = new SanPhamService();

        private List<DON_HANG> _donHangList = new List<DON_HANG>();
        private DON_HANG _selectedDonHang = null;

        public FormQuanLyDonHang()
        {
            InitializeComponent();
            LoadTrangThaiFilter();
            LoadData();
            groupChiTiet.Enabled = false;
        }

        // Load trạng thái vào combobox lọc và cập nhật
        private void LoadTrangThaiFilter()
        {
            var trangThaiList = new List<string> { "Tất cả", "Đã thanh toán", "Đã hủy" };
            cbTimTrangThai.DataSource = trangThaiList.ToList();
            cbCapNhatTrangThai.DataSource = trangThaiList.Where(x => x != "Tất cả").ToList();
        }

        // Load danh sách đơn hàng
        private void LoadData()
        {
            _donHangList = _dhService.GetAll();
            ShowDonHang(_donHangList);
            groupChiTiet.Enabled = false;
            ClearChiTiet();
        }

        // Hiển thị danh sách đơn hàng lên DataGridView
        private void ShowDonHang(List<DON_HANG> list)
        {
            dgvDonHang.DataSource = list.Select(dh => new
            {
                dh.MaDH,
                TenKH = dh.KHACH_HANG?.TenKH,
                TenNV = dh.NHAN_VIEN?.TenNV,
                NgayTao = dh.NgayTao.HasValue ? dh.NgayTao.Value.ToString("dd/MM/yyyy HH:mm") : "",
                dh.TrangThai,
                dh.TongTien
            }).ToList();
            dgvDonHang.ClearSelection();
        }

        // Tìm kiếm/lọc
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var maDH = txtTimMaDH.Text.Trim().ToLower();
            var tenKH = txtTimTenKH.Text.Trim().ToLower();
            var trangThai = cbTimTrangThai.SelectedItem?.ToString();
            var ngayChecked = dtpTimNgay.Checked;
            var ngay = dtpTimNgay.Value.Date;

            var list = _donHangList.AsQueryable();
            if (!string.IsNullOrEmpty(maDH))
                list = list.Where(dh => dh.MaDH != null && dh.MaDH.ToLower().Contains(maDH));
            if (!string.IsNullOrEmpty(tenKH))
                list = list.Where(dh => dh.KHACH_HANG != null && dh.KHACH_HANG.TenKH.ToLower().Contains(tenKH));
            if (trangThai != "Tất cả")
                list = list.Where(dh => dh.TrangThai == trangThai);
            if (ngayChecked)
                list = list.Where(dh => dh.NgayTao.HasValue && dh.NgayTao.Value.Date == ngay);

            ShowDonHang(list.ToList());
            groupChiTiet.Enabled = false;
            ClearChiTiet();
        }

        // Khi chọn đơn hàng, hiển thị chi tiết
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDonHang.Rows.Count > e.RowIndex)
            {
                var maDH = dgvDonHang.Rows[e.RowIndex].Cells["MaDH"].Value?.ToString();
                _selectedDonHang = _dhService.GetById(maDH);
                if (_selectedDonHang != null)
                {
                    ShowChiTiet(_selectedDonHang);
                    groupChiTiet.Enabled = true;
                }
            }
        }

        // Hiển thị chi tiết đơn hàng
        private void ShowChiTiet(DON_HANG dh)
        {
            lblMaDH.Text = "Mã ĐH: " + dh.MaDH;
            lblKH.Text = "Khách hàng: " + (dh.KHACH_HANG?.TenKH ?? "");
            lblNV.Text = "Nhân viên: " + (dh.NHAN_VIEN?.TenNV ?? "");
            lblNgay.Text = "Ngày: " + (dh.NgayTao.HasValue ? dh.NgayTao.Value.ToString("dd/MM/yyyy HH:mm") : "");
            lblTrangThai.Text = "Trạng thái: " + dh.TrangThai;
            lblPTTT.Text = "Phương thức TT: " + (dh.PhuongThucThanhToan ?? "");
            lblTongTien.Text = "Tổng tiền: " + dh.TongTien.ToString("N0");

            dgvChiTiet.DataSource = dh.CHI_TIET_DON_HANG.Select(ct => new
            {
                ct.MaSP,
                TenSP = ct.SAN_PHAM?.TenSP,
                ct.SoLuong,
                DonGia = ct.DonGia.ToString("N0"),
                ThanhTien = ct.ThanhTien.ToString("N0")
            }).ToList();

            cbCapNhatTrangThai.SelectedItem = dh.TrangThai;
        }

        // Xóa chi tiết khi không chọn đơn hàng
        private void ClearChiTiet()
        {
            lblMaDH.Text = "Mã ĐH:";
            lblKH.Text = "Khách hàng:";
            lblNV.Text = "Nhân viên:";
            lblNgay.Text = "Ngày:";
            lblTrangThai.Text = "Trạng thái:";
            lblPTTT.Text = "Phương thức TT:";
            lblTongTien.Text = "Tổng tiền:";
            dgvChiTiet.DataSource = null;
            cbCapNhatTrangThai.SelectedIndex = 0;
        }

        // Lưu trạng thái đơn hàng
        private void btnLuuTrangThai_Click(object sender, EventArgs e)
        {
            if (_selectedDonHang == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newStatus = cbCapNhatTrangThai.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus) || newStatus == _selectedDonHang.TrangThai)
            {
                MessageBox.Show("Vui lòng chọn trạng thái mới khác trạng thái hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu chuyển sang "Đã hủy", hoàn lại tồn kho
            if (newStatus == "Đã hủy" && _selectedDonHang.TrangThai != "Đã hủy")
            {
                foreach (var ct in _selectedDonHang.CHI_TIET_DON_HANG)
                {
                    var sp = _spService.GetById(ct.MaSP);
                    if (sp != null)
                    {
                        sp.SoLuongTon += ct.SoLuong;
                        _spService.Update(sp);
                    }
                }
            }
            // Nếu chuyển từ "Đã hủy" sang trạng thái khác, cần kiểm tra tồn kho
            if (_selectedDonHang.TrangThai == "Đã hủy" && newStatus != "Đã hủy")
            {
                foreach (var ct in _selectedDonHang.CHI_TIET_DON_HANG)
                {
                    var sp = _spService.GetById(ct.MaSP);
                    if (sp == null || sp.SoLuongTon < ct.SoLuong)
                    {
                        MessageBox.Show($"Không đủ tồn kho để khôi phục đơn hàng cho sản phẩm {ct.MaSP}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Trừ tồn kho
                foreach (var ct in _selectedDonHang.CHI_TIET_DON_HANG)
                {
                    var sp = _spService.GetById(ct.MaSP);
                    sp.SoLuongTon -= ct.SoLuong;
                    _spService.Update(sp);
                }
            }

            _selectedDonHang.TrangThai = newStatus;
            try
            {
                _dhService.Update(_selectedDonHang);
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
