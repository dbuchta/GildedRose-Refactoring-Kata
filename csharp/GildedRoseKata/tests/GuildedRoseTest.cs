using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace GildedRoseKata
{
    public class GuildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("fixme", Items[0].Name);
        }
    }
}
