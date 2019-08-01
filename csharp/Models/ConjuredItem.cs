namespace csharp.Models
{
    public class ConjuredItem : StoreItem
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        /// <summary>
        /// I'm not sure about the requirement, the text-test describes the behaviour of conjured item as
        /// same as the normal items however the requirement text says
        /// "Conjured items degrade in Quality twice as fast as normal items"
        /// </summary>
        /// <returns></returns>
        protected override int GetUpdatedQuality()
        {
            if (SellInDatePassed)
                return ItemQuality - 2;
            else
                return ItemQuality - 1;
        }
    }
}