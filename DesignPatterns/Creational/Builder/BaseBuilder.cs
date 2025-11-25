namespace DesignPatterns.Creational.Builder
{
    internal class BaseBuilder<T> where T : ICloneable
    {
        protected T Vehicle { get; }
        public BaseBuilder(T vehicle)
        {
            Vehicle = vehicle;
        }

        public T Build()
        {
            return (T)Vehicle.Clone();
        }
    }
}
