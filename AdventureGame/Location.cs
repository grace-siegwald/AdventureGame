using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    internal class Location
    {
        public string LocationName;
        public string FinalLocationName;
        // There will be items to be found.
        // NPC"s will be here too.

        // Constructors run when the instance is made. Constructors never have a return type. (void, static, etc)
        public Location() 
        {

        }   

        public void Visit(string job)
        {
            Encounters encounter = new Encounters();
            Console.Clear();
            // Print out name of where the player is.
            Print($"You have arrived at {LocationName}");
            if (job == "Sorcerer")
            {
                // Display specific encounter based on the prefix within the LocationName the player selected 
                if (LocationName.StartsWith("Cave of"))
                {
                    encounter.GetRandomSorcererCaveEncounter();
                }

                if (LocationName.StartsWith("Village of"))
                {
                    encounter.GetRandomSorcererVillageEncounter();
                }

                if (LocationName.StartsWith("Forest of"))
                {
                    encounter.GetRandomSorcererForestEncounter();
                }
            }

            if (job == "Thief")
            {
                if (LocationName.StartsWith("Cave of"))
                {
                    encounter.GetRandomThiefCaveEncounter();
                }

                if (LocationName.StartsWith("Village of"))
                {
                    encounter.GetRandomThiefVillageEncounter();
                }

                if (LocationName.StartsWith("Forest of"))
                {
                    encounter.GetRandomThiefForestEncounter();
                }
            }

            if (job == "Brute")
            {
                if (LocationName.StartsWith("Cave of"))
                {
                    encounter.GetRandomBruteCaveEncounter();
                }

                if (LocationName.StartsWith("Village of"))
                {
                    encounter.GetRandomBruteVillageEncounter();
                }

                if (LocationName.StartsWith("Forest of"))
                {
                    encounter.GetRandomBruteForestEncounter();
                }
            }
            Continue();
        }
    }
}
