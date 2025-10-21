using System;

class Product
{

    public double Price { get; set; }
    public double Discount { get; set; }

    
    public double CalculateFinalPrice()
    {
        double finalPrice = Price - (Price * Discount / 100);
        return finalPrice;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine("=== Product Details ===");
        Console.WriteLine($"Price: ₹{Price}");
        Console.WriteLine($"Discount: {Discount}%");
        Console.WriteLine($"Final Price after discount: ₹{CalculateFinalPrice()}");
    }
}

class Program
{
    static void Main()
    {
        
        Product p = new Product()
        {
            Price = 2000,
            Discount = 10
        };

    
        p.DisplayDetails();
    }
}
