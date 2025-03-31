using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class NPC:Person
    {
        List<string> TrollNames = new List<string>()
        {
            "Gornak the Stonefist",
            "Throggar Mudshroud",
            "Karruk Blackclaw",
            "Gulkath the Grim",
            "Drogor Ironbellow",
            "Vrogg the Deepstalker",
            "Krullor Caveheart",
            "Grokthar Bonecrusher",
            "Ulgoth Skullsplitter",
            "Balgor Rocktusk"
        };

        List<string> VillagerNames = new List<string>() 
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

        List<string> NymphNames = new List<string>() 
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


    }
}
