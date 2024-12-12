using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingTask
{
    class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            try
            {
                return (double)numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0.0;
            }
        }

        public int ParseInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
                return -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Input number is too large or too small.");
                return -1;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                Console.WriteLine("Enter the first number:");
                string input1 = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();

                int num1 = calculator.ParseInput(input1);
                int num2 = calculator.ParseInput(input2);

                if (num1 == -1 || num2 == -1)
                {
                    Console.WriteLine("Cannot proceed due to invalid input.");
                }
                else
                {
                    double result = calculator.Divide(num1, num2);
                    Console.WriteLine($"Result: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}

