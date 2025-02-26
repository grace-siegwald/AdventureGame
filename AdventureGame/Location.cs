using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    enum AverageTempurature: byte
    {
        mountains = 20,
        forest = 50,
        grassland = 75,
        desert = 90,
        volcano = 120
    }

    internal class Location
    {
        public string LocationName;
        public AverageTempurature Tempurature = AverageTempurature.volcano;
        // There will be items to be found.
        // NPC"s will be here too.

        // Constuctors run when the instance is made. Constructors never have a return type. (void, static, etc)
        public Location() 
        {

        }   

        public void Visit()
        {
            Console.Clear();
            // Print out name of where the player is.
            Utility.Print($"You have arrived at {LocationName}");

            // NPC randomly appears (or dedicated?)?

            // NPC has a request?

            // Find a random item?

            // Another activity?

            // Special event based on random number or probability?

            Continue();
        }
    }
}
