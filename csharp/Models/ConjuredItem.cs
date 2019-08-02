namespace csharp.Models
{
    public class ConjuredItem : StoreItem
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        protected override int GetUpdatedQuality()
        {
            if (SellInDatePassed)
                return ItemQuality - 4;

            return ItemQuality - 2;
        }
    }
}