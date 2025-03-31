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
        // There will be items to be found.
        // NPC"s will be here too.

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
                Cave(job, playerInventory);
            }

            if (LocationName.StartsWith("Village of"))
            {
                Village(job, playerInventory);
            }

            if (LocationName.StartsWith("Forest of"))
            {
                Forest(job, playerInventory);
            }

            Continue();
        }

        // Sorcerer Encounters
        public void Cave(string Job, List<Item> playerInventory)
        {
            Console.Clear();
            if (Job == "Sorcerer")
            {
                Print($"You step into the mouth an important looking cave. Its walls are covered in brilliant red crystals. " +
                $"As you walk deeper, the light from the outside becomes dimmer, until eventually you cannot see a thing!");
                Print(DisplayChoices(playerInventory));
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int i))
                {
                    if (i == 1)
                    {
                        Print("You used ");
                    }
                    if (i == 2)
                    {
                        Print("temp");
                    }
                    else
                    {
                        Print("Please Enter a valid input");
                        TryAgain();
                        Cave(Job, playerInventory);
                        // This is a recursive call to the GameLoop method. It's recursive because it's inside the method it's calling. 
                    }
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
        public void Village(string Job, List<Item> playerInventory)
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
        public void Forest(string Job, List<Item> playerInventory)
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
        public string DisplayChoices(List<Item> playerInventory)
        {
            string output = "Will you...\n";
            int i = 1;
            foreach (Item item in playerInventory)
            {
                output += $"    {i}) Use {item.ItemName}\n";
                i++;
            }
            return output;
        }
    }
}
