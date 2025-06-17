# Quản Lý Bách Hóa - TTNN1_QLBachHoa

## Mô tả

**TTNN1_QLBachHoa** là một ứng dụng quản lý bách hóa tổng hợp, hỗ trợ các nghiệp vụ quản lý sản phẩm, loại sản phẩm, nhà cung cấp, nhân viên, khách hàng, đơn hàng, phiếu nhập kho và báo cáo. Ứng dụng được phát triển bằng C# WinForms trên nền tảng .NET Framework 4.7.2, sử dụng Entity Framework để thao tác với cơ sở dữ liệu.

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
  - Tạo cơ sở dữ liệu và các bảng:
    CREATE DATABASE QuanLyBachHoa;
USE QuanLyBachHoa;
GO

-- 1. Bảng LOAI_SAN_PHAM
CREATE TABLE LOAI_SAN_PHAM (
    MaLoai   NVARCHAR(10) PRIMARY KEY, -- Khóa chính: Mã loại sản phẩm
    TenLoai  NVARCHAR(100) NOT NULL,   -- Tên loại sản phẩm
    MoTa     NVARCHAR(255)             -- Mô tả về loại sản phẩm (có thể null)
);
GO

-- 2. Bảng NHA_CUNG_CAP
CREATE TABLE NHA_CUNG_CAP (
    MaNCC    NVARCHAR(10) PRIMARY KEY, -- Khóa chính: Mã nhà cung cấp
    TenNCC   NVARCHAR(150) NOT NULL,   -- Tên của nhà cung cấp
    DiaChi   NVARCHAR(255),            -- Địa chỉ của nhà cung cấp
    SDT      NVARCHAR(20),             -- Số điện thoại liên hệ
    Email    NVARCHAR(100)             -- Email liên hệ
);
GO

-- 3. Bảng NHAN_VIEN
CREATE TABLE NHAN_VIEN (
    MaNV      NVARCHAR(10) PRIMARY KEY, -- Khóa chính: Mã nhân viên
    TenNV     NVARCHAR(100) NOT NULL,   -- Tên của nhân viên
    ChucVu    NVARCHAR(50),             -- Chức vụ của nhân viên
    SDT       NVARCHAR(20),             -- Số điện thoại liên hệ
    Email     NVARCHAR(100),            -- Email liên hệ
    NgayVaoLam DATE                      -- Ngày nhân viên bắt đầu làm việc
);
GO

-- 4. Bảng KHACH_HANG
CREATE TABLE KHACH_HANG (
    MaKH        NVARCHAR(10) PRIMARY KEY, -- Khóa chính: Mã khách hàng
    TenKH       NVARCHAR(100) NOT NULL,   -- Tên của khách hàng
    SDT         NVARCHAR(20),             -- Số điện thoại liên hệ
    DiaChi      NVARCHAR(255),            -- Địa chỉ của khách hàng (có thể null)
    Email       NVARCHAR(100),            -- Email của khách hàng (có thể null)
    DiemTichLuy INT DEFAULT 0             -- Điểm tích lũy của khách hàng (nếu có), mặc định 0
);
GO

-- 5. Bảng SAN_PHAM
CREATE TABLE SAN_PHAM (
    MaSP         NVARCHAR(10) PRIMARY KEY, -- Khóa chính: Mã sản phẩm
    TenSP        NVARCHAR(255) NOT NULL,   -- Tên của sản phẩm
    MoTa         NVARCHAR(MAX),            -- Mô tả ngắn gọn về sản phẩm (có thể null, NVARCHAR(MAX) cho văn bản dài)
    DonViTinh    NVARCHAR(50) NOT NULL,    -- Đơn vị tính của sản phẩm
    GiaBan       DECIMAL(18, 2) NOT NULL,  -- Giá bán lẻ của một đơn vị sản phẩm
    GiaNhap      DECIMAL(18, 2) NOT NULL,  -- Giá nhập vào của một đơn vị sản phẩm
    SoLuongTon   INT NOT NULL,             -- Số lượng sản phẩm hiện có trong kho
    MaLoai       NVARCHAR(10),             -- Khóa ngoại: Tham chiếu đến bảng LOAI_SAN_PHAM
    MaNCC        NVARCHAR(10),             -- Khóa ngoại: Tham chiếu đến bảng NHA_CUNG_CAP
    NgayCapNhat  DATETIME DEFAULT GETDATE(), -- Ngày/giờ cuối cùng cập nhật thông tin sản phẩm, mặc định là thời gian hiện tại

    CONSTRAINT FK_SP_LoaiSP FOREIGN KEY (MaLoai) REFERENCES LOAI_SAN_PHAM(MaLoai),
    CONSTRAINT FK_SP_NCC FOREIGN KEY (MaNCC) REFERENCES NHA_CUNG_CAP(MaNCC)
);
GO

-- 6. Bảng DON_HANG
CREATE TABLE DON_HANG (
    MaDH                 NVARCHAR(20) PRIMARY KEY, -- Khóa chính: Mã đơn hàng
    MaKH                 NVARCHAR(10),             -- Khóa ngoại: Tham chiếu đến bảng KHACH_HANG (có thể null nếu là khách vãng lai)
    MaNV                 NVARCHAR(10),             -- Khóa ngoại: Tham chiếu đến bảng NHAN_VIEN (người tạo đơn hàng)
    NgayTao              DATETIME DEFAULT GETDATE(), -- Ngày và giờ tạo đơn hàng, mặc định là thời gian hiện tại
    TongTien             DECIMAL(18, 2) NOT NULL,  -- Tổng số tiền của đơn hàng
    TrangThai            NVARCHAR(50) NOT NULL,    -- Trạng thái của đơn hàng
    PhuongThucThanhToan  NVARCHAR(50),             -- Phương thức thanh toán
    GiamGia              DECIMAL(18, 2) DEFAULT 0, -- Tổng số tiền giảm giá áp dụng cho đơn hàng, mặc định 0

    CONSTRAINT FK_DH_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
    CONSTRAINT FK_DH_NV FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV)
);
GO

-- 7. Bảng CHI_TIET_DON_HANG
CREATE TABLE CHI_TIET_DON_HANG (
    MaCTDH      BIGINT IDENTITY(1,1) PRIMARY KEY, -- Khóa chính: Mã chi tiết đơn hàng (sử dụng IDENTITY để tự tăng)
    MaDH        NVARCHAR(20) NOT NULL,            -- Khóa ngoại: Tham chiếu đến bảng DON_HANG
    MaSP        NVARCHAR(10) NOT NULL,            -- Khóa ngoại: Tham chiếu đến bảng SAN_PHAM
    SoLuong     INT NOT NULL,                     -- Số lượng sản phẩm trong dòng này
    DonGia      DECIMAL(18, 2) NOT NULL,          -- Giá bán của sản phẩm tại thời điểm bán (quan trọng vì giá có thể thay đổi)
    ThanhTien   DECIMAL(18, 2) NOT NULL,          -- Tổng tiền của dòng này (SoLuong * DonGia)

    CONSTRAINT FK_CTDH_DH FOREIGN KEY (MaDH) REFERENCES DON_HANG(MaDH),
    CONSTRAINT FK_CTDH_SP FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP),
    CONSTRAINT UQ_MaDH_MaSP UNIQUE (MaDH, MaSP) -- Đảm bảo cặp MaDH và MaSP là duy nhất (khóa tổng hợp logic)
);
GO

-- 8. Bảng PHIEU_NHAP_KHO
CREATE TABLE PHIEU_NHAP_KHO (
    MaPN         NVARCHAR(20) PRIMARY KEY, -- Khóa chính: Mã phiếu nhập
    MaNCC        NVARCHAR(10),             -- Khóa ngoại: Tham chiếu đến bảng NHA_CUNG_CAP
    MaNV         NVARCHAR(10),             -- Khóa ngoại: Tham chiếu đến bảng NHAN_VIEN (người tạo phiếu nhập)
    NgayNhap     DATETIME DEFAULT GETDATE(), -- Ngày và giờ nhập hàng, mặc định là thời gian hiện tại
    TongTienNhap DECIMAL(18, 2) NOT NULL,  -- Tổng giá trị của phiếu nhập
    GhiChu       NVARCHAR(255),            -- Ghi chú (có thể null)

    CONSTRAINT FK_PNK_NCC FOREIGN KEY (MaNCC) REFERENCES NHA_CUNG_CAP(MaNCC),
    CONSTRAINT FK_PNK_NV FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV)
);
GO

-- 9. Bảng CHI_TIET_PHIEU_NHAP
CREATE TABLE CHI_TIET_PHIEU_NHAP (
    MaCTPN       BIGINT IDENTITY(1,1) PRIMARY KEY, -- Khóa chính: Mã chi tiết phiếu nhập (sử dụng IDENTITY để tự tăng)
    MaPN         NVARCHAR(20) NOT NULL,            -- Khóa ngoại: Tham chiếu đến bảng PHIEU_NHAP_KHO
    MaSP         NVARCHAR(10) NOT NULL,            -- Khóa ngoại: Tham chiếu đến bảng SAN_PHAM
    SoLuongNhap  INT NOT NULL,                     -- Số lượng sản phẩm nhập vào
    DonGiaNhap   DECIMAL(18, 2) NOT NULL,          -- Giá nhập của sản phẩm tại thời điểm nhập
    ThanhTienNhap DECIMAL(18, 2) NOT NULL,         -- Tổng tiền của dòng này

    CONSTRAINT FK_CTPN_PNK FOREIGN KEY (MaPN) REFERENCES PHIEU_NHAP_KHO(MaPN),
    CONSTRAINT FK_CTPN_SP FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP),
    CONSTRAINT UQ_MaPN_MaSP UNIQUE (MaPN, MaSP) -- Đảm bảo cặp MaPN và MaSP là duy nhất (khóa tổng hợp logic)
);
GO
  - Chuỗi kết nối cấu hình trong `App.config`:
    <connectionStrings>
      <add name="QuanLyBachHoaEntities" connectionString="metadata=res://*/...;provider=System.Data.SqlClient;provider connection string=&quot;data     source=YOUR_SERVER;initial catalog=YOUR_DATABASE;integrated security=True;MultipleActiveResultSets=True&quot;" providerName="System.Data.EntityClient" />
    </connectionStrings>
    
- **Cấu trúc thư mục:**
  - `Forms/` - Các form giao diện người dùng
  - `Services/` - Các lớp xử lý nghiệp vụ và truy xuất dữ liệu
  - `Models/` - Các lớp thực thể ánh xạ với bảng dữ liệu (nếu có)
  - `App.config` - File cấu hình ứng dụng

---

## Liên hệ

- Tác giả: Đức Lợi
- Email: ndlgaming2004@gmail.com
- Github: https://github.com/DucLoi24

---

> **Lưu ý:** Đây là dự án mẫu phục vụ học tập, vui lòng kiểm tra và chỉnh sửa thông tin cấu hình phù hợp với môi trường của bạn trước khi sử dụng.
