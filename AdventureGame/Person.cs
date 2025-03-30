using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public void DisplayInventory()
        {
            Console.Clear();
            foreach (Item item in playerInventory)
            {
                // Display the ItemName and ItemDescription
                PrintWithColor($"\n{item.ItemName}", item.ItemName, "Black");
                PrintWithColor($"\n{item.ItemDescription} ", item.ItemDescription, "Black");
            }
        }
        
        public void AddItemToInventory(string item)
        {
            if (item == "Wand")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Wand",
                    ItemDescription = "It may look like a simple stick, but it contains an abundance of magical potential. Use it to light your way",
                });
            }
            if (item == "Book")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Book",
                    ItemDescription = "Sorcerers know a lot of stuff, where else would you put all that knowledge!",
                });
            }
            if (item == "Lighter")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Lighter",
                    ItemDescription = "A simple tool, but it's more handy then it looks! Use it to light your way",
                });
            }
            if (item == "Lockpick")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Lockpick",
                    ItemDescription = "It may look unassuming, but in the hands of a thief, it's a potent tool.",
                });
            }
            if (item == "Torch")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Torch",
                    ItemDescription = "It may be primitive, but if it works, it works! Use it to light your way.",
                });
            }
            if (item == "Shield")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Shield",
                    ItemDescription = "A powerful protective tool... but what else can it do?",
                });
            }
            if (item == "Red Key"){
                playerInventory.Add(new Item
                {
                    ItemName = "Red Key",
                    ItemDescription = ""
                });
            }
            if (item == "Green Key"){
                playerInventory.Add(new Item
                {
                    ItemName = "Green Key",
                    ItemDescription = ""
                });
            }
            if (item == "Blue Key"){
                playerInventory.Add(new Item
                {
                    ItemName = "Blue Key",
                    ItemDescription = ""
                });
            }
        }

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
