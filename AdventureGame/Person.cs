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
        Brute
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
                    ItemDescription = "It may look like a simple stick, but it contains an abundance of magical potential. Use it to light your way",
                },
                new Item
                {
                    ItemName = "Book",
                    ItemDescription = "Sorcerers know a lot of stuff, where else would you put all that knowledge!"
                }
        };
        public List<Item> thiefItems = new List<Item>()
        {
                new Item
                {
                    ItemName = "Lighter",
                    ItemDescription = "A simple tool, but it's more handy then it looks! Use it to light your way",
                },
                new Item
                {
                    ItemName = "Lockpick",
                    ItemDescription = "Sorcerers know a lot of stuff, where else would you put all that knowledge!"
                }
        };
        public List<Item> bruteItems = new List<Item>()
        {
                new Item
                {
                    ItemName = "Torch",
                    ItemDescription = "It may be primitive, but if it works, it works! Use it to light your way.",
                },
                new Item
                {
                    ItemName = "Shield",
                    ItemDescription = "Sorcerers know a lot of stuff, where else would you put all that knowledge!"
                }
        };
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
