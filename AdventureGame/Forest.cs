using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class Forest : Location
    {
        static List<string> PossibleNymphNames = new List<string>()
        {
            "Sylwen",
            "Naida",
            "Elara",
            "Virelle",
            "Liora",
            "Nyssa",
            "Aeris",
            "Selene",
            "Zyphra",
            "Callistra"
        };
        new NPC nymph = new NPC()
        {
            NPCName = $"{PossibleNymphNames[GetRandomNumber(0, PossibleNymphNames.Count)]}"
        };
        new Item GreenKey = new Item()
        {
            ItemName = "Green Key",
            ItemDescription = "A key... that's green..."
        };
        public Forest()
        {

        }

        public void VisitForest(string Job, List<Item> playerInventory)
        {
            Console.Clear();
            if (Job == "Sorcerer")
            {
                Warning("The scope of this project quickly spiraled out of control, so this section is not complete yet :(");
            }
            if (Job == "Thief")
            {
                Warning("The scope of this project quickly spiraled out of control, so this section is not complete yet :(");
            }
            if (Job == "Bard")
            {
                Warning("The scope of this project quickly spiraled out of control, so this section is not complete yet :(");
            }
        }
    }
}
