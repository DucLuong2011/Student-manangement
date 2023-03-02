using System;

namespace Exception
{
    internal class Program
    {
        public static void Main(String[] args)
        {

            #region Ex3 Special
            /*
            int a, b;
            int c, chosse;
            Console.Title = " My First App In C# ";
            Console.ForegroundColor = ConsoleColor.Green;

            
            do
            {
                Console.WriteLine();
                string oder = "oder menu";
                oder = oder.ToUpper();
                Console.WriteLine("*********{0}********", oder);
                Console.WriteLine("** 1. Summation \t**");
                Console.WriteLine("** 2. Permission \t**");
                Console.WriteLine("** 3. Multiple \t\t**");
                Console.WriteLine("** 4. Dividesion \t**");
                Console.WriteLine("** 5. Out \t\t**");
                Console.WriteLine("***********END***********");
                Console.Write("Your menu :");
                chosse = Convert.ToInt32(Console.ReadLine());
                switch (chosse)
                {
                    case 1:
                        Console.Write("Import number one :");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Import number two :");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("Summation of {0} and {1} is: {2}",a,b,c);
                        break;
                    case 2:
                        Console.Write("Import number one :");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Import number two :");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine("Permission of {0} and {1} is: {2}", a, b, c);
                        break;
                    case 3:
                        Console.Write("Import number one :");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Import number two :");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine("Multiple of {0} and {1} is: {2}", a, b, c);
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Import number one :");
                            a = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Import number two :");
                            b = Convert.ToInt32(Console.ReadLine());
                            c = a / b;
                            Console.WriteLine("Dividesion of {0} and {1} is: {2}", a, b, c);
                        } catch(DivideByZeroException dbze)
                        {
                            Console.WriteLine(" Cannot divide by Zero");
                        }
                        break;
                }
            } while (chosse <=4);
            Console.WriteLine("You out program");
            */
            #endregion

            #region Ex 4
            /*
            int a;
            int mul;
            Console.Write("Bảng nhân : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0} x {1} = {2}",i,a,(i*a));
            }
            */

            /*
            int a;
            int sum1 = 0;
            int sum2 = 0;
            Console.Write("Tong cac so le va chan tu 1 den ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= a; i++)
            {
                if(i % 2 == 0)
                {
                    sum1 = sum1 + i;
                    continue;
                }
                Console.Write(i + " ");
                sum2 = sum2 + i;
            }

            Console.WriteLine();
            Console.WriteLine("Tong cac so le la : {0}", sum2);
            Console.WriteLine("Tong cac so chan la : {0}", sum1);
            */

            /*Ex ...
            int a,b,c,d,e;
            Console.Write("Import number one:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Import number two:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Import number three:");
            c = Convert.ToInt32(Console.ReadLine());

            e = (a + b + c ) / 3;

            Console.WriteLine("result = {0}", e);

            if(e <= 8)
            {
                Console.WriteLine("Congratulations ban dat loai gioi : " + e + " point");
            } 
            else if(e <= 5)
            {
                Console.WriteLine("Congratulations ban dat loai kha : " + e + " point");
            }
            else
            {
                Console.WriteLine("Ban dat loai yeu : " + e + " point");
            }
            */
            #endregion

            #region ARRAY

            /*
            int i, a;
            Console.ForegroundColor = ConsoleColor.Green;// doi mau cua so cmd
            Console.Write("\nDoc va in cac phan mang trong C#:\n");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap so phan tu mang:\n");
            a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Phan tu - {0} : ", i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nIn cac phan tu mang: ");
            for (i = a-1; i >= 0; i--)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            int sum = 0;
            for (i = 0; i < a; i++)
            {
                sum += arr[i];
            }
            Console.Write("Tong cac phan tu : {0}", sum);

            Console.ReadKey();
            */

            /*
            int i, a;
            Console.ForegroundColor = ConsoleColor.Green;// doi mau cua so cmd
            Console.Write("\nSao chep cac phan mang trong C#:\n");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap so phan tu mang:\n");
            a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            
            for (i = 0; i < a; i++)
            {
                Console.Write("Phan tu - {0} : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Dang sao chep ....");
            int[] arr1 = new int[a];
            for (i = 0; i < a; i++)
            {
                    arr1[i] = arr[i];
            }
            for (i = 0; i < a; i++)
            {
                Console.Write("phan tu [i] : {0}  ", arr[i]);
            }
            Console.WriteLine("complete! An nut bat ky....");
            for (i= 0; i < a; i++)
            {
                Console.Write("phan tu [j] : {0}  ", arr1[i]);
            }

            Console.Write("\n");


            Console.ReadKey();
            */


            /*
            int i, k = 1, j, side;
            Console.Write("\n");
            Console.Write("Ve tam giac sao trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            side = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= side; i++)
            {
                for (j = 1; j <= side; j++)
                {
                    if (i == 1 || i == side || j == 1 || j == side)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            
         

            Console.ReadKey();
            */

            /*
            int i, j, bien_dem, so_hang, k, t = 1;

            Console.Write("\n");
            Console.Write("Ve tam giac so can trong C# - cac so trong tam giac co thu tu tang dan:\n");
            Console.Write("-----------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            bien_dem = so_hang + 4 - 1;
            for(i = 1; i <= so_hang; i++)
            {
                for(k = bien_dem; k >=1; k--)
                {
                    Console.Write("k");
                }
                for(j = 1; j <= i; j++)
                {
                    Console.Write(" "+i);  
                }
                Console.Write("\n");
                bien_dem--;
            }

            Console.ReadKey();
            */

            /*
            int a, b, c, i,j,k;
            

            Console.Write("Nhap so luong phan tu cua mang 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[a];

            for (i = 0; i < a; i++)
            {
                Console.Write("Nhap phan tu {0} cua mang 1: ", i + 1);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Nhap so luong phan tu cua mang 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[b];
            for (i = 0; i < a; i++)
            {
                Console.Write("Nhap phan tu {0} cua mang 2: ", i + 1);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            c = a + b;
            int[] arr3 = new int[c];

            for (i = 0; i < a; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < b; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }
            for (i = 0; i < c; i++)
            {
                for (k = 0; k < c - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }
            for (i = 0; i < c; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
            */


            /*
            int[] arr1 = new int[10];
            int[] arr2 = new int[10]; // mang chua cac phan tu chan
            int[] arr3 = new int[10]; // mang chua cac phan tu le
            int i, j = 0, k = 0, n;


            Console.Write("\nChia mang thanh mang chan, mang le trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nCac phan tu le la:\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
            */

            /*
            int d;
            Console.Write("Nhap so phan tu arr : ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so phan tu arr1 : ");
            int[,] arr1 = new int[100, 100];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("Nhap phan tu [{0}][{1}] cua arr1 : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Nhap so phan tu arr2 : ");
            int[,] arr2 = new int[100,100];
            for(int i = 0; i < d; i++)
            {
                for(int j = 0; j < d; j++)
                {
                    Console.Write("Nhap phan tu [{0}][{1}] cua arr2 : ",i,j);
                    arr2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("In ra mang da chieu arr1 ...");
            Console.ReadKey();
            for(int i = 0; i < d; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < d; j++)
                {
                    Console.Write(" [{0}] ", arr1[i,j]);
                }
            }
            Console.Write("\n");

            Console.Write("In ra mang da chieu arr2 ...");
            Console.ReadKey();
            for (int i = 0; i < d; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < d; j++)
                {
                    Console.Write(" [{0}] ", arr2[i, j]);
                }
            }

            int[,] arr3 = new int[200,200];
            for (int i = 0; i < d ; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    arr3[i, j] = arr1[i,j] + arr2[i,j];
                }
                
            }
            Console.Write("\n");
            Console.WriteLine("In ra tong cua arr1 and arr2");

            Console.ReadKey ();
            for (int i = 0; i < d; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < d; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
                    
            }


            Console.ReadKey();
            */
            #endregion

            #region Ex1
            /*
            int i, j, n;
            int[,] arr1 = new int[10, 10];
            int[] tong_hang = new int[10];
            int[] tong_cot = new int[10];

            Console.Write("\nTinh tong cac hang va cac cot cua ma tran trong C#:\n ");
            Console.Write("------------------------------------------------\n");

            Console.Write("Nhap kich co ma tran vuong: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap cac phan tu vao trong ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("In ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }

            /* tinh tong cac hang 
            for (i = 0; i < n; i++)
            {
                tong_hang[i] = 0;
                for (j = 0; j < n; j++)
                    tong_hang[i] = tong_hang[i] + arr1[i, j];
            }

            /* tinh tong cac cot 
            for (i = 0; i < n; i++)
            {
                tong_cot[i] = 0;
                for (j = 0; j < n; j++)
                    tong_cot[i] = tong_cot[i] + arr1[j, i];
            }

            Console.Write("Tong cua cac hang va cac cot trong ma tran la:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}   ", arr1[i, j]);
                Console.Write("[{0}]    ", tong_hang[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < n; j++)
            {
                Console.Write("[{0}]   ", tong_cot[j]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
            */
            #endregion



        }


    }
}
