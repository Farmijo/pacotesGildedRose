﻿using Xunit;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            System.Console.Write(app.ToString());
            Assert.Equal("A completar", Items[0].Name);
        }
    }
}