using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplicationCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int num = 7;
            int length = 5;

            
            int[] multiplicationArray = new int[length];

            Console.WriteLine($"Multiplication Table for {num}:");

            
            for (int i = 0; i < length; i++)
            {
                multiplicationArray[i] = num * (i + 1); 
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{num} x {i + 1} = {multiplicationArray[i]}");
            }
        }
    }
}
