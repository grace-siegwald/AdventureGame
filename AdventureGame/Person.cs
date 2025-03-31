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
        Bard
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
                    ItemName = "Wand of Wonder",
                    ItemDescription = "This wonderful little stick contains an an abundance of magical potential!",
                });
            }
            if (item == "Grimoire")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Never-ending Grimoire",
                    ItemDescription = "This peculiar book contains all the spells a sorcerer could ask for... literally",
                });
            }
            if (item == "Cloak")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Cloak of Invisibility",
                    ItemDescription = "Cloaks like these are what separate a skilled thief from... a thief in jail!",
                });
            }
            if (item == "Gloves")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Mischievous Gloves of Thievery",
                    ItemDescription = "With these gloves, the hands if a pickpocket are completely undetectable",
                });
            }
            if (item == "Lute")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Adorned Lute",
                    ItemDescription = "The chosen 'tool' of a bard like yourself. It sure can play some beautiful tunes!",
                });
            }
            if (item == "Hat")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Feathered Hat",
                    ItemDescription = "Nobody wants to listen to a bard with no style! Very stylish, indeed...",
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
