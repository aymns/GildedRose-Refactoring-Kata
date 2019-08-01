namespace csharp.Models
{
    public abstract class StoreItem
    {
        private readonly Item _item;
        private readonly int _maxAllowedQuality;

        protected StoreItem(Item item, int maxAllowedQuality = 50)
        {
            _item = item;
            _maxAllowedQuality = maxAllowedQuality;
        }

        public int ItemQuality => _item.Quality;
        public int ItemSellIn => _item.SellIn;

        public bool SellInDatePassed => _item.SellIn <= 0;

        public void UpdateData()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        private void UpdateQuality()
        {
            var quality = GetUpdatedQuality();

            if (quality < 0)
                quality = 0;
            else if (quality > _maxAllowedQuality)
                quality = _maxAllowedQuality;

            _item.Quality = quality;
        }

        protected abstract int GetUpdatedQuality();

        protected virtual void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}