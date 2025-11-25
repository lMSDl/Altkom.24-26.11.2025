namespace DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public Person? Parent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        public ICollection<Person> Children { get; private set; } = [];

        //standardowe klonowanie - płytkie klonowanie z ręcznym klonowaniem zagnieżdżonych obiektów
        //ręczne dostosowanie głębokości klonowania
        //najczęściej używane podejście
        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            //clone.Parent - nie klonujemy rodzica, pozostawiamy referencję
            clone.Address = Address?.Clone(); //klonujemy w pełni adres
            clone.Children = Children.ToList(); //płytkie klonowanie listy dzieci (nie chcemy klonować dzieci)
            return clone;
        }

        //głębokie klonowanie - kopiuje cały obiekt wraz z zagnieżdżonymi obiektami
        //może doprowadzić do problemów z cyklami referencyjnymi
        public object DeepClone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Parent = (Person?)Parent?.DeepClone();
            clone.Address = Address?.Clone();
            clone.Children = Children.Select(c => (Person)c.DeepClone()).ToList();
            return clone;
        }

        //płytkie klonowanie - kopiuje pamięć obiektu, przez co zagnieżdżone obiekty są współdzielone
        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            var childrenNames = string.Join(", ", Children.Select(c => c.FirstName));
            return $"{FirstName} {LastName}, Age: {Age}, Address: {Address}, Children: [{childrenNames}]";
        }
    }
}
