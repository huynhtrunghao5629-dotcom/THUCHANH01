using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai5
    {
        public void Chaybai5()
        {
            int luachon = 0;
            double x = 0;
            double y = 0;
            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Nhap 2 gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang : ");
                if (!int.TryParse(Console.ReadLine(), out luachon))
                {
                    Console.WriteLine("Vui long nhap so nguyen tu 1 den 4.");
                    continue;
                }
                switch(luachon)


          {

          case 1:
                        Console.Write("Nhap x: ");
                        double.TryParse(Console.ReadLine(), out x);
                        Console.Write("Nhap y: ");
                        double.TryParse(Console.ReadLine(), out y);
                        break;
                    case 2:
                        Console.WriteLine($"Ket qua {x}^{y} = {Math.Pow(x, y)}");
                        break;
                    case 3:
                        if (x >= 0) Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}");
                        else Console.WriteLine($"Khong the tinh can bac 2 cua {x} vi no la so am.");
                        if (y >= 0) Console.WriteLine($"Can bac 2 cua {y} = {Math.Sqrt(y)}");
                        else Console.WriteLine($"Khong the tinh can bac 2 cua {y} vi no la so am.");
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Chuc nang khong hop le. Vui long chon tu 1 den 4.");
                        break;
                    }
                } while (luachon != 4) ;
            }
            

    }
    }

