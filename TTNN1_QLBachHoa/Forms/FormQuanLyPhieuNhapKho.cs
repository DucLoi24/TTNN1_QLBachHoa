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
    public partial class FormQuanLyPhieuNhapKho : Form
    {
        private readonly PhieuNhapKhoService _pnService = new PhieuNhapKhoService();
        private readonly ChiTietPhieuNhapService _ctpnService = new ChiTietPhieuNhapService();
        private List<PHIEU_NHAP_KHO> _danhSachPhieuNhap = new List<PHIEU_NHAP_KHO>();

        public FormQuanLyPhieuNhapKho()
        {
            InitializeComponent();
            Load += FormQuanLyPhieuNhapKho_Load;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            this.FormClosed += FormQuanLyPhieuNhapKho_FormClosed;
        }

        private void FormQuanLyPhieuNhapKho_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuNhap();
        }

        private void FormQuanLyPhieuNhapKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pnService.Dispose();
            _ctpnService.Dispose();
        }

        private void LoadDanhSachPhieuNhap()
        {
            _danhSachPhieuNhap = _pnService.GetAll();

            dgvPhieuNhap.DataSource = _danhSachPhieuNhap
                .Select(p => new
                {
                    MaPN = p.MaPN,
                    NgayNhap = p.NgayNhap.HasValue ? p.NgayNhap.Value.ToString("dd/MM/yyyy") : "",
                    TenNCC = p.NHA_CUNG_CAP != null ? p.NHA_CUNG_CAP.TenNCC : "",
                    TenNV = p.NHAN_VIEN != null ? p.NHAN_VIEN.TenNV : "",
                    TongTien = p.TongTienNhap
                })
                .ToList();

            dgvPhieuNhap.ClearSelection();
            groupChiTiet.Enabled = false;
            dgvChiTiet.DataSource = null;
            ResetChiTietLabels();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maPN = txtTimMaPN.Text.Trim().ToLower();
            string tenNCC = txtTimTenNCC.Text.Trim().ToLower();
            DateTime? ngay = dtpTimNgay.Checked ? dtpTimNgay.Value.Date : (DateTime?)null;

            var ketQua = _danhSachPhieuNhap.Where(p =>
                (string.IsNullOrEmpty(maPN) || p.MaPN.ToLower().Contains(maPN)) &&
                (string.IsNullOrEmpty(tenNCC) || (p.NHA_CUNG_CAP != null && p.NHA_CUNG_CAP.TenNCC.ToLower().Contains(tenNCC))) &&
                (!ngay.HasValue || (p.NgayNhap.HasValue && p.NgayNhap.Value.Date == ngay.Value))
            )
            .Select(p => new
            {
                MaPN = p.MaPN,
                NgayNhap = p.NgayNhap.HasValue ? p.NgayNhap.Value.ToString("dd/MM/yyyy") : "",
                TenNCC = p.NHA_CUNG_CAP != null ? p.NHA_CUNG_CAP.TenNCC : "",
                TenNV = p.NHAN_VIEN != null ? p.NHAN_VIEN.TenNV : "",
                TongTien = p.TongTienNhap
            })
            .ToList();

            dgvPhieuNhap.DataSource = ketQua;
            dgvPhieuNhap.ClearSelection();
            groupChiTiet.Enabled = false;
            dgvChiTiet.DataSource = null;
            ResetChiTietLabels();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var maPN = dgvPhieuNhap.Rows[e.RowIndex].Cells["MaPN"].Value.ToString();
            var phieuNhap = _danhSachPhieuNhap.FirstOrDefault(p => p.MaPN == maPN);
            if (phieuNhap == null) return;

            // Hiển thị thông tin chung
            lblMaPN.Text = "Mã PN: " + phieuNhap.MaPN;
            lblNCC.Text = "Nhà cung cấp: " + (phieuNhap.NHA_CUNG_CAP != null ? phieuNhap.NHA_CUNG_CAP.TenNCC : "");
            lblNV.Text = "Nhân viên: " + (phieuNhap.NHAN_VIEN != null ? phieuNhap.NHAN_VIEN.TenNV : "");
            lblNgay.Text = "Ngày: " + (phieuNhap.NgayNhap.HasValue ? phieuNhap.NgayNhap.Value.ToString("dd/MM/yyyy") : "");
            lblTongTien.Text = "Tổng tiền: " + phieuNhap.TongTienNhap.ToString("N0");
            lblGhiChu.Text = "Ghi chú: " + (phieuNhap.GhiChu ?? "");

            // Lấy chi tiết phiếu nhập
            var chiTietList = _ctpnService.GetAll().Where(ct => ct.MaPN == maPN).ToList();

            dgvChiTiet.DataSource = chiTietList.Select(c => new
            {
                MaSP = c.MaSP,
                TenSP = c.SAN_PHAM != null ? c.SAN_PHAM.TenSP : "",
                SoLuongNhap = c.SoLuongNhap,
                DonGiaNhap = c.DonGiaNhap,
                ThanhTienNhap = c.ThanhTienNhap
            }).ToList();

            groupChiTiet.Enabled = true;
        }

        private void ResetChiTietLabels()
        {
            lblMaPN.Text = "Mã PN:";
            lblNCC.Text = "Nhà cung cấp:";
            lblNV.Text = "Nhân viên:";
            lblNgay.Text = "Ngày:";
            lblTongTien.Text = "Tổng tiền:";
            lblGhiChu.Text = "Ghi chú:";
        }
    }
}
