using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng NHA_CUNG_CAP.
    /// </summary>
    internal class NhaCungCapService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public NhaCungCapService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách nhà cung cấp.
        /// </summary>
        /// <returns>Danh sách NHA_CUNG_CAP</returns>
        public List<NHA_CUNG_CAP> GetAll()
        {
            return _context.NHA_CUNG_CAP.ToList();
        }

        /// <summary>
        /// Lấy nhà cung cấp theo mã nhà cung cấp.
        /// </summary>
        /// <param name="maNCC">Mã nhà cung cấp</param>
        /// <returns>Đối tượng NHA_CUNG_CAP hoặc null nếu không tìm thấy</returns>
        public NHA_CUNG_CAP GetById(string maNCC)
        {
            return _context.NHA_CUNG_CAP.FirstOrDefault(ncc => ncc.MaNCC == maNCC);
        }

        /// <summary>
        /// Thêm mới một nhà cung cấp vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="nhaCungCap">Đối tượng NHA_CUNG_CAP cần thêm</param>
        public void Add(NHA_CUNG_CAP nhaCungCap)
        {
            _context.NHA_CUNG_CAP.Add(nhaCungCap);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một nhà cung cấp đã có.
        /// </summary>
        /// <param name="nhaCungCap">Đối tượng NHA_CUNG_CAP với thông tin mới</param>
        public void Update(NHA_CUNG_CAP nhaCungCap)
        {
            var existing = _context.NHA_CUNG_CAP.FirstOrDefault(ncc => ncc.MaNCC == nhaCungCap.MaNCC);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(nhaCungCap);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một nhà cung cấp theo mã nhà cung cấp.
        /// </summary>
        /// <param name="maNCC">Mã nhà cung cấp cần xóa</param>
        public void Delete(string maNCC)
        {
            var nhaCungCap = _context.NHA_CUNG_CAP.FirstOrDefault(ncc => ncc.MaNCC == maNCC);
            if (nhaCungCap != null)
            {
                _context.NHA_CUNG_CAP.Remove(nhaCungCap);
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
