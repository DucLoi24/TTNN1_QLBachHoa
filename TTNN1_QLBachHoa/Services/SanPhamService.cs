using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng SAN_PHAM.
    /// </summary>
    internal class SanPhamService
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public SanPhamService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm.
        /// </summary>
        /// <returns>Danh sách SAN_PHAM</returns>
        public List<SAN_PHAM> GetAll()
        {
            return _context.SAN_PHAM.ToList();
        }

        /// <summary>
        /// Lấy sản phẩm theo mã sản phẩm.
        /// </summary>
        /// <param name="maSP">Mã sản phẩm</param>
        /// <returns>Đối tượng SAN_PHAM hoặc null nếu không tìm thấy</returns>
        public SAN_PHAM GetById(string maSP)
        {
            return _context.SAN_PHAM.FirstOrDefault(sp => sp.MaSP == maSP);
        }

        /// <summary>
        /// Thêm mới một sản phẩm vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="sanPham">Đối tượng SAN_PHAM cần thêm</param>
        public void Add(SAN_PHAM sanPham)
        {
            _context.SAN_PHAM.Add(sanPham);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một sản phẩm đã có.
        /// </summary>
        /// <param name="sanPham">Đối tượng SAN_PHAM với thông tin mới</param>
        public void Update(SAN_PHAM sanPham)
        {
            var existing = _context.SAN_PHAM.FirstOrDefault(sp => sp.MaSP == sanPham.MaSP);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(sanPham);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một sản phẩm theo mã sản phẩm.
        /// </summary>
        /// <param name="maSP">Mã sản phẩm cần xóa</param>
        public void Delete(string maSP)
        {
            var sanPham = _context.SAN_PHAM.FirstOrDefault(sp => sp.MaSP == maSP);
            if (sanPham != null)
            {
                _context.SAN_PHAM.Remove(sanPham);
                _context.SaveChanges();
            }
        }
    }
}
