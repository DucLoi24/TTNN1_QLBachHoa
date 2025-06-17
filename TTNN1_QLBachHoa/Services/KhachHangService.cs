using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng KHACH_HANG.
    /// </summary>
    internal class KhachHangService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public KhachHangService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng.
        /// </summary>
        /// <returns>Danh sách KHACH_HANG</returns>
        public List<KHACH_HANG> GetAll()
        {
            return _context.KHACH_HANG.ToList();
        }

        /// <summary>
        /// Lấy khách hàng theo mã khách hàng.
        /// </summary>
        /// <param name="maKH">Mã khách hàng</param>
        /// <returns>Đối tượng KHACH_HANG hoặc null nếu không tìm thấy</returns>
        public KHACH_HANG GetById(string maKH)
        {
            return _context.KHACH_HANG.FirstOrDefault(kh => kh.MaKH == maKH);
        }

        /// <summary>
        /// Thêm mới một khách hàng vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="khachHang">Đối tượng KHACH_HANG cần thêm</param>
        public void Add(KHACH_HANG khachHang)
        {
            _context.KHACH_HANG.Add(khachHang);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một khách hàng đã có.
        /// </summary>
        /// <param name="khachHang">Đối tượng KHACH_HANG với thông tin mới</param>
        public void Update(KHACH_HANG khachHang)
        {
            var existing = _context.KHACH_HANG.FirstOrDefault(kh => kh.MaKH == khachHang.MaKH);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(khachHang);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một khách hàng theo mã khách hàng.
        /// </summary>
        /// <param name="maKH">Mã khách hàng cần xóa</param>
        public void Delete(string maKH)
        {
            var khachHang = _context.KHACH_HANG.FirstOrDefault(kh => kh.MaKH == maKH);
            if (khachHang != null)
            {
                _context.KHACH_HANG.Remove(khachHang);
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
