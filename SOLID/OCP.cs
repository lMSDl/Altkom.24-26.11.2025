namespace SOLID
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => Width * Height;
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double Area => SideLength * SideLength;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area => Math.PI * Radius * Radius;
    }

    public class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.Area;
            /* return shape switch
             {
                 Rectangle rectangle => rectangle.Width * rectangle.Height,
                 Square square => square.SideLength * square.SideLength,
                 Circle circle => Math.PI * circle.Radius * circle.Radius,
                 _ => throw new NotSupportedException("Shape not supported")
             };*/
        }
    }
}