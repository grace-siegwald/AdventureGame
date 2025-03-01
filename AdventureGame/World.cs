﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    enum Jobs
    {

    }
    internal class World
    {
        // Set of locations.
        // The world "has a" location.
        List<Location> locations = new List<Location>();
        
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
            SetName();
            SetJob();
        }
 
        private void SetName()
        {
            Console.WriteLine("Welcome, Adventurer!\n" +
                "Please enter your Name:\n");
            player.PlayerName = Console.ReadLine();
            GameLoop();
        }

        private void SetJob()
        {

        }



        public void SetLocationList()
        {
            int numberLocations = GetRandomNumber(4, 6);
            List<string> prefix = new List<string>() { "Mount", "Castle", "Village of", "Lake", "Valley of", "Desert", "Realm of", "Land of" };
            List<string> names = new List<string>() { "Awesome", "Superior", "Fabulous", "Purpleness", "Lattes", "Coffee", "Sourdough Bread", "Cupcake", "Tiramisu", "Candycane" };
            for (int i = 0; i < numberLocations; i++)
            {
                int prefixNumber = GetRandomNumber(prefix.Count);
                int nameNumber = GetRandomNumber(names.Count);
                locations.Add(new Location() { LocationName = $"{prefix[prefixNumber]} {names[nameNumber]}" });
                prefix.RemoveAt(prefixNumber);
                names.RemoveAt(nameNumber);
            }
        }

        private void GameLoop()
        {
            Console.Clear();
            Console.WriteLine("Where would you like to go? Enter a number to go to the location\n");
            Console.WriteLine(GetLocationList());
            
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int result))
            {
                // && is "and", || is "or", ! is "not", != is "not equal"

                if (result > 0 && result <= locations.Count)
                {
                    locations[result - 1].Visit();
                }
                else
                {
                    Print("Please Enter a valid number of location");
                    Continue();
                    // This is a recursive call to the GameLoop method. It's recursive because it's inside the method it's calling. 
                    GameLoop();
                }
            }
            GameLoop();
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
            
            return output;
        }
    }
}
