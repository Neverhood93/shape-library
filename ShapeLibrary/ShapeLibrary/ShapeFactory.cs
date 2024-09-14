using ShapeLibrary;

public static class ShapeFactory
{
    public static IShape CreateCircle(double radius)
    {
        return new Circle(radius);
    }
}
