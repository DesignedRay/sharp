using System;
using System.IO;
using System.Linq;

namespace sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "", y = "";
            string userInput = Console.ReadLine();
            for (int i = 0,j=99; i < userInput.Length; i++)
            {
                if (!(userInput[i] == 'd'))
                {
                    if (i < j)
                    {
                        x += Convert.ToString(userInput[i]);
                    }
                    else if (i > j)
                    {
                        y += Convert.ToString(userInput[i]);
                    }
                }
                else
                {
                    j = i;
                }
            }
            Console.WriteLine("{0}-{1}",x,int.Parse(x)*int.Parse(y));
        }
    }
}
