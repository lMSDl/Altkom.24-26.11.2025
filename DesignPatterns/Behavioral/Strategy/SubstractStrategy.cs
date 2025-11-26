namespace DesignPatterns.Behavioral.Strategy
{
    internal class SubtractStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a - b;
        }
    }
}
