using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayTaskInC_
{
    class numbers
    {
        public static void SumOfNumbers()
        {
            int[] arrayNumbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
           
            foreach (int number in arrayNumbers)
            {
                sum  += number;
            }                    

            Console.WriteLine("The length of the array is " + arrayNumbers.Length + " numbers");

            if (sum > -1)
            {
                Console.WriteLine("The total is: " + sum);
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

        }
      
        
    }

     
    internal class Program
    {
        static void Main(string[] args)
        {
            numbers.SumOfNumbers();

            

            Console.ReadLine();
        }
    }
}
