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
    public partial class FormTaoDonHang : Form
    {
        private readonly SanPhamService _spService = new SanPhamService();
        private readonly KhachHangService _khService = new KhachHangService();
        private readonly DonHangService _dhService = new DonHangService();

        // Giỏ hàng tạm
        private class GioHangItem
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public decimal DonGia { get; set; }
            public int SoLuong { get; set; }
            public decimal ThanhTien => DonGia * SoLuong;
        }
        private List<GioHangItem> _gioHang = new List<GioHangItem>();

        public FormTaoDonHang()
        {
            InitializeComponent();
            LoadSanPham();
            LoadKhachHang();
            LoadPTTT();
            UpdateTongTien();
        }

        // Load danh sách sản phẩm vào combobox
        private void LoadSanPham()
        {
            var list = _spService.GetAll();
            cbMaSP.DataSource = list;
            cbMaSP.DisplayMember = "MaSP";
            cbMaSP.ValueMember = "MaSP";
            cbMaSP.SelectedIndex = -1;
            lblTenSP.Text = "Tên SP:";
            lblDonGia.Text = "Đơn giá:";
        }

        // Load danh sách khách hàng vào combobox
        private void LoadKhachHang()
        {
            var list = _khService.GetAll();
            cbKhachHang.DataSource = list;
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "MaKH";
            cbKhachHang.SelectedIndex = -1;
        }

        // Load phương thức thanh toán
        private void LoadPTTT()
        {
            cbPTTT.Items.Clear();
            cbPTTT.Items.Add("Tiền mặt");
            cbPTTT.Items.Add("Chuyển khoản");
            cbPTTT.Items.Add("Thẻ");
            cbPTTT.SelectedIndex = 0;
        }

        // Khi chọn sản phẩm, hiển thị tên và đơn giá
        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaSP.SelectedIndex >= 0)
            {
                var sp = cbMaSP.SelectedItem as SAN_PHAM;
                if (sp != null)
                {
                    lblTenSP.Text = "Tên SP: " + sp.TenSP;
                    lblDonGia.Text = "Đơn giá: " + sp.GiaBan.ToString("N0");
                }
            }
            else
            {
                lblTenSP.Text = "Tên SP:";
                lblDonGia.Text = "Đơn giá:";
            }
        }

        // Thêm sản phẩm vào giỏ hàng
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cbMaSP.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sp = cbMaSP.SelectedItem as SAN_PHAM;
            if (sp == null) return;

            // Kiểm tra tồn kho
            int daCoTrongGio = _gioHang.Where(x => x.MaSP == sp.MaSP).Sum(x => x.SoLuong);
            if (soLuong + daCoTrongGio > sp.SoLuongTon)
            {
                MessageBox.Show($"Số lượng tồn kho không đủ. Hiện còn: {sp.SoLuongTon - daCoTrongGio}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu đã có trong giỏ thì cộng dồn
            var item = _gioHang.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (item != null)
            {
                item.SoLuong += soLuong;
            }
            else
            {
                _gioHang.Add(new GioHangItem
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = soLuong
                });
            }
            UpdateGioHang();
            txtSoLuong.Text = "";
        }

        // Cập nhật DataGridView giỏ hàng và tổng tiền
        private void UpdateGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _gioHang.Select(x => new
            {
                x.MaSP,
                x.TenSP,
                DonGia = x.DonGia.ToString("N0"),
                x.SoLuong,
                ThanhTien = x.ThanhTien.ToString("N0")
            }).ToList();
            UpdateTongTien();
        }

        // Tính tổng tiền
        private void UpdateTongTien()
        {
            decimal tong = _gioHang.Sum(x => x.ThanhTien);
            decimal giamGia = 0;
            decimal.TryParse(txtGiamGia.Text, out giamGia);
            if (giamGia < 0) giamGia = 0;
            lblTongTien.Text = $"Tổng tiền: {(tong - giamGia):N0}";
        }

        // Khi thay đổi giảm giá
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            UpdateTongTien();
        }

        // Xóa sản phẩm khỏi giỏ
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa khỏi giỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maSP = dgvGioHang.SelectedRows[0].Cells["MaSP"].Value?.ToString();
            var item = _gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (item != null)
            {
                _gioHang.Remove(item);
                UpdateGioHang();
            }
        }

        // Làm mới form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _gioHang.Clear();
            UpdateGioHang();
            cbMaSP.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            cbKhachHang.SelectedIndex = -1;
            cbPTTT.SelectedIndex = 0;
        }

        // Hoàn tất đơn hàng
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbKhachHang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbPTTT.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal giamGia = 0;
            decimal.TryParse(txtGiamGia.Text, out giamGia);
            if (giamGia < 0) giamGia = 0;

            // Tạo đơn hàng
            var donHang = new DON_HANG
            {
                MaDH = GenerateMaDH(),
                MaKH = cbKhachHang.SelectedValue.ToString(),
                MaNV = null, // Có thể lấy từ session đăng nhập
                NgayTao = DateTime.Now,
                TongTien = _gioHang.Sum(x => x.ThanhTien) - giamGia,
                TrangThai = "Đã thanh toán",
                PhuongThucThanhToan = cbPTTT.SelectedItem.ToString(),
                GiamGia = giamGia
            };

            try
            {
                _dhService.Add(donHang);
                // Thêm chi tiết đơn hàng và cập nhật tồn kho
                foreach (var item in _gioHang)
                {
                    var ctdh = new CHI_TIET_DON_HANG
                    {
                        MaDH = donHang.MaDH,
                        MaSP = item.MaSP,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        ThanhTien = item.ThanhTien
                    };
                    // Lưu chi tiết
                    _dhService.AddChiTiet(ctdh);

                    // Cập nhật tồn kho
                    var sp = _spService.GetById(item.MaSP);
                    if (sp != null)
                    {
                        sp.SoLuongTon -= item.SoLuong;
                        _spService.Update(sp);
                    }
                }
                MessageBox.Show("Tạo đơn hàng thành công!", "Thông báo");
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sinh mã đơn hàng tự động (ví dụ: DH001, DH002, ...)
        private string GenerateMaDH()
        {
            var all = _dhService.GetAll();
            int max = 0;
            foreach (var dh in all)
            {
                if (dh.MaDH != null && dh.MaDH.StartsWith("DH"))
                {
                    if (int.TryParse(dh.MaDH.Substring(2), out int num))
                        if (num > max) max = num;
                }
            }
            return "DH" + (max + 1).ToString("D3");
        }
    }
}
