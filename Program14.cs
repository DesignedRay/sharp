using System;
using System.IO;
using System.Linq;

namespace sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double year = double.Parse(Console.ReadLine());
            year = ((((((year * 2 + 5) * 4 / 20) + 3) * 5) - 20) / year) + 5;
            Console.WriteLine((year == 7) ? "YES" : "NO");
        }
    }
}