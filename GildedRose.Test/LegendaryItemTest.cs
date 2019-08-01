using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class LegendaryItemTest
    {
        [Test]
        public void SellInDateNotPassed_UpdateQuality_QualityNeverChanged()
        {
            var quality = 80;
            var item = new Item
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = quality,
                SellIn = 20
            };
            var items = new List<Item> {item};

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(quality, item.Quality);
        }
    }
}