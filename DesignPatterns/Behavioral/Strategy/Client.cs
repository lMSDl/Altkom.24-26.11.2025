
namespace DesignPatterns.Behavioral.Strategy
{
    internal class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();
            while (true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' '); // 2 + 4
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetStrategy(split[1]);
                if (calculator.Strategy == null)
                {
                    Console.WriteLine("Unknown operation");
                    continue;
                }

                if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
                {
                    Console.WriteLine(calculator.Operate(a, b));
                    Console.WriteLine(GetFunc(split[1])(a, b));
                }
            }
        }

        private static ICalcStrategy? GetStrategy(string sign)
        {
            return sign switch
            {
                "+" => new AddStrategy(),
                "-" => new SubtractStrategy(),
                "*" => new MultiplyStrategy(),
                "/" => new DivideStrategy(),
                _ => null
            };
        }

        private static Func<float, float, float> GetFunc(string sign)
        {
            return sign switch
            {
                "+" => (a, b) => a + b,
                "-" => (a, b) => a - b,
                "*" => (a, b) => a * b,
                "/" => (a, b) =>
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    return a / b;
                },
                _ => throw new InvalidOperationException("Unknown operation")
            };
        }
    }
}
