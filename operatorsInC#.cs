using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 5;
            int num3 = 60;
            int num4 = 20;
            int num5 = 80;
            int num6 = 40;

            int sum = (num1 += num2);
            int product = (num3 *= num4);
            int remainder = (num5 /= num6);

            Console.WriteLine("The sum of num1 and num2 is " + sum);
            Console.WriteLine("The product of num3 and num4 is " + product);
            Console.WriteLine("The remainder of num5 divided by num6 is " + remainder);

            int prefixNumber = ++num6;
            int postfixNumber = --num6;
            
            Console.WriteLine("The prefix number is: " + prefixNumber);
            Console.WriteLine("The postfix number is: " + postfixNumber);




        }
    }
}
