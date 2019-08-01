namespace csharp.Models
{
    public class RegularItem : StoreItem
    {
        public RegularItem(Item item) : base(item)
        {
        }

        protected override int GetUpdatedQuality()
        {
            if(SellInDatePassed)
                return ItemQuality - 2;

            return ItemQuality - 1;
        }
    }
}