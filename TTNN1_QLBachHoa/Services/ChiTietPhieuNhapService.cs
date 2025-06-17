using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng CHI_TIET_PHIEU_NHAP.
    /// </summary>
    internal class ChiTietPhieuNhapService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public ChiTietPhieuNhapService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách chi tiết phiếu nhập.
        /// </summary>
        /// <returns>Danh sách CHI_TIET_PHIEU_NHAP</returns>
        public List<CHI_TIET_PHIEU_NHAP> GetAll()
        {
            return _context.CHI_TIET_PHIEU_NHAP.ToList();
        }

        /// <summary>
        /// Lấy chi tiết phiếu nhập theo mã chi tiết phiếu nhập (khóa chính).
        /// </summary>
        /// <param name="maCTPN">Mã chi tiết phiếu nhập</param>
        /// <returns>Đối tượng CHI_TIET_PHIEU_NHAP hoặc null nếu không tìm thấy</returns>
        public CHI_TIET_PHIEU_NHAP GetById(long maCTPN)
        {
            return _context.CHI_TIET_PHIEU_NHAP.FirstOrDefault(ct => ct.MaCTPN == maCTPN);
        }

        /// <summary>
        /// Thêm mới một chi tiết phiếu nhập vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="chiTiet">Đối tượng CHI_TIET_PHIEU_NHAP cần thêm</param>
        public void Add(CHI_TIET_PHIEU_NHAP chiTiet)
        {
            _context.CHI_TIET_PHIEU_NHAP.Add(chiTiet);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một chi tiết phiếu nhập đã có.
        /// </summary>
        /// <param name="chiTiet">Đối tượng CHI_TIET_PHIEU_NHAP với thông tin mới</param>
        public void Update(CHI_TIET_PHIEU_NHAP chiTiet)
        {
            var existing = _context.CHI_TIET_PHIEU_NHAP.FirstOrDefault(ct => ct.MaCTPN == chiTiet.MaCTPN);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(chiTiet);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một chi tiết phiếu nhập theo mã chi tiết phiếu nhập.
        /// </summary>
        /// <param name="maCTPN">Mã chi tiết phiếu nhập cần xóa</param>
        public void Delete(long maCTPN)
        {
            var chiTiet = _context.CHI_TIET_PHIEU_NHAP.FirstOrDefault(ct => ct.MaCTPN == maCTPN);
            if (chiTiet != null)
            {
                _context.CHI_TIET_PHIEU_NHAP.Remove(chiTiet);
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
