using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    enum Job
    {
        Sorcerer,
        Thief,
        Knight
    }
    internal class Person
    {
        public string PlayerName;
        public string PersonName;
        public Job PlayerJob;
        public Item item = new Item();

        // Both the player and npc's will need a list to hold items.

        /* TO DO:
         * Allow the player to choose which class they want after they enter their name. Should explain what that choice means.
         * Assign their chosen job to the PlayerJob variable.
         * Give certain properties to each of the jobs. 
         */


        public List<Item> sorcererItems = new List<Item>()
        {
                new Item
                {
                    ItemName = "Wand",
                    ItemDescription = "It may look like a simple stick, but it contains an abundance of magical potential",
                },
                new Item
                {
                    ItemName = "Book",
                    ItemDescription = "Sorcerers know a lot of stuff, where else would you put all that knowledge!"
                }
        };
        public string ShowItems(string job)
        {
            string output = "";
            if (job == "Sorcerer")
            {
                output += "Inventory:\n";
                foreach (Item i in sorcererItems)
                {
                    output += $"{i.ItemName} \n";
                }
                return output;
            }
            return output;
        }

        public void SetupJob()
        {
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            if (num == 1)
            {
                PlayerJob = new Job();
                PlayerJob = Job.Sorcerer;
            }
            if (num == 2)
            {
                PlayerJob = new Job();
                PlayerJob = Job.Thief;
            }
            if (num == 3)
            {
                PlayerJob = new Job();
                PlayerJob = Job.Knight;
            }
            else
            {
                Print($"\nPlease enter a valid number");
            }
        }

        public void Equip(Item item)
        {
            // Code here to "equip" a wearable item.
        }

        public void Use(Item item) 
        { 
            // Code here to "use" an item.
        }
    }
}
