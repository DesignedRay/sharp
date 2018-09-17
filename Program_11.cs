using System;
using System.IO;

namespace sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string activaitionKey = File.ReadAllText("key.txt");
            string[] keysBrut = File.ReadAllLines("brut.txt");
            for (int i = 0; i < keysBrut.Length ; i++)
            {
                Console.WriteLine("Attempt {0} ...",i+1);
                if (activaitionKey == keysBrut[i])
                {
                    Console.WriteLine(" {0}  - подтвержден , программа завершила работу.", keysBrut[i]);
                    break;
                }
                else Console.WriteLine(" {0}  - не подтвержден", keysBrut[i]);
            }
        }
    }
}
