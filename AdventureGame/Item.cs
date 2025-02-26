using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Item
    {
        public string ItemName;

        public virtual string DescribeItem()
        {
            return ItemName;
        }
    }
}
