using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 16;
            int ageVote = Convert.ToInt32(age);

            if (age >= 18)
                {
                    Console.WriteLine("You are old enough to vote!");
                }
            else
                {
                    Console.WriteLine("You can't vote yet!");
                }
             



        }
    }
}
