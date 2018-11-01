using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Символы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату в формате ДД.ММ.ГГ : ");
            string sUserDate = Console.ReadLine();
            Console.WriteLine("Вывести информацию о дате? (+/-) ");
            CheckDate(Console.ReadLine(),sUserDate);
            Console.WriteLine("Был произведен выход из режима цикла (Please enter...)");
            Console.ReadKey();
        }

        static void CheckDate(string check,string sUserDate)
        {
            string[] moth = { "January" , "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};


            if (check == "+")
            {
                string[] split = sUserDate.Split('.');
                ////////////////////////////////////////
                Console.WriteLine(moth[int.Parse(split[1]) - 1]);
                Console.WriteLine( (int.Parse(split[2])%4 == 0) ? "Високосный" : "Не високосный" );
                Console.Write("Желаете продолжить? (+/-) ");
                CheckDateWhile(Console.ReadLine(),sUserDate);
            }
        }

        static void CheckDate(string check,string sUserDate , string sUserDateWhile)
        {
            string[] moth = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


            if (check == "+")
            {
                string[] split = sUserDate.Split('.');
                string[] split_2 = sUserDateWhile.Split('.');
                ////////////////////////////////////////
                Console.WriteLine(moth[int.Parse(split_2[1]) - 1]);
                Console.WriteLine((int.Parse(split[2]) % 4 == 0) ? "Високосный" : "Не високосный");
                Console.WriteLine("Разница в годах : " + Math.Abs(int.Parse(split_2[2]) - int.Parse(split[2])));
                Console.WriteLine("Желаете продолжить? (+/-) ");
                CheckDateWhile(Console.ReadLine(),sUserDateWhile);
            }
        }

        static void CheckDateWhile(string check,string sUserDate)
        {
            if (check == "+")
            {
                Console.Write("Введите дату в формате ДД.ММ.ГГ :");
                string sUserDateWhile = Console.ReadLine();
                Console.WriteLine("Вывести информацию о дате и сравнить с предыдущей? (+/-)");
                CheckDate(Console.ReadLine(), sUserDate, sUserDateWhile);
            }
        }
    }
}
