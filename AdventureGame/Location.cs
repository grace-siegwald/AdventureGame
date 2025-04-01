using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    internal class Location
    {
        public string LocationName;
        public string FinalLocationName;
        public virtual void VisitCave(string Job, List<Item> playerInventory) { }

        // Constructors run when the instance is made. Constructors never have a return type. (void, static, etc)
        public Location()
        {

        }

        public void Visit(string job, List<Item> playerInventory)
        {
            Console.Clear();
            // Print out name of where the player is.
            Print($"You have arrived at {LocationName}");

            // Display specific encounter based on the prefix within the LocationName the player selected 
            if (LocationName.StartsWith("Cave of"))
            {
                new Cave().VisitCave(job, playerInventory);
            }

            if (LocationName.StartsWith("Village of"))
            {
                new Village().VisitVillage(job, playerInventory);
            }

            if (LocationName.StartsWith("Forest of"))
            {
                new Forest().VisitForest(job, playerInventory);
            }

            Continue();
        }
    }
}
