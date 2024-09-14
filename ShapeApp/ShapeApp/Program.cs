using ShapeLibrary;

namespace ShapeApp;

public class Program
{
    public static void Main(string[] args)
    {
        IShape circle = ShapeFactory.CreateCircle(5);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
    }
}