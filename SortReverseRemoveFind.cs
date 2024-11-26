using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortReverseRemoveFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The array
            int[] numbers = new int [6]
            {
                45, 12, 78, 34, 89, 23
            };

            // Prints out the original array
            Console.Write("The original array: ");
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // Sort
            Console.Write("Sorted array: ");
            Array.Sort(numbers);
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write($"{numbers[x]} ");
            }
            Console.WriteLine();

            // Reverse
            Console.Write("Reversed array: ");
            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Clear
            Console.Write("Removed '78' array: ");
            Array.Clear(numbers, 1, 1);
            foreach(var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //Index
            int find = 34;
            int position = Array.IndexOf(numbers, find);

            if (position > -1)
            {
                Console.WriteLine($"The number exists at {position + 1}");
            }
            else
            {
                Console.WriteLine("The number doesen't exist");
            }
            Console.ReadLine();
            
        }


        
    }

}
