using System.Security.Principal;

namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount? account, float amount)
        {
            return account?.Charge(amount) ?? false;
        }

        public void Fund(PaymentAccount? account, float amount)
        {
            account?.Fund(amount);
        }
    }

}