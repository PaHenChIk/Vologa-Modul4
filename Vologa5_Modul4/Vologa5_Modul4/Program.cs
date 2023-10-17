using System;

public interface IDrawing
{
    void DrawLine();
    void DrawCircle();
    void DrawRectangle();
}

public class Canvas : IDrawing
{
    public void DrawLine()
    {
        Console.WriteLine("Рисуем линию...");
        Console.WriteLine("........................................");
    }

    public void DrawCircle()
    {
        Console.WriteLine("Рисуем круг...");
        Console.WriteLine("    ....");
       Console.WriteLine( "  ..     ..");
       Console.WriteLine("  ..     ..");
        Console.WriteLine("    ....");
    }

    public void DrawRectangle()
    {
        Console.WriteLine("Рисуем прямоугольник...");
        Console.WriteLine("..........");
        Console.WriteLine("..      ..");
        Console.WriteLine("..      ..");
        Console.WriteLine("..........");
    }
}

public class Risunok
{
    public void vivod_risunka() 
    {
        var canvas = new Canvas();

        try
        {
            Console.WriteLine("Введите команду для рисования (line, circle, rectangle):");
            var command = Console.ReadLine();

            switch (command)
            {
                case "line":
                    canvas.DrawLine();
                    break;
                case "circle":
                    canvas.DrawCircle();
                    break;
                case "rectangle":
                    canvas.DrawRectangle();
                    break;
                default:
                    throw new Exception("Неизвестная команда.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
    }
    static void Main(string[] args)
    {
        Risunok risunok = new Risunok();
        risunok.vivod_risunka();
    }
}
