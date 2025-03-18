using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    internal class World
    {
        // Set of locations.
        // The world "has a" location.
        public string WorldName = "Randomazo";

        List<Location> locations = new List<Location>();
        Location[,] map;
        
        // Player
        // The world "has a" player.
        Person player = new Person();

        public World()
        {
            SetLocationList();
        }

        //method that will setup up the world
        public void Setup()
        {
            Console.Title = "A Random Adventure";
            Console.BackgroundColor = System.ConsoleColor.DarkGray;
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.Clear();
            ChooseName();
        }
 
        private void ChooseName()
        {
            Print("Welcome, Adventurer!\n" +
                "Please enter your Name:\n");
            player.PlayerName = Console.ReadLine();
            ChooseJob();
        }

        private void ChooseJob()
        {
            Console.Clear();
            PrintWithColor($"{player.PlayerName}, welcome to the world of {WorldName} !\n" +
                $"In {WorldName} , everywhere you go, everything you see, and every item you find is randomized.\n", WorldName, "DarkMagenta");

            PrintWithColor($"\nHere in {WorldName} ,", WorldName, "DarkMagenta");
            PrintWithColor("there are three Jobs  to choose from. Each will give you a unique gameplay experience.\n", "Jobs", "DarkMagenta");
            

            Print("\nTo choose your Job, input its corresponding number");
            SetJob();
        }
        
        public void SetJob()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                if (choice > 0 && choice <= 3)
                {
                    switch (choice)
                    {
                        case 1:
                            player.PlayerJob = Job.Sorcerer;
                            // Add the Wand and the Book into the player's inventory
                            player.playerInventory.Add(new Item
                            {
                                ItemName = "Wand",
                                ItemDescription = "It may look like a simple stick, but it contains an abundance of magical potential. Use it to light your way",
                            });
                            player.playerInventory.Add(new Item
                            {
                                ItemName = "Book",
                                ItemDescription = "Sorcerers know a lot of stuff, where else would you put all that knowledge!"
                            });
                            Print($"You are now a {player.PlayerJob}!");
                            break;

                        case 2:
                            player.PlayerJob = Job.Thief;
                            // Add the Lighter and the Lockpick to the player's inventory
                            Print($"You are now a {player.PlayerJob}!");
                            break;

                        case 3:
                            player.PlayerJob = Job.Brute;
                            // Add the Torch and the Shield to the player's inventory 
                            Print($"You are now a {player.PlayerJob}!");
                            break;
                    }
                }
                else
                {
                    Print("Please enter a valid number");
                    TryAgain();
                    ChooseJob();
                }
            }
            else
            {
                Print("Please enter a valid number");
                TryAgain();
                ChooseJob();
            }
            Continue();
            GameLoop();
        }
        private void GameLoop()
        {
            Console.Clear();
            Print("Where would you like to go? Enter a number to go to the location\n");
            Print(GetLocationList());
            
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int result))
            {
                // && is "and", || is "or", ! is "not", != is "not equal"

                if (result > 0 && result <= locations.Count)
                {
                    locations[result - 1].Visit($"{player.PlayerJob}");
                }
                else
                {
                    Print("Please Enter a valid number");
                    TryAgain();
                    GameLoop();
                    // This is a recursive call to the GameLoop method. It's recursive because it's inside the method it's calling. 
                    //GameLoop();
                }
            }
            else
            {
                Print("Please Enter a valid number");
                TryAgain();
                GameLoop();
            }
            GameLoop();
        }
         public void SetLocationList()
         {
            //int numberLocations = GetRandomNumber(4, 6);
            int numberLocations = 3;
            List<string> prefix = new List<string>() { "Cave of", "Village of", "Forest of" };
            List<string> names = new List<string>() { "the Accidental", "Aimlessness", "the Incidental", "Irregularity", "Oddity", "Surprise" };
            for (int i = 0; i < numberLocations; i++)
            {
                int prefixNumber = GetRandomNumber(prefix.Count);
                int nameNumber = GetRandomNumber(names.Count);
                locations.Add(new Location() { LocationName = $"{prefix[prefixNumber]} {names[nameNumber]}" });
                prefix.RemoveAt(prefixNumber);
                names.RemoveAt(nameNumber);
            }
         }
        private string GetLocationList()
        {
            string output = "Locations in the world:\n";
            int number = 1;
            // The "foreach" loop is specically helpful for "collections" (array, list, etc.).
            foreach (Location location in locations)
            {
                output += $"    {number}) {location.LocationName}\n";
                number++;
            }

            //if player has all three keys
            //{
            //    locations.Add(new Location() { LocationName = $"Castle of Intention" });
            //    output += $"    4) Castle of Intention\n";
            //}
            
            //else
            //{
            //    output += $"    4) Castle of Intention\n" +
            //        $"         The castle is locked. Find all three keys to enter.";
            //}
            
            return output;
        }
    }
}
