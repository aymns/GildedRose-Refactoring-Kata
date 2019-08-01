using System.Collections.Generic;
using csharp.Models;

namespace csharp
{
    public class GildedRose
    {
        public static void UpdateQuality(IList<Item> items)
        {
            foreach (var item in items)
            {
                StoreItemFactory.Build(item).UpdateData();
            }
        }
    }
}
