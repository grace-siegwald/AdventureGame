using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Item
    {
        public string ItemName;
        public string ItemDescription;

        //list containing all the items in the game
        public List<Item> Items = new List<Item>()
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
                },
                new Item
                {
                    ItemName = "Lighter",
                    ItemDescription = "A simple tool, but it's more handy then it looks! Use it to light your way",
                },
                new Item
                {
                    ItemName = "Lockpick",
                    ItemDescription = "It may look unassuming, but in the hands of a thief, it's a potent tool."
                },
                new Item
                {
                    ItemName = "Torch",
                    ItemDescription = "It may be primitive, but if it works, it works! Use it to light your way.",
                },
                new Item
                {
                    ItemName = "Shield",
                    ItemDescription = "A powerful protective tool... but what else can it do?"
                },

                new Item
                {
                    ItemName = "Red Key",
                    ItemDescription = "One the three keys required to enter the Castle"
                },
                new Item
                {
                    ItemName = "Blue Key",
                    ItemDescription = "Another key required to enter the Castle"
                },
                new Item
                {
                    ItemName = "Green Key",
                    ItemDescription = "The last key required to enter the Castle"
                }
        };
 
        //public virtual string DescribeItem()
        //{
        //    return ItemName;
        //}
    }
}
