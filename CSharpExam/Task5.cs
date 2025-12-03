using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exam1___Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> Words = new Dictionary<string, string>();
            while (true)
            {
                //PLIS READ ME. I ALSO ADDED "Console.WriteLine("------------"); IN THE SCRIPT TO MAKE THE OUTPUT MORE READABLE.

                //Prints out the menu options.
                Console.WriteLine("=== Menu ========================");
                Console.WriteLine("1. Add a word and its definition");
                Console.WriteLine("2. Remove a word");
                Console.WriteLine("3. Show all words and definitions");
                Console.WriteLine("4. Exit program");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //Adds a word and its definition to the dictionary.
                        Console.WriteLine("------------");
                        Console.Write("Enter the word: ");
                        string wordToAdd = Console.ReadLine();
                        Console.WriteLine("------------");
                        Console.Write("Enter the definition: ");
                        string definitionToAdd = Console.ReadLine();
                        if (Words.ContainsKey(wordToAdd))
                        {

                            //Checks if the word already exists or not and gives you an option to overwrite it.
                            Console.Write("This word already exists. Do you want to overwrite it? (yes / no): ");
                            string overwriteChoice = Console.ReadLine();
                            if (overwriteChoice.ToLower() == "yes")
                            {
                                Console.WriteLine("------------");
                                Words[wordToAdd] = definitionToAdd;
                                Console.WriteLine("Word updated.");
                            }
                            else
                            {
                                Console.WriteLine("--------------");

                                Console.WriteLine("Word not added.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-----------");
                            Words.Add(wordToAdd, definitionToAdd);
                            Console.WriteLine("Word added.");
                        }
                        break;
                    case "2":
                        //Removes a word from the dictionary.
                        Console.WriteLine("----------------------");
                        Console.Write("Enter the word to remove: ");
                        string wordToRemove = Console.ReadLine();
                        if (Words.ContainsKey(wordToRemove))
                        {
                            Console.WriteLine("-------------");

                            Words.Remove(wordToRemove);
                            Console.WriteLine("Word removed.");
                        }
                        else
                        {
                            Console.WriteLine("---------------");
                            Console.WriteLine("Word not found.");
                        }
                        break;
                    case "3":
                        //Shows all words and their definitions that you added to the dictionary.
                        if (Words.Count == 0)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine("No words in the dictionary.");
                        }
                        else
                        {
                            foreach (var entry in Words)
                            {
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine($"{entry.Key}: {entry.Value}");
                            }
                        }
                        break;
                    case "4":
                        //Exits the program.
                        return;
                    default:
                        Console.WriteLine("--------------");
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine();

            }
        }
    }
}
