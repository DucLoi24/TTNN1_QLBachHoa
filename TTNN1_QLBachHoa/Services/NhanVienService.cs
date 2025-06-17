using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng NHAN_VIEN.
    /// </summary>
    internal class NhanVienService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public NhanVienService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách nhân viên.
        /// </summary>
        /// <returns>Danh sách NHAN_VIEN</returns>
        public List<NHAN_VIEN> GetAll()
        {
            return _context.NHAN_VIEN.ToList();
        }

        /// <summary>
        /// Lấy nhân viên theo mã nhân viên.
        /// </summary>
        /// <param name="maNV">Mã nhân viên</param>
        /// <returns>Đối tượng NHAN_VIEN hoặc null nếu không tìm thấy</returns>
        public NHAN_VIEN GetById(string maNV)
        {
            return _context.NHAN_VIEN.FirstOrDefault(nv => nv.MaNV == maNV);
        }

        /// <summary>
        /// Thêm mới một nhân viên vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="nhanVien">Đối tượng NHAN_VIEN cần thêm</param>
        public void Add(NHAN_VIEN nhanVien)
        {
            _context.NHAN_VIEN.Add(nhanVien);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một nhân viên đã có.
        /// </summary>
        /// <param name="nhanVien">Đối tượng NHAN_VIEN với thông tin mới</param>
        public void Update(NHAN_VIEN nhanVien)
        {
            var existing = _context.NHAN_VIEN.FirstOrDefault(nv => nv.MaNV == nhanVien.MaNV);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(nhanVien);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một nhân viên theo mã nhân viên.
        /// </summary>
        /// <param name="maNV">Mã nhân viên cần xóa</param>
        public void Delete(string maNV)
        {
            var nhanVien = _context.NHAN_VIEN.FirstOrDefault(nv => nv.MaNV == maNV);
            if (nhanVien != null)
            {
                _context.NHAN_VIEN.Remove(nhanVien);
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
