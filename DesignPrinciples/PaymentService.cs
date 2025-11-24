namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool DeleteCustomer(Customer customer)
        {
            return customer.IsActive = false;
        }

        public Customer FindByDebit(float debit)
        {
            return CustomersGloabalFilter().SingleOrDefault(x => x.AllowedDebit == debit);
        }

        public bool Charge(int customerId, float amount)
        {
            var customer = FindCustomerById(customerId);
            if (customer == null)
            {
                return false;
            }

            if (GetBalance(customerId) + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcome += amount;
            return true;
        }

        public void Fund(int customerId, float amount)
        {
            var customer = FindCustomerById(customerId);
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int customerId)
        {
            Customer? customer = FindCustomerById(customerId);
            return customer?.Income - customer?.Outcome;
        }

        private Customer? FindCustomerById(int customerId)
        {
            return CustomersGloabalFilter().Where(x => x.Id == customerId).SingleOrDefault();
        }

        private IEnumerable<Customer> CustomersGloabalFilter()
        {
            return Customers.Where(x => x.IsActive);
        }
    }

}