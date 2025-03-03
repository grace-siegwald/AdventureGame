using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    enum Job
    {
        Sorcerer,
        Theif,
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
                    ItemDescription = "Sorcerers know a lot of stuff, where better to put all that knowledge then a book!"
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
