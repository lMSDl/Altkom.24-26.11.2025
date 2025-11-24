namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer? customer, float amount)
        {
            return customer?.Account.Charge(amount) ?? false;
        }

        public void Fund(Customer? customer, float amount)
        {
            customer?.Account.Fund(amount);
        }
    }

}