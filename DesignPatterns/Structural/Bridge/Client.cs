namespace DesignPatterns.Structural.Bridge
{
    internal class Client
    {
        public static void Execute()
        {
            var square = new Square();
            var circle = new Circle();

            Console.WriteLine(square);
            Console.WriteLine(circle);

            var red = new Red();
            var blue = new Blue();

            Console.WriteLine(red);
            Console.WriteLine(blue);

            square.Color = red;
            circle.Color = blue;

            Console.WriteLine(square);
            Console.WriteLine(circle);

            red.Brightness = new Light();
            blue.Brightness = new Dark();

            Console.WriteLine(square);
            Console.WriteLine(circle);
        }
    }
}
