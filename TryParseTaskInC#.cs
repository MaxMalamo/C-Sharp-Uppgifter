using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseTaskInC_
{
    class Program
    {
        static void Main(string[] args)
        {
          // Jag var tvungen att googla ganska mycket hjälp

            string input = "123abc"; 

           
            Console.WriteLine("Step 2: Observing the error without handling.");
            try
            {
                int result = Convert.ToInt32(input);
                Console.WriteLine($"Conversion succeeded: {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("\nStep 3: Using a Try-Catch block to handle the error.");
          
            try
            {
                int result = Convert.ToInt32(input);
                Console.WriteLine($"Conversion succeeded: {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("\nStep 5: Using a custom TryParse function.");
           
            if (TryParseCustom(input, out int resultTwo))
            {
                Console.WriteLine($"Conversion succeeded: {resultTwo}");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        
        /// <param name="input"
        /// <param name="result"
        
        static bool TryParseCustom(string input, out int result)
        {
            result = 0; 
            try
            {
                result = Convert.ToInt32(input);
                return true; 
            }
            catch (FormatException)
            {
                return false; 
            }
        }
    }
}

