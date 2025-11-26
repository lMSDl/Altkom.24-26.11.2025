namespace DesignPatterns.Behavioral.Memento
{
    internal class Caretaker<T> : IDisposable where T : ICloneable, IRestorable<T>
    {
        private ICollection<Memento<T>> _mementos = [];
        protected T _originator;
        public Caretaker(T originator)
        {
            _originator = originator;
        }
        public void SaveState()
        {
            var memento = new Memento<T>(_originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }

        public void RestoreState()
        {
            var memento = _mementos.LastOrDefault();
            if (memento != null)
            {
                _mementos.Remove(memento);
                RestoreState(memento);
            }
        }

        protected virtual void RestoreState(Memento<T> memento)
        {
            _originator.Restore(memento.GetState());
            Console.WriteLine($"Caretaker: restored {memento.DateTime}");
        }

        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(m => m.DateTime <= dateTime);
            if (memento != null)
            {
                _mementos.Remove(memento);
                RestoreState(memento);
            }
        }

        public virtual void Dispose()
        {
            _originator = default;
            _mementos.Clear();
        }
    }
}
