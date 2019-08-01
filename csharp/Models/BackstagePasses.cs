namespace csharp.Models
{
    public class BackstagePasses : StoreItem
    {
        public BackstagePasses(Item item) : base(item)
        {
        }

        protected override int GetUpdatedQuality()
        {
            var quality = ItemQuality;

            if (SellInDatePassed)
                return 0;
            if (ItemSellIn <= 5)
                return quality + 3;
            if (ItemSellIn <= 10)
                return quality + 2;
            return quality + 1;
        }
    }
}