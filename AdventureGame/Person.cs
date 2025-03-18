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
        public List<Item> playerInventory = new List<Item>();


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
