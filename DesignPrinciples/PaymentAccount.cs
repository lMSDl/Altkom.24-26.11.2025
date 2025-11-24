namespace DesignPrinciples
{
    public class PaymentAccount
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }
        public bool Charge(float amount)
        {
            if (GetBalance() + AllowedDebit < amount)
            {
                return false;
            }

            Outcome += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Income += amount;
        }

        public float GetBalance()
        {
            return Income - Outcome;
        }
    }
}
