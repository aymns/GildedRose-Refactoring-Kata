using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class BackstagePassesTest
    {
        [Test]
        public void SellIn10Days_UpdateQuality_QualityIncreasedBy2()
        {
            var quality = 20;
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = quality,
                SellIn = 10
            };
            var items = new List<Item> {item};

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(quality + 2, item.Quality);
        }

        [Test]
        public void SellIn20Days_UpdateQuality_QualityIncreasedBy1()
        {
            var quality = 20;
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = quality,
                SellIn = 20
            };
            var items = new List<Item> {item};

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(quality + 1, item.Quality);
        }


        [Test]
        public void SellIn5Days_UpdateQuality_QualityIncreasedBy3()
        {
            var quality = 20;
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = quality,
                SellIn = 5
            };
            var items = new List<Item> {item};

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(quality + 3, item.Quality);
        }


        [Test]
        public void SellIn5Days_UpdateQuality_QualityNeverMoreThan50()
        {
            var quality = 49;
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = quality,
                SellIn = 2
            };
            var items = new List<Item> {item};

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(50, item.Quality);
        }


        [Test]
        public void SellInDatePassed_UpdateQuality_QualityDropToZero()
        {
            var quality = 40;
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = quality,
                SellIn = 0
            };
            var items = new List<Item> {item};

            csharp.GildedRose.UpdateQuality(items);
            Assert.AreEqual(0, item.Quality);
        }
    }
}