using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng LOAI_SAN_PHAM.
    /// </summary>
    internal class LoaiSanPhamService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public LoaiSanPhamService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách loại sản phẩm.
        /// </summary>
        /// <returns>Danh sách LOAI_SAN_PHAM</returns>
        public List<LOAI_SAN_PHAM> GetAll()
        {
            return _context.LOAI_SAN_PHAM.ToList();
        }

        /// <summary>
        /// Lấy loại sản phẩm theo mã loại.
        /// </summary>
        /// <param name="maLoai">Mã loại sản phẩm</param>
        /// <returns>Đối tượng LOAI_SAN_PHAM hoặc null nếu không tìm thấy</returns>
        public LOAI_SAN_PHAM GetById(string maLoai)
        {
            return _context.LOAI_SAN_PHAM.FirstOrDefault(l => l.MaLoai == maLoai);
        }

        /// <summary>
        /// Thêm mới một loại sản phẩm vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="loaiSanPham">Đối tượng LOAI_SAN_PHAM cần thêm</param>
        public void Add(LOAI_SAN_PHAM loaiSanPham)
        {
            _context.LOAI_SAN_PHAM.Add(loaiSanPham);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một loại sản phẩm đã có.
        /// </summary>
        /// <param name="loaiSanPham">Đối tượng LOAI_SAN_PHAM với thông tin mới</param>
        public void Update(LOAI_SAN_PHAM loaiSanPham)
        {
            var existing = _context.LOAI_SAN_PHAM.FirstOrDefault(l => l.MaLoai == loaiSanPham.MaLoai);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(loaiSanPham);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một loại sản phẩm theo mã loại.
        /// </summary>
        /// <param name="maLoai">Mã loại sản phẩm cần xóa</param>
        public void Delete(string maLoai)
        {
            var loaiSanPham = _context.LOAI_SAN_PHAM.FirstOrDefault(l => l.MaLoai == maLoai);
            if (loaiSanPham != null)
            {
                _context.LOAI_SAN_PHAM.Remove(loaiSanPham);
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
