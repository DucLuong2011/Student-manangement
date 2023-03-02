using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class HocVien
    {
        public string Ma { get; set; }
        public string  HoTen { get; set; }
        public float Diem { get; set; }
        public string Email { get; set; }

        public HocVien()
        {

        }

        public HocVien(string ma , string hoTen , float diem , string email)
        {
            this.Ma = ma;
            this.HoTen = hoTen;
            this.Diem = diem;
            this.Email = email;
        }


        public void Nhap()
        {
            Console.Write("Ma hoc vien :");
            Ma = Console.ReadLine();
            Console.Write("Ho va ten hoc vien :");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem cua hoc vien :");
            Diem = Convert.ToSingle(Console.ReadLine());
            Console.Write("Email hoc vien :");
            Email = Console.ReadLine();

        }

        public void Xuat()
        {
            Console.WriteLine($"Ma: {Ma} / Ho va ten: {HoTen} / Email: {Email} / Diem: {Diem}" +
                              $" / Hoc luc: {GetHocLuc()}");
        }

        public string GetHocLuc()
        {
            string hocLuc = "Xuat sac";
            if(Diem < 5)
            {
                hocLuc = "Yeu";
            } 
            else if (Diem < 7)
            {
                hocLuc = "Trung Binh";
            }
            else if (Diem < 8)
            {
                hocLuc = "Kha";
            }
            else if (Diem < 9)
            {
                hocLuc = "Gioi";
            }

            return hocLuc;
        }













    }
}
