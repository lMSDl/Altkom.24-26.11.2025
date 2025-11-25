namespace DesignPatterns.Creational.Prototype
{
    internal interface ICloneable<T> : ICloneable
    {
        new T Clone();
    }
}
