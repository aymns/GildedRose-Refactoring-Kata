namespace csharp.Models
{
    public static class StoreItemFactory
    {
        public static StoreItem Build(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie": return new AgedBrie(item);
                case "Backstage passes to a TAFKAL80ETC concert": return new BackstagePasses(item);
                case "Sulfuras, Hand of Ragnaros": return new LegendaryItem(item);
                case "Conjured Mana Cake": return new ConjuredItem(item);
                default: return new RegularItem(item);
            }
        }
    }
}