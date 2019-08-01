namespace csharp.Models
{
    public class AgedBrie : StoreItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }

        protected override int GetUpdatedQuality()
        {
            if (SellInDatePassed) return ItemQuality + 2;

            return ItemQuality + 1;
        }
    }
}