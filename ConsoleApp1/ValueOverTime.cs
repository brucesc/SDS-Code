using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ValueOverTime : Item, IUpdate
    {
        public Item UpdateQuality()
        {
            if (Quality < 50)
            {
                SellIn -= 1;
                Quality += 1;
            }
            else
            {
                SellIn -= 1;
                Quality = 50;
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
