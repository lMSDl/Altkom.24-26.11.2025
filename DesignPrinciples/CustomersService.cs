namespace DesignPrinciples
{
    public class CustomersService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public Customer? FindCustomerById(int customerId)
        {
            return CustomersGloabalFilter().Where(x => x.Id == customerId).SingleOrDefault();
        }

        public IEnumerable<Customer> CustomersGloabalFilter()
        {
            return Customers.Where(x => x.IsActive);
        }
    }

}