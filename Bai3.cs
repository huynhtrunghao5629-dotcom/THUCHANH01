using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace THUCHANH01
{
    public class Bai3
    {
        public void Chaybai3()
        {
            Console.Write("Nhap so nguyen x: ");
            string inputX = Console.ReadLine();
            Console.Write("Nhap so nguyen y: ");
            string inputY = Console.ReadLine();
            bool isValidX = int.TryParse(inputX, out int x);
            bool isValidY = int.TryParse(inputY, out int y);
            if (isValidX && isValidY)
            {
                Console.WriteLine($"Ket qua {x} mu {y} la : {Math.Pow(x, y)}");
            }
            else
            {
                Console.WriteLine("Gia tri nhap khong phai so nguyen !");
            }
        }
    }
}
