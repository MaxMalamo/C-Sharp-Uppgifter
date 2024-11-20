using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 5)
            {
                counter++;
                Console.WriteLine(counter.ToString("Counter"));
            }
            Console.WriteLine("The loop has finished!");
        }
    }
}
