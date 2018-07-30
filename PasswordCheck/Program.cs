using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{
    class Program
    {
        public static int minimumNumber (int number,string password)

        {
            
            int sum=0;
            int SpecialChar=0;
            int NumberChar=0;
            int Upper=0;
            int Lower=0;
            
            string specialChar = "[!@#$%^&*()-+]";
            string numbers = "[0123456789]";

            if (number < 6)
                return sum = 6 - number;

            else
              
            if (!password.Any(char.IsUpper))
                Upper = 1;

            if (!password.Any(char.IsLower))
                Lower = 1;

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, specialChar))
                SpecialChar = 1;

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, numbers))
                NumberChar = 1;

            return sum = Upper + Lower + SpecialChar + NumberChar;   

        }


        static void Main(string[] args)
        {
            
            int count;
            do
            {
                Console.Write("Insert new password:");
                string Password = Console.ReadLine();
                int number = Password.Length;
                var t = minimumNumber(number, Password);
                Console.WriteLine($"You need at least :{t} characters to make password strong.");
                count = t;
                
            }

            while (count!= 0);
            Console.ReadLine();
            
        }
    }


}

