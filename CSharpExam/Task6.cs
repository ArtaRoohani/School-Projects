using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1___Task6
{
    internal class Game
    {
        // Properties
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        //Constructor
        public Game(string name, string publisher, int year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }

        //A method to display game information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Publisher: {Publisher}, Year: {Year}, Genre: {Genre}");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //Create a list of games

            List<Game> games = new List<Game>();
            games.Add(new Game("Bloons 6", "Ninja Kiwi", 2018, "Tower Defense"));
            games.Add(new Game("Undertale", "Toby Fox", 2015, "RPG"));
            foreach (var game in games)
            {
                game.DisplayInfo();
            }
        }
    }
}
