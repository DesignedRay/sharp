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

            string password = Console.ReadLine();
            if (password.Length >= 6 && password.Length <= 18)
            {
                bool Letter = false, Upper = false, Lower = false, Digit = false;
                for (int i = 0; i < password.Length; i++) {
                    if (char.IsLetter(password[i])) Letter = true;
                    if (char.IsUpper(password[i])) Upper = true;
                    if (char.IsLower(password[i])) Lower = true;
                    if (char.IsDigit(password[i])) Digit = true; 
                }
                if (Letter == true && Upper == true && Lower == true && Digit == true) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
