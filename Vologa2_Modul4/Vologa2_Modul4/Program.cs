using System;

public interface IProduct
{
    double GetCost();
    int GetStock();
}

public class Milk : IProduct
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Milk(double price, int quantity)
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

public class Bread : IProduct
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Bread(double price, int quantity)
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

public class Cheese : IProduct
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Cheese(double price, int quantity)
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

public class Producti
{
    public void vivod_productov() 
    {
        try
        {
            Console.WriteLine("Введите стоимость и количество молока:");
            var milkPrice = Convert.ToDouble(Console.ReadLine());
            var milkQuantity = Convert.ToInt32(Console.ReadLine());
            if (milkPrice < 0 || milkQuantity < 0) throw new Exception("Стоимость и количество не могут быть меньше нуля.");
            var milk = new Milk(milkPrice, milkQuantity);
            Console.WriteLine($"Стоимость молока: {milk.GetCost()}, Остаток на складе: {milk.GetStock()}");

            Console.WriteLine("Введите стоимость и количество хлеба:");
            var breadPrice = Convert.ToDouble(Console.ReadLine());
            var breadQuantity = Convert.ToInt32(Console.ReadLine());
            if (breadPrice < 0 || breadQuantity < 0) throw new Exception("Стоимость и количество не могут быть меньше нуля.");
            var bread = new Bread(breadPrice, breadQuantity);
            Console.WriteLine($"Стоимость хлеба: {bread.GetCost()}, Остаток на складе: {bread.GetStock()}");

            Console.WriteLine("Введите стоимость и количество сыра:");
            var cheesePrice = Convert.ToDouble(Console.ReadLine());
            var cheeseQuantity = Convert.ToInt32(Console.ReadLine());
            if (cheesePrice < 0 || cheeseQuantity < 0) throw new Exception("Стоимость и количество не могут быть меньше нуля.");
            var cheese = new Cheese(cheesePrice, cheeseQuantity);
            Console.WriteLine($"Стоимость сыра: {cheese.GetCost()}, Остаток на складе: {cheese.GetStock()}");
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
        Producti producti = new Producti() ;
        producti.vivod_productov();
    }
}
