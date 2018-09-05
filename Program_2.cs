using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[0] == arr[1] || arr[0] == arr[2])
            {
                if (arr[1] == arr[2]) Console.WriteLine("3");
                else Console.WriteLine("2");
            }
            else if (arr[1] == arr[2])
            {
                if (arr[0] == arr[1] || arr[0] == arr[2]) Console.WriteLine("3");
                else Console.WriteLine("2");
            }
            else Console.WriteLine("0");
        }
    }
}
