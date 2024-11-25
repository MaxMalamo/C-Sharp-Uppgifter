using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePrinterTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message: ");
            var userMessage = Console.ReadLine();

            char[] messageArray = userMessage.ToCharArray();
            Array.Reverse(messageArray);

            Console.WriteLine("Original order: " + userMessage);
            Console.WriteLine("Reverse order: " + messageArray);

            foreach (char c in userMessage)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("-------------");

            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }

        }
    }
}
