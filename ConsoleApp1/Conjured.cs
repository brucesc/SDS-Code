using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Conjured : Item, IUpdate
    {
        public Item UpdateQuality()
        {           
           if (SellIn >= 2)
            {
                SellIn -= 1;
                Quality -= 2;
            }
            else if (SellIn <= 1 && Quality > 3)
            {
                SellIn -= 1;
                Quality -= 4;
            }
            else
            {
                SellIn -= 1;
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
