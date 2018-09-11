using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            double z = 0;
            int p = Convert.ToInt32(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            y = y + y * p / 100;
            x = x + x * p / 100;
            z = x*100 - (int)x*100;
            y += (int)z;
            if (y >= 100) c = y / 100;
            Console.WriteLine((x + c - z/100 ) + " " + (y - (c*100)));
        }
    }
}
