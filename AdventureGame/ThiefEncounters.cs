using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class ThiefEncounters:Location
    {
        public ThiefEncounters()
        {

        }
        // The first three methods randomize which variation of the encounter you get.
        public void GetRandomThiefCaveEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(ThiefCaveEncounters(1));
            }
            if (num == 2)
            {
                Print(ThiefCaveEncounters(2));
            }
        }
        public void GetRandomThiefVillageEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(ThiefVillageEncounters(1));
            }
            if (num == 2)
            {
                Print(ThiefVillageEncounters(2));
            }
        }
        public void GetRandomThiefForestEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(ThiefForestEncounters(1));
            }
            if (num == 2)
            {
                Print(ThiefForestEncounters(2));
            }
        }

        // The next three methods contain each of those encounter variations. 
        private string ThiefCaveEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "thief cave encounter one";
                    break;

                case 2:
                    output += "thief cave encounter two";
                    break;
            }
            return output;
        }

        private string ThiefVillageEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "thief village encounter one";
                    break;

                case 2:
                    output += "thief village encounter two";
                    break;
            }
            return output;
        }
        private string ThiefForestEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "thief forest encounter one";
                    break;

                case 2:
                    output += "thief forest encounter two";
                    break;
            }
            return output;
        }
    }
}
