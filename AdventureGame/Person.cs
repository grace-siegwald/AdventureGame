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
                    // Each jobs first item is their "practical" item. When you use it, you'll pretty much get what you expect.
                    ItemName = "Wand",
                    ItemDescription = "It may look like a simple stick, but it contains an abundance of magical potential. Use it to light your way",
                },
                new Item
                {
                    // Each jobs second item is their "fun" item. When you use it, you get something very unexpected!
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
                    ItemDescription = "It may look unassuming, but in the hands of a thief, it's a potent tool."
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
                    ItemDescription = "A powerful protective tool... but what else can it do?"
                }
        };
        //public void Equip(Item item)
        //{
        //    // Code here to "equip" a wearable item.
        //}

        public void Use(Item item) 
        { 
            if (item.ItemName == "Wand")
            {
                Print("use wand");
            }
            if (item.ItemName == "Book")
            {
                Print("use book");
            }

            if (item.ItemName == "Lighter")
            {
                Print("use lighter");
            }
            if (item.ItemName == "Lockpick")
            {
                Print("use lockpick");
            }

            if (item.ItemName == "Torch")
            {
                Print("use torch");
            }
            if (item.ItemName == "Shield")
            {
                Print("use shield");
            }
        }
    }
}
