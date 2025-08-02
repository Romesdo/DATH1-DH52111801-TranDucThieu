# Đồ Án Tin Học - DH52111801 - Trần Đức Thiều

## Thông tin chung
- **Trường:** Đại học Công nghệ Sài Gòn
- **Niên khóa:** 2023 - 2024
- **Tên sinh viên:** Trần Đức Thiều
- **Chủ đề:** Hệ thống Quản lý Nhà hàng và Đồ uống (F&B)

## Giới thiệu chi tiết về dự án
Dự án "Quản lý F&B" là một ứng dụng được phát triển để hỗ trợ quản lý các hoạt động trong lĩnh vực nhà hàng hoặc quán cà phê. Dự án được thực hiện bằng ngôn ngữ C# với nền tảng .NET, sử dụng giao diện Windows Forms. Hệ thống bao gồm các chức năng cơ bản như:
- Quản lý danh sách thực đơn.
- Theo dõi đơn hàng và thanh toán.
- Quản lý nhân viên
- Báo cáo doanh thu và thống kê hàng tồn kho.

## Cấu trúc thư mục (Quan_Ly_F&B)
- **/Properties:** Chứa các tệp cấu hình và tài nguyên của dự án (ví dụ: `AssemblyInfo.cs`, `Resources.resx`).
- **/bin/Debug:** Thư mục chứa tệp thực thi sau khi biên dịch (ví dụ: `Quan_Ly_F&B.csproj`).
- **/obj/Debug:** Thư mục tạm thời cho quá trình biên dịch.
- **App.config:** Tệp cấu hình ứng dụng.
- **CBill.cs:** Lớp quản lý hóa đơn.
- **CMenu.cs:** Lớp quản lý thực đơn.
- **CNhanVien.cs:** Lớp quản lý thông tin nhân viên.
- **COrder.cs:** Lớp quản lý đơn hàng.
- **Program.cs:** Điểm nhập của ứng dụng.
- **fLogin.resx, fMenuDesigner.cs, fMenu.cs, fMenu.resx:** Form đăng nhập và quản lý thực đơn (giao diện và tài nguyên).
- **fNotification.Designer.cs, fNotification.cs, fNotification.resx:** Form thông báo (giao diện và tài nguyên).
- **fPOSOrder.Designer.cs, fPOSOrder.cs, fPOSOrder.resx:** Form đặt hàng POS (giao diện và tài nguyên).
- **fRevenue.Designer.cs, fRevenue.cs, fRevenue.resx:** Form báo cáo doanh thu (giao diện và tài nguyên).
- **fStaff.Designer.cs, fStaff.cs, fStaff.resx:** Form quản lý nhân viên (giao diện và tài nguyên).
  
## Hướng dẫn cài đặt và chạy
1. **Clone repository:**
- git clone https://github.com/Romesdo/DATH1-DH52111801-TranDucThieu.git
- cd Quan_Ly_F&B
2. **Cài đặt môi trường:**
- Cài đặt Visual Studio (phiên bản hỗ trợ .NET Framework).
- Khôi phục các gói NuGet nếu có (nếu có file `.csproj`).
3. **Mở dự án:**
- Mở file `Quan_Ly_F&B.csproj` trong Visual Studio.
4. **Chạy ứng dụng:**
- Nhấn F5 hoặc Build > Run trong Visual Studio.
5. **Yêu cầu hệ thống:** Visual Studio 2019/2022, .NET Framework 4.7.2 hoặc cao hơn.

## Tính năng nổi bật
- **Quản lý đăng nhập:** Hỗ trợ đăng nhập cho nhân viên.
- **Quản lý thực đơn:** Thêm, sửa, xóa món ăn/thức uống.
- **Đặt hàng POS:** Theo dõi và xử lý đơn hàng trực tiếp.
- **Quản lý nhân viên:** Lưu trữ và quản lý thông tin nhân viên.
- **Báo cáo doanh thu:** Thống kê doanh thu theo thời gian.
- **Thông báo:** Hiển thị thông tin quan trọng cho người dùng.

## Hướng dẫn đóng góp
- Fork repository này.
- Tạo branch mới: `git checkout -b ten-tinh-nang`.
- Commit thay đổi: `git commit -m "Mô tả thay đổi"`.
- Push lên branch: `git push origin ten-tinh-nang`.
- Tạo Pull Request để hợp nhất code.

## Liên hệ
- **Tác giả:** Trần Đức Thiều
- **Email:** ducthieu1606@gmail.com

## Lưu ý
- Dự án này là sản phẩm học tập, vui lòng không sử dụng cho mục đích thương mại nếu không được phép.
- Đóng góp hoặc phản hồi xin gửi qua ducthieu1606@gmail.com.
- Phiên bản hiện tại có thể chưa hoàn thiện, mọi phản hồi đều được chào đón.
