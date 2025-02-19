using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    internal class World
    {
        // Set of locations.
        List<Location> locations = new List<Location>();
        
        // Player
        Person player = new Person();

        public World()
        {
            // We will have a random number of locations between 4 and 6
            int numberLocations = GetRandomNumber(4, 6);
            for (int i = 0; i < numberLocations; i++)
            {
                locations.Add(new Location());
            }
        }

        //method that will setup up the world
        public void Setup()
        {
            GameLoop();
        }
        private void GameLoop()
        {
            Console.Clear();
            Console.WriteLine("Where would you like to go? Enter a number to go to the location\n");
            Console.WriteLine(GetLocationList());
            
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int result))
            {
                if (result > 0 && result <= locations.Count)
                {
                    locations[result--].Visit();
                }
                else
                {
                    Print("Please Enter a valid number of location");
                    Continue();
                    GameLoop();
                }
            }
        }
        private string GetLocationList()
        {
            string output = "Locations in the world:\n";
            int number = 1;
            foreach (Location location in locations) 
            {
                output += $"    {number}) {location.LocationName}\n";
                number++;
            }
            
            return output;
        }
    }
}
