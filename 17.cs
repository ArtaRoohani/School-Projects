using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.DictionaryCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>
            {
                {"123456", "Someone" }
            };

            while (true)
            {
                Console.WriteLine("=== Student Management Menu ====================");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Display all students");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Chose an option (1-4): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        string id = Console.ReadLine();

                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();

                        subjects[id] = name;

                        Console.WriteLine("Student added successfully!");
                       
                        break;

                    case 2:
                        Console.Write("Enter ID to remove: ");
                        string removeId = Console.ReadLine();

                        if (subjects.Remove(removeId))
                            Console.WriteLine("Student removed.");
                        else
                            Console.WriteLine("ID not found.");

                    
                        break;
                    case 3:
                        Console.WriteLine("--- List of Students ---");
                        foreach (var s in subjects)
                            Console.WriteLine($"ID: {s.Key} | Name: {s.Value}");

                   
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                    
                        break;


                }
            }

        }
    }
}

