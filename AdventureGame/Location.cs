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
            SorcererEncounters SorcererEncounter = new SorcererEncounters();
            ThiefEncounters ThiefEncounter = new ThiefEncounters();
            BruteEncounters BruteEncounter = new BruteEncounters();
            Console.Clear();
            // Print out name of where the player is.
            Print($"You have arrived at {LocationName}");
            if (job == "Sorcerer")
            {
                // Display specific encounter based on the prefix within the LocationName the player selected 
                if (LocationName.StartsWith("Cave of"))
                {
                    SorcererEncounter.GetRandomSorcererCaveEncounter();
                }

                if (LocationName.StartsWith("Village of"))
                {
                    SorcererEncounter.GetRandomSorcererVillageEncounter();
                }

                if (LocationName.StartsWith("Forest of"))
                {
                    SorcererEncounter.GetRandomSorcererForestEncounter();
                }
            }

            if (job == "Thief")
            {
                if (LocationName.StartsWith("Cave of"))
                {
                    ThiefEncounter.GetRandomThiefCaveEncounter();
                }

                if (LocationName.StartsWith("Village of"))
                {
                    ThiefEncounter.GetRandomThiefVillageEncounter();
                }

                if (LocationName.StartsWith("Forest of"))
                {
                    ThiefEncounter.GetRandomThiefForestEncounter();
                }
            }

            if (job == "Brute")
            {
                if (LocationName.StartsWith("Cave of"))
                {
                    BruteEncounter.GetRandomBruteCaveEncounter();
                }

                if (LocationName.StartsWith("Village of"))
                {
                    BruteEncounter.GetRandomBruteVillageEncounter();
                }

                if (LocationName.StartsWith("Forest of"))
                {
                    BruteEncounter.GetRandomBruteForestEncounter();
                }
            }
            Continue();
        }
    }
}
