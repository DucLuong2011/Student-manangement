using System;
using System.Text;

namespace QuanLySinhVien
{
    class Program
    {

        static void Main(String[] args)
        {
            DanhSachHocVien dshv = new DanhSachHocVien();
            Console.OutputEncoding = Encoding.UTF8; // In ra màn hình có
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (true)
            {
                Console.WriteLine("========== QUẢN LÝ SINH VIÊN ==========");
                Console.WriteLine("1. Nhập thông tin sinh viên");
                Console.WriteLine("2. Danh sách sinh viên");
                Console.WriteLine("3. Tìm kiếm theo khoảng điểm");
                Console.WriteLine("4. Tim kiếm theo học lực");
                Console.WriteLine("5. Cập nhập thông tin sinh viên");
                Console.WriteLine("6. Sắp xếp điểm tăng dần");
                Console.WriteLine("7. Hiển thị 5 sinh viên điểmn cao nhất");
                Console.WriteLine("8. Những sinh viên điêm trên trung bình");
                Console.WriteLine("9. Tổng số học sinh theo học lực");
                Console.WriteLine("0. Thoát Chương trình");
                Console.WriteLine("=======================================");
                Console.Write("Vui lòng chọn chức năng:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("\n~ Cảm ơn bạn đã sủ dụng chương trình ~");
                        return;//thoát vòng lập 
                        break;
                    case 1:
                        dshv.Nhap();
                        break;
                    case 2:
                        dshv.Xuat();
                        break;
                    case 3:
                        dshv.TimKiemTheoKhoangDiem();
                        break;
                    case 4:
                        dshv.TimKiemTheoHocLuc();
                        break;
                    case 5:
                        dshv.TimVaCapNhatTheoMa();
                        break;
                    case 6:
                        dshv.SapXepTheoDiem();
                        dshv.Xuat();
                        break;
                    case 7:
                        dshv.XuatTop5();
                        break;
                    case 8:
                        dshv.HocVienTrenTrungBinh();
                        break;
                    case 9:
                        dshv.SoHocSinhTheoHocLuc();
                        break;

                }



            }

        } 

    }
}
