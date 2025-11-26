namespace DesignPatterns.Behavioral.Interpreter
{
    internal class AbsExpression : IExpression
    {
        private readonly IExpression _expression;
        public AbsExpression(IExpression expression)
        {
            _expression = expression;
        }

        public float Interpret()
        {
            return Math.Abs(_expression.Interpret());
        }
    }
}
