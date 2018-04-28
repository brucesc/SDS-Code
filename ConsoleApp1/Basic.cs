using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Basic : Item, IUpdate
    {
        public Item UpdateQuality()
        {
            if (SellIn >= 1)
            {
                SellIn -= 1;
                Quality -= 1;
            }
            else if (SellIn <= 0 && Quality > 1)
            {
                SellIn -= 1;
                Quality -= 2;
            }
            else
            {
                Quality = 0;
            }
            return new Item
            {
                Name = Name,
                SellIn = SellIn,
                Quality = Quality
            };
        }
    }
}
