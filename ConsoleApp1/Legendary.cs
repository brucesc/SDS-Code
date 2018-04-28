using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Legendary : Item, IUpdate
    {
        public Item UpdateQuality()
        {
            return new Item
            {
                Name = Name,
                SellIn = SellIn,
                Quality = Quality
            };
        }
    }
}
