using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationTaskInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width: ");
            int Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the height: ");
            int Height = Convert.ToInt32(Console.ReadLine());
            
            int area = Calculation(Width, Height);
            Console.WriteLine($"The area of the triangle is {area}");

        }

        static int Calculation(int Width, int Height)
        {
            return Width * Height / 2;
        }
    }
}
