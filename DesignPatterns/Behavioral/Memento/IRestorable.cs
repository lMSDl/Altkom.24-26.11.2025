namespace DesignPatterns.Behavioral.Memento
{
    internal interface IRestorable<T>
    {
        void Restore(T state);
    }
}
