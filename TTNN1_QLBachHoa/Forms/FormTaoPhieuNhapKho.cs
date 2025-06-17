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
    public partial class FormTaoPhieuNhapKho : Form
    {
        private readonly SanPhamService _spService = new SanPhamService();
        private readonly NhaCungCapService _nccService = new NhaCungCapService();
        private readonly PhieuNhapKhoService _pnService = new PhieuNhapKhoService();
        private List<SAN_PHAM> _allSanPham = new List<SAN_PHAM>();

        // Danh sách sản phẩm nhập tạm
        private class NhapKhoItem
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuongNhap { get; set; }
            public decimal DonGiaNhap { get; set; }
            public decimal ThanhTienNhap => SoLuongNhap * DonGiaNhap;
        }
        private List<NhapKhoItem> _phieuNhap = new List<NhapKhoItem>();

        public FormTaoPhieuNhapKho()
        {
            InitializeComponent();
            LoadNCC();
            LoadSanPham();
            UpdateTongTien();
        }

        // Load danh sách nhà cung cấp
        private void LoadNCC()
        {
            var nccList = _nccService.GetAll();
            cbNCC.DataSource = nccList;
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";
            cbNCC.SelectedIndex = -1;
        }

        // Load danh sách sản phẩm
        private void LoadSanPham()
        {
            _allSanPham = _spService.GetAll();
            cbMaSP.DataSource = _allSanPham;
            cbMaSP.DisplayMember = "MaSP";
            cbMaSP.ValueMember = "MaSP";
            cbMaSP.SelectedIndex = -1;
            lblTenSP.Text = "Tên SP:";
        }

        // Khi chọn sản phẩm, hiển thị tên
        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaSP.SelectedIndex >= 0)
            {
                var sp = cbMaSP.SelectedItem as SAN_PHAM;
                lblTenSP.Text = "Tên SP: " + (sp?.TenSP ?? "");

                // Nếu chưa chọn nhà cung cấp, tự động chọn theo sản phẩm
                if (cbNCC.SelectedIndex < 0 && sp != null)
                {
                    // Tìm vị trí nhà cung cấp tương ứng
                    for (int i = 0; i < cbNCC.Items.Count; i++)
                    {
                        var ncc = cbNCC.Items[i] as NHA_CUNG_CAP;
                        if (ncc != null && ncc.MaNCC == sp.MaNCC)
                        {
                            cbNCC.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                lblTenSP.Text = "Tên SP:";
            }
        }

        // Thêm sản phẩm vào phiếu nhập
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cbMaSP.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng nhập phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập phải là số >= 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sp = cbMaSP.SelectedItem as SAN_PHAM;
            if (sp == null) return;

            // Nếu đã có trong phiếu thì cộng dồn số lượng và cập nhật giá nhập
            var item = _phieuNhap.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (item != null)
            {
                item.SoLuongNhap += soLuong;
                item.DonGiaNhap = giaNhap; // cập nhật giá nhập mới nhất
            }
            else
            {
                _phieuNhap.Add(new NhapKhoItem
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    SoLuongNhap = soLuong,
                    DonGiaNhap = giaNhap
                });
            }
            UpdatePhieuNhap();
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
        }

        // Cập nhật DataGridView phiếu nhập và tổng tiền
        private void UpdatePhieuNhap()
        {
            dgvPhieuNhap.DataSource = null;
            dgvPhieuNhap.DataSource = _phieuNhap.Select(x => new
            {
                x.MaSP,
                x.TenSP,
                x.SoLuongNhap,
                DonGiaNhap = x.DonGiaNhap.ToString("N0"),
                ThanhTienNhap = x.ThanhTienNhap.ToString("N0")
            }).ToList();
            UpdateTongTien();
        }

        // Tính tổng tiền nhập
        private void UpdateTongTien()
        {
            decimal tong = _phieuNhap.Sum(x => x.ThanhTienNhap);
            lblTongTienNhap.Text = $"Tổng tiền nhập: {tong:N0}";
        }

        // Xóa sản phẩm khỏi phiếu nhập
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa khỏi phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maSP = dgvPhieuNhap.SelectedRows[0].Cells["MaSP"].Value?.ToString();
            var item = _phieuNhap.FirstOrDefault(x => x.MaSP == maSP);
            if (item != null)
            {
                _phieuNhap.Remove(item);
                UpdatePhieuNhap();
            }
        }

        // Làm mới form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _phieuNhap.Clear();
            UpdatePhieuNhap();
            cbNCC.SelectedIndex = -1;
            cbMaSP.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGhiChu.Text = "";
            LoadSanPham();
        }

        // Hoàn tất phiếu nhập
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (cbNCC.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_phieuNhap.Count == 0)
            {
                MessageBox.Show("Phiếu nhập chưa có sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal tongTien = _phieuNhap.Sum(x => x.ThanhTienNhap);

            // Tạo phiếu nhập kho
            var phieuNhap = new PHIEU_NHAP_KHO
            {
                MaPN = GenerateMaPN(),
                MaNCC = cbNCC.SelectedValue.ToString(),
                MaNV = null, // Có thể lấy từ session đăng nhập
                NgayNhap = DateTime.Now,
                TongTienNhap = tongTien,
                GhiChu = txtGhiChu.Text
            };

            try
            {
                _pnService.Add(phieuNhap);
                // Thêm chi tiết phiếu nhập và cập nhật tồn kho
                foreach (var item in _phieuNhap)
                {
                    var ct = new CHI_TIET_PHIEU_NHAP
                    {
                        MaPN = phieuNhap.MaPN,
                        MaSP = item.MaSP,
                        SoLuongNhap = item.SoLuongNhap,
                        DonGiaNhap = item.DonGiaNhap,
                        ThanhTienNhap = item.ThanhTienNhap
                    };
                    _pnService.AddChiTiet(ct);

                    // Cập nhật tồn kho
                    var sp = _spService.GetById(item.MaSP);
                    if (sp != null)
                    {
                        sp.SoLuongTon += item.SoLuongNhap;
                        sp.GiaNhap = item.DonGiaNhap; // cập nhật giá nhập mới nhất
                        _spService.Update(sp);
                    }
                }
                MessageBox.Show("Tạo phiếu nhập kho thành công!", "Thông báo");
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sinh mã phiếu nhập tự động (ví dụ: PN001, PN002, ...)
        private string GenerateMaPN()
        {
            var all = _pnService.GetAll();
            int max = 0;
            foreach (var pn in all)
            {
                if (pn.MaPN != null && pn.MaPN.StartsWith("PN"))
                {
                    if (int.TryParse(pn.MaPN.Substring(2), out int num))
                        if (num > max) max = num;
                }
            }
            return "PN" + (max + 1).ToString("D3");
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNCC.SelectedIndex >= 0)
            {
                var maNCC = cbNCC.SelectedValue?.ToString();
                var filtered = _allSanPham.Where(sp => sp.MaNCC == maNCC).ToList();
                cbMaSP.DataSource = filtered;
                cbMaSP.DisplayMember = "MaSP";
                cbMaSP.ValueMember = "MaSP";
                cbMaSP.SelectedIndex = -1;
                lblTenSP.Text = "Tên SP:";
            }
            else
            {
                // Nếu bỏ chọn NCC, hiển thị lại toàn bộ sản phẩm
                cbMaSP.DataSource = _allSanPham;
                cbMaSP.DisplayMember = "MaSP";
                cbMaSP.ValueMember = "MaSP";
                cbMaSP.SelectedIndex = -1;
                lblTenSP.Text = "Tên SP:";
            }
        }
    }
}
