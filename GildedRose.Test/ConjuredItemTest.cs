using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class ConjuredItemTest
    {
        [Test]
        public void SellInDateNotPassed_UpdateQuality_QualityDecreasedBy1()
        {
            var quality = 20;
            var item = new Item
            {
                Name = "Conjured Mana Cake",
                Quality = quality,
                SellIn = 20
            };
            var items = new List<Item> { item };

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(quality - 1, item.Quality);
        }

        [Test]
        public void SellInDatePassed_UpdateQuality_QualityDecreasedBy2()
        {
            var quality = 20;
            var item = new Item
            {
                Name = "Conjured Mana Cake",
                Quality = quality,
                SellIn = 0
            };
            var items = new List<Item> { item };

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(quality - 2, item.Quality);
        }
    }
}