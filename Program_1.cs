using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int userTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tCorrect time >> " + (userTime < 1440 ? userTime/60 : (userTime % 1440)/60) + " : " + (userTime % 60));
        }
    }
}
