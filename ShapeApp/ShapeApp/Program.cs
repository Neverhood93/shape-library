using ShapeLibrary;

namespace ShapeApp;

public class Program
{
    public static void Main(string[] args)
    {
        IShape circle = ShapeFactory.CreateCircle(5);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
        
        IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        
        if (triangle is Triangle t)
        {
            string isRightTriangle = t.IsRightTriangle() ? "Да" : "Нет";
            Console.WriteLine($"Треугольник прямоугольный: {isRightTriangle}");
        }
    }
}