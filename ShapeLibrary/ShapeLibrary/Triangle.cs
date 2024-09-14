namespace ShapeLibrary;

public class Triangle : IShape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("Стороны не образуют треугольник");
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double CalculateArea()
    {
        // вычисление площади треугольника через полупериметр
        double halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }
    
    public bool IsRightTriangle()
    {
        List<double> sides = new () { SideA, SideB, SideC };
        List<double> orderedSides = sides.OrderBy(s => s).ToList(); // сортируем, чтобы понять большую сторону
        return Math.Abs(Math.Pow(orderedSides[2], 2) - (Math.Pow(orderedSides[0], 2) + Math.Pow(orderedSides[1], 2))) < 0.00001;
    }
    
    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}