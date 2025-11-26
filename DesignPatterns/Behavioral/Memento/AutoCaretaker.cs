using System.ComponentModel;

namespace DesignPatterns.Behavioral.Memento
{
    internal class AutoCaretaker<T> : Caretaker<T> where T : ICloneable, IRestorable<T>, INotifyPropertyChanging
    {
        public AutoCaretaker(T originator) : base(originator)
        {
            originator.PropertyChanging += Originator_PropertyChanging;
        }

        private void Originator_PropertyChanging(object? sender, PropertyChangingEventArgs e)
        {
            SaveState();
        }

        /*protected override void RestoreState(Memento<T> memento)
        {
            _originator.PropertyChanging -= Originator_PropertyChanging;
            base.RestoreState(memento);
            _originator.PropertyChanging += Originator_PropertyChanging;
        }*/


        public override void Dispose()
        {
            if (_originator != null)
            {
                _originator.PropertyChanging -= Originator_PropertyChanging;
            }
            base.Dispose();
        }

    }
}
