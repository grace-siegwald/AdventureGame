using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class Village : Location 
    {
        static List<string> PossibleVillagerNames = new List<string>()
        {
            "Eldrin",
            "Mira",
            "Osric",
            "Gwenna",
            "Jareth",
            "Tilda",
            "Borin",
            "Lena",
            "Edric",
            "Fenna"
        };
        new NPC villager = new NPC()
        {
            NPCName = $"{PossibleVillagerNames[GetRandomNumber(0, PossibleVillagerNames.Count)]}"
        };
        new Item BlueKey = new Item()
        {
            ItemName = "Blue Key",
            ItemDescription = "A key... that's blue..."
        };
        public Village()
        {

        }

        public void VisitVillage(string Job, List<Item> playerInventory)
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
