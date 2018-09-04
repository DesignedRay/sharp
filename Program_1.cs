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
            int userTime = (Convert.ToInt32(Console.ReadLine())); // Считываем ввод пользователя
            int hourTime = userTime / 60; // Создаем переменную для вывода часов
            if (userTime < 1440) // Проверка переменной на валидность 
            {
                Console.WriteLine("\tCorrect time >> " + hourTime + " : " + (userTime % 60)); //Вывод в случае валидности
            }
            else if (userTime >= 1440) { 
                while (hourTime >= 24) {
                    hourTime -= 24;
                }
                Console.WriteLine("\tCorrect time >> " + hourTime + " : " + (userTime % 60)); //Вывод в случае невалидности
            } else {
                Console.WriteLine("Error..."); // Вывод в остальных случаях
            }
            Console.WriteLine("Succes");
        }
    }
}
