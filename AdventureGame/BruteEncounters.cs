using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class BruteEncounters:Location
    {
        public BruteEncounters()
        {

        }
        public void GetRandomBruteCaveEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                Print(BruteCaveEncounters(1));
            }
            if (num == 2)
            {
                Print(BruteCaveEncounters(2));
            }
        }
        public void GetRandomBruteVillageEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                BruteVillageEncounters(1);
            }
            if (num == 2)
            {
                BruteVillageEncounters(2);
            }
        }
        public void GetRandomBruteForestEncounter()
        {
            int num = GetRandomNumber(1, 3);
            if (num == 1)
            {
                BruteForestEncounters(1);
            }
            if (num == 2)
            {
                BruteForestEncounters(2);
            }
        }

        // The next three methods contain each of those encounter variations. 
        private string BruteCaveEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "brute encounter one";
                    break;

                case 2:
                    output += "brute encounter two";
                    break;
            }
            return output;
        }

        private string BruteVillageEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "brute encounter one";
                    break;

                case 2:
                    output += "brute encounter two";
                    break;
            }
            return output;
        }
        private string BruteForestEncounters(int variation)
        {
            string output = "";
            switch (variation)
            {
                case 1:
                    output += "brute encounter one";
                    break;

                case 2:
                    output += "brute encounter two";
                    break;
            }
            return output;
        }
    }
}
