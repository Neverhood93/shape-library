using ShapeLibrary;

public class ShapeTests
{
    [Fact]
    public void Circle_CalculateArea_Correct()
    {
        // Arrange
        var circle = new Circle(5);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * 25, area, 4);
    }

    [Fact]
    public void Triangle_CalculateArea_Correct()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area, 4);
    }

    [Fact]
    public void Triangle_IsRightTriangle_True()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRight);
    }

    [Fact]
    public void Triangle_IsRightTriangle_False()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 6);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.False(isRight);
    }

    [Fact]
    public void Triangle_InvalidSides_ThrowsException()
    {
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}
