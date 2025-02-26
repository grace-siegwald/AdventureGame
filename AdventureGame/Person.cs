using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Person
    {
        public string PlayerName;
        public string PersonName;
        // Both the player and npc's will need a list to hold items.

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
