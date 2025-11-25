
namespace DesignPatterns.Creational.Prototype
{
    public class Address : ICloneable<Address>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address Clone()
        {
            return (Address)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public override string ToString()
        {
            return $"{Street}, {City}";
        }
    }
}