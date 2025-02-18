using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    internal class Location
    {
        public string LocationName;
        // There will be items to be found.
        // NPC"s will be here too.

        // Constuctors run when the instance is made. Constructors never have a return type. (void, static, etc)
        public Location() 
        {
            List<string> prefix = new List<string>{ "Mount", "Castle", "Village of", "Lake of", "Valley of", "Desert of", "Realm of", "Land of" };
            List<string> names = new List<string> { "Awesomeness", "Superioriority", "Fabulousness", "Might", "Sorcery", "Garbage", "Deliciousness", "Greatness", "Bizare", "Candy", "Contradiction", "Fire", "Ice", "Confusion", "Gathering"};
            LocationName = $"{prefix[GetRandomNumber(prefix.Count)]} {names[GetRandomNumber(names.Count)]}";
        }   
    }
}
