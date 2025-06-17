using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng CHI_TIET_DON_HANG.
    /// </summary>
    internal class ChiTietDonHangService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public ChiTietDonHangService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách chi tiết đơn hàng.
        /// </summary>
        /// <returns>Danh sách CHI_TIET_DON_HANG</returns>
        public List<CHI_TIET_DON_HANG> GetAll()
        {
            return _context.CHI_TIET_DON_HANG.ToList();
        }

        /// <summary>
        /// Lấy chi tiết đơn hàng theo mã chi tiết đơn hàng (khóa chính).
        /// </summary>
        /// <param name="maCTDH">Mã chi tiết đơn hàng</param>
        /// <returns>Đối tượng CHI_TIET_DON_HANG hoặc null nếu không tìm thấy</returns>
        public CHI_TIET_DON_HANG GetById(long maCTDH)
        {
            return _context.CHI_TIET_DON_HANG.FirstOrDefault(ct => ct.MaCTDH == maCTDH);
        }

        /// <summary>
        /// Thêm mới một chi tiết đơn hàng vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="chiTiet">Đối tượng CHI_TIET_DON_HANG cần thêm</param>
        public void Add(CHI_TIET_DON_HANG chiTiet)
        {
            _context.CHI_TIET_DON_HANG.Add(chiTiet);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một chi tiết đơn hàng đã có.
        /// </summary>
        /// <param name="chiTiet">Đối tượng CHI_TIET_DON_HANG với thông tin mới</param>
        public void Update(CHI_TIET_DON_HANG chiTiet)
        {
            var existing = _context.CHI_TIET_DON_HANG.FirstOrDefault(ct => ct.MaCTDH == chiTiet.MaCTDH);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(chiTiet);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một chi tiết đơn hàng theo mã chi tiết đơn hàng.
        /// </summary>
        /// <param name="maCTDH">Mã chi tiết đơn hàng cần xóa</param>
        public void Delete(long maCTDH)
        {
            var chiTiet = _context.CHI_TIET_DON_HANG.FirstOrDefault(ct => ct.MaCTDH == maCTDH);
            if (chiTiet != null)
            {
                _context.CHI_TIET_DON_HANG.Remove(chiTiet);
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
