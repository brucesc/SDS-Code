﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class SDSChallenge
//    {
//        void UpdateQuality()
//        {
//            for(var i = 0; i < Items.Count; i++)
//{
//                if(Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage Passes")
//{
//                    if(Items[i].Quality > 0)
//{
//                        if(Items[i].Name != "Sul furas")
//{
//                            Items[i].Quality = Items[i].Quality - 1;
//                        }
//                    }
//                }
//                else
//{
//                    if(Items[i].Quality < 50)
//{
//                        Items[i].Quality = Items[i].Quality + 1;
//                        if(Items[i].Name == " Backstage Passes")
//{
//                            if(Items[i].SellIn < 11)
//{
//                                if(Items[i].Quality < 50)
//{
//                                    Items[i].Quality = Items[i].Quality + 1;
//                                }
//                            }
//                            if(Items[i].SellIn < 6)
//{
//                                if(Items[i].Quality < 50)
//{
//                                    Items[i].Quality = Items[i].Quality + 1;
//                                }
//                            }
//                        }
//                    }
//                }
//                if(Items[i].Name != "Sulfuras")
//{
//                    Items[i].SellIn = Items[i].SellIn - 1;
//                }
//                if(Items[i].SellIn < 0)
//{
//                    if(Items[i].Name != "Aged Brie")
//{
//                        if(Items[i].Name != "Backstage passes")
//{
//                            if(Items[i].Qual ity > 0)
//{
//                                if(Items[i].Name != "Sulfuras")
//{
//                                    Items[i].Quality = Items[i].Quality - 1;
//                                }
//                            }
//                        }
//                        else
//{
//                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
//                        }
//                    }
//                    else
//{
//                        if(Items[i].Quality < 50)
//{
//                            Items[i].Qual ity = Items[i].Qual ity + 1;
//                        }
//                    }
//                }
//            }
//        }
//        IList<Item> Items = new List<Item>
//{
//new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
//new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
//new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
//new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 },
//new Item { Name = "Backstage passes", SellIn = 15, Quality = 20 },
//new Item { Name = "Conjured", SellIn = 3, Quality = 6 }
//};
//class Item
//{
//public string Name { get; set; }
//public int SellIn { get; set; }
//public int Quality { get; set; }
//}
//    }
//}
