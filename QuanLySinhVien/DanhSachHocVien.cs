using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class DanhSachHocVien
    {
        private List<HocVien> list = new List<HocVien> { };

        public void Nhap()
        {
            
            Console.WriteLine("Số lượng sinh viên nhập thêm : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                HocVien hv = new HocVien();
                Console.WriteLine("Nhập thông tin sinh viên thứ {0}:",i+1);
                hv.Nhap();
                list.Add(hv);
            }
                
                
        }

        public void Xuat()
        {
            foreach(var item in list)
            {
                item.Xuat();
            }
        }

        public void TimKiemTheoKhoangDiem()
        {
            float min, max;
            Console.Write("Nhap khoang diem tu : ");
            min = Convert.ToSingle(Console.ReadLine());

            Console.Write("Den khoang : ");
            max = Convert.ToSingle(Console.ReadLine());

            foreach(var item in list)
            {
                if(item.Diem >= min && item.Diem <= max)
                {
                    item.Xuat();
                }
            }
        }

        public void TimKiemTheoHocLuc()
        {
            Console.Write("Nhap hoc luc can tim: ");
            string hocLuc = Console.ReadLine();

            Console.WriteLine($"Nhung sinh vien co hoc luc {hocLuc} : ");
            foreach(var item in list)
            {
                if (item.GetHocLuc().Equals(hocLuc, StringComparison.OrdinalIgnoreCase))
                {
                    item.Xuat();
                }
            }
        }

        public void TimVaCapNhatTheoMa()
        {
            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine();

            foreach(var item in list)
            {
                if(item.Ma == ma)
                {
                    item.Nhap();
                    break;
                }
            }

        }

        public void SapXepTheoDiem()
        {
            list.Sort((a,b) => (int)(a.Diem - b.Diem));
        }

        public void XuatTop5()
        {
            list.Sort((a, b) => (int)(b.Diem - a.Diem));
            for(int i = 0; i < 5 && i < list.Count; i++)
            {
                list[i].Xuat();
            }
        }

        public void HocVienTrenTrungBinh()
        {
            foreach (var item in list)
            {
                if (item.Diem > 5)
                {
                    item.Xuat();
                }
            }

        }

        public void SoHocSinhTheoHocLuc()
        {
            int a = 0, b = 0, c = 0, d = 0, e= 0;

            foreach (var item in list)
            {
                if (item.GetHocLuc().Equals("Yeu", StringComparison.OrdinalIgnoreCase))
                {
                    a++;
                } 
                else if (item.GetHocLuc().Equals("Trung Binh", StringComparison.OrdinalIgnoreCase))
                {
                    b++;
                }
                else if (item.GetHocLuc().Equals("Kha", StringComparison.OrdinalIgnoreCase))
                {
                    c++;
                }
                else if (item.GetHocLuc().Equals("Gioi", StringComparison.OrdinalIgnoreCase))
                {
                    d++;
                }
                else if (item.GetHocLuc().Equals("Xuat sac", StringComparison.OrdinalIgnoreCase))
                {
                    e++;
                }
            }

            Console.WriteLine($"So sinh vien hoc luc yeu: {a}");
            Console.WriteLine($"So sinh vien hoc luc trung binh: {b}");
            Console.WriteLine($"So sinh vien hoc luc kha: {c}");
            Console.WriteLine($"So sinh vien hoc luc gioi: {d}");
            Console.WriteLine($"So sinh vien hoc luc suat sac: {e}");

        }

    }
}
