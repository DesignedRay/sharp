using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpModified
{
    class Program
    {
        static void Main(string[] args)
        {
            long userInputSeconds = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine((userInputSeconds /60 % 1440 / 60) + " : " + (userInputSeconds / 60 % 60) + " : " + (userInputSeconds % 60));
        }
    }
}
