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
            string ticketNumber = Console.ReadLine();
            int sumLeft = int.Parse(ticketNumber[0].ToString()) + int.Parse(ticketNumber[1].ToString()) + int.Parse(ticketNumber[2].ToString());
            int sumRight = int.Parse(ticketNumber[3].ToString()) + int.Parse(ticketNumber[4].ToString()) + int.Parse(ticketNumber[5].ToString());
            Console.WriteLine(sumLeft - sumRight);
        }
    }
}
