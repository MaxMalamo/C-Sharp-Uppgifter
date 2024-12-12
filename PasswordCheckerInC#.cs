using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordCheckerInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password: ");
            string firstPass = Console.ReadLine();
            Console.WriteLine("Enter it again: ");
            string secondPass = Console.ReadLine(); 

            if (string.IsNullOrEmpty(firstPass) || string.IsNullOrEmpty(secondPass))
            {
                Console.WriteLine("Please enter a password");
            }

            int length = secondPass.Length;

            Console.WriteLine($"The length of your password is {length}")

            Console.Readline();

            if (firstPass == secondPass)
            {
                Console.WriteLine("Passwords match");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }


        }
    }
}

