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
            Console.WriteLine(GetLocationList());
        }

        private string GetLocationList()
        {
            string output = "Locations in the world:\n";
            foreach (Location location in locations) 
            {
                output += $"{location.LocationName}\n";
            }
            
            return output;
        }
    }
}
