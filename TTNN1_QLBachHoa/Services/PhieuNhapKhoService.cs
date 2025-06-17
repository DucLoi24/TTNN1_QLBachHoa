using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNN1_QLBachHoa.Services
{
    /// <summary>
    /// Service cung cấp các thao tác CRUD cho bảng PHIEU_NHAP_KHO.
    /// </summary>
    internal class PhieuNhapKhoService : IDisposable
    {
        // Đối tượng context để thao tác với cơ sở dữ liệu
        private readonly QuanLyBachHoaEntities _context;

        /// <summary>
        /// Khởi tạo service và context kết nối CSDL.
        /// </summary>
        public PhieuNhapKhoService()
        {
            _context = new QuanLyBachHoaEntities();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách phiếu nhập kho.
        /// </summary>
        /// <returns>Danh sách PHIEU_NHAP_KHO</returns>
        public List<PHIEU_NHAP_KHO> GetAll()
        {
            return _context.PHIEU_NHAP_KHO.ToList();
        }

        /// <summary>
        /// Lấy phiếu nhập kho theo mã phiếu nhập.
        /// </summary>
        /// <param name="maPN">Mã phiếu nhập</param>
        /// <returns>Đối tượng PHIEU_NHAP_KHO hoặc null nếu không tìm thấy</returns>
        public PHIEU_NHAP_KHO GetById(string maPN)
        {
            return _context.PHIEU_NHAP_KHO.FirstOrDefault(pn => pn.MaPN == maPN);
        }

        /// <summary>
        /// Thêm mới một phiếu nhập kho vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="phieuNhapKho">Đối tượng PHIEU_NHAP_KHO cần thêm</param>
        public void Add(PHIEU_NHAP_KHO phieuNhapKho)
        {
            _context.PHIEU_NHAP_KHO.Add(phieuNhapKho);
            _context.SaveChanges();
        }

        /// <summary>
        /// Thêm mới một chi tiết phiếu nhập kho vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="chiTiet">Đối tượng CHI_TIET_PHIEU_NHAP cần thêm</param>
        public void AddChiTiet(CHI_TIET_PHIEU_NHAP chiTiet)
        {
            _context.CHI_TIET_PHIEU_NHAP.Add(chiTiet);
            _context.SaveChanges();
        }

        /// <summary>
        /// Cập nhật thông tin một phiếu nhập kho đã có.
        /// </summary>
        /// <param name="phieuNhapKho">Đối tượng PHIEU_NHAP_KHO với thông tin mới</param>
        public void Update(PHIEU_NHAP_KHO phieuNhapKho)
        {
            var existing = _context.PHIEU_NHAP_KHO.FirstOrDefault(pn => pn.MaPN == phieuNhapKho.MaPN);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(phieuNhapKho);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Xóa một phiếu nhập kho theo mã phiếu nhập.
        /// </summary>
        /// <param name="maPN">Mã phiếu nhập cần xóa</param>
        public void Delete(string maPN)
        {
            var phieuNhapKho = _context.PHIEU_NHAP_KHO.FirstOrDefault(pn => pn.MaPN == maPN);
            if (phieuNhapKho != null)
            {
                _context.PHIEU_NHAP_KHO.Remove(phieuNhapKho);
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
