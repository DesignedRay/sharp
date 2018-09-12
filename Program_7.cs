using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            const String pass = "1234";
            while (true)
            {
                if (Console.ReadLine() == pass) {
                    Console.WriteLine(1);
                    break;
                }
                else Console.WriteLine(0);
            }
        }
    }
}
