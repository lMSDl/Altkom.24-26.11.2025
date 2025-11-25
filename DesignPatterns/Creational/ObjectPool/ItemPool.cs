namespace DesignPatterns.Creational.ObjectPool
{
    internal class ItemPool
    {
        private readonly IReadOnlyCollection<Item> _items;
        public ItemPool(int count)
        {
            _items = Enumerable.Range(1, count).Select(x => new Item()).ToArray();
        }

        public Item? Acquire()
        {
            var item = _items.FirstOrDefault(x => !x.IsVisible);
            if (item != null)
            {
                item.IsVisible = true;
                return item;
            }
            return null;
        }
    }
}
