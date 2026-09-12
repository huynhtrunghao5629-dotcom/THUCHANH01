using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai6_9
    {
        public int max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        public bool kiemtrasnt(int n)
        {
            if(n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public void hoanvi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        public void timminmax(double a, double b, double c, out double min, out double max)
        {
            min = Math.Min(a, Math.Min(b, c));
            max = Math.Max(a, Math.Max(b, c));
        }
    }
}
