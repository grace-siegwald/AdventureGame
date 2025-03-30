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
            Console.Clear();
            // Print out name of where the player is.
            Print($"You have arrived at {LocationName}");

            // Display specific encounter based on the prefix within the LocationName the player selected 
            if (LocationName.StartsWith("Cave of"))
            {
                CaveEncounter(job);
            }

            if (LocationName.StartsWith("Village of"))
            {
                VillageEncounter(job);
            }

            if (LocationName.StartsWith("Forest of"))
            {
                ForestEncounter(job);
            }

            Continue();
        }

        // Sorcerer Encounters
        public void CaveEncounter(string Job)
        {
            Console.Clear();
            if (Job == "Sorcerer")
            {
                PrintWithColor($"You step into the mouth an important looking cave. Its walls are covered in brilliant red crystals. " +
                $"As you walk deeper, the light from the outside becomes dimmer, until eventually you cannot see a thing!" +
                $"\n\nPerhaps you could use your handy wand  to help your way? If you don't know how, type 'I' to enter your inventory", "wand", "Black");
                string input = Console.ReadLine();
                if (input == "Use Wand")
                {
                    Print($"\n\n You cast a light spell! A pebble of light quickly flutters from your wand traveling upwards ");
                }
                if (input == "Use Grimoire")
                {

                }
                else
                {
                    Print("Please enter a valid input");
                    TryAgain();
                    CaveEncounter("Sorcerer");
                }
            }
            if (Job == "Thief")
            {
                Print(Job);
            }
            if (Job == "Bard")
            {
                Print(Job);
            }
        }
        public void VillageEncounter(string Job)
        {
            Console.Clear();
            if (Job == "Sorcerer")
            {
                Print(Job);
            }
            if (Job == "Thief")
            {
                Print(Job);
            }
            if (Job == "Bard")
            {
                Print(Job);
            }
        }
        public void ForestEncounter(string Job)
        {
            Console.Clear();
            if (Job == "Sorcerer")
            {
                Print(Job);
            }
            if (Job == "Thief")
            {
                Print(Job);
            }
            if (Job == "Bard")
            {
                Print(Job);
            }
        }
    }
}
