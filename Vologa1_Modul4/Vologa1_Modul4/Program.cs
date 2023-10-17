using System;

public interface IFigure
{
    double GetArea();
    double GetPerimeter();
}

public class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : IFigure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Triangle : IFigure
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Triangle(double baseLength, double height, double sideA, double sideB)
    {
        Base = baseLength;
        Height = height;
        SideA = sideA;
        SideB = sideB;
    }

    public double GetArea()
    {
        return 0.5 * Base * Height;
    }

    public double GetPerimeter()
    {
        return Base + SideA + SideB;
    }
}

public class Figiri
{
    public void vivod_figur() 
    {
        try
        {
            Console.WriteLine("Введите радиус круга:");
            var radius = Convert.ToDouble(Console.ReadLine());
            if (radius <= 0) throw new Exception("Радиус не может быть меньше либо равным нулю.");
            var circle = new Circle(radius);
            Console.WriteLine($"Площадь круга: {circle.GetArea()}, Периметр круга: {circle.GetPerimeter()}");

            Console.WriteLine("Введите ширину и высоту прямоугольника:");
            var width = Convert.ToDouble(Console.ReadLine());
            var height = Convert.ToDouble(Console.ReadLine());
            if (width <= 0 || height <=  0) throw new Exception("Ширина и высота не могут быть меньше либо равным нулю.");
            var rectangle = new Rectangle(width, height);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}, Периметр прямоугольника: {rectangle.GetPerimeter()}");

            Console.WriteLine("Введите основание, высоту и две стороны треугольника:");
            var baseLength = Convert.ToDouble(Console.ReadLine());
            var triangleHeight = Convert.ToDouble(Console.ReadLine());
            var sideA = Convert.ToDouble(Console.ReadLine());
            var sideB = Convert.ToDouble(Console.ReadLine());
            if (baseLength <= 0 || triangleHeight <= 0 || sideA <= 0 || sideB <= 0) throw new Exception("Основание, высота и стороны не могут быть меньше либо равным нулю.");
            var triangle = new Triangle(baseLength, triangleHeight, sideA, sideB);
            Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}, Периметр треугольника: {triangle.GetPerimeter()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введенные данные должны быть числом.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
    }
    static void Main(string[] args)
    {
        Figiri figiri = new Figiri();
        figiri.vivod_figur();
    }
}
