using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade(0-5): ");
            int userGrade = Convert.ToInt32(Console.ReadLine());


            if (userGrade <= 5)
            {
                switch (userGrade)
                {
                    case 5:
                        Console.WriteLine("Excellent");
                        break;
                    case 4:
                        Console.WriteLine("Good");
                        break;
                    case 3:
                        Console.WriteLine("Satisfactory");
                        break;
                    case 2:
                        Console.WriteLine("Ok");
                        break;
                    case 1:
                        Console.WriteLine("Needs Improvement");
                        break;
                    case 0:
                        Console.WriteLine("Fail");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid, enter your grade (0-5)");
            }

            Console.ReadLine();
    
        }
    }
}
