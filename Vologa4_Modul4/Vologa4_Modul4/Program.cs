using System;

public interface IBook
{
    double GetCost();
    int GetStock();
}

public class Novel : IBook
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Novel(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }

    public double GetCost()
    {
        return Price;
    }

    public int GetStock()
    {
        return Quantity;
    }
}

public class Textbook : IBook
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Textbook(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }

    public double GetCost()
    {
        return Price;
    }

    public int GetStock()
    {
        return Quantity;
    }
}

public class Magazine : IBook
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Magazine(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }

    public double GetCost()
    {
        return Price;
    }

    public int GetStock()
    {
        return Quantity;
    }
}

public class Book
{
    public void vivod_book() 
    {
        try
        {
            Console.WriteLine("Введите стоимость и количество романов:");
            var novelPrice = Convert.ToDouble(Console.ReadLine());
            var novelQuantity = Convert.ToInt32(Console.ReadLine());
            if (novelPrice < 0 || novelQuantity < 0) throw new Exception("Стоимость и количество не могут быть меньше нуля.");
            var novel = new Novel(novelPrice, novelQuantity);
            Console.WriteLine($"Стоимость романа: {novel.GetCost()}, Остаток на складе: {novel.GetStock()}");

            Console.WriteLine("Введите стоимость и количество учебников:");
            var textbookPrice = Convert.ToDouble(Console.ReadLine());
            var textbookQuantity = Convert.ToInt32(Console.ReadLine());
            if (textbookPrice < 0 || textbookQuantity < 0) throw new Exception("Стоимость и количество не могут быть меньше нуля.");
            var textbook = new Textbook(textbookPrice, textbookQuantity);
            Console.WriteLine($"Стоимость учебника: {textbook.GetCost()}, Остаток на складе: {textbook.GetStock()}");

            Console.WriteLine("Введите стоимость и количество журналов:");
            var magazinePrice = Convert.ToDouble(Console.ReadLine());
            var magazineQuantity = Convert.ToInt32(Console.ReadLine());
            if (magazinePrice < 0 || magazineQuantity < 0) throw new Exception("Стоимость и количество не могут быть меньше нуля.");
            var magazine = new Magazine(magazinePrice, magazineQuantity);
            Console.WriteLine($"Стоимость журнала: {magazine.GetCost()}, Остаток на складе: {magazine.GetStock()}");
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
        Book book = new Book();
        book.vivod_book();
    }
}
