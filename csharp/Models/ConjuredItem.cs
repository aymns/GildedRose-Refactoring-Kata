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
                return ItemQuality - 2;
            else
                return ItemQuality - 1;
        }
    }
}