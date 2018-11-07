// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран.
// б) Добавить обработку исключений на то, что могут быть введены не корректные данные.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int all = 0;
            int userInput = 0;


            try {
             userInput = int.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("FormatException");
                userInput = -1;
            }




            while (!(userInput == 0))
            {
                if(userInput > 0 && (userInput % 2) == 1) all += userInput;
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException");
                    userInput = -1;
                }
            }

            Console.WriteLine(all);
        }
    }
}
