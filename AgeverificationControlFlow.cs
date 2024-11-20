using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeVerificationControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            int LegalAge = 18;

            if (Age >= LegalAge)
            {
                Console.WriteLine("You are an adult");
            } 
            else
            {
                Console.WriteLine("You are under the legal age");
            }

            int Counter = 1;
            string loopMessage = "Counter";
            while (Counter <= 4)
            {
                Counter++;
                //Jag var tvungen att google hjälp för raden nedanför:
                Console.WriteLine($"{loopMessage}: {Counter}");
            }

            switch (Counter)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Invalid number");
                    break;
            }
            Console.ReadLine();



        }
    }
}
