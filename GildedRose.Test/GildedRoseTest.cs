using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void EmptyInventory_UpdateQuality_NoErrors()
        {
            var items = new List<Item> {};
            var app = new csharp.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items.Count);
        }
    }
}