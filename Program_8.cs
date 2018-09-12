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
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Аргументов 1/2");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Аргументов 2/2");
                String userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "+":
                        Console.WriteLine(x1 + x2);
                        break;
                    case "-":
                        Console.WriteLine(x1 - x2);
                        break;
                    case "*":
                        Console.WriteLine(x1 * x2);
                        break;
                    case "/":
                        Console.WriteLine(x1 / x2);
                        break;
            }
        }
    }
}
