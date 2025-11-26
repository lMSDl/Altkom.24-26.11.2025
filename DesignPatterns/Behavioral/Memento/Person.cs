using System.ComponentModel;

namespace DesignPatterns.Behavioral.Memento
{
    internal class Person : ICloneable, IRestorable<Person>, INotifyPropertyChanging
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(FirstName)));
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(LastName)));
            }
        }

        public event PropertyChangingEventHandler? PropertyChanging;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public virtual void Restore(Person state)
        {
            firstName = state.FirstName;
            lastName = state.LastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
