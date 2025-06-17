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
    public partial class FormBaoCao : Form
    {
        private readonly DonHangService _donHangService = new DonHangService();
        private readonly ChiTietDonHangService _ctdhService = new ChiTietDonHangService();
        private readonly SanPhamService _spService = new SanPhamService();

        public FormBaoCao()
        {
            InitializeComponent();
            btnXemBaoCaoDoanhThu.Click += btnXemBaoCaoDoanhThu_Click;
            btnLocTonKho.Click += btnLocTonKho_Click;
            this.Load += FormBaoCao_Load;
            this.FormClosed += FormBaoCao_FormClosed;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // Mặc định load toàn bộ tồn kho khi mở tab
            LoadTonKho();
        }

        private void FormBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            _donHangService.Dispose();
            _ctdhService.Dispose();
            // SanPhamService không cần Dispose vì không implement IDisposable
        }

        // Báo cáo doanh thu
        private void btnXemBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            // Lấy đơn hàng trong khoảng thời gian
            var donHangs = _donHangService.GetAll()
                .Where(dh => dh.NgayTao.HasValue && dh.NgayTao.Value >= tuNgay && dh.NgayTao.Value <= denNgay)
                .ToList();

            var maDHs = donHangs.Select(dh => dh.MaDH).ToList();

            // Lấy chi tiết đơn hàng liên quan
            var chiTietList = _ctdhService.GetAll()
                .Where(ct => maDHs.Contains(ct.MaDH))
                .ToList();

            // Gộp doanh thu theo sản phẩm
            var doanhThuTheoSP = chiTietList
                .GroupBy(ct => ct.MaSP)
                .Select(g =>
                {
                    var sp = g.First().SAN_PHAM;
                    return new
                    {
                        MaSP = g.Key,
                        TenSP = sp != null ? sp.TenSP : "",
                        SoLuongBan = g.Sum(x => x.SoLuong),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    };
                })
                .OrderByDescending(x => x.DoanhThu)
                .ToList();

            dgvDoanhThu.DataSource = doanhThuTheoSP;

            // Tổng doanh thu
            decimal tongDoanhThu = doanhThuTheoSP.Sum(x => x.DoanhThu);
            lblTongDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0}";
        }

        // Báo cáo tồn kho
        private void btnLocTonKho_Click(object sender, EventArgs e)
        {
            int nguong = 0;
            int.TryParse(txtNguongTon.Text, out nguong);
            LoadTonKho(nguong);
        }

        private void LoadTonKho(int nguong = -1)
        {
            var sanPhams = _spService.GetAll();
            var data = sanPhams
                .Where(sp => nguong < 0 || sp.SoLuongTon <= nguong)
                .Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.SoLuongTon,
                    DonViTinh = sp.DonViTinh,
                    NhaCungCap = sp.NHA_CUNG_CAP != null ? sp.NHA_CUNG_CAP.TenNCC : "",
                    LoaiSP = sp.LOAI_SAN_PHAM != null ? sp.LOAI_SAN_PHAM.TenLoai : ""
                })
                .OrderBy(sp => sp.SoLuongTon)
                .ToList();

            dgvTonKho.DataSource = data;
        }
    }
}
