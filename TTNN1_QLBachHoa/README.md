# Quản Lý Bách Hóa - TTNN1_QLBachHoa

## Mô tả

**TTNN1__QLBachHoa** là một ứng dụng quản lý bách hóa tổng hợp, hỗ trợ các nghiệp vụ quản lý sản phẩm, loại sản phẩm, nhà cung cấp, nhân viên, khách hàng, đơn hàng, phiếu nhập kho và báo cáo. Ứng dụng được phát triển bằng C# WinForms trên nền tảng .NET Framework 4.7.2, sử dụng Entity Framework để thao tác với cơ sở dữ liệu.

---

## Mục lục

- [Mô tả](#mô-tả)
- [Cài đặt](#cài-đặt)
- [Cách sử dụng](#cách-sử-dụng)
- [Tính năng](#tính-năng)
- [Cấu hình](#cấu-hình)
- [Liên hệ](#liên-hệ)

---

## Cài đặt

1. **Yêu cầu hệ thống:**
   - Windows 7 trở lên
   - .NET Framework 4.7.2
   - SQL Server (hoặc SQL Express) với database phù hợp

2. **Clone repository:**
git clone https://github.com/DucLoi24/TTNN1_QLBachHoa.git

3. **Mở giải pháp:**
   - Mở file `TTNN1_QLBachHoa.sln` bằng Visual Studio 2022.

4. **Khôi phục package (nếu có):**
   - Visual Studio sẽ tự động khôi phục các NuGet package cần thiết khi mở giải pháp.

5. **Cấu hình chuỗi kết nối:**
   - Chỉnh sửa file `App.config` để cập nhật chuỗi kết nối đến database SQL Server của bạn.

6. **Build và chạy:**
   - Nhấn `F5` hoặc chọn `Start` để chạy ứng dụng.

---

## Cách sử dụng

- Đăng nhập vào ứng dụng (nếu có chức năng đăng nhập).
- Sử dụng các nút chức năng trên giao diện chính để truy cập các module:
  - Quản lý sản phẩm, loại sản phẩm, nhà cung cấp, nhân viên, khách hàng.
  - Tạo và quản lý đơn hàng, phiếu nhập kho.
  - Xem và xuất báo cáo.

---

## Tính năng

- **Quản lý sản phẩm:** Thêm, sửa, xóa, tìm kiếm sản phẩm.
- **Quản lý loại sản phẩm:** Thêm, sửa, xóa loại sản phẩm.
- **Quản lý nhà cung cấp:** Thêm, sửa, xóa nhà cung cấp.
- **Quản lý nhân viên:** Thêm, sửa, xóa nhân viên.
- **Quản lý khách hàng:** Thêm, sửa, xóa khách hàng.
- **Quản lý đơn hàng:** Tạo mới, cập nhật, xóa đơn hàng và chi tiết đơn hàng.
- **Quản lý phiếu nhập kho:** Tạo mới, cập nhật, xóa phiếu nhập và chi tiết phiếu nhập.
- **Báo cáo:** Thống kê, xuất báo cáo theo nhiều tiêu chí.

---

## Cấu hình

- **Cơ sở dữ liệu:**  
  - Sử dụng SQL Server, các bảng chính: `SAN_PHAM`, `LOAI_SAN_PHAM`, `NHA_CUNG_CAP`, `NHAN_VIEN`, `KHACH_HANG`, `DON_HANG`, `CHI_TIET_DON_HANG`, `PHIEU_NHAP_KHO`, `CHI_TIET_PHIEU_NHAP`.
  - Chuỗi kết nối cấu hình trong `App.config`:
3. **Mở giải pháp:**
   - Mở file `TTNN1_QLBachHoa.sln` bằng Visual Studio 2022.

4. **Khôi phục package (nếu có):**
   - Visual Studio sẽ tự động khôi phục các NuGet package cần thiết khi mở giải pháp.

5. **Cấu hình chuỗi kết nối:**
   - Chỉnh sửa file `App.config` để cập nhật chuỗi kết nối đến database SQL Server của bạn.

6. **Build và chạy:**
   - Nhấn `F5` hoặc chọn `Start` để chạy ứng dụng.

---

## Cách sử dụng

- Đăng nhập vào ứng dụng (nếu có chức năng đăng nhập).
- Sử dụng các nút chức năng trên giao diện chính để truy cập các module:
  - Quản lý sản phẩm, loại sản phẩm, nhà cung cấp, nhân viên, khách hàng.
  - Tạo và quản lý đơn hàng, phiếu nhập kho.
  - Xem và xuất báo cáo.

---

## Tính năng

- **Quản lý sản phẩm:** Thêm, sửa, xóa, tìm kiếm sản phẩm.
- **Quản lý loại sản phẩm:** Thêm, sửa, xóa loại sản phẩm.
- **Quản lý nhà cung cấp:** Thêm, sửa, xóa nhà cung cấp.
- **Quản lý nhân viên:** Thêm, sửa, xóa nhân viên.
- **Quản lý khách hàng:** Thêm, sửa, xóa khách hàng.
- **Quản lý đơn hàng:** Tạo mới, cập nhật, xóa đơn hàng và chi tiết đơn hàng.
- **Quản lý phiếu nhập kho:** Tạo mới, cập nhật, xóa phiếu nhập và chi tiết phiếu nhập.
- **Báo cáo:** Thống kê, xuất báo cáo theo nhiều tiêu chí.

---

## Cấu hình

- **Cơ sở dữ liệu:**  
  - Sử dụng SQL Server, các bảng chính: `SAN_PHAM`, `LOAI_SAN_PHAM`, `NHA_CUNG_CAP`, `NHAN_VIEN`, `KHACH_HANG`, `DON_HANG`, `CHI_TIET_DON_HANG`, `PHIEU_NHAP_KHO`, `CHI_TIET_PHIEU_NHAP`.
  - Chuỗi kết nối cấu hình trong `App.config`:
	<connectionStrings>
  <add name="QuanLyBachHoaEntities" connectionString="metadata=res://*/...;provider=System.Data.SqlClient;provider connection string=&quot;data source=YOUR_SERVER;initial catalog=YOUR_DATABASE;integrated security=True;MultipleActiveResultSets=True&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>

- **Cấu trúc thư mục:**
  - `Forms/` - Các form giao diện người dùng
  - `Services/` - Các lớp xử lý nghiệp vụ và truy xuất dữ liệu
  - `Models/` - Các lớp thực thể ánh xạ với bảng dữ liệu (nếu có)
  - `App.config` - File cấu hình ứng dụng

---

## Liên hệ

- Tác giả: [Tên của bạn]
- Email: [Email của bạn]
- Github: [https://github.com/<your-username>](https://github.com/<your-username>)

---

> **Lưu ý:** Đây là dự án mẫu phục vụ học tập, vui lòng kiểm tra và chỉnh sửa thông tin cấu hình phù hợp với môi trường của bạn trước khi sử dụng.