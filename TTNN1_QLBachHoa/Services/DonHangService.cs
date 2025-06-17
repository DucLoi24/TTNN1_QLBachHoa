using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng DON_HANG.
    /// </summary>
    internal class DonHangService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public DonHangService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách đơn hàng.
        /// </summary>
        /// <returns>Danh sách DON_HANG</returns>
        public List<DON_HANG> GetAll()
        {
            return _context.DON_HANG.ToList();
        }

        /// <summary>
        /// Lấy đơn hàng theo mã đơn hàng.
        /// </summary>
        /// <param name="maDH">Mã đơn hàng</param>
        /// <returns>Đối tượng DON_HANG hoặc null nếu không tìm thấy</returns>
        public DON_HANG GetById(string maDH)
        {
            return _context.DON_HANG.FirstOrDefault(dh => dh.MaDH == maDH);
        }

        /// <summary>
        /// Thêm mới một đơn hàng vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="donHang">Đối tượng DON_HANG cần thêm</param>
        public void Add(DON_HANG donHang)
        {
            _context.DON_HANG.Add(donHang);
            _context.SaveChanges();
        }

        /// <summary>
        /// Thêm mới một chi tiết đơn hàng vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="chiTiet">Đối tượng CHI_TIET_DON_HANG cần thêm</param>
        public void AddChiTiet(CHI_TIET_DON_HANG chiTiet)
        {
            _context.CHI_TIET_DON_HANG.Add(chiTiet);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một đơn hàng đã có.
        /// </summary>
        /// <param name="donHang">Đối tượng DON_HANG với thông tin mới</param>
        public void Update(DON_HANG donHang)
        {
            var existing = _context.DON_HANG.FirstOrDefault(dh => dh.MaDH == donHang.MaDH);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(donHang);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một đơn hàng theo mã đơn hàng.
        /// </summary>
        /// <param name="maDH">Mã đơn hàng cần xóa</param>
        public void Delete(string maDH)
        {
            var donHang = _context.DON_HANG.FirstOrDefault(dh => dh.MaDH == maDH);
            if (donHang != null)
            {
                _context.DON_HANG.Remove(donHang);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Giải phóng tài nguyên context khi không sử dụng nữa.
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
