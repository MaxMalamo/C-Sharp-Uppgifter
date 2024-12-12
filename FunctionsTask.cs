using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsTask
{
    class MathOperations
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Division(int num1, int num2)
        {
            try
            {
                return (double)num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0.0;
            }
        }

        public double Power(int baseNum, int exponent)
        {
            return Math.Pow(baseNum, exponent);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            try
            {
                Console.WriteLine("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Addition: {mathOps.Addition(num1, num2)}");
                Console.WriteLine($"Subtraction: {mathOps.Subtraction(num1, num2)}");
                Console.WriteLine($"Multiplication: {mathOps.Multiplication(num1, num2)}");

                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine($"Division: {mathOps.Division(num1, num2)}");
                }

                Console.WriteLine($"Power: {mathOps.Power(num1, num2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
