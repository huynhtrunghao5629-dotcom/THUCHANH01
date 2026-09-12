using System;
namespace THUCHANH01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Bai1 b1 = new Bai1();
            //b1.Chaybai1();
            //Bai2 bai2 = new Bai2();
            //bai2.Chaybai2();
            //Bai3 bai3 = new Bai3();
            //bai3.Chaybai3();
            //Bai5 b5 = new Bai5();
            //b5.Chaybai5();
            Bai6_9 baiTap = new Bai6_9();
            Console.WriteLine("- Test bai 6 -");
            int maxBai6 = baiTap.max(15, 8, 4);
            Console.WriteLine($"So lon nhat la : {maxBai6}");

            Console.WriteLine("- Test bai 7 -");
            int soCanKiemTra = 29;
            bool SNT = baiTap.kiemtrasnt(soCanKiemTra);
            Console.WriteLine($"So {soCanKiemTra} co phai la so nguyen to khong ? : {SNT}");
            Console.WriteLine("- Test bai 8 (ref) -");
            double x = 5.5;
            double y = 9.9;
            Console.WriteLine($"Truoc hoan vi: x = {x}, y = {y}");
            baiTap.hoanvi(ref x, ref y);
            Console.WriteLine($"Sau hoan vi: x = {x}, y = {y}");
            Console.WriteLine("- Test bai 9 (out) -");
            double a = 3.3, b = 7.7, c = 1.1;
            double min, max;
            baiTap.timminmax(a, b, c, out min, out max);
            Console.WriteLine($"Gia tri nho nhat la: {min}, Gia tri lon nhat la: {max}");


            Console.ReadLine();
        }
    }
}
