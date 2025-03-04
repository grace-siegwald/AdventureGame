using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class SorcererEncounters:Location
    {
        public SorcererEncounters()
        {

        }
        
        // The first three methods randomize which variation of the encounter you get.
        public void GetRandomSorcererCaveEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(SorcererCaveEncounters(1));
            }
            if (num == 2)
            {
                Print(SorcererCaveEncounters(2));
            }
        }
        public void GetRandomSorcererVillageEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(SorcererVillageEncounters(1));
            }
            if (num == 2)
            {
                Print(SorcererVillageEncounters(2));
            }
        }
        public void GetRandomSorcererForestEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(SorcererForestEncounters(1));
            }
            if (num == 2)
            {
                Print(SorcererForestEncounters(2));
            }
        }
        
        // The next three methods contain each of those encounter variations. 
        private string SorcererCaveEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "As you enter the massive cave, you trip on a rock. Ouch!" +
                        "\nThere's not a lot of light in here. Use an item to light your way!";
                    break;

                case 2:
                    output += "sorcerer cave encounter two";
                    break;
            }
            return output;
        }

        private string SorcererVillageEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "sorcerer village encounter one";
                    break;

                case 2:
                    output += "sorcerer village encounter two";
                    break;
            }
            return output;
        }
        private string SorcererForestEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "sorcerer forest encounter one";
                    break;

                case 2:
                    output += "sorcerer forest encounter two";
                    break;
            }
            return output;
        }
    }
}
