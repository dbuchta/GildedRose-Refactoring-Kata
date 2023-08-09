using FluentAssertions;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GildedRoseKata
{
    /// <summary>
    /// Test naming convention recommendation:
    /// https://ardalis.com/unit-test-naming-convention/
    /// </summary>
    public class GildedRose_UpdateQuality
    {
        [Fact]
        public void DoesNothingGivenSulfuras()
        {
            int initialQuality = 80;
            var items = new List<Item> {
                                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = initialQuality},

            };
            var gildedRose = new GildedRose(items);
            
            gildedRose.UpdateQuality();

            var firstItem = items.First();
            
            // Use your preferred assertion library (already included - pick one delete others)
            // xunit default
            Assert.Equal(initialQuality, firstItem.Quality);
        }

        [Fact]
        public void AddsNameToNewItem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void ReducesQualityBy1After1Day()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 60, Quality = 10 } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(9);
        }
    }
}
