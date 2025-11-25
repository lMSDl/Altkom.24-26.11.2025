namespace DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            IBall ball = new Ball { R = 5 };
            CheckBall(ball);

            Cube cube = new Cube { A = 5 };
            var adapter = new CubeToBallAdapter(cube);
            CheckBall(adapter);
        }

        public static void CheckBall(IBall ball)
        {
            Console.WriteLine(ball.R <= 5);
        }
    }
}
