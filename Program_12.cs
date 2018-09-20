using System;
using System.IO;
using System.Linq;

namespace sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] en_al = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            char userInput = char.Parse(Console.ReadLine());
            for (int i = 0; i < en_al.Length; i++)
            {
                if (en_al[i] == userInput)
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }
        }
    }
}
