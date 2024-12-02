using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            Dictionary<string, string> teachers = new Dictionary<string, string>();
            bool running = true;
            bool exit = false;

            while (running)
            {

                // Menu
                Console.WriteLine("1. Add a new subject\n" + "2. Remove a subject\n" + "3. Display all\n" + "4. Exit\n");
                string userChoice = Console.ReadLine();

                // Menu options
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Enter the name of the new subject: ");
                        string nameSubject = Console.ReadLine();
                        Console.WriteLine("Enter the teachers name for this subject: ");
                        string teacherName = Console.ReadLine();

                        teachers[nameSubject] = teacherName;

                        if (teachers.ContainsKey(nameSubject))
                        {
                            Console.WriteLine("Succes");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter the name of the subject you want to remove: ");
                        string subjectRemove = Console.ReadLine();
                        if (teachers.ContainsKey(subjectRemove))
                        {
                            teachers.Remove(subjectRemove);
                            Console.WriteLine("Succes");
                        }
                        else
                        {
                            Console.WriteLine("Error, the subject was not found");
                        }
                        break;

                    case "3":
                        foreach (var item in teachers)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        break;                   
                }

                // Exit
                if (userChoice == "4")
                {
                    exit = true;
                }
                else
                {
                    continue;
                }

                Console.ReadLine();
            }
            
        }
    }
}
