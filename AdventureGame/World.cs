﻿using System;
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
        public string WorldName = "Everhollow";

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
            Console.Title = "An Adventure";
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
            PrintWithColor($"{player.PlayerName}, welcome to the world of {WorldName} !\n", WorldName, "Black");

            PrintWithColor($"\nHere in {WorldName} ,", WorldName, "Black");
            PrintWithColor("you have three Classes  to choose from. Each will give you a uniquely random gameplay experience!\n", "Classes", "Black");

            // TEMPORARY WARNING
            Warning("Warning: The \"Sorcerer\" is the only class with a feature complete encounter. " +
                "\nTo experience this encounter, choose the \"Sorcerer\"");

            PrintWithColor($"\n 1) The Sorcerer \n", "Sorcerer", "DarkMagenta");
            PrintWithColor($"2) The Thief \n", "Thief", "DarkGreen");
            PrintWithColor($"3) The Bard \n", "Bard", "DarkBlue");

            Print("\nTo choose your Class, input its corresponding number");
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
                            player.AddClassItemToInventory("Wand");
                            player.AddClassItemToInventory("Grimoire");
                            PrintWithColor($"\nYou are now a {player.PlayerJob} !", $"{player.PlayerJob}", "DarkMagenta"); 
                            break;

                        case 2:
                            player.PlayerJob = Job.Thief;
                            // Add the Lighter and the Lockpick to the player's inventory
                            player.AddClassItemToInventory("Cloak");
                            player.AddClassItemToInventory("Gloves");
                            PrintWithColor($"\nYou are now a {player.PlayerJob} !", $"{player.PlayerJob}", "DarkGreen");
                            break;

                        case 3:
                            player.PlayerJob = Job.Bard;
                            // Add the Torch and the Shield to the player's inventory 
                            player.AddClassItemToInventory("Lute");
                            player.AddClassItemToInventory("Hat");
                            PrintWithColor($"\nYou are now a {player.PlayerJob} !", $"{player.PlayerJob}", "DarkBlue");
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
            PrintWithColor($"\nEach class has a set of unique Items. Make sure to check your Inventory  to see what they are!\n\n", "Inventory", "Black");
            Continue();
            GameLoop();
        }
        private void GameLoop()
        {
            Console.Clear();
            //Print("Where would you like to go? Enter a number to go to the location\n");

            PrintWithColor($"Welcome to the Overworld ! Travel to a location by entering it's corresponding number.\n", "Overworld", "Green");
            PrintWithColor($"To check your Inventory , type 'I'\n", "Inventory", "Black");
            
            // TEMPORARY WARNING
            Warning("Warning: The \"Cave\" encounter is the only story that is feature complete." +
                "\nUnfortunately, after you complete the \"Cave\" encounter, there is nothing left to do...");
            
            Print(LocationList());
            
            string choice = Console.ReadLine();
            if (choice == "I")
            {
                player.DisplayInventory();
                Continue();
                GameLoop();
            }
            if (int.TryParse(choice, out int result))
            {
                if (result > 0 && result <= locations.Count)
                {
                    locations[result - 1].Visit($"{player.PlayerJob}", player.playerInventory);
                }
                else
                {
                    Print("Please Enter a valid number");
                    TryAgain();
                    GameLoop();
                    // This is a recursive call to the GameLoop method. It's recursive because it's inside the method it's calling. 
                }
            }
            else
            {
                Print("Please Enter a valid input");
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
        private string LocationList()
        {
            string output = "\nLocations in the world:\n";
            int number = 1;
            // The "foreach" loop is specically helpful for "collections" (array, list, etc.).
            foreach (Location location in locations)
            {
                output += $"    {number}) {location.LocationName}\n";
                number++;
            }

            if (player.playerInventory.Count == 5)
            {
                locations.Add(new Location() { LocationName = $"Castle of Intention" });
                output += $"    4) Castle of Intention\n" +
                    $"         Could the castle be unlocked now...?";
            }
            else
            {
                output += $"    4) Castle of Intention\n" +
                    $"         The castle is locked. Find all three keys to enter!";
            }

            return output;
        }
    }
}
