using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want the loop to run?: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            char loopCharacter = 'X';
            int startNumber = 1;

            if (userChoice >= 0)
            {
                for (int i = startNumber; i <= userChoice; i++)
                {
                    Console.WriteLine(loopCharacter);
                }
                Console.WriteLine("Your loop has finished!");
            }
            else
            {
                Console.WriteLine("Enter a number above 0");
            }
        }
    }
}
