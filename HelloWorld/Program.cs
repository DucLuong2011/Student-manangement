using System;
using System.Text;
using OPP;

namespace HelloWorld
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Hello World
            /*
            Console.Title = "My First In C#";
            Console.WriteLine("Hello World ! My name is Luong...\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("***************************");
            Console.WriteLine("**     0 0 0    0 0 0    **");
            Console.WriteLine("**   0 0 0 0 0 0 0 0 0   **");
            Console.WriteLine("** 0 0 0 0 0 0 0 0 0 0 0 **");
            Console.WriteLine("** 0 0 0 0 0 0 0 0 0 0 0 **");
            Console.WriteLine("**   0 0 0 0 0 0 0 0 0   **");
            Console.WriteLine("**     0 0 0 0 0 0 0     **");
            Console.WriteLine("**       0 0 0 0 0       **");
            Console.WriteLine("**         0 0 0         **");
            Console.WriteLine("**           0           **");
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            */
            #endregion

            #region Demo ATM
            
            string password = "1";
            long ballance = default;// So du
            bool isLogin = false;//dang nhap
            long amount = default;// so luong
            int choice = default;// su lua chon
            string format = " ";

            Console.OutputEncoding = Encoding.Unicode;// in ra màn hình có dấu

            while (true)
            {
                Console.WriteLine("=========> CHOICE PROGRAM <=========");
                Console.WriteLine("1. Đăng nhập vào tài khoản");
                Console.WriteLine("2. Rút tiền");
                Console.WriteLine("3. Nạp tiền");
                Console.WriteLine("4. Kiểm tra số dư");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("=========>    THE END     <=========");
                Console.Write("Mời bạn chọn chương trình :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Xin cam on ban da su dung chuong trinh :))");
                        return;//thoat vong lap vo han      

                    case 1:
                        if (isLogin)
                        {
                            Console.WriteLine("ban da dang nhap vao tk...");
                        }
                        else
                        {
                            Console.WriteLine("Vui long nhap mat khau");
                            var userPassword = Console.ReadLine();

                            if (userPassword.CompareTo(password) == 0)
                            {
                                Console.WriteLine("Dang Nhap Thanh Cong");
                                isLogin = true;
                            }
                            else
                            {
                                Console.WriteLine("Sai mat khau ! vui long nhap lai");
                            }

                        }
                        break;
                    case 2:
                        if (isLogin)
                        {
                            bool isWithdrawable = true;
                            int option = default;
                            Console.WriteLine("Chon so tien can rut");
                            Console.WriteLine("1. 100k");
                            Console.WriteLine("2. 200k");
                            Console.WriteLine("3. 500k");
                            Console.WriteLine("4. 1000k");
                            Console.WriteLine("5. 2000k");
                            Console.WriteLine("6. Nhap mot so khac");
                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    amount = 100000;
                                    break;

                                case 2:
                                    amount = 200000;
                                    break;

                                case 3:
                                    amount = 500000;
                                    break;

                                case 4:
                                    amount = 1000000;
                                    break;

                                case 5:
                                    amount = 2000000;
                                    break;

                                case 6:
                                    Console.WriteLine("Nhap so tien can rut la boi so cua 10k:");
                                    amount = int.Parse(Console.ReadLine());
                                    if (amount % 10000 != 0)
                                    {
                                        Console.WriteLine("Vui long nhap so tien la boi so cua 10k!");
                                        amount = 0;
                                        isWithdrawable = false;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Sai tuy chon, vui long nhap lai!");
                                    break;
                            }
                            if (isWithdrawable)
                            {
                                if (ballance > amount)
                                {
                                    ballance -= amount;
                                    amount.ToString("N");// format number
                                    string format1 = string.Format("{0:N0}",amount);
                                    ballance.ToString("N");
                                    format = string.Format("{0:N0}", ballance);
                                    Console.WriteLine($"Ban da rut {format1}d");
                                    Console.WriteLine($"So tien trong TK hien tai la: {format}d");
                                }
                                else
                                {
                                    Console.WriteLine("So du cua ban khong du");
                                }

                            }
                           
                        } 
                        else
                        {
                            Console.WriteLine("Vui long dang nhap!");
                        }
                        break;

                    case 3:
                        if (isLogin)
                        {
                            Console.WriteLine("Nhap so tien muon nap vao TK: ");
                            amount = long.Parse(Console.ReadLine());
                            if (amount > 0)
                            {
                                ballance += amount;
                                amount = 0;
                                Console.WriteLine("Nap tien vao TK thanh cong!");
                            }
                            else
                            {
                                Console.WriteLine("So tien can nap khong hop le, vui long kiem tra lai!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    case 4:
                        if (isLogin)
                        {
                            ballance.ToString("N");
                            format = string.Format("{0:N0}", ballance);
                            Console.WriteLine($"So tien trong TK cua ban hien tai la: {format} VND");
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    default:
                        Console.WriteLine("Ban chon sai , vui long chon lai !");
                        break;
                }
            }
            
            #endregion

            #region Array
            /*
            int[] numbers = { 1, 7, 5, 1, 8, 0, 6, 2, 9, 4, 8, 6, 3 };
            string[] names = { "luong", "phong", "minh", "duy", "dung", "khanh" };

            //Array.Sort(numbers);//tang dan cac gia tri trong mang
            //Array.Reverse(names);//dao nguoc cac phan tu trong mang
            Array.Clear(numbers, 0, numbers.Length); //set cac phan tu trong mang = 0

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            */
            #endregion

            #region method + out / ref / params

            // =======> out khong nhat thiet khai bao ben ngoai  
            /*
            getUserInfo(out string name, out int age, out float mark);
            showInfo(name, age, mark);
            */

            // =======> ref phai khai bao ben ngoai r goi
            /*
            string name2 = " ";
            int age2 = 0;
            float mark2 = 0;

            getUserInfo2(ref name2, ref age2,ref mark2);

            showInfo( name2, age2, mark2);
            */


            // =======> farams

            //float[] marks = { 5, 8.2f, 9, 4.2f, 6, 7, 9.8f };
            //float math = 9;
            //float bio = 8.5f;
            //float vi = 3;
            //float it = 6.9f;

            //float avg = Avg(math, bio, vi, 6, 9.6f); // co the cho nhieu float hoac so hon

            //Console.WriteLine("Diem trung binh : " + avg);
            #endregion

            #region Hướng đối tượng OOP
            /*
            Person person1 = new Person();
            person1.Name = "Tran Duc Luong";
            person1.Age = 20;
            person1.SayName();

            var person2 = new Person("Nguyen Vu Phong",12);
            person2.SayName();
            */

            
            
            
            #endregion



        }
        /// <summary>
        /// Tính điểm trung bình
        /// </summary>
        /// <param name="marks">....</param>
        /// <returns>Trả về điểm trung bình</returns>
        static float Avg(params float[] marks)
        {
            float sum = 0;
            foreach (var item in marks)
            {
                sum += item;
            }

            return (marks.Length == 0) ? 0 : sum / marks.Length;
        }

        
        private static void getUserInfo2(ref string name2,ref int age2, ref float mark2)
        {
            Console.WriteLine("Vui long nhap ten : ");
            name2 = Console.ReadLine();

            Console.WriteLine($"Nhap tuoi cua {name2} : ");
            age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Nhap diem cua {name2} : ");
            mark2 = Convert.ToSingle(Console.ReadLine());
        }

        private static void showInfo(string name, int age, float mark)
        {
            Console.Write($"Name : {name}\t");
            Console.Write($"Age : {age}\t");
            Console.Write($"Mark : {mark}\n");
        }

        private static void getUserInfo(out string name,out  int age,out  float mark)
        {
            Console.WriteLine("Vui long nhap ten : ");
            name = Console.ReadLine();

            Console.WriteLine($"Nhap tuoi cua {name} : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Nhap diem cua {name} : ");
            mark = Convert.ToSingle(Console.ReadLine());

        }
    }
}


