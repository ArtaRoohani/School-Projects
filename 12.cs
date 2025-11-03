using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to make a userpassword
            Console.Write("Make your password: ");
            string userpassword = Console.ReadLine();
            //Say that the password has to be atleast 6 characters long and ask again til the user inputs a valid password
            while (userpassword.Length < 6 || string.IsNullOrEmpty(userpassword))
            {
                if (string.IsNullOrEmpty(userpassword))
                {
                    Console.WriteLine("Please enter a password");
                }
                else
                {
                    Console.WriteLine("Password is too short. It must be at least 6 characters long.");
                }
                Console.Write("Make your password: ");
                userpassword = Console.ReadLine();
            }



            //Input password
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();


            //Check password length
            Console.WriteLine(password);
            if (password.Length < 6)
            {
                Console.WriteLine("Password is too short. It must be at least 6 characters long.");
            }
            else if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please enter a password");
            }
            else
            {
                Console.WriteLine("Ok i guess...");
            }
            //Check if the password is correct
            if (password == userpassword)
            {
                Console.WriteLine("Password match");
            }
            else if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Password do not match");

            }

            //text if password is empty
            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please enter a password!");
            }
        }
    }
}
