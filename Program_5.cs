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
            int payWork = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В месяц : {0} руб, в день {1} руб, в час {2} руб, в минуту {3} руб", payWork , payWork / 30 , payWork / 720 , payWork / 43200);
        }
    }
}
