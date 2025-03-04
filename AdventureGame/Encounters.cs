using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class Encounters:Location
    {
        public Encounters()
        {

        }
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
                SorcererVillageEncounters(1);
            }
            if (num == 2)
            {
                SorcererVillageEncounters(2);
            }
        }
        public void GetRandomSorcererForestEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                SorcererForestEncounters(1);
            }
            if (num == 2)
            {
                SorcererForestEncounters(2);
            }
        }

        public void GetRandomThiefCaveEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                
            }
            if (num == 2)
            {
                
            }
        }
        public void GetRandomThiefVillageEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                
            }
            if (num == 2)
            {
                
            }
        }
        public void GetRandomThiefForestEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {

            }
            if (num == 2)
            {

            }
        }

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
                    output += "encounter two";
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
                    output += "encounter one";
                    break;

                case 2:
                    output += "encounter two";
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
                    output += "encounter one";
                    break;

                case 2:
                    output += "encounter two";
                    break;
            }
            return output;
        }
        //Method for "Castle" encounter
        public void CastleEncounter()
        {

        }
    }
}
