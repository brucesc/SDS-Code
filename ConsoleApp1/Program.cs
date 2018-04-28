using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Item> Items = new List<Item>
            {
                new Basic { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new ValueOverTime { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Basic { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Legendary { Name = "Sulfuras", SellIn = 0, Quality = 80 },
                new EventTicket { Name = "Backstage passes", SellIn = 15, Quality = 20 },
                new Conjured { Name = "Conjured", SellIn = 3, Quality = 6 },
                new Conjured { Name = "ConjuredTest", SellIn = 3, Quality = 50 }, // to test if Quality drops by 4 after SellIn hits 0.
                new Conjured { Name = "ConjuredTest2", SellIn = 2, Quality = 5 } // to test if Quality drops to 0 on next day when current Quality is less than 4
            };
           
            var days = 30;

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Day = " + i);
                foreach (IUpdate item in Items)
            {
                    var test = item.UpdateQuality();
                    Console.WriteLine("Name = " + test.Name + " SellIn = " + test.SellIn + " Quality = " + test.Quality);
                }
            }
            Console.ReadKey();
        }
    }
}
