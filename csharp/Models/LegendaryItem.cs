namespace csharp.Models
{
    public class LegendaryItem : StoreItem
    {
        public LegendaryItem(Item item) : base(item, 80)
        {
        }

        protected override int GetUpdatedQuality()
        {
            // quality never change
            return ItemQuality;
        }

        protected override void UpdateSellIn()
        {
            // SellIn date never change
        }
    }
}