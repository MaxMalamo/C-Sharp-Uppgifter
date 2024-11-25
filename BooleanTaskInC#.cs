using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanTaskInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;

            bool isTrue = true;

            bool resultAnd = isTrue && (num1 > num3 && num2 < num4);
            bool resultOr = isTrue || (num1 == num3 || num2 == num4);
            bool resultNot = !isTrue;

            Console.WriteLine(resultAnd);
            Console.WriteLine(resultOr);
            Console.WriteLine(resultNot);

            Console.WriteLine("----------------");

            // Option 1:
            bool greater = isTrue && (num1 > num3);
            bool less = !isTrue || (num2 < num4);
            bool equal = isTrue || (num1 == num4);
            bool notEqual = !isTrue || (num2 == num3);
            

            Console.WriteLine(greater);
            Console.WriteLine(less);
            Console.WriteLine(equal);
            Console.WriteLine(notEqual);

            // Option 2:
            /*
            if (num1 > num3)
            {
                Console.WriteLine("num1 is greater than num3");
            }
            else
            {
                Console.WriteLine("num1 is not greater than num3");
            }

            if (num2 < num4)
            {
                Console.WriteLine("num2 is less than num4");
            }
            else
            {
                Console.WriteLine("num2 is greater than num4");
            }

            if (num1 == num4)
            {
                Console.WriteLine("num1 and num4 are equal");
            }
            else
            {
                Console.WriteLine("num1 and num4 are not equal");
            }

            if (num2 != num3)
            {
                Console.WriteLine("num2 is not equal to num2");
            }
            else
            {
                Console.WriteLine("num2 is equal to num3");
            }
            */


        }
    }
}
