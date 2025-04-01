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
        public Job PlayerJob;

        // Both the player and npc's will need a list to hold items.
        public List<Item> playerInventory = new List<Item>();

        public Person()
        {

        }

        public void DisplayInventory()
        {
            Console.Clear();
            Print(":*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:\n");
            int i = 1;
            foreach (Item item in playerInventory)
            {
                // Display the ItemName and ItemDescription
                Print($"{i}) {item.ItemName}");
                Print($"         {item.ItemDescription}\n");
                i++;
            }
            Print(":*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:");
        }
        
        public void AddClassItemToInventory(string item)
        {
            if (item == "Wand")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Wand of Wonder",
                    ItemDescription = "This wonderful little stick contains an an abundance of magical potential!"
                });
            }
            if (item == "Grimoire")
            {
                playerInventory.Add(new Item
                {
                    ItemName = "Never-ending Grimoire",
                    ItemDescription = "This peculiar book contains all the incantations a sorcerer could ask for... literally"
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
        }
    }
}
