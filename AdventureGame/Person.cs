﻿using System;
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
        public string PlayerJob;
        // Both the player and npc's will need a list to hold items.

        /* TO DO:
         * Create an enum containing the diferent jobs a player can choose from
         * Allow the player to choose which class they want after they enter their name. Should explain what that choice means.
         * Assign their chosen job to the PlayerJob variable.
         * Give certain properties to each of the jobs. 
         */

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
