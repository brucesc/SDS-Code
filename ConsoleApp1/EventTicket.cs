using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EventTicket : Item, IUpdate
    {
        public Item UpdateQuality()
        {
            if (SellIn > 11)
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
            }
            else if (SellIn <= 11 && SellIn > 6)
            {
                if (Quality < 50)
                {
                    SellIn -= 1;
                    Quality += 2;
                }
                else
                {
                    SellIn -= 1;
                    Quality = 50;
                }                
            }
            else if (SellIn <= 6 && SellIn > 1)
            {
                if (Quality < 50)
                {
                    SellIn -= 1;
                    Quality += 3;
                }
                else
                {
                    SellIn -= 1;
                    Quality = 50;
                }                
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
