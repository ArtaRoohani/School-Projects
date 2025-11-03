using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the message: C# is fun I am going to code C# thomorrow ");
            var message = Console.ReadLine();

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            //print massage in reverse order from top to bottom
            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
                Thread.Sleep(100); // Pause for 100 milliseconds
            }

            //Making space between the two outputs in a really tupid way
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //print massage normally from top to bottom
            //I dont like pinnaple on pizza by the way


            foreach (char c in message)
            {
                Console.WriteLine(c);
                Thread.Sleep(100); // Pause for 100 milliseconds

            }
        }
    }
}





































































































































                       //Its here for no reason at all but dont worry, it wont affect the code (hopefully)

                 //          ⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⡀⠀⠀⠀⠀⢀⣀⣀⡀⠀⠀
                ⠀//⠀⠀⠀ ⠀⣀⣀⡀⠀⠀⠀⠀⢀⣀⣀⣀⡀⠘⠋⢉⠙⣷⠀⠀⢀⣾⣿⡿⠁⠀⠀
                 //⠀⠀⢀⣴⣿⡿⠋⣉⠁⣠⣾⣿⣿⣿⣿⡿⠿⣦⡈⠀⣿⡇⠀⣼⣿⣿⠃⠀⠀⠀
                 //⠀⠀⠀⣽⣿⣧⠀⠃⢰⣿⣿⡏⠙⣿⠿⢧⣀⣼⣷⠀⡿⠃⣰⣿⣿⡏⠀⠀⠀⠀
                 //⠀⠀⠀⠉⣿⣿⣦⠀⢿⣿⣿⣷⣾⡏⠀⠀⢹⣿⣿⠀⠀⢰⣿⣿⡟⠀⠀⠀⠀⠀
                 //⠀⠀⠀⠀⠀⠉⠛⠁⠈⠿⣿⣿⣿⣷⣄⣠⡼⠟⠁⠀⢠⣿⣿⡿⠁⠀⠀⠀⠀⠀
                ⠀//⠀⠀⠀⠀ ⠀⠀⠀⢀⣤⣤⣄⣉⣉⣉⣠⡀⠀⠀⢀⡿⠿⢿⠃⠀⠀⠀⠀⠀⠀
                ⠀//⠀⠀   ⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣤⣤⣶⣄⠀⠀⠀⠀⠀⠀⠀
⠀⠀              ⠀//⠀⠀   ⢀⣾⣿⣿⣿⣿⠟⠋⣉⣉⠙⠻⣿⣿⣿⣿⠿⠋⠀⠀⠀⠀⠀⠀⠀
⠀              ⠀⠀//⠀  ⠀⣾⣿⣿⣿⡏⢀⣴⣿⣿⣿⣿⡄⢀⣤⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀               ⠀//⠀  ⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⢀⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
               ⠀⠀// ⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⣠⣿⣿⠿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
               ⠀⠀//⠀ ⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⣯⣠⣾⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀                //⠀ ⠀⠀⠀⠉⠻⠿⣿⣿⣿⣿⣿⠿⠋⣠⡾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                 //⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀