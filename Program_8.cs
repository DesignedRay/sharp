using System;
using System.IO;

namespace sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = TryInputInt();
            int x2 = TryInputInt();
            String userInput = Console.ReadLine();
            switch (userInput)
            {
                default:
                    Console.WriteLine("An incorrect expression was entered...");
                    break;
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
			    case "//":
                    Console.WriteLine(x1 % x2);
                    break;
            }
            Console.ReadKey();
        }
        static public int TryInputInt() {
            string x = Console.ReadLine();
            if (int.TryParse(x, out int result))
            {
                return int.Parse(x);
            }
            else
            {
                Console.WriteLine("Строка не являеться числом преобразовано в 0");
                return 0; 
            }
        }
    }
}
