
using SOLID.L;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


var rectangle = CreateRectangle(a, b);
Console.WriteLine($"Area of rectangle ({a}x{b}) : {rectangle.Area}");




Rectangle CreateRectangle(int a, int b)
{
    return new Square { Width = a, Height = b };
} 